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
            FechaDesdeCalendario.Visible = true;
        }

        private void FechaHastaAbrirCalendario_Click(object sender, EventArgs e)
        {
            FechaHastaCalendario.Visible = true;

        }

        private void FechaHastaCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime hasta = FechaHastaCalendario.SelectionStart;
            string fechaHastaStr = hasta.Date.ToShortDateString();

            FechaHasta.Text = fechaHastaStr;

            FechaHastaCalendario.Visible = false;
       
        }

        private void FechaDesdeCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime desde = FechaDesdeCalendario.SelectionStart;
            string fechaDesdeStr = desde.Date.ToShortDateString();

            FechaDesde.Text = fechaDesdeStr;

            FechaDesdeCalendario.Visible = false;
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            if (FechaDesde.Text == "" || FechaHasta.Text == "" || Estado.SelectedItem == null) {
                MessageBox.Show("Faltan datos");
                return;
            }
            DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            Session s = (Session)AppContext.getObject(typeof(Session));
            SQLResponse r;
            String cliente = s.username;
            switch(Estado.SelectedItem.ToString()){
                case "Comprado":
                    r = dbManager.executeQuery("select c.id_cupon, c.id_grupo, gc.descripcion, c.fecha_compra, c.estado from Cupones c join GruposCupon gc on c.id_grupo = gc.id_grupo where c.cliente = " + cliente + " and c.estado = 'Comprado'");
                    break;
                case "Entregado":
                    r = dbManager.executeQuery("select c.id_cupon, c.id_grupo, gc.descripcion, c.fecha_compra, c.fecha_canje, c.estado from Cupones c join GruposCupon gc on c.id_grupo = gc.id_grupo where c.cliente = " + cliente + " and c.estado = 'Entregado'");
                    break;
                case "Devuelto":
                    r = dbManager.executeQuery("select c.id_cupon, c.id_grupo, gc.descripcion, c.fecha_compra, d.fecha_devolucion, c.estado from Cupones c join GruposCupon gc on c.id_grupo = gc.id_grupo join Devoluciones d on d.id_cupon = c.id_cupon where c.cliente = " + cliente);
                    break;
            }

            Listado listado = new Listado();
            
        }

    }
}
