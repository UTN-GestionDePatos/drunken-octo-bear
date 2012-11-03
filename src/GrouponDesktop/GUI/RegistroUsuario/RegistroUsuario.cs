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

namespace GrouponDesktop.GUI.RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            try
            {
                
                SQLResponse response = manager.executeQuery("SELECT localidad from Localidades");

                foreach(DataRow r in response.result.Rows){
                    ListaZonas.Items.Add(r[0]);
                }
                
            }
            catch (Exception)
            {
                
            }
        }
    }
}
