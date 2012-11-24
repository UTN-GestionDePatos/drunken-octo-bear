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
            NombreCliente.Text = cliente.getDato("nombreDataGridViewTextBoxColumn").ToString();
            ApellidoCliente.Text = cliente.getDato("apellidoDataGridViewTextBoxColumn").ToString();
            MailCliente.Text = cliente.getDato("mailDataGridViewTextBoxColumn").ToString();
            TelefonoCliente.Text = cliente.getDato("telefonoDataGridViewTextBoxColumn").ToString();
            FchNacimientoCliente.Text = cliente.getDato("fechanacimientoDataGridViewTextBoxColumn").ToString();
            DNICliente.Text = cliente.getDato("dniDataGridViewTextBoxColumn").ToString();
            Calle.Text = "";
            Piso.Text = "";
            Departamento.Text = "";
            Localidad.Text = cliente.getDato("ciudadDataGridViewTextBoxColumn").ToString();

            Localidad.Items.Add(cliente.getDato("ciudadDataGridViewTextBoxColumn").ToString());
            SQLResponse r = dbManager.executeQuery("SELECT localidad FROM GESTION_DE_PATOS.Localidades");
            foreach (DataRow row in r.result.Rows)
            {
                this.Localidad.Items.Add(row[0]);
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
            Calle.Text = "";
            Piso.Text = "";
            Departamento.Text = "";
            Localidad.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.ModificarCliente");

            ps.AddParameter("@user", UsernameCliente.Text);
            ps.AddParameter("@nombre", NombreCliente.Text);
            ps.AddParameter("@apellido", ApellidoCliente.Text);
            ps.AddParameter("@mail", MailCliente.Text);
            ps.AddParameter("@tel", TelefonoCliente.Text);
            ps.AddParameter("@fecha", FchNacimientoCliente.Text);
            ps.AddParameter("@dni", DNICliente.Text);
            ps.AddParameter("@direccion", Calle.Text);
            //FALTA AGREGAR ESTOS 3 PARAMETROS EN EL SCRIPT DE LOS PROCEDURES
            ps.AddParameter("@piso", Piso.Text);
            ps.AddParameter("@departamento", Departamento.Text);
            ps.AddParameter("@ciudad", Localidad.Text);

            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString())
            {
                case "0": MessageBox.Show("Registro modificado con éxito","Modificar cliente");
                    break;
                case "1": MessageBox.Show("Ocurrió un error al modificar el registro","Modificar cliente");
                    break;
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
