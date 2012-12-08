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
using System.Data.SqlTypes;

namespace GrouponDesktop.AbmCliente
{
    public partial class AltaProveedor : Form
    {

        private String rol_anterior = "";
        static DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));
        Listado listado;

        public AltaProveedor()
        {
            InitializeComponent();
        }

        public AltaProveedor(String user, String rol, Listado listado)
        {
            InitializeComponent();
            UsernameP.Text = user;
            PassP.Text = "sumbudrule";
            ConfirmarPassword.Text = "sumbudrule";
            ConfirmarPassword.Enabled = false;
            PassP.Enabled = false;
            UsernameP.Enabled = false;
            this.rol_anterior = rol;
            this.listado = listado;
          
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            if (this.UsernameP.Enabled == true)
            {
                this.UsernameP.Text = "";
                this.ConfirmarPassword.Text = "";
                this.PassP.Text = "";
            }            
            this.RazonSocial.Text = "";
            this.CUIT.Text = "";
            this.MailP.Text = "";
            this.TelefonoP.Text = "";
            this.NombreContacto.Text = "";
            this.Direccion.Text = "";
            this.CodigoPostalP.Text = "";
            
        }

        private void AltaProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Desea rechazar los cambios?", "Alta proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (!String.Equals(rol_anterior, ""))
                {
                    db.executeQuery("UPDATE GESTION_DE_PATOS.Usuarios SET rol = '" + rol_anterior + "' where username = '" + UsernameP.Text + "'");
                    MessageBox.Show("Cancelación de alta. Este usuario vuelve a tener el rol anterior", "Cambiar rol");
                    this.listado.actualizar_datagridview();
                    this.Hide();
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            if (!String.Equals(PassP.Text, ConfirmarPassword.Text))
            {
                MessageBox.Show("Los campos passwords no coinciden", "Alta Proveedor");
                return;
            }

            if ((UsernameP.Text == "" && UsernameP.Enabled == true) || PassP.Text == "" ||
                       RazonSocial.Text == "" || CUIT.Text == "" ||
                       MailP.Text == "" || TelefonoP.Text == "" ||
                       Direccion.Text == "" || NombreContacto.Text == "" ||
                       ciudadP.SelectedItem == null ||
                       CodigoPostalP.Text == "" ||
                       RubroP.SelectedItem  == null || ConfirmarPassword.Text == "")
            {

                MessageBox.Show("Faltan datos");
                return;
            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.AltaProveedor");
            ps.AddParameter("@user", UsernameP.Text);

            if (UsernameP.Enabled == true)
            {
                ps.AddParameter("@pass", PassP.Text);
            }
            else
            {
                ps.NombreSP("GESTION_DE_PATOS.CambiarRolProveedor");
            }

            try
            {
                ps.AddParameter("@cuit", CUIT.Text);
                ps.AddParameter("@razon_social", RazonSocial.Text);
                ps.AddParameter("@mail", MailP.Text);
                ps.AddParameter("@telefono", Int64.Parse(TelefonoP.Text));
                ps.AddParameter("@direccion", Direccion.Text);
                ps.AddParameter("@codigo_postal", Int64.Parse(CodigoPostalP.Text));
                ps.AddParameter("@ciudad", ciudadP.SelectedItem.ToString());
                ps.AddParameter("@rubro", RubroP.SelectedItem.ToString());
                ps.AddParameter("@nombre_contacto", NombreContacto.Text);


                SqlParameter ret = ps.execSP();
                switch (ret.Value.ToString())
                {
                    case "0":
                        MessageBox.Show("Registro realizado con éxito", "Alta proveedor");

                        if (this.listado != null)
                            this.listado.actualizar_datagridview();

                        this.Hide();
                        return;

                    case "2":
                        MessageBox.Show("Los datos ingresados corresponden a un usuario existente", "Alta proveedor");
                        return;

                    case "1":
                        MessageBox.Show("El usuario ya existe", "Alta proveedor");
                        return;

                }

                return;

            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor correcto para el teléfono o el código postal", "Alta proveedor");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ha ingresado un codigo postal demasiado grande, ingrese otro", "Alta proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Hay campos vacíos", "Alta proveedor");
            }

            return;
        }

 

        private void AltaProveedor_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));

            SQLResponse response = manager.executeQuery("SELECT localidad from GESTION_DE_PATOS.Localidades");

            foreach (DataRow r in response.result.Rows)
            {
                ciudadP.Items.Add(r[0]);
       
            }

            response = manager.executeQuery("SELECT descripcion from GESTION_DE_PATOS.Rubros");
            foreach (DataRow r in response.result.Rows)
            {
                RubroP.Items.Add(r[0]);
            }
            RubroP.Items.Add("Otro");
        }
       
    }
}
