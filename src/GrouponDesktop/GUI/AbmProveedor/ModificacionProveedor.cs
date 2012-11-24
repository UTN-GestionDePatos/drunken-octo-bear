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
            Username.Text = proveedor.getDato("usernameDataGridViewTextBoxColumn").ToString();
            RazonSocial.Text = proveedor.getDato("razon_socialDataGridViewTextBoxColumn").ToString();
            CUIT.Text = proveedor.getDato("cuitDataGridViewTextBoxColumn").ToString();
            Mail.Text = proveedor.getDato("mailDataGridViewTextBoxColumn").ToString();
            Telefono.Text = proveedor.getDato("telefonoDataGridViewTextBoxColumn").ToString();
            Ciudad.Text = proveedor.getDato("ciudadDataGridViewTextBoxColumn").ToString();
            Rubro.Text = proveedor.getDato("rubroDataGridViewTextBoxColumn").ToString();
            NombreContacto.Text = proveedor.getDato("nombre_contactoDataGridViewTextBoxColumn").ToString();
            Calle.Text = proveedor.getDato("direccionDataGridViewTextBoxColumn").ToString();
            Piso.Text = "";
            Departamento.Text = "";
            Localidad.Text = "";
            CodigoPostal.Text = "";

            Ciudad.Items.Add(proveedor.getDato("ciudadDataGridViewTextBoxColumn").ToString());
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
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            RazonSocial.Text = "";
            CUIT.Text = "";
            Mail.Text = "";
            Telefono.Text = "";
            Ciudad.Text = "";
            Rubro.Text = "";
            NombreContacto.Text = "";
            Calle.Text = "";
            Piso.Text = "";
            Departamento.Text = "";
            Localidad.Text = "";
            CodigoPostal.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.ModificarProveedor");

            ps.AddParameter("@user", Username.Text);
            ps.AddParameter("@cuit", CUIT.Text);
            ps.AddParameter("@razon_social", RazonSocial.Text);
            ps.AddParameter("@mail", Mail.Text);
            ps.AddParameter("@telefono", Telefono.Text);
            ps.AddParameter("@direccion", Calle.Text);
            ps.AddParameter("@nombre_contacto", NombreContacto.Text);
            ps.AddParameter("@ciudad", Ciudad.Text);
            //FALTA AGREGAR ESTOS 5 PARAMETROS EN EL SCRIPT DE LOS PROCEDURES
            ps.AddParameter("@piso", Piso.Text);
            ps.AddParameter("@departamento", Departamento.Text);
            ps.AddParameter("@rubro", Rubro.Text);
            ps.AddParameter("@localidad", Localidad.Text);
            ps.AddParameter("@codigo_postal", CodigoPostal.Text);

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
