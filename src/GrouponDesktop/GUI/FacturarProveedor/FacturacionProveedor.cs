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

        public FacturacionProveedor()
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        }

        private void FacturacionProveedor_Load(object sender, EventArgs e)
        {
            this.proveedores.Items.Clear();
            Session s = (Session)AppContext.getObject(typeof(Session));
            
            SQLResponse r = dbManager.executeQuery("SELECT username FROM GESTION_DE_PATOS.Proveedores");
            foreach (DataRow row in r.result.Rows)
            {
                this.proveedores.Items.Add(row[0]);
            }
            this.proveedores.SelectedIndex = 0;
        }

        private void FechaDesdeCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime desde = FechaDesdeCalendario.SelectionStart;
            string fechaDesdeStr = desde.Date.ToShortDateString();

            FechaDesde.Text = fechaDesdeStr;

            FechaDesdeCalendario.Visible = false;
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

        private void Listar_Click(object sender, EventArgs e)
        {
            if (FechaDesde.Text == "" || FechaHasta.Text == "")
            {
                MessageBox.Show("Faltan datos");
                return;
            }
            SQLResponse r;

            r = dbManager.executeQuery("SELECT c.id_cupon, c.cliente, c.id_promocion, c.fecha_compra, ca.fecha_canje FROM GESTION_DE_PATOS.Cupones c, GESTION_DE_PATOS.Promociones g, GESTION_DE_PATOS.Proveedores p, GESTION_DE_PATOS.Canjes ca WHERE ca.id_cupon = c.id_cupon AND c.id_promocion = g.id_promocion AND g.proveedor = p.username AND p.username = \'" + this.proveedores.SelectedItem.ToString() + "\' AND c.fecha_compra between " + "\'" + this.FechaDesde.Text + "\'" + " and " + "\'" + this.FechaHasta.Text + "\'");
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
        }

        private object montoFactura()
        {
            SQLResponse r;
            object monto = null;

            r = dbManager.executeQuery("SELECT SUM(g.precio_real) FROM GESTION_DE_PATOS.Cupones c, GESTION_DE_PATOS.Promociones g, GESTION_DE_PATOS.Proveedores p,GESTION_DE_PATOS.Canjes ca WHERE c.id_cupon = ca.id_cupon AND c.id_promocion = g.id_promocion AND g.proveedor = p.username AND p.username = \'" + this.proveedores.SelectedItem.ToString() + "\' AND c.fecha_compra between " + "\'" + this.FechaDesde.Text + "\'" + " and " + "\'" + this.FechaHasta.Text + "\'");
            monto = r.result.Rows[0][0];

            return monto;

        }

        private void Facturar_Click(object sender, EventArgs e)
        {
            if (FechaDesde.Text == "" || FechaHasta.Text == "" || this.dataGridCupones.RowCount == 0 || this.proveedores.Text == "" )
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            if (this.dataGridCupones.SelectedRows.Count != 1)
            {

                MessageBox.Show("Seleccione una fila de cupón para la compra");
                return;
            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.FacturarProveedor");
            
            float monto = float.Parse(montoFactura().ToString());
            ps.AddParameter("@proveedor", proveedores.SelectedItem);
            ps.AddParameter("@fecha_desde", FechaDesde.Text);
            ps.AddParameter("@fecha_hasta", FechaHasta.Text);
            ps.AddParameter("@monto", monto);

            SqlParameter retval = ps.execSP();
            
            String ret = retval.Value.ToString();
            switch (ret)
            {
                case "1": MessageBox.Show("Ya hay cupones facturados para el intervalo ingresado.");
                    return;
                default: MessageBox.Show("Facturación finalizada con éxito. \n Nro de factura: " + ret + ".\n Monto: $" + monto.ToString());
                    return;
               
               
            }
        }



    }
}

