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
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.NombreRol.Text = "";

        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            try
            {

                SQLResponse response = manager.executeQuery("SELECT id_funcionalidad, descripcion from Funcionalidades");

                foreach (DataRow r in response.result.Rows)
                {
                    ListaFuncionalidades.Items.Add(r[0] + ": " + r[1]);
                }

            }
            catch (Exception)
            {

            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "" || ListaFuncionalidades.CheckedItems.Count == 0) {
                MessageBox.Show("Faltan datos");
            }



        }

    }
}
