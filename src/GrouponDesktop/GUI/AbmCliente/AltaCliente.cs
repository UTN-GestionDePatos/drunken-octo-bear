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
    public partial class AltaCliente : Form
    {
        private String rol_anterior = "";
        static DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));
        public Listado listado;

        public AltaCliente()
        {
            InitializeComponent();
        }
        public AltaCliente(String user, String rol, Listado listado)
        {
            InitializeComponent();
            UsernameCliente.Text = user;
            UsernameCliente.Enabled = false;
            PasswordCliente.Text = "sumbudrule";
            PasswordCliente.Enabled = false;
            this.rol_anterior = rol;
            this.listado = listado;

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.ApellidoCliente.Text = "";
            this.UsernameCliente.Text = "";
            this.NombreCliente.Text = "";
            this.MailCliente.Text = "";
            this.TelefonoCliente.Text = "";
            this.FchNacimientoCliente.Text = "";
            this.DNICliente.Text = "";
            this.PasswordCliente.Text = "";
            this.DireccionC.Text = "";
            this.CodigoPostal.Text = "";
            for (int i = 0; i < ListaZonas.Items.Count; i++) ListaZonas.SetItemChecked(i, false);
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((UsernameCliente.Text == "" && UsernameCliente.Enabled == true) || PasswordCliente.Text == "" ||
                       NombreCliente.Text == "" || ApellidoCliente.Text == "" ||
                       MailCliente.Text == "" || TelefonoCliente.Text == "" ||
                       FchNacimientoCliente.Text == "" || DNICliente.Text == "" ||
                       DireccionC.Text == "" || ListaZonas.CheckedItems.Count == 0 ||
                       CodigoPostal.Text == "" ||
                       ciudadCliente.SelectedItem.ToString() == "")
                {

                    MessageBox.Show("Faltan datos","Alta cliente");
                    return;
                }
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.AltaCliente");

                ps.AddParameter("@user", UsernameCliente.Text);
                if (UsernameCliente.Enabled == true)
                {
                    ps.AddParameter("@pass", PasswordCliente.Text);
                }
                else {
                    ps.NombreSP("GESTION_DE_PATOS.CambiarRolCliente");
                }

                ps.AddParameter("@nombre", NombreCliente.Text);
                ps.AddParameter("@apellido", ApellidoCliente.Text);
                ps.AddParameter("@dni", Int64.Parse(DNICliente.Text));
                ps.AddParameter("@fecha", DateTime.Parse(FchNacimientoCliente.Text));
                ps.AddParameter("@mail", MailCliente.Text);
                ps.AddParameter("@tel", Int64.Parse(TelefonoCliente.Text));
                ps.AddParameter("@direccion", DireccionC.Text);
                ps.AddParameter("@cp", Int64.Parse(CodigoPostal.Text));
                ps.AddParameter("@ciudad", ciudadCliente.SelectedItem.ToString());
                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "0":
                        ps.NombreSP("GESTION_DE_PATOS.RegistrarLocalidades");
                        foreach (Object localidad in this.ListaZonas.CheckedItems)
                        {
                            ps.AddParameter("@localidad", localidad.ToString());
                            ps.AddParameter("@user", UsernameCliente.Text);
                            ps.executeNoReturn();
                        }

                        MessageBox.Show("Registro realizado con éxito","Alta cliente");
                        this.listado.actualizar_datagridview();
                        this.Hide();
                        return;

                    case "1": MessageBox.Show("El cliente ya existe", "Alta cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "2": MessageBox.Show("Los datos ingresados corresponden a un usuario ya registrado", "Alta cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un valor correcto para el teléfono, el dni, el código postal o la fecha de nacimiento","Alta cliente");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ha ingresado un codigo postal demasiado grande, ingrese otro", "Alta proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Alta cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if(!String.Equals(rol_anterior,""))
            {
                db.executeQuery("UPDATE GESTION_DE_PATOS.Usuarios SET rol = '" + rol_anterior + "' where username = '" + UsernameCliente.Text + "'");
                MessageBox.Show("Cancelación de alta. Este usuario vuelve a tener el rol anterior", "Cambiar rol");
                this.listado.actualizar_datagridview();
                this.Hide();
            }
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));

            SQLResponse response = manager.executeQuery("SELECT localidad from GESTION_DE_PATOS.Localidades");

            foreach (DataRow r in response.result.Rows)
            {
                ListaZonas.Items.Add(r[0]);
                ciudadCliente.Items.Add(r[0]);
              
            }
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            Fecha.Visible = true;
        }

        private void Fecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = Fecha.SelectionStart;
            string fechaStr = date.Date.ToShortDateString();

            FchNacimientoCliente.Text = fechaStr;

            Fecha.Visible = false;
        }     
    }
}
