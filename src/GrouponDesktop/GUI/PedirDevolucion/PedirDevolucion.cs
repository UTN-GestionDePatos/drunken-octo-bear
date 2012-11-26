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
                ps.NombreSP("GESTION_DE_PATOS.PedirDevolucion");
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
                    case "4": MessageBox.Show("El cupón está canjeado o ya devuelto");
                        return;
                    case "3": MessageBox.Show("El cupón expiró");
                        return;
                      }
            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un valor numérico de cupón");
                return;
            }

            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            SQLResponse response = manager.executeQuery("select c.id_cupon, c.id_promocion, gc.descripcion from GESTION_DE_PATOS.Cupones c join GESTION_DE_PATOS.Promociones gc on c.id_promocion = gc.id_promocion where c.id_cupon = " + Cupon.Text);

            if (MessageBox.Show("¿Esta seguro que quiere devolver el cupón?\n\nID CUPON: " + this.Cupon.Text + " \nPROMOCIÓN: " + response.result.Rows[0][1].ToString() + "\nDESCRIPCIÓN: "+ response.result.Rows[0][2].ToString() ,"Devolver cupón", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session s = (Session)AppContext.getObject(typeof(Session));
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.ConfirmarDevolucion");
                ps.AddParameter("@idCupon", Int64.Parse(this.Cupon.Text));
                ps.AddParameter("@fecha_actual", Core.Properties.getProperty("fecha"));
                ps.AddParameter("@motivo", this.Motivo.Text);

                SqlParameter retval = ps.execSP();
                switch (retval.Value.ToString())
                {
                    case "0": MessageBox.Show("Devolución exitosa");
                        return;

                    case "1": MessageBox.Show("El cupón ya está devuelto");
                        return;


                }
            }
            
        }
    }
}
