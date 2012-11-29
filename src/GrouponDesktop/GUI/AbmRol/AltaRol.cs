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
            for (int i = 0; i < ListaFuncionalidades.Items.Count; i++) ListaFuncionalidades.SetItemChecked(i, false);
          
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            try
            {

                SQLResponse response = manager.executeQuery("SELECT id_funcionalidad, descripcion from GESTION_DE_PATOS.Funcionalidades");

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
                return;
            }

            String nombreRol = NombreRol.Text;

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.AltaRol");
            ps.AddParameter("@nombre",nombreRol);
            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString()) {
                case "1" : MessageBox.Show("El rol ya existe");
                    return;
            }

            ps.NombreSP("GESTION_DE_PATOS.AsignarFuncionalidadAlRol");

            foreach (String item in ListaFuncionalidades.CheckedItems)
            {
                ps.AddParameter("@id",Int32.Parse(item.ToString().Substring(0,item.IndexOf(":"))));
                ps.AddParameter("@rol",nombreRol);
                ps.execSP();
            }
            MessageBox.Show("Alta correcta");
            this.Hide();
            return;
        }

    }
}
