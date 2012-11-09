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
            if (LocalidadCupon.Text == "" ||PrecioFicticio.Text == "" || PrecioReal.Text  == ""
                || FchVencimientoCanje.Text == "" || FchVencimientoOferta.Text == "" || Stock.Text  == "" ||
                LimitePorUsuario.Text  == "" || DescripcionCupon.Text  == "")
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            Session s = (Session)AppContext.getObject(typeof(Session));
            ParamSet ps = new ParamSet();
            ps.NombreSP("dbo.ArmarCupon");
            Dictionary<String, Object> d = new Dictionary<string, object>();
            d.Add("@username", s.username);
            //d.Add("@codigoGrupo",); de donde?????
            d.Add("@descripcion", DescripcionCupon.Text);
            d.Add("@fechaSistema", DateTime.Now);
            d.Add("@fechaVencimientoCanje", FchVencimientoCanje.Text);//modificar
            d.Add("@fechaVencimientoOferta", FchVencimientoOferta.Text);//modificar
            d.Add("@precio_ficticio", float.Parse(PrecioFicticio.Text));
            d.Add("@precio_real", float.Parse(PrecioReal.Text));
            d.Add("@limite_usuario", Int32.Parse(LimitePorUsuario.Text));
            d.Add("@stock", Int32.Parse(Stock.Text));
            //el proveedor de donde lo saco?
            ps.Parametros(d);

            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString())
            {
                case "1": MessageBox.Show("El cupón ya existe");
                    return;
                case "2": MessageBox.Show("La fecha de vencimiento de la oferta ya pasó");
                    return;

            }

        }

      
    }
}
