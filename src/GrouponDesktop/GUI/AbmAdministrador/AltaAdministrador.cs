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

namespace GrouponDesktop.GUI.AbmAdministrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.user.Text = "";
            this.pass.Text = "";
            this.nombreA.Text = "";
            this.apellido.Text = "";

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (this.user.Text == "" || this.pass.Text == "" || this.nombreA.Text == "" || this.apellido.Text == "") {
                MessageBox.Show("Faltan datos");
                return;

            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarAdministrador");
            ps.AddParameter("@user", user.Text);
          
            switch (ps.execSP().Value.ToString()) { 
            
                case "0":
                    MessageBox.Show("Baja realizada con éxito");
                    return;
                case "1":
                    MessageBox.Show("El username no existe");
                    return;
            
            }

        }
    }
}
