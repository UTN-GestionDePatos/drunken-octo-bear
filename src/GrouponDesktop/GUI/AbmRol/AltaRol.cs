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
            this.ListaFuncionalidades.ClearSelected();
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

            String nombreRol = NombreRol.Text;
            ParamSet ps = new ParamSet();
            ps.NombreSP("dbo.AltaRol");
            Dictionary<String,Object> d = new Dictionary<string,object>();
            d.Add("@nombre",nombreRol);
            ps.Parametros(d);
            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString()) {
                case "1" : MessageBox.Show("El rol ya existe");
                    break;
            }
            
            ps.NombreSP("dbo.AsignarFuncionalidadAlRol");
            d.Clear();
            foreach (Object item in ListaFuncionalidades.CheckedItems)
            {
                d.Add("@id",Int32.Parse(item.ToString().Substring(0,item.ToString().IndexOf(":"))));
                d.Add("@rol",nombreRol);
                ps.Parametros(d);
                ps.execSP();
                d.Clear();
           
            }
            MessageBox.Show("Alta correcta");
        }

    }
}
