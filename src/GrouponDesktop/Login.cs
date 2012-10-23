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
            SqlConnection myConnection = manager.getConnection();
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
