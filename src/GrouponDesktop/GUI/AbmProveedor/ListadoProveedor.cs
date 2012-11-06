using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.GUI.AbmProveedor
{
    public partial class ListadoProveedor : Form
    {
        public ListadoProveedor()
        {
            InitializeComponent();
        }

        private void ListadoProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2012DataSetProveedor.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.gD2C2012DataSetProveedor.Proveedores);

        }
    }
}
