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
    public partial class ListadoAdministradores : Form
    {
        private DBManager dbManager = null;
        Listado listado;

        public ListadoAdministradores()
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
            this.listado = new Listado(administradores, "SELECT * FROM GESTION_DE_PATOS.viewadministradores WHERE username != 'admin'");
            this.listado.actualizar_datagridview();
            this.administradores.ReadOnly = true;
            this.administradores.Columns[4].ReadOnly = false;
            this.administradores.Columns[5].ReadOnly = false;
            this.administradores.Columns[6].ReadOnly = false;
            this.administradores.AllowUserToAddRows = false;

        }

        private void administradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.administradores.Columns[e.ColumnIndex].Name;
            int columna = administradores.Columns["usernameDataGridViewTextBoxColumn"].Index;
            int fila = administradores.CurrentCell.RowIndex;
            String username = administradores[columna, fila].Value.ToString();
  

            if (columna_seleccionada == "eliminar")
            {

                ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarUsuario");
                ps.AddParameter("@user", username);

                switch (ps.execSP().Value.ToString())
                {

                    case "0":
                        MessageBox.Show("Baja realizada con éxito","Baja administrador");
                        this.listado.actualizar_datagridview();
                        return;
                    case "1":
                        MessageBox.Show("El usuario no existe","Baja administrador");
                        return;
                    case "2":
                        MessageBox.Show("El usuario ya se encuentra dado de baja", "Baja administrador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                }

            }
            else if (columna_seleccionada == "habilitar")
            {
                SQLResponse r;
                String query = "UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstado('Habilitado') WHERE username = '" + username + "'";
                r = dbManager.executeQuery(query);
                this.listado.actualizar_datagridview();
                return;
            }
            else if (columna_seleccionada == "deshabilitar")
            {
                SQLResponse r;
                String query = "UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstado('Deshabilitado') WHERE username = '" + username + "'";
                r = dbManager.executeQuery(query);
                this.listado.actualizar_datagridview();
                return;
            }
        }

    }
}
