using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.GUI.CargaCredito
{
    public partial class CargaCredito : Form
    {
        public CargaCredito()
        {
            InitializeComponent();
        }

        private void TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TipoPago.SelectedItem.Equals("Tarjeta de Crédito") || this.TipoPago.SelectedItem.Equals("Tarjeta de Débito"))
            {
                this.NumeroTarjeta.Enabled = true;
            }
            else {
                this.NumeroTarjeta.Enabled = false;
            }
        }

       

      
    }
}
