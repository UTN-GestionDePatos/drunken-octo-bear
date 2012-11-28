using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.GUI.AbmAdministrador
{
    public partial class ABMAdministrador : Form
    {
        public ABMAdministrador()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            new AltaAdministrador().Show();

        }

        private void Baja_Click(object sender, EventArgs e)
        {
            new BajaAdministrador().Show();
        }
    }
}
