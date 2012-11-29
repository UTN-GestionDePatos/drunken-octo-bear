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
       public Listado listado;

        public ModificacionCliente(FilaSeleccionada cliente_seleccionado, Listado listado)
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            this.cliente = cliente_seleccionado;
            this.listado = listado;
        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {
            UsernameCliente.Text = cliente.getDato("usernameDataGridViewTextBoxColumn").ToString();

            NombreCliente.Text = cliente.getDato("nombreDataGridViewTextBoxColumn").ToString();
            ApellidoCliente.Text = cliente.getDato("apellidoDataGridViewTextBoxColumn").ToString();
            MailCliente.Text = cliente.getDato("mailDataGridViewTextBoxColumn").ToString();
            DNICliente.Text = cliente.getDato("dniDataGridViewTextBoxColumn").ToString();

            SQLResponse response = dbManager.executeQuery("SELECT fecha_nacimiento, telefono, direccion, codigo_postal, GESTION_DE_PATOS.localidad(ciudad) FROM GESTION_DE_PATOS.Clientes WHERE username = '" + UsernameCliente.Text + "'");

            FchNacimientoCliente.Text = response.result.Rows[0][0].ToString();
            TelefonoCliente.Text = response.result.Rows[0][1].ToString();
            DireccionC.Text = response.result.Rows[0][2].ToString();
            CodigoPostal.Text = response.result.Rows[0][3].ToString();
            
            SQLResponse ciudades = dbManager.executeQuery("SELECT localidad FROM GESTION_DE_PATOS.Localidades");
            foreach (DataRow row in ciudades.result.Rows)
            {
                this.ciudadCliente.Items.Add(row[0]);
            }

            ciudadCliente.SelectedItem = response.result.Rows[0][4].ToString();

            response = dbManager.executeQuery("SELECT e.nombre_estado FROM GESTION_DE_PATOS.Usuarios u JOIN GESTION_DE_PATOS.Estados e ON u.estado = e.id_estado WHERE u.username = '" + UsernameCliente.Text + "'");

            Estado.Items.Add("Habilitado");
            Estado.Items.Add("Deshabilitado");

            String estado_actual = response.result.Rows[0][0].ToString();
            if(!Estado.Items.Contains(estado_actual))
                Estado.Items.Add(estado_actual);

            Estado.SelectedItem = estado_actual;

            response = dbManager.executeQuery("SELECT GESTION_DE_PATOS.localidad(id_localidad) AS 'localidad' FROM GESTION_DE_PATOS.Localidad_por_usuario WHERE username = '" + UsernameCliente.Text + "'");
 
            foreach (DataRow row in ciudades.result.Rows)
            {
                this.ListaZonas.Items.Add(row[0]);
            }

            foreach (DataRow r in response.result.Rows) {
                ListaZonas.SetItemChecked(ListaZonas.Items.IndexOf(r[0]), true);
            }

           
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
            for (int i = 0; i < ListaZonas.Items.Count; i++) ListaZonas.SetItemChecked(i, false);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (UsernameCliente.Text == "" || NombreCliente.Text == "" || ApellidoCliente.Text == "" || TelefonoCliente.Text == "" || DNICliente.Text == "")
            {
                MessageBox.Show("Hay campos obligatorios que están vacíos", "Modificar cliente");
                return;
            }

            try
            {
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.ModificarCliente");

                ps.AddParameter("@user", UsernameCliente.Text);
                ps.AddParameter("@nombre", NombreCliente.Text);
                ps.AddParameter("@apellido", ApellidoCliente.Text);
                ps.AddParameter("@mail", MailCliente.Text);
                ps.AddParameter("@tel", TelefonoCliente.Text);
                ps.AddParameter("@fecha", DateTime.Parse(FchNacimientoCliente.Text));
                ps.AddParameter("@dni", DNICliente.Text);
                ps.AddParameter("@direccion", DireccionC.Text);
                ps.AddParameter("@codigo_postal", CodigoPostal.Text);
                ps.AddParameter("@ciudad", ciudadCliente.SelectedItem.ToString());
                ps.AddParameter("@estado", Estado.SelectedItem.ToString());

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
                        this.listado.actualizar_datagridview();
                        this.Hide();
                        break;
                    case "1": MessageBox.Show("El cliente no existe", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "2": MessageBox.Show("Los datos ingresados corresponden a un usuario ya registrado", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
            catch (SqlException) {
                MessageBox.Show("Ingrese valores correctos para el dni, teléfono, código postal y fecha de nacimiento");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ha ingresado un codigo postal demasiado grande, ingrese otro", "Alta proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ModificacionCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del formulario?", "Modificar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
            CambiarPassDesdeAdmin new_form = new CambiarPassDesdeAdmin(UsernameCliente.Text);
            new_form.ShowDialog();

        }

        private void CambiarRol_Click(object sender, EventArgs e)
        {
            new CambiarRol(UsernameCliente.Text, listado).Show();
            listado.actualizar_datagridview();
            this.Hide();
        }

        private void Fecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = Fecha.SelectionStart;
            string fechaStr = date.Date.ToShortDateString();

            FchNacimientoCliente.Text = fechaStr;

            Fecha.Visible = false;
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            Fecha.Visible = true;
        }



      
    }
}
