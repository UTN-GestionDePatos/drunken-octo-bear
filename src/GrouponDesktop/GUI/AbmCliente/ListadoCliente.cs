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
        public Listado listado;

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
            this.listado = new Listado(dataGridClientes, "SELECT v.username, v.nombre, v.apellido, v.dni, v.mail FROM GESTION_DE_PATOS.viewclientes v JOIN GESTION_DE_PATOS.Usuarios u ON v.username = u.username WHERE u.rol = 'Cliente'");
            this.listado.actualizar_datagridview();

            DataGridViewButtonColumn modificar = new DataGridViewButtonColumn();
            modificar.Name = "modificar";
            modificar.HeaderText = "Modificar";
            this.dataGridClientes.Columns.Add(modificar);

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.Name = "eliminar";
            eliminar.HeaderText = "Eliminar";
            this.dataGridClientes.Columns.Add(eliminar);

            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.Columns["modificar"].ReadOnly = false;
            this.dataGridClientes.Columns["eliminar"].ReadOnly = false;

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

 
                ModificacionCliente mc = new ModificacionCliente(cliente, listado);
                mc.Show();

                this.listado.actualizar_datagridview();

                
            }
            else if (columna_seleccionada == "eliminar")
            {
                if (MessageBox.Show("¿Esta seguro que quiere eliminar este cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarUsuario");
                    int columna = dataGridClientes.Columns["usernameDataGridViewTextBoxColumn"].Index;
                    int fila = dataGridClientes.CurrentCell.RowIndex;

                    String username = dataGridClientes[columna, fila].Value.ToString();
                    ps.AddParameter("@user", username);

                    SqlParameter retval = ps.execSP();

                    switch (retval.Value.ToString())
                    {
                        case "0": MessageBox.Show("Registro eliminado");
                            this.listado.actualizar_datagridview();
                            break;
                        case "1": MessageBox.Show("Se produció un error. El nombre de usuario no existe", "Eliminar cliente");
                            break;
                        case "2": MessageBox.Show("El cliente ya se encuentra eliminado","Eliminar cliente");
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

            this.listado.actualizar_datagridview();
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
            String where = "";

            if (validarTextBox(Nombre))
                where = where + " AND nombre like '" + Nombre.Text.ToString() + "%'";

            if (validarTextBox(Apellido))
                where = where + " AND apellido like '" + Apellido.Text.ToString() + "%'";

            if (validarTextBox(DNI))
                where = where + " AND dni = '" + DNI.Text.ToString() + "'";

            if (validarTextBox(Mail))
                where = where + " AND mail like '" + Mail.Text.ToString() + "%'";

            try
            {
                //Formación de query final
                String query = "SELECT v.username, v.nombre, v.apellido, v.dni, v.mail FROM GESTION_DE_PATOS.viewclientes v JOIN GESTION_DE_PATOS.Usuarios u ON v.username = u.username WHERE u.rol = 'Cliente' ";
                if (!string.Equals(where, ""))
                {
                    query = query + where;
                }

                SQLResponse r = dbManager.executeQuery(query);
                this.SetDataGridView(r.result);
            }
            catch (SqlException)
            {
                MessageBox.Show("Ingrese datos correctos", "Listado Cliente");
                return;
            }


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


     

      
    }
}
