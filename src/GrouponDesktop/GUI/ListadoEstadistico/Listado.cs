using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.GUI.ListadoEstadistico
{
    public partial class Listado : Form
    {


        public Listado()
        {
            InitializeComponent();
        }

        public void SetDataGridView(DataTable dt){
            this.ListadoGV.DataSource = dt;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
