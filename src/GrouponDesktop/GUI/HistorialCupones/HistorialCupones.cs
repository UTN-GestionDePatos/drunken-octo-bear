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
            SQLResponse r = dbManager.executeQuery("SELECT id_cupon, promocion, fecha_compra, estado FROM GESTION_DE_PATOS.viewcupones WHERE cliente = '" + cliente + "' AND fecha_compra between " + "\'" + this.FechaDesde.Text + "\'" + " and " + "\'" + this.FechaHasta.Text + "\' ORDER BY 4");
            this.SetDataGridView(r.result);

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

        }


    }
}
