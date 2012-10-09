using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.AbmCliente;

namespace GrouponDesktop.AbmProveedor
{
    public partial class ABMProveedor : Form
    {
        public ABMProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaProveedor ap = new AltaProveedor();
            ap.Show();
        }
    }
}
