using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.AbmRol
{
    public partial class ListadoRol : Form
    {
        public ListadoRol()
        {
            InitializeComponent();
        }

        DBManager m = (DBManager)AppContext.getObject(typeof(DBManager));
            

        private void ListadoRol_Load(object sender, EventArgs e)
        {
            Datos.DataSource = m.executeQuery("SELECT * from GESTION_DE_PATOS.viewroles" ).result;
           
            }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si el índice es 3, quiere borrar el registro.
            if (e.ColumnIndex == 3) {
                DialogResult ret = MessageBox.Show(null, "Desea borrar el Rol?", "Confirmación", MessageBoxButtons.OKCancel);
                if (ret.Equals(DialogResult.Cancel))
                {
                    return;
                }

                SQLResponse resp = m.executeQuery("select id_estado from GESTION_DE_PATOS.Estados where nombre_estado = 'Eliminado'");

                
                DataGridViewCellCollection celdas = this.Datos.Rows[e.RowIndex].Cells;
                ParamSet builder = new ParamSet("GESTION_DE_PATOS.EstablecerEstadoDelRol");
                builder.AddParameter("nombre_rol", celdas[0].Value.ToString());
                builder.AddParameter("estado", resp.result.Rows[0][0]);
                builder.executeNoReturn();
                MessageBox.Show("Baja de rol exitosa");
                Datos.DataSource = m.executeQuery("SELECT * from GESTION_DE_PATOS.viewroles").result;

            }
            // Índice 2 es modificar columna.
            else if (e.ColumnIndex == 2)
            {
                new ModificacionRol(this.Datos.Rows[e.RowIndex].Cells[0].Value.ToString()).ShowDialog();
                Datos.DataSource = m.executeQuery("SELECT * from GESTION_DE_PATOS.viewroles").result;

            }

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void AltaRol_Click(object sender, EventArgs e)
        {
            new AltaRol().Show();
        }
    }
}
