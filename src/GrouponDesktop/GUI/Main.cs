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
using System.Data.SqlClient;

namespace GrouponDesktop.GUI
{
    public partial class Main : Form
    {
        private DBManager dbManager = null;
        private Session sesion = null;

        public Main(){
            InitializeComponent();
            dbManager = (DBManager) AppContext.getObject(typeof(DBManager));
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.funcionalidades.Items.Clear();
            this.sesion = (Session)AppContext.getObject(typeof(Session));

            bienvenida.Text = "Bienvenido: " + sesion.username;

            SQLResponse r = dbManager.executeQuery("SELECT f.id_funcionalidad,descripcion FROM GESTION_DE_PATOS.Funcionalidades f,GESTION_DE_PATOS.Funcion_por_rol fpr WHERE f.id_funcionalidad = fpr.id_funcionalidad AND fpr.nombre_rol =\'" + sesion.rol + "\'");
            foreach(DataRow row in r.result.Rows){
                this.funcionalidades.Items.Add(row[1]);
            }
            this.funcionalidades.SelectedIndex = 0;

            if (!sesion.rol.Equals("Administrador General"))
            {
                //esto es para que cualquier rol que no sea administrador pueda cambiar la 
                //pass y darse de baja. Para los administradores, esta funcionalidad se realiza
                //en los ABM correspondientes

                cambiarPass.Visible = true;
                DarDeBaja.Visible = true;

            }
            else {
                this.funcionalidades.Items.Add("ABM Administrador");
            }

            this.actualizarSaldo();
            Fecha.Text = ((String)AppContext.getObject(typeof(String)));
            AppContext.setObject(typeof(Main), this);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write((String)funcionalidades.SelectedItem);

            switch (((String)funcionalidades.SelectedItem))
            {

                case "ABM Rol": new ABMRol().Show();
                    break;
                case "ABM Clientes": new ABMCliente().Show();
                    break;
                case "ABM Proveedores": new ABMProveedor().Show();
                    break;
                case "Carga de credito": new CargaCredito.CargaCredito().Show();
                    break;
                case "Comprar Giftcard": new ComprarGiftCard.ComprarGirftcard().Show();
                    break;
                case "Comprar Cupon": new ComprarCupon.CompraCupon().Show();
                    break;
                case "Pedir Devolucion": new PedirDevolucion.PedirDevolucion().Show();
                    break;
                case "Historial de Compra de Cupones": new HistorialCupones.HistorialCupones().Show();
                    break;
                case "Armar Cupon": new ArmarCupon.ArmarCupon().Show();
                    break;
                case "Registro de consumo de cupon": new RegistroConsumoCupon.RegistroConsumoCupon().Show();
                    break;
                case "Publicar Cupon": new PublicarCupon.PublicarCupon().Show();
                    break;
                case "Facturacion a Proveedor": new FacturarProveedor.FacturacionProveedor().Show();
                    break;
                case "Listado estadistico": new ListadoEstadistico.ListadoEstadistico().Show();
                    break;

                case "ABM Administrador": new AbmAdministrador.ABMAdministrador().Show();
                    break;
            }
        }

        private void funcionalidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.button1_Click(sender, null);
            }
        }

        private void cambiarPass_Click_1(object sender, EventArgs e)
        {
            new cambiarPass().Show();
         
        }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea darse de baja?", "Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarUsuario");
                ps.AddParameter("@user", sesion.username);
                ps.execSP();
                MessageBox.Show("Usted ha sido dado de baja");
                Dispose();
            }
        }

        /**
         * Método que debe ser llamado cuando alguna acción requiera que se actualice el
         * saldo del cliente que está usando la aplicación.
         **/
        public void actualizarSaldo()
        {
            if (this.Saldo.Visible)
            {

                DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));

                SQLResponse r = dbManager.executeQuery(
                    "SELECT c.saldo FROM GESTION_DE_PATOS.Clientes c WHERE c.username = \'" + this.sesion.username + "\'");

                if (r.rowsAffected == 0)
                {
                    this.Saldo.Visible = false;
                    this.LabelSaldo.Visible = false;
                }
                else
                {
                    this.Saldo.Text = "$ " + r.result.Rows[0][0];
                }
            }
        }

        public static void actualizar()
        {
            Main m = (Main)AppContext.getObject(typeof(Main));
            m.actualizarSaldo();
        }
    }
}
