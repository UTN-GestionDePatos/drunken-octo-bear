using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.GUI.AbmRol
{
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            new AltaRol().Show();
        }

        private void Modificacion_Click(object sender, EventArgs e)
        {
            new ListadoRol().Show();
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            new ListadoRol().Show();
        }

    
    }
}
