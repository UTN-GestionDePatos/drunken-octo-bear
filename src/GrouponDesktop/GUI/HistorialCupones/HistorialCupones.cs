using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.HistorialCupones
{
    public partial class HistorialCupones : Form
    {
        public HistorialCupones()
        {
            InitializeComponent();
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
            if (FechaDesde.Text == "" || FechaHasta.Text == "") {
                MessageBox.Show("Faltan datos");
                return;
            }
            DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            Session s = (Session)AppContext.getObject(typeof(Session));
            String cliente = s.username;
            SQLResponse r = dbManager.executeQuery("SELECT v.id_cupon, c.id_promocion, v.promocion, v.fecha_compra,isnull(convert(varchar,can.fecha_canje,103),'-') fecha_canje, isnull(convert(varchar,d.fecha_devolucion,103),'-') fecha_devolucion, v.estado FROM GESTION_DE_PATOS.viewcupones v join GESTION_DE_PATOS.Cupones c on c.id_cupon = v.id_cupon left join GESTION_DE_PATOS.Canjes can on can.id_cupon = v.id_cupon left join GESTION_DE_PATOS.Devoluciones d on d.id_cupon = v.id_cupon WHERE v.cliente = '" + cliente + "' AND v.fecha_compra between " + "\'" + this.FechaDesde.Text + "\'" + " and " + "\'" + this.FechaHasta.Text + "\' ORDER BY 4");
            this.SetDataGridView(r.result);
            this.Cupones.Columns[2].Width = 250;
            if (r.result.Rows.Count == 0)
            {
                MessageBox.Show("No hay cupones en su historial en esas fechas", "Historial cupones");
            }

        }

        public void SetDataGridView(DataTable data)
        {
            this.Cupones.DataSource = data;
        }

        private void FechaHastaCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime hasta = FechaHastaCalendario.SelectionStart;
            string fechaHastaStr = hasta.Date.ToShortDateString();

            FechaHasta.Text = fechaHastaStr;

            FechaHastaCalendario.Visible = false;
        }

        private void FechaDesdeCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime desde = FechaDesdeCalendario.SelectionStart;
            string fechaDesdeStr = desde.Date.ToShortDateString();

            FechaDesde.Text = fechaDesdeStr;

            FechaDesdeCalendario.Visible = false;
        }

        private void HistorialCupones_Load(object sender, EventArgs e)
        {
            this.Cupones.AllowUserToAddRows = false;
            this.Cupones.ReadOnly = true;
        }


    }
}
