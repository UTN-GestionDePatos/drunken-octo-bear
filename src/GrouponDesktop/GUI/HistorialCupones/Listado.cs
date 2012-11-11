using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.GUI.HistorialCupones
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        public DataGridView GetDataGridView() {
            return this.listadoCupones;
        }
        public void SetDataGridView(DataTable data){
            this.listadoCupones.DataSource = data;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       }
}
