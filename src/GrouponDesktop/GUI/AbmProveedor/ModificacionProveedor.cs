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

namespace GrouponDesktop.GUI.AbmProveedor
{
    public partial class ModificacionProveedor : Form
    {
       private DBManager dbManager = null;
       private FilaSeleccionada proveedor;

        public ModificacionProveedor(FilaSeleccionada proveedor_seleccionado)
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            proveedor = proveedor_seleccionado;
        }

        private void ModificacionProveedor_Load(object sender, EventArgs e)
        {
            UsernameP.Text = proveedor.getDato("usernameDataGridViewTextBoxColumn").ToString();
            PassP.Text = proveedor.getDato("passwdDataGridViewTextBoxColumn").ToString();
            RazonSocial.Text = proveedor.getDato("razon_socialDataGridViewTextBoxColumn").ToString();
            CUIT.Text = proveedor.getDato("cuitDataGridViewTextBoxColumn").ToString();
            MailP.Text = proveedor.getDato("mailDataGridViewTextBoxColumn").ToString();
            TelefonoP.Text = proveedor.getDato("telefonoDataGridViewTextBoxColumn").ToString();
            ciudadP.Text = proveedor.getDato("ciudadDataGridViewTextBoxColumn").ToString();
            RubroP.Text = proveedor.getDato("rubroDataGridViewTextBoxColumn").ToString();
            NombreContacto.Text = proveedor.getDato("nombre_contactoDataGridViewTextBoxColumn").ToString();
            Direccion.Text = proveedor.getDato("direccionDataGridViewTextBoxColumn").ToString();
            CodigoPostalP.Text = proveedor.getDato("codigopostalDataGridViewTextBoxColumn").ToString();

            SQLResponse r2 = dbManager.executeQuery("SELECT e.nombre_estado FROM GESTION_DE_PATOS.Usuarios u JOIN GESTION_DE_PATOS.EstadosUsuarios e ON u.estado = e.id_estado WHERE u.username = " + UsernameP.Text);
            Estado.Text = r2.result.Rows[0][0].ToString();
            Estado.Items.Add("Habilitado");
            Estado.Items.Add("Deshabilitado");

          /*  Ciudad.Items.Add(proveedor.getDato("ciudadDataGridViewTextBoxColumn").ToString());
            SQLResponse r = dbManager.executeQuery("SELECT localidad FROM GESTION_DE_PATOS.Localidades");
            foreach (DataRow row in r.result.Rows)
            {
                this.Ciudad.Items.Add(row[0]);
            }

            //Localidad.Items.Add(proveedor.getDato("localidadDataGridViewTextBoxColumn").ToString());
            foreach (DataRow row in r.result.Rows)
            {
                this.Localidad.Items.Add(row[0]);
            }
            */
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            UsernameP.Text = "";
            PassP.Text = "";
            RazonSocial.Text = "";
            CUIT.Text = "";
            MailP.Text = "";
            TelefonoP.Text = "";
            NombreContacto.Text = "";
            Direccion.Text = "";
            CodigoPostalP.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.ModificarProveedor");

            ps.AddParameter("@user", UsernameP.Text);
            ps.AddParameter("@pass", PassP.Text);
            ps.AddParameter("@cuit", CUIT.Text);
            ps.AddParameter("@razon_social", RazonSocial.Text);
            ps.AddParameter("@mail", MailP.Text);
            ps.AddParameter("@telefono", TelefonoP.Text);
            ps.AddParameter("@direccion", Direccion.Text);
            ps.AddParameter("@rubro", RubroP.SelectedItem.ToString());
            ps.AddParameter("@nombre_contacto", NombreContacto.Text);
            ps.AddParameter("@ciudad", ciudadP.SelectedItem.ToString());
            ps.AddParameter("@cp", CodigoPostalP.Text);
            ps.AddParameter("@estado", Estado.Text);

            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString())
            {
                case "0": MessageBox.Show("Registro modificado con éxito","Modificar proveedor");
                    break;
                case "1": MessageBox.Show("Ocurrió un error al modificar el registro","Modificar proveedor");
                    break;
            }
        }

        private void ModificacionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModificacionProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Modificar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


       
    }
}
