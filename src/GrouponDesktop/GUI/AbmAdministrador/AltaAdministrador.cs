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
    public partial class AltaAdministrador : Form
    {
        public AltaAdministrador()
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

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.AltaAdministrador");
            ps.AddParameter("@user", user.Text);
            ps.AddParameter("@nombre", nombreA.Text);
            ps.AddParameter("@apellido", apellido.Text);
            ps.AddParameter("@pass", pass.Text);

            switch (ps.execSP().Value.ToString()) { 
            
                case "0":
                    MessageBox.Show("Alta realizada con éxito");
                    this.Hide();
                    return;
                case "1":
                    MessageBox.Show("El username ya existe");
                    return;
             
            }

        }

        private void AltaAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Alta administrador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
