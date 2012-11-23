using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

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
            Username.Text = proveedor.getDato("usernameDataGridView").ToString();
            RazonSocial.Text = proveedor.getDato("razon_socialDataGridView").ToString();
            CUIT.Text = proveedor.getDato("cuitDataGridView").ToString();
            Mail.Text = proveedor.getDato("mailDataGridView").ToString();
            Telefono.Text = proveedor.getDato("telefonoDataGridView").ToString();
            Ciudad.Text = proveedor.getDato("ciudadDataGridView").ToString();
            Rubro.Text = proveedor.getDato("rubroDataGridView").ToString();
            NombreContacto.Text = "nombre_contactoDataGridView";
            Calle.Text = "";
            Piso.Text = "";
            Departamento.Text = "";
            Localidad.Text = "";
            CodigoPostal.Text = "";
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


       
    }
}
