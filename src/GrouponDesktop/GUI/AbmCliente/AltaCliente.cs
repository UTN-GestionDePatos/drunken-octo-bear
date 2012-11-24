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
        public AltaCliente()
        {
            InitializeComponent();
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
            this.Calle.Text = "";
            this.Piso.Text = "";
            this.Departamento.Text = "";
            this.CodigoPostal.Text = "";
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.ABMClientes");

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
                case "0": MessageBox.Show("Registro guardado con éxito");
                    break;
                case "1": MessageBox.Show("El cliente ya existe");
                    break;
                case "2": MessageBox.Show("Hay clientes gemelos");
                    break;
            }
        }

        private void AltaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Alta cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }     
    }
}
