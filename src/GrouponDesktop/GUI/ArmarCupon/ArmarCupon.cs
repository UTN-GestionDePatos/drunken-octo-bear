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

            Session s = (Session)AppContext.getObject(typeof(Session));
            ParamSet ps = new ParamSet();
            ps.NombreSP("dbo.ArmarCupon");
            Dictionary<String, Object> d = new Dictionary<string, object>();
            
            d.Add("@codigoGrupo",codigoGrupo.Text);
            d.Add("@descripcion", DescripcionCupon.Text);
            d.Add("@fechaSistema", Core.Properties.getProperty("fecha"));
            d.Add("@fechaVencimientoCanje", VencimientoCanje.Text);
            d.Add("@fechaVencimientoOferta", VencimientoOferta.Text);
            d.Add("@precio_ficticio", float.Parse(PrecioFicticio.Text));
            d.Add("@precio_real", float.Parse(PrecioReal.Text));
            d.Add("@limite_usuario", Int32.Parse(LimitePorUsuario.Text));
            d.Add("@stock", Int32.Parse(Stock.Text));
            d.Add("@proveedor", s.username);
            ps.Parametros(d);

            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString())
            {
                case "1": MessageBox.Show("El cupón ya existe");
                    return;
                case "2": MessageBox.Show("La fecha de vencimiento de la oferta ya pasó");
                    return;

            }

            d.Clear();
            ps.NombreSP("dbo.AsignarLocalidadAlGrupo");

            foreach (Object item in ListaZonas.CheckedItems)
            {
                d.Add("@localidad", item.ToString());
                d.Add("@grupo", codigoGrupo.Text);
                ps.Parametros(d);
                ps.execSP();
                d.Clear();

            }

            MessageBox.Show("Grupo de cupon armado exitosamente");
        }

        private void ArmarCupon_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            SQLResponse response = manager.executeQuery("SELECT localidad from Localidades");
            
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

        private void VencimientoOfertaCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime oferta = VencimientoOfertaCalendario.SelectionStart;
            string ofertaStr = oferta.Date.ToShortDateString();

            VencimientoOferta.Text = ofertaStr;

            VencimientoOfertaCalendario.Visible = false;
        }

        private void VencimientoCanjeCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime canje = VencimientoCanjeCalendario.SelectionStart;
            string canjeStr = canje.Date.ToShortDateString();

            VencimientoCanje.Text = canjeStr;

            VencimientoCanjeCalendario.Visible = false;
        }

       

      
    }
}
