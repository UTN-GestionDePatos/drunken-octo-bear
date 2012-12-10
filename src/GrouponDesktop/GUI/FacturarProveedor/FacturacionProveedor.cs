using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;
using System.Data.SqlClient;

namespace GrouponDesktop.GUI.FacturarProveedor
{
    public partial class FacturacionProveedor : Form
    {
        private DBManager dbManager = null;
        SQLResponse r;
        public FacturacionProveedor()
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        }

        private void FacturacionProveedor_Load(object sender, EventArgs e)
        {
            this.proveedores.Items.Clear();
            Session s = (Session)AppContext.getObject(typeof(Session));
            
            SQLResponse r = dbManager.executeQuery("SELECT p.CUIT FROM GESTION_DE_PATOS.Proveedores p JOIN GESTION_DE_PATOS.Usuarios u on p.username = u.username and u.rol = 'Proveedor'");
            foreach (DataRow row in r.result.Rows)
            {
                this.proveedores.Items.Add(row[0]);
            }
            this.proveedores.SelectedIndex = 0;

            this.dataGridCupones.AllowUserToAddRows = false;
        }

        private void FechaDesdeCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime desde = FechaDesdeCalendario.SelectionStart;
            string fechaDesdeStr = desde.Date.ToShortDateString();

            FechaDesde.Text = fechaDesdeStr;

            FechaDesdeCalendario.Visible = false;
            this.dataGridCupones.DataSource = null;

        }


        private void FechaDesdeAbrirCalendario_Click(object sender, EventArgs e)
        {
            FechaHastaCalendario.Visible = false;
            FechaDesdeCalendario.Visible = true;
        }

        private void FechaHastaAbrirCalendario_Click(object sender, EventArgs e)
        {
            FechaDesdeCalendario.Visible = false;
            FechaHastaCalendario.Visible = true;
        }

        public int esMenor(String unaFecha, String otraFecha)
        {
            String anioF1 = unaFecha.Substring(6, 4);
            String anioF2 = otraFecha.Substring(6, 4);
            String mesF1 = unaFecha.Substring(3, 2);
            String mesF2 = otraFecha.Substring(3, 2);
            String diaF1 = unaFecha.Substring(0, 2);
            String diaF2 = otraFecha.Substring(0, 2);
            String fecha1 = anioF1 + mesF1 + diaF1;
            String fecha2 = anioF2 + mesF2 + diaF2;
            return fecha1.CompareTo(fecha2);

        }

        private void Listar_Click(object sender, EventArgs e)
        {
            if (FechaDesde.Text == "" || FechaHasta.Text == "")
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            if (esMenor(FechaDesde.Text, FechaHasta.Text) > 0)
            {
                MessageBox.Show("La fecha desde no puede ser posterior a la fecha hasta");
                return;
            }
            SQLResponse r;

            r = dbManager.executeQuery("SELECT c.id_cupon, c.cliente, c.id_promocion, c.fecha_compra, ca.fecha_canje FROM GESTION_DE_PATOS.Cupones c, GESTION_DE_PATOS.Promociones g, GESTION_DE_PATOS.Proveedores p , GESTION_DE_PATOS.Canjes ca WHERE ca.id_cupon = c.id_cupon AND c.id_promocion = g.id_promocion AND g.proveedor = p.username AND p.cuit = \'" + this.proveedores.SelectedItem.ToString() + "\' AND ca.fecha_canje between " + "\'" + this.FechaDesde.Text + "\'" + " and " + "\'" + this.FechaHasta.Text + "\' and not exists (select * from GESTION_DE_PATOS.Cupones_por_factura cpf where cpf.id_cupon = c.id_cupon)");
            this.SetDataGridView(r.result);

        }

        public void SetDataGridView(DataTable data)
        {
            this.dataGridCupones.DataSource = data;
        }

        private void FechaHastaCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime hasta = FechaHastaCalendario.SelectionStart;
            string fechaHastaStr = hasta.Date.ToShortDateString();

            FechaHasta.Text = fechaHastaStr;

            FechaHastaCalendario.Visible = false;

            this.dataGridCupones.DataSource = null;
        }

        private object montoFactura()
        {
            
            object monto = null;

            r = dbManager.executeQuery("SELECT SUM(g.precio_real) FROM GESTION_DE_PATOS.Cupones c, GESTION_DE_PATOS.Promociones g, GESTION_DE_PATOS.Proveedores p,GESTION_DE_PATOS.Canjes ca WHERE c.id_cupon = ca.id_cupon AND c.id_promocion = g.id_promocion AND g.proveedor = p.username AND p.cuit = \'" + this.proveedores.SelectedItem.ToString() + "\' AND ca.fecha_canje between " + "\'" + this.FechaDesde.Text + "\'" + " and " + "\'" + this.FechaHasta.Text + "\' and c.id_cupon not in (select id_cupon from GESTION_DE_PATOS.Cupones_por_factura)");
            monto = r.result.Rows[0][0];

            return monto;

        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            if (FechaDesde.Text == "" || FechaHasta.Text == "" || this.proveedores.Text == "" )
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            if(this.dataGridCupones.RowCount == 0){
                MessageBox.Show("No hay cupones para facturar para el intervalo de fechas seleccionado");
                return;
            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.FacturarProveedor");
            
            float monto = float.Parse(montoFactura().ToString());
            r = dbManager.executeQuery("SELECT username FROM GESTION_DE_PATOS.Proveedores where cuit = '"+proveedores.SelectedItem.ToString() + "'");
            ps.AddParameter("@proveedor", r.result.Rows[0][0].ToString() );
            ps.AddParameter("@fecha_desde", FechaDesde.Text);
            ps.AddParameter("@fecha_hasta", FechaHasta.Text);
            ps.AddParameter("@monto", monto*0.5);

            SqlParameter retval = ps.execSP();
            
            String ret = retval.Value.ToString();
            switch (ret)
            {
                case "1": MessageBox.Show("Ya hay cupones facturados para el intervalo ingresado.");
                    return;

                default:
                            
                    String elMonto = (monto*0.5).ToString();
                    MessageBox.Show("Facturación finalizada con éxito. \n Nro de factura: " + ret + ".\n Monto: $" + elMonto.Substring(0,elMonto.IndexOf(",") + 3));
                    r = dbManager.executeQuery("SELECT c.id_cupon, c.cliente, c.id_promocion, c.fecha_compra, ca.fecha_canje FROM GESTION_DE_PATOS.Cupones c, GESTION_DE_PATOS.Promociones g, GESTION_DE_PATOS.Proveedores p , GESTION_DE_PATOS.Canjes ca WHERE ca.id_cupon = c.id_cupon AND c.id_promocion = g.id_promocion AND g.proveedor = p.username AND p.cuit = \'" + this.proveedores.SelectedItem.ToString() + "\' AND ca.fecha_canje between " + "\'" + this.FechaDesde.Text + "\'" + " and " + "\'" + this.FechaHasta.Text + "\' and not exists (select * from GESTION_DE_PATOS.Cupones_por_factura cpf where cpf.id_cupon = c.id_cupon)");
                    this.SetDataGridView(r.result);
                    return;
       
               
            }


        }



    }
}

