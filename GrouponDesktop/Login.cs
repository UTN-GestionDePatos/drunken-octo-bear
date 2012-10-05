using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            /*
             * Ésto es claramente temporal y para probar la conexión, si alguien se conecta
             * así de ahora en más, muere en la horca, así de una (?.
             */
            SqlConnection myConnection = new SqlConnection("user id=gd;" +
                                       "password=gd2012;server=localhost\\SQLSERVER2008;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GD2C2012; " +
                                       "connection timeout=60");
            try
            {
                myConnection.Open();
                usuario.Text = "Conectado";
            }
            catch (Exception)
            {
                usuario.Text = "No se pudo conectar a la DB. =(";
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
