using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using GrouponDesktop.Core;
using GrouponDesktop.GUI.RegistroUsuario;
using GrouponDesktop.GUI;

namespace GrouponDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager manager = (DBManager) AppContext.getObject(typeof(DBManager));
            try
            {

                if (usuario.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Faltan datos");
                    return;
                }

                ParamSet ps = new ParamSet();
                ps.NombreSP("dbo.Loguearse");

                Dictionary<String, Object> d = new Dictionary<string, object>();
                d.Add("@user", usuario.Text);
                d.Add("@pass", password.Text);

                ps.Parametros(d);

                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "0":
                        SqlCommand consulta = new SqlCommand("SELECT rol FROM Logins WHERE username=@username AND passwd=dbo.SHA256(@passwd)");
                        consulta.Parameters.AddWithValue("username", usuario.Text);
                        consulta.Parameters.AddWithValue("passwd", password.Text);
                        SQLResponse r = manager.executeQuery(consulta);
                        Session s = new Session();
                        s.username = usuario.Text;
                        s.rol = (String)r.result.Rows[0][0];
                        AppContext.setObject(typeof(Session), s);
                        new Main().Show(null);
                        this.Hide();
                        break;
                    case "1": MessageBox.Show("La contraseña no es válida");
                        break;
                    case "2": MessageBox.Show("Se ha inhabilitado al usuario por intentos fallidos");
                        break;
                    case "3": MessageBox.Show("Usuario incorrecto");
                        break;
                    case "4": MessageBox.Show("Usted se encuentra inhabilitado, hable con un administrador");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
                Console.Write(ex);
            }
          
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            RegistroUsuario r = new RegistroUsuario();
            r.Show();
        }
    }
}
