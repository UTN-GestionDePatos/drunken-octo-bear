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
            this.Piso.Text = "";
            this.Departamento.Text = "";
            this.CodigoPostal.Text = "";
            
        }

       
    }
}
