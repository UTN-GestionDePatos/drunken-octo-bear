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

namespace GrouponDesktop.GUI.AbmCliente
{
    public partial class ModificacionCliente : Form
    {
       private DBManager dbManager = null;
       private FilaSeleccionada cliente;

        public ModificacionCliente(FilaSeleccionada cliente_seleccionado)
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            cliente = cliente_seleccionado;
        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {
            UsernameCliente.Text = cliente.getDato("usernameDataGridViewTextBoxColumn").ToString();

            SQLResponse response = dbManager.executeQuery("SELECT passwd FROM GESTION_DE_PATOS.Usuarios WHERE username = '" + UsernameCliente.Text + "'");
            PasswordCliente.Text = response.result.Rows[0][0].ToString();
            NombreCliente.Text = cliente.getDato("nombreDataGridViewTextBoxColumn").ToString();
            ApellidoCliente.Text = cliente.getDato("apellidoDataGridViewTextBoxColumn").ToString();
            MailCliente.Text = cliente.getDato("mailDataGridViewTextBoxColumn").ToString();
            TelefonoCliente.Text = cliente.getDato("telefonoDataGridViewTextBoxColumn").ToString();
            FchNacimientoCliente.Text = cliente.getDato("fechanacimientoDataGridViewTextBoxColumn").ToString();
            DNICliente.Text = cliente.getDato("dniDataGridViewTextBoxColumn").ToString();
            DireccionC.Text = cliente.getDato("direccionDataGridViewTextBoxColumn").ToString();
           // CodigoPostal.Text = cliente.getDato("codigopostalDataGridViewTextBoxColumn").ToString();

            SQLResponse r = dbManager.executeQuery("SELECT localidad FROM GESTION_DE_PATOS.Localidades");
            foreach (DataRow row in r.result.Rows)
            {
                this.ciudadCliente.Items.Add(row[0]);
            }

            SQLResponse r2 = dbManager.executeQuery("SELECT e.nombre_estado FROM GESTION_DE_PATOS.Usuarios u JOIN GESTION_DE_PATOS.EstadosUsuarios e ON u.estado = e.id_estado WHERE u.username = '" + UsernameCliente.Text + "'");
            Estado.Text = r2.result.Rows[0][0].ToString();
            Estado.Items.Add("Habilitado");
            Estado.Items.Add("Deshabilitado");
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            UsernameCliente.Text = "";
            NombreCliente.Text = "";
            ApellidoCliente.Text = "";
            MailCliente.Text = "";
            TelefonoCliente.Text = "";
            FchNacimientoCliente.Text = "";
            DNICliente.Text = "";
            DireccionC.Text = "";
            CodigoPostal.Text = "";
            PasswordCliente.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.ModificarCliente");

                ps.AddParameter("@user", UsernameCliente.Text);
                ps.AddParameter("@nombre", NombreCliente.Text);
                ps.AddParameter("@apellido", ApellidoCliente.Text);
                ps.AddParameter("@mail", MailCliente.Text);
                ps.AddParameter("@tel", Int64.Parse(TelefonoCliente.Text));
                ps.AddParameter("@fecha", FchNacimientoCliente.Text);
                ps.AddParameter("@dni", Int64.Parse(DNICliente.Text));
                ps.AddParameter("@direccion", DireccionC.Text);
                ps.AddParameter("@cp", Int64.Parse(CodigoPostal.Text));
                ps.AddParameter("@ciudad", ciudadCliente.SelectedItem.ToString());

                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "0":
                        ps.NombreSP("GESTION_DE_PATOS.EliminarLocalidades");
                        ps.AddParameter("@user", UsernameCliente.Text);
                        ps.executeNoReturn();

                        ps.NombreSP("GESTION_DE_PATOS.RegistrarLocalidades");
                        foreach (Object localidad in this.ListaZonas.CheckedItems)
                        {
                            ps.AddParameter("@localidad", localidad.ToString());
                            ps.AddParameter("@user", UsernameCliente.Text);
                            ps.executeNoReturn();
                        }

                        MessageBox.Show("Registro modificado con éxito", "Modificar cliente");
                        break;
                    case "1": MessageBox.Show("Ocurrió un error al modificar el registro", "Modificar cliente");
                        break;
                }
            }
            catch (SqlException) {
                MessageBox.Show("Ingrese valores correctos para el dni, teléfono, código postal y fecha de nacimiento");
                return;
            }
        }

        private void ModificacionCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Modificar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



      
    }
}
