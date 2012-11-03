using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI
{
    public partial class Main : Form
    {
        private DBManager dbManager = null;

        public Main()
        {
            InitializeComponent();
            dbManager = (DBManager) AppContext.getObject(typeof(DBManager));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.funcionalidades.Items.Clear();
            Session s = (Session) AppContext.getObject(typeof(Session));
            bienvenida.Text = "Bienvenido: " + s.username;

            SQLResponse r = dbManager.executeQuery("SELECT f.id_funcionalidad,descripcion FROM Funcionalidades f,Funcion_por_rol fpr WHERE f.id_funcionalidad = fpr.id_funcionalidad AND fpr.nombre_rol =\'"+s.rol+"\'");
            foreach(DataRow row in r.result.Rows){
                this.funcionalidades.Items.Add(row[0]+": "+row[1]);
            }
            this.funcionalidades.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
