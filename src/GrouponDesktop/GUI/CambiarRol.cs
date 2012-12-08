using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;
using GrouponDesktop.AbmCliente;

namespace GrouponDesktop.GUI
{
    public partial class CambiarRol : Form
    {

        static DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));
        static Session sesion = (Session)AppContext.getObject(typeof(Session));
        String user;
        String actual;
        public Listado listado;

        public CambiarRol(String user, Listado listado)
        {
            InitializeComponent();
            this.user = user;
            this.actual = db.executeQuery("select rol from GESTION_DE_PATOS.Usuarios where username = '" + user + "'").result.Rows[0][0].ToString();
            this.listado = listado;
       
        }

        private void CambiarRol_Load(object sender, EventArgs e)
        {

            SQLResponse re = db.executeQuery("select nombre from GESTION_DE_PATOS.Roles where estado = gestion_de_patos.idEstado('Habilitado')");
            foreach (DataRow r in re.result.Rows)
            {
                Rol.Items.Add(r[0]);
            } 
            Session s = (Session)AppContext.getObject(typeof(Session));
           
            Rol.Items.Remove("Administrador General");
            
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rol = this.Rol.SelectedItem.ToString();
            if (rol.Equals(actual))
            {
                MessageBox.Show("El rol asignado ya corresponde al usuario");
                return;
            }

            MessageBox.Show("Nuevo rol asignado correctamente", "Cambiar rol");
          
            if (this.Rol.SelectedItem.ToString() == "Proveedor")
            {
                AltaProveedor ap = new AltaProveedor(user, actual, listado);
                ap.ShowDialog();
            }
            else if (this.Rol.SelectedItem.ToString() == "Cliente")
            {
                AltaCliente ac = new AltaCliente(user, actual, listado);
                ac.ShowDialog();
            }
            else if (this.Rol.SelectedItem.ToString() == "Administrador General" || this.Rol.SelectedItem.ToString() == "Administrador") 
            {
                db.executeQuery("INSERT INTO GESTION_DE_PATOS.Administradores VALUES('" + user + "', null, null)");
            
            }

         
            db.executeQuery("UPDATE GESTION_DE_PATOS.Usuarios SET rol = '" + rol + "' where username = '" + user + "'");

            this.listado.actualizar_datagridview();
            this.Hide();
        }

        private void CambiarRol_Load()
        {

        }
   }
}
