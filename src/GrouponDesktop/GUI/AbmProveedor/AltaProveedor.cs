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

namespace GrouponDesktop.AbmCliente
{
    public partial class AltaProveedor : Form
    {
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.RazonSocial.Text = "";
            this.UsernameProveedor.Text = "";
            this.CUIT.Text = "";
            this.MailProveedor.Text = "";
            this.TelefonoProveedor.Text = "";
            this.NombreContactoProveedor.Text = "";
            this.RubroProveedor.Text = "";
            this.Calle.Text = "";
            /*
            this.Piso.Text = "";
            this.Departamento.Text = "";
             * */
            this.CodigoPostal.Text = "";
            
        }

        private void AltaProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Alta proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.AltaProveedor");

            ps.AddParameter("@user", UsernameProveedor.Text);
            ps.AddParameter("@cuit", CUIT.Text);
            ps.AddParameter("@razon_social", RazonSocial.Text);
            ps.AddParameter("@mail", MailProveedor.Text);
            ps.AddParameter("@telefono", TelefonoProveedor.Text);
            ps.AddParameter("@direccion", Calle.Text);
            ps.AddParameter("@nombre_contacto", NombreContactoProveedor.Text);
            ps.AddParameter("@ciudad", CiudadProveedor.Text);
            //FALTA AGREGAR ESTOS 5 PARAMETROS EN EL SCRIPT DE LOS PROCEDURES
           // ps.AddParameter("@piso", Piso.Text);
           // ps.AddParameter("@departamento", Departamento.Text);
            ps.AddParameter("@rubro", RubroProveedor.Text);
            ps.AddParameter("@localidad", Localidad.Text);
            ps.AddParameter("@codigo_postal", CodigoPostal.Text);
            ps.AddParameter("@estado", "Habilitado");

            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString())
            {
                case "0": MessageBox.Show("Registro guardado con éxito","Alta proveedor");
                    break;
                case "1": MessageBox.Show("El proveedor ya existe","Alta proveedor");
                    break;
            }
        }

       
    }
}
