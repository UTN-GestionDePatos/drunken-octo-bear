using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

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
            // TODO: esta línea de código carga datos en la tabla 'gD2C2012DataSet3.Cupones' Puede moverla o quitarla según sea necesario.
            this.cuponesTableAdapter.Fill(this.gD2C2012DataSet3.Cupones);
            this.proveedores.Items.Clear();
            Session s = (Session)AppContext.getObject(typeof(Session));
            
            SQLResponse r = dbManager.executeQuery("SELECT cuit FROM Proveedores");
            foreach (DataRow row in r.result.Rows)
            {
                this.proveedores.Items.Add(row[0]);
            }
            this.proveedores.SelectedIndex = 0;
        }

        private void FechaDesdeCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime desde = FechaDesdeCalendario.SelectionStart;
            string fechaDesdeStr = desde.Date.ToShortDateString();

            FechaDesde.Text = fechaDesdeStr;

            FechaDesdeCalendario.Visible = false;
        }

        private void FechaHastaCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime hasta = FechaHastaCalendario.SelectionStart;
            string fechaHastaStr = hasta.Date.ToShortDateString();

            FechaHasta.Text = fechaHastaStr;

            FechaHastaCalendario.Visible = false;
        }

        private void FechaDesdeAbrirCalendario_Click(object sender, EventArgs e)
        {
            FechaDesdeCalendario.Visible = true;
        }

        private void FechaHastaAbrirCalendario_Click(object sender, EventArgs e)
        {
            FechaHastaCalendario.Visible = true;
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            dataGridCupones.
        }


    }
}
