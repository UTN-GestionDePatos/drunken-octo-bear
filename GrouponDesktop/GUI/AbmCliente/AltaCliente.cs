using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        }

        
     


      
    }
}
