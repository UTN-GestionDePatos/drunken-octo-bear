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
                SqlCommand consulta = new SqlCommand("SELECT rol FROM Logins WHERE username=@username AND passwd=dbo.SHA256(@passwd)");
                consulta.Parameters.AddWithValue("username", usuario.Text);
                consulta.Parameters.AddWithValue("passwd", password.Text);
                SQLResponse r = manager.executeQuery(consulta);

                if (r.result.Rows.Count == 1)
                {
                    Session s = new Session();
                    s.username = usuario.Text;
                    s.rol = (String) r.result.Rows[0][0];
                    AppContext.setObject(typeof(Session), s);
                    new Main().Show(null);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no coinciden.");
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
