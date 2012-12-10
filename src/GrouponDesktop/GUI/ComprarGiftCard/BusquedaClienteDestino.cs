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

namespace GrouponDesktop.GUI.ComprarGiftCard
{
    public partial class BusquedaClienteDestino : Form
    {
        public BusquedaClienteDestino(ComprarGiftCard.ComprarGirftcard cG)
        {
            InitializeComponent();
            this.comprarG = cG;
        }

        public Listado listado;
        public ComprarGiftCard.ComprarGirftcard comprarG;

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.Nombre.Text = "";
            this.Apellido.Text = "";
            this.DNI.Text = "";

            this.dataGridClientes.DataSource = null;
            if(dataGridClientes.Columns.Contains("Seleccionar")){
                this.dataGridClientes.Columns.Remove("Seleccionar");
            }



        }

        public void SetDataGridView(DataTable data)
        {
            this.dataGridClientes.DataSource = data;
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
            if (Nombre.Text == "" && Apellido.Text == "" && DNI.Text == "")
            {
                MessageBox.Show("Debe ingresar por lo menos un filtro", "Error al buscar");
                return;
            }

            //Clausula WHERE para filtrar la búsqueda
            String where = "WHERE";
            bool es_primero = true;

            if (validarTextBox(Nombre))
            {
                where = where + " nombre like '%" + Nombre.Text.ToString() + "%'";
                es_primero = false;
            }

            if (validarTextBox(Apellido))
            {
                if (es_primero)
                {
                    where = where + " apellido like '%" + Apellido.Text.ToString() + "%'";
                    es_primero = false;
                }
                else
                    where = where + " AND apellido like '%" + Apellido.Text.ToString() + "%'";

            }

            if (validarTextBox(DNI))
            {
                if (es_primero)
                {
                    where = where + " dni = '" + DNI.Text.ToString() + "'";
                    es_primero = false;
                }
                else
                    where = where + " AND dni = '" + DNI.Text.ToString() + "'";

            }

           try
            {
                //Formación de query final
                String query = "SELECT username, nombre, apellido, dni FROM GESTION_DE_PATOS.viewclientes ";
                if (!string.Equals(where, "WHERE"))
                {
                    query = query + where;
                    query = query + " and estado = 'Habilitado'";
                }

                this.dataGridClientes.Enabled = true;
                new Listado(dataGridClientes, query).actualizar_datagridview();
               
               if (!dataGridClientes.Columns.Contains("Seleccionar"))
                {
                    DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
                    seleccionar.Name = "Seleccionar";
                    seleccionar.HeaderText = "Seleccionar";
                    this.dataGridClientes.Columns.Add(seleccionar);

                    this.dataGridClientes.ReadOnly = true;
                    this.dataGridClientes.Columns["Seleccionar"].ReadOnly = false;
                }
           
            }
            catch (SqlException)
            {
                MessageBox.Show("Ingrese datos correctos", "Listado Cliente");
                return;
            }


        }

        private void BusquedaClienteDestino_Load(object sender, EventArgs e)
        {
            this.dataGridClientes.AllowUserToAddRows = false;
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.dataGridClientes.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "Seleccionar")
            {
                Object username = dataGridClientes.Rows[dataGridClientes.CurrentCell.RowIndex].Cells["username"].Value;
                
                if (username == null){
                    MessageBox.Show("Seleccione un cliente");
                    return;
                }
                comprarG.SetUsername(username.ToString());
                this.Hide();
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Buscar_Click(sender, null);
            }
        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Buscar_Click(sender, null);
            }
        }

        private void DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Buscar_Click(sender, null);
            }
        }


    }
}
