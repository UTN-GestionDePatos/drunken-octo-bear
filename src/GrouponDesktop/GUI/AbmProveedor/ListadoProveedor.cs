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


        private void dataGridProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.dataGridProveedores.Columns[e.ColumnIndex].Name;

            if ( columna_seleccionada == "modificar")
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
            else if (columna_seleccionada == "eliminar")
            {
                if (MessageBox.Show("¿Esta seguro que quiere eliminar este proveedor?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarProveedor");
                    int columna = dataGridProveedores.Columns["usernameDataGridViewTextBoxColumn"].Index;
                    int fila = dataGridProveedores.CurrentCell.RowIndex;

                    String username = dataGridProveedores[columna, fila].Value.ToString();
                    ps.AddParameter("@user", username);

                    SqlParameter retval = ps.execSP();

                    switch (retval.Value.ToString())
                    {
                        case "0": MessageBox.Show("Registro eliminado","Eliminar proveedor");
                            break;
                        case "1": MessageBox.Show("Se produció un error. El nombre de usuario no existe", "Eliminar proveedor");
                            break;
                        case "2": MessageBox.Show("El proveedor ya se encuentra eliminado");
                            break;

                    }
                }
            }
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            RazonSocial.Text = "";
            Mail.Text = "";
            CUIT.Text = "";
            dataGridProveedores.DataSource = null;
        }

        private void ListadoProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2012DataSet5.viewproveedores' Puede moverla o quitarla según sea necesario.
            this.viewproveedoresTableAdapter.Fill(this.gD2C2012DataSet5.viewproveedores);

            dataGridProveedores.DataSource = null;

            DataGridViewButtonColumn modificar = new DataGridViewButtonColumn();
            modificar.Name = "modificar";
            modificar.HeaderText = "Modificar";
            this.dataGridProveedores.Columns.Add(modificar);

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.Name = "eliminar";
            eliminar.HeaderText = "Eliminar";
            this.dataGridProveedores.Columns.Add(eliminar);
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
            if (RazonSocial.Text == "" && Mail.Text == "" && CUIT.Text == "")
            {
                MessageBox.Show("Debe ingresar por lo menos un filtro","Error al buscar");
                return;
            }

            //Clausula WHERE para filtrar la búsqueda
            String where = "WHERE";

            if (validarTextBox(RazonSocial))
            {
                where = where + " razon_social like '" + RazonSocial.Text.ToString() + "%'";
                if (validarTextBox(Mail))
                    where = where + " AND mail like '" + Mail.Text.ToString() + "%'";
                if (validarTextBox(CUIT))
                    where = where + " AND cuit like '" + CUIT.Text.ToString() + "%'";
            }
            else if (validarTextBox(Mail))
            {
                where = where + " mail like '" + Mail.Text.ToString() + "%'";
                if (validarTextBox(CUIT))
                    where = where + " AND cuit like '" + CUIT.Text.ToString() + "%'";
            }
            else if (validarTextBox(CUIT))
                where = where + " cuit like '" + CUIT.Text.ToString() + "%'";

            //Formación de query final
            String query = "SELECT * FROM GESTION_DE_PATOS.viewproveedores ";
            if (!string.Equals(where, "WHERE"))
            {
                query = query + where;
            }

            SQLResponse r = dbManager.executeQuery(query);
            this.SetDataGridView(r.result);
        }

        private void RazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Buscar_Click(sender, null);
            }
        }

        private void CUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Buscar_Click(sender, null);
            }
        }

        private void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Buscar_Click(sender, null);
            }
        }
    }
}
