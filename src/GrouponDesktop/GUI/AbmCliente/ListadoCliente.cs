using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;
using System.Data.SqlClient;

namespace GrouponDesktop.GUI.AbmCliente
{
    public partial class ListadoCliente : Form
    {
        private DBManager dbManager = null;

        public ListadoCliente()
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        }

        public void SetDataGridView(DataTable data)
        {
            this.dataGridClientes.DataSource = data;
        }

        private void ListadoCliente_Load(object sender, EventArgs e)
        {
            SQLResponse r;

            r = dbManager.executeQuery("SELECT * FROM Clientes");
            this.SetDataGridView(r.result);


            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = "seleccionar";
            seleccionar.HeaderText = "Seleccionar";

            this.dataGridClientes.Columns.Add(seleccionar);

        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.dataGridClientes.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "seleccionar")
            {
                FilaSeleccionada cliente = new FilaSeleccionada();
                int cantidad_columnas = dataGridClientes.ColumnCount - 1;


                for (int i = 0; i < cantidad_columnas; i++)
                {
                    Object value = dataGridClientes[i, dataGridClientes.CurrentCell.RowIndex].Value;
                    String nombre = dataGridClientes.Columns[i].Name;
                    cliente.addDato(nombre, value);
                }

                ModificacionCliente mc = new ModificacionCliente(cliente);
                mc.Show();
            }
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Nombre.Text = "";
            Apellido.Text = "";
            DNI.Text = "";
            Mail.Text = "";
            dataGridClientes.DataSource = null;
        }

        private bool validarTextBox(TextBox textBox)
        {
            bool sin_espacios = true;

            if (textBox.Text == "")
            {
                return false;
            }

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (string.Equals(textBox.Text.ToString()[i], " "))
                {
                    sin_espacios = false;
                }
            }

            return sin_espacios;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "" && Apellido.Text == "" && DNI.Text == "" && Mail.Text == "")
            {
                MessageBox.Show("Debe ingresar por lo menos un filtro");
                return;
            }

            String where = "WHERE";

            if (validarTextBox(Nombre))
            {
                where = where + " nombre like '" + Nombre.Text.ToString() + "%'";
                if (validarTextBox(Apellido))
                    where = where + " AND apellido like '" + Apellido.Text.ToString() + "%'";
                if (validarTextBox(DNI))
                    where = where + " AND dni = " + DNI.Text.ToString();
                if (validarTextBox(Mail))
                    where = where + " AND mail like '" + Mail.Text.ToString() + "%'";
            }
            else if (validarTextBox(Apellido))
            {
                where = where + " apellido like '" + Apellido.Text.ToString() + "%'";
                if (validarTextBox(DNI))
                    where = where + " AND dni = " + DNI.Text.ToString();
                if (validarTextBox(Mail))
                    where = where + " AND mail like '" + Mail.Text.ToString() + "%'";
            }
            else if (validarTextBox(DNI))
            {
                where = where + " dni = " + DNI.Text.ToString();
                if(validarTextBox(Mail))
                    where = where + " AND mail like '" + Mail.Text.ToString() + "%'";
            }
            else if(validarTextBox(Mail))
            {
                where = where + " mail like '" + Mail.Text.ToString() + "%'";
            }

            String query = "SELECT * FROM GESTION_DE_PATOS.Clientes ";
            if (!string.Equals(where,"WHERE"))
            {
                query = query + where;
            }

            SQLResponse r = dbManager.executeQuery(query);
            this.SetDataGridView(r.result);
        }



     

      
    }
}
