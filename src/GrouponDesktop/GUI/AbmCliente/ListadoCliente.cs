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
            // TODO: esta línea de código carga datos en la tabla 'gD2C2012DataSet4.viewclientes' Puede moverla o quitarla según sea necesario.
            this.viewclientesTableAdapter.Fill(this.gD2C2012DataSet4.viewclientes);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2012DataSetClientes.Clientes' Puede moverla o quitarla según sea necesario.
          //  this.clientesTableAdapter1.Fill(this.gD2C2012DataSetClientes.Clientes);
            dataGridClientes.DataSource = null;
            /*
            SQLResponse r;
            
            r = dbManager.executeQuery("SELECT * FROM Clientes");
            this.SetDataGridView(r.result);
            */

            DataGridViewButtonColumn modificar = new DataGridViewButtonColumn();
            modificar.Name = "modificar";
            modificar.HeaderText = "Modificar";
            this.dataGridClientes.Columns.Add(modificar);

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.Name = "eliminar";
            eliminar.HeaderText = "Eliminar";
            this.dataGridClientes.Columns.Add(eliminar);

        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.dataGridClientes.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "modificar")
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
            else if (columna_seleccionada == "eliminar")
            {
                if (MessageBox.Show("¿Esta seguro que quiere eliminar este cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarCliente");
                    int columna = dataGridClientes.Columns["usernameDataGridViewTextBoxColumn"].Index;
                    int fila = dataGridClientes.CurrentCell.RowIndex;

                    String username = dataGridClientes[columna, fila].Value.ToString();
                    ps.AddParameter("@user", username);

                    SqlParameter retval = ps.execSP();

                    switch (retval.Value.ToString())
                    {
                        case "0": MessageBox.Show("Registro eliminado");
                            break;
                        case "1": MessageBox.Show("Se produció un error. El nombre de usuario no existe", "Eliminar cliente");
                            break;
                    }
                }
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
                MessageBox.Show("Debe ingresar por lo menos un filtro","Error al buscar");
                return;
            }

            //Clausula WHERE para filtrar la búsqueda
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

            //Formación de query final
            String query = "SELECT * FROM GESTION_DE_PATOS.viewclientes ";
            if (!string.Equals(where,"WHERE"))
            {
                query = query + where;
            }

            SQLResponse r = dbManager.executeQuery(query);
            this.SetDataGridView(r.result);
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Buscar_Click(sender, null);
            }
        }

        private void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Buscar_Click(sender, null);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.viewclientesTableAdapter.FillBy(this.gD2C2012DataSet4.viewclientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



     

      
    }
}
