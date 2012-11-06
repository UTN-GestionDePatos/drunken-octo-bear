using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;
using GrouponDesktop.GUI;
using GrouponDesktop.GUI.AbmRol;
using GrouponDesktop.AbmCliente;
using GrouponDesktop.AbmProveedor;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write((String)funcionalidades.SelectedItem);

            switch (((String)funcionalidades.SelectedItem).Substring(0, 2))
            {
                case "1:": new ABMRol().Show();
                    break;
                case "2:": new RegistroUsuario.RegistroUsuario().Show();
                    break;
                case "3:": new ABMCliente().Show();
                    break;
                case "4:": new ABMProveedor().Show();
                    break;
                case "5:": new CargaCredito.CargaCredito().Show();
                    break;
                case "6:": new ComprarGiftCard.ComprarGirftcard().Show();
                    break;
                case "7:": new ComprarCupon.CompraCupon().Show();
                    break;
                case "8:": new PedirDevolucion.PedirDevolucion().Show();
                    break;
                case "9:": new HistorialCupones.HistorialCupones().Show();
                    break;
                case "10": new ArmarCupon.ArmarCupon().Show();
                    break;
                case "11": new RegistroConsumoCupon.RegistroConsumoCupon().Show();
                    break;
                case "12": new RegistroUsuario.RegistroUsuario().Show();
                    break;
                case "13": new RegistroUsuario.RegistroUsuario().Show();
                    break;
                case "14": new RegistroUsuario.RegistroUsuario().Show();
                    break;
                
            }
        }
    }
}
