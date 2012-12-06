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

namespace GrouponDesktop.GUI.RegistroConsumoCupon
{
    public partial class BusquedaCliente : Form
    {
        public BusquedaCliente(RegistroConsumoCupon rcc)
        {
            InitializeComponent();
            this.registro = rcc;
        }

        public RegistroConsumoCupon registro;
        private DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));
        Session s = (Session)AppContext.getObject(typeof(Session));
        public Listado listado;
    

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.Nombre.Text = "";
            this.Apellido.Text = "";
            this.DNI.Text = "";

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
           
            this.dataGridClientes.Enabled = true;
            if (Nombre.Text == "" && Apellido.Text == "" && DNI.Text == "")
            {
                //todos los clientes que tuvieron actividad con el proveedor logueado
                SQLResponse r = db.executeQuery("select distinct c.username, c.nombre, c.apellido, c.dni from GESTION_DE_PATOS.Clientes c join GESTION_DE_PATOS.Cupones cu on cu.cliente = c.username join GESTION_DE_PATOS.Promociones p on p.id_promocion = cu.id_promocion and p.proveedor = '" + s.username + "'");
                this.dataGridClientes.DataSource = r.result;
                this.dataGridClientes.ReadOnly = true;

                if (!dataGridClientes.Columns.Contains("Seleccionar"))
                {
                    DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
                    seleccionar.Name = "Seleccionar";
                    seleccionar.HeaderText = "Seleccionar";
                    this.dataGridClientes.Columns.Add(seleccionar);

                   
                    this.dataGridClientes.Columns["Seleccionar"].ReadOnly = false;
                }
            }

            else
            {

                //Clausula WHERE para filtrar la búsqueda
                String where = "WHERE";
                bool es_primero = true;

                if (validarTextBox(Nombre))
                {
                    where = where + " nombre like '" + Nombre.Text.ToString() + "%'";
                    es_primero = false;
                }

                if (validarTextBox(Apellido))
                {
                    if (es_primero)
                    {
                        where = where + " apellido like '" + Apellido.Text.ToString() + "%'";
                        es_primero = false;
                    }
                    else
                        where = where + " AND apellido like '" + Apellido.Text.ToString() + "%'";

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
        }

          private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.dataGridClientes.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "Seleccionar")
            {
                
                Object username = dataGridClientes.Rows[dataGridClientes.CurrentCell.RowIndex].Cells["username"].Value;
                
                if (username == null)
                {
                    MessageBox.Show("Seleccione un cliente");
                    return;
                }
                GridCupones gridCupones = new GridCupones(username.ToString(), this.registro);
                gridCupones.Show();
                this.Hide();
            }
        }

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            this.dataGridClientes.Enabled = false;
            this.dataGridClientes.AllowUserToAddRows = false;
        }
    }
}
