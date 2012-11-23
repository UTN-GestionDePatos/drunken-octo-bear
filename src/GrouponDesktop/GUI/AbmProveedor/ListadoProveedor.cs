using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.AbmProveedor
{
    public partial class ListadoProveedor : Form
    {
        private DBManager dbManager = null;

        public ListadoProveedor()
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        }

        public void SetDataGridView(DataTable data)
        {
            this.dataGridProveedores.DataSource = data;
        }

        private void ListadoCliente_Load(object sender, EventArgs e)
        {
            SQLResponse r;

            r = dbManager.executeQuery("SELECT * FROM Proveedores");
            this.SetDataGridView(r.result);


            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = "seleccionar";
            seleccionar.HeaderText = "Seleccionar";

            this.dataGridProveedores.Columns.Add(seleccionar);

        }

        private void dataGridProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.dataGridProveedores.Columns[e.ColumnIndex].Name;

            if ( columna_seleccionada == "seleccionar")
            {
                FilaSeleccionada proveedor = new FilaSeleccionada();
                int cantidad_columnas = dataGridProveedores.ColumnCount - 1;


                for (int i = 0; i < cantidad_columnas; i++)
                {
                    Object value = dataGridProveedores[i, dataGridProveedores.CurrentCell.RowIndex].Value;
                    String nombre = dataGridProveedores.Columns[i].Name;
                    proveedor.addDato(nombre, value);
                }

                ModificacionProveedor mc = new ModificacionProveedor(proveedor);
                mc.Show();
            }
            
        }
    }
}
