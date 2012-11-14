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
    public partial class ModificacionRol : Form
    {
        String nombre = "";
        DBManager manager;

        public ModificacionRol(String nombre_rol)
        {
            InitializeComponent();
            this.nombre = nombre_rol;
            this.manager = (DBManager)AppContext.getObject(typeof(DBManager));
        }

        private void ModificacionRol_Load(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("SELECT * FROM dbo.FuncionalidadesDelRol(@rol)");
            query.Parameters.AddWithValue("rol", this.nombre);
            SQLResponse respuesta = manager.executeQuery(query);

            String funcionalidad = "";

            foreach(DataRow r in respuesta.result.Rows){
                funcionalidad = r[0].ToString() + ": " + r[1].ToString();
                ListaFuncionalidades.Items.Add(funcionalidad, (r[2].ToString() == "1") ? true : false);
            }

            respuesta = manager.executeQuery("SELECT id_estado, nombre_estado, "+
                "(SELECT 1 FROM Roles roles WHERE roles.estado = e.id_estado AND "+
                " roles.nombre = '"+this.nombre+"') FROM EstadosUsuarios e");
            foreach (DataRow r in respuesta.result.Rows)
            {
                this.Estado.Items.Add(r[0]+": "+ r[1]);
                if (r[2].ToString() == "1") Estado.SelectedIndex = this.Estado.Items.Count - 1;
            }

            this.NombreRol.Text = this.nombre;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            ParamSet builder = new ParamSet("EliminarFuncionalidadesDeRol");
            builder.AddParameter("nombre_rol", this.nombre);
            builder.executeNoReturn();

            builder.NombreSP("dbo.AsignarFuncionalidadAlRol");
            foreach (String item in ListaFuncionalidades.CheckedItems)
            {
                builder.AddParameter("@id", Int32.Parse(item.ToString().Substring(0, item.IndexOf(":"))));
                builder.AddParameter("@rol", this.nombre);
                builder.execSP();
            }

            SqlCommand query;

            String estado = this.Estado.SelectedItem.ToString();
            query = new SqlCommand("UPDATE Roles SET estado=@estado WHERE nombre=@nombre_rol");
            query.Parameters.AddWithValue("estado", estado.Substring(0, estado.IndexOf(':')));
            query.Parameters.AddWithValue("nombre_rol", this.nombre);
            manager.executeQuery(query);

            if (this.nombre != this.NombreRol.Text)
            {
                query = new SqlCommand("UPDATE Roles SET nombre=@nombre WHERE nombre=@nombre_original");
                query.Parameters.AddWithValue("nombre", this.NombreRol.Text);
                query.Parameters.AddWithValue("nombre_original", this.nombre);
                manager.executeQuery(query);
            }
            MessageBox.Show("Rol actualizado");
        }
    }
}
