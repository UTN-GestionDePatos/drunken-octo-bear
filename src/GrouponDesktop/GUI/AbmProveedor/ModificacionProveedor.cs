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
       public Listado listado;

        public ModificacionProveedor(FilaSeleccionada proveedor_seleccionado, Listado listado)
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            proveedor = proveedor_seleccionado;
            this.listado = listado;
        }

        private void ModificacionProveedor_Load(object sender, EventArgs e)
        {
            UsernameP.Text = proveedor.getDato("usernameDataGridViewTextBoxColumn").ToString();
            CUIT.Text = proveedor.getDato("cuitDataGridViewTextBoxColumn").ToString();
 
            SQLResponse response = dbManager.executeQuery("SELECT telefono, GESTION_DE_PATOS.localidad(ciudad) AS 'ciudad', direccion, codigo_postal FROM GESTION_DE_PATOS.Proveedores WHERE username = '" + UsernameP.Text + "' AND cuit = '" + CUIT.Text + "'");

            RazonSocial.Text = proveedor.getDato("razonsocialDataGridViewTextBoxColumn").ToString();
            MailP.Text = proveedor.getDato("mailDataGridViewTextBoxColumn").ToString();
            TelefonoP.Text = response.result.Rows[0][0].ToString();
            NombreContacto.Text = proveedor.getDato("nombrecontactoDataGridViewTextBoxColumn").ToString();
            Direccion.Text = response.result.Rows[0][2].ToString();
            CodigoPostalP.Text = response.result.Rows[0][3].ToString();

            SQLResponse rubros = dbManager.executeQuery("SELECT descripcion FROM GESTION_DE_PATOS.Rubros");
            foreach (DataRow row in rubros.result.Rows)
            {
                this.RubroP.Items.Add(row[0]);
            }

            RubroP.SelectedItem = proveedor.getDato("rubroDataGridViewTextBoxColumn").ToString();

            SQLResponse ciudades = dbManager.executeQuery("SELECT localidad FROM GESTION_DE_PATOS.Localidades");
            foreach (DataRow row in ciudades.result.Rows)
            {
                this.ciudadP.Items.Add(row[0]);
            }

            ciudadP.SelectedItem = response.result.Rows[0][1].ToString();

            response = dbManager.executeQuery("SELECT e.nombre_estado FROM GESTION_DE_PATOS.Usuarios u JOIN GESTION_DE_PATOS.Estados e ON u.estado = e.id_estado WHERE u.username = '" + UsernameP.Text + "'");

            Estado.Items.Add("Habilitado");
            Estado.Items.Add("Deshabilitado");

            String estado_actual = response.result.Rows[0][0].ToString();
            if (!Estado.Items.Contains(estado_actual))
                Estado.Items.Add(estado_actual);

            Estado.SelectedItem = estado_actual;

            response = dbManager.executeQuery("SELECT nombre FROM GESTION_DE_PATOS.Roles");

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            UsernameP.Text = "";
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

            try
            {
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.ModificarProveedor");

                ps.AddParameter("@user", UsernameP.Text);
                ps.AddParameter("@cuit", CUIT.Text);
                ps.AddParameter("@razon_social", RazonSocial.Text);
                ps.AddParameter("@mail", MailP.Text);
                ps.AddParameter("@telefono", Int64.Parse(TelefonoP.Text));
                ps.AddParameter("@direccion", Direccion.Text);
                ps.AddParameter("@codigo_postal", Int64.Parse(CodigoPostalP.Text));
                ps.AddParameter("@ciudad", ciudadP.SelectedItem.ToString());
                ps.AddParameter("@rubro", RubroP.SelectedItem.ToString());
                ps.AddParameter("@nombre_contacto", NombreContacto.Text);
                ps.AddParameter("@estado", Estado.Text);

                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "0":
                        MessageBox.Show("Registro modificado con éxito", "Modificar proveedor", MessageBoxButtons.OK);
                        this.listado.actualizar_datagridview();
                        this.Hide();
                        break;
                    case "1": MessageBox.Show("El proveedor no existe", "Modificar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "2": MessageBox.Show("Los datos ingresados corresponden a un usuario ya registrado", "Modificar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }


            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un valor numérico para código postal y teléfono ");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ha ingresado un codigo postal demasiado grande, ingrese otro", "Alta proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ModificacionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ModificacionProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del formulario?", "Modificar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.listado.actualizar_datagridview();
            }
        }

        private void CambiarPassword_Click(object sender, EventArgs e)
        {
            CambiarPassDesdeAdmin new_form = new CambiarPassDesdeAdmin(UsernameP.Text);
            new_form.Show();
        }

        private void Limpiar_Click_1(object sender, EventArgs e)
        {
            this.NombreContacto.Text = "";
            this.RazonSocial.Text = "";
            this.MailP.Text = "";
            this.Direccion.Text = "";
            this.TelefonoP.Text = "";
            this.CodigoPostalP.Text = "";
            this.CUIT.Text = "";
        }

        private void CambiarRol_Click(object sender, EventArgs e)
        {
            new CambiarRol(UsernameP.Text, listado).Show();
            this.listado.actualizar_datagridview();
            this.Hide();
        }


       
    }
}
