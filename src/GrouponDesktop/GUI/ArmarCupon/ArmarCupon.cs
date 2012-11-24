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

namespace GrouponDesktop.ArmarCupon
{
    public partial class ArmarCupon : Form
    {
        public ArmarCupon()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (codigoGrupo.Text == "" || PrecioFicticio.Text == "" || PrecioReal.Text  == ""
                || VencimientoOferta.Text == "" || VencimientoCanje.Text == "" || Stock.Text  == "" ||
                LimitePorUsuario.Text  == "" || DescripcionCupon.Text  == "" || ListaZonas.CheckedItems.Count == 0)
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            try{
            Session s = (Session)AppContext.getObject(typeof(Session));
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.ArmarCupon");
            
            ps.AddParameter("@codigoGrupo",codigoGrupo.Text);
            ps.AddParameter("@descripcion", DescripcionCupon.Text);
            ps.AddParameter("@fechaSistema", Core.Properties.getProperty("fecha"));
            ps.AddParameter("@fechaVencimientoCanje", VencimientoCanje.Text);
            ps.AddParameter("@fechaVencimientoOferta", VencimientoOferta.Text);
            ps.AddParameter("@precio_ficticio", float.Parse(PrecioFicticio.Text));
            ps.AddParameter("@precio_real", float.Parse(PrecioReal.Text));
            ps.AddParameter("@limite_usuario", Int32.Parse(LimitePorUsuario.Text));
            ps.AddParameter("@stock", Int32.Parse(Stock.Text));
            ps.AddParameter("@proveedor", s.username);
            
            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString())
            {
                case "1": MessageBox.Show("El cupón ya existe");
                    return;
                case "2": MessageBox.Show("La fecha de vencimiento de la oferta ya pasó");
                    return;
                case "3": MessageBox.Show("El canje no puede vencer antes de la oferta");
                    return;

            }


            ps.NombreSP("GESTION_DE_PATOS.AsignarLocalidadAlGrupo");

            foreach (Object item in ListaZonas.CheckedItems)
            {
                ps.AddParameter("@localidad", item.ToString());
                ps.AddParameter("@grupo", codigoGrupo.Text);
                ps.execSP();
            }

            MessageBox.Show("Grupo de cupon armado exitosamente");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numérico para los precios, límite y stock");
                return;
            }
        }

        private void ArmarCupon_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            SQLResponse response = manager.executeQuery("SELECT localidad from GESTION_DE_PATOS.Localidades");
            
            foreach(DataRow r in response.result.Rows){
                ListaZonas.Items.Add(r[0]);
            }
        }

        private void OfertaAbrir_Click(object sender, EventArgs e)
        {
            VencimientoOfertaCalendario.Visible = true;
        }

        private void CanjeAbrir_Click(object sender, EventArgs e)
        {
            VencimientoCanjeCalendario.Visible = true;
        }

    
   
        private void VencimientoCanjeCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime canje = VencimientoCanjeCalendario.SelectionStart;
            string canjeStr = canje.Date.ToShortDateString();

            VencimientoCanje.Text = canjeStr;

            VencimientoCanjeCalendario.Visible = false;
        }

        private void VencimientoOfertaCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime oferta = VencimientoOfertaCalendario.SelectionStart;
            string ofertaStr = oferta.Date.ToShortDateString();

            VencimientoOferta.Text = ofertaStr;

            VencimientoOfertaCalendario.Visible = false;
        }

       

      
    }
}
