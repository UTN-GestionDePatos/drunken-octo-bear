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
using GrouponDesktop.GUI.AbmCliente;
using GrouponDesktop.GUI.AbmProveedor;

namespace GrouponDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            RegistroUsuario r = new RegistroUsuario();
            r.Show();
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.confirmarLogin_Click(sender, null);
            }
        }

        private void confirmarLogin_Click(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            try
            {

                if (usuario.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Faltan datos");
                    return;
                }

                ParamSet ps = new ParamSet("GESTION_DE_PATOS.Loguearse");
                ps.AddParameter("@user", usuario.Text);
                ps.AddParameter("@pass", password.Text);

                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "0":
                        SqlCommand consulta = new SqlCommand("SELECT rol FROM GESTION_DE_PATOS.Usuarios WHERE username=@username AND passwd=GESTION_DE_PATOS.SHA256(@passwd)");
                        consulta.Parameters.AddWithValue("username", usuario.Text);
                        consulta.Parameters.AddWithValue("passwd", password.Text);
                        SQLResponse r = manager.executeQuery(consulta);
                        Session s = new Session();
                        s.username = usuario.Text;
                        s.rol = (String)r.result.Rows[0][0];
                        AppContext.setObject(typeof(Session), s);
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
                    case "5": MessageBox.Show("Usuario incorrecto");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.");
                Console.Write(ex);
            }
        }

    }
}
