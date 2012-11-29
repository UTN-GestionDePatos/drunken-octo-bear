using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.AbmAdministrador
{
    public partial class BajaAdministrador : Form
    {
        private DBManager dbManager = null;

        public BajaAdministrador()
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        }


        public void SetDataGridView(DataTable data)
        {
            this.administradores.DataSource = data;
        }

        private void BajaAdministrador_Load(object sender, EventArgs e)
        {
            SQLResponse r;
            String query = "SELECT * FROM GESTION_DE_PATOS.Administradores";
            r = dbManager.executeQuery(query);
            this.SetDataGridView(r.result);
        }

        private void administradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.administradores.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "eliminar")
            {

                ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarUsuario");
                int columna = administradores.Columns["usernameDataGridViewTextBoxColumn"].Index;
                int fila = administradores.CurrentCell.RowIndex;

                String username = administradores[columna, fila].Value.ToString();
                ps.AddParameter("@user", username);

                switch (ps.execSP().Value.ToString())
                {

                    case "0":
                        MessageBox.Show("Baja realizada con éxito");
                        this.Hide();
                        return;
                    case "1":
                        MessageBox.Show("El usuario no existe");
                        return;
                    case "2":
                        MessageBox.Show("El usuario ya se encuentra dado de baja");
                        return;
                }

            }
        }
    }
}
