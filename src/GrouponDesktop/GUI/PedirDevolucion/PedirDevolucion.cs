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

namespace GrouponDesktop.GUI.PedirDevolucion
{
    public partial class PedirDevolucion : Form
    {
        public PedirDevolucion()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Cupon.Text == "" || Motivo.Text == "")
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            try
            {
                Session s = (Session)AppContext.getObject(typeof(Session));

                ParamSet ps = new ParamSet();
                ps.NombreSP("dbo.PedirDevolucion");
                Dictionary<String, Object> d = new Dictionary<string, object>();
                d.Add("@idCupon", Int32.Parse(Cupon.Text));
                d.Add("@username", s.username);
                d.Add("@fecha_actual", Core.Properties.getProperty("fecha"));
                d.Add("@motivo", Motivo.Text);
                ps.Parametros(d);
                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "1": MessageBox.Show("El cupón no existe o el usuario no es el dueño");
                        return;
                    case "2": MessageBox.Show("El cupón está canjeado o ya devuelto");
                        return;
                    case "3": MessageBox.Show("El cupón expiró");
                        return;


                }
            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un valor numérico de cupón");
                return;
            }

            Devolucion dev = new Devolucion();
            
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            SQLResponse response = manager.executeQuery("select c.id_cupon, c.id_grupo, gc.descripcion from Cupones c join GruposCupon gc on c.id_grupo = gc.id_grupo where c.id_cupon = " + Cupon.Text);

            foreach (DataRow r in response.result.Rows)
            {
                dev.SetDatos("ID CUPON: " + r[0] + "  \n");
                dev.SetDatos("ID GRUPO: " + r[1] + "  \n");
                dev.SetDatos("DESCRIPCIÓN: " + r[2] + "  \n");

                dev.idCupon = Int32.Parse(r[0].ToString());
                dev.idGrupo = r[1].ToString();
                
            }

            dev.motivo = this.Motivo.Text;
            dev.Show();

            
        }
    }
}
