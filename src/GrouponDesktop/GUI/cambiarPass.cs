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

namespace GrouponDesktop.GUI
{
    public partial class cambiarPass : Form
    {
        public cambiarPass()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }


        private void cambiarPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Cambiar password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Confirmar_Click_1(object sender, EventArgs e)
        {
            if (passV.Text == "" || passN.Text == "" || passN2.Text == "")
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            Session s = (Session)AppContext.getObject(typeof(Session));
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.CambiarPassword");
            ps.AddParameter("@user", s.username);
            ps.AddParameter("@passVieja", passV.Text);
            ps.AddParameter("@passNueva", passN.Text);
            ps.AddParameter("@passNueva2", passN2.Text);
            SqlParameter ret = ps.execSP();

            switch (ret.Value.ToString())
            {

                case "0":
                    MessageBox.Show("Contraseña cambiada con éxito");
                    this.Hide();
                    return;

                case "1":
                    MessageBox.Show("La contraseña actual ingresada es incorrecta");
                    return;

                case "2":
                    MessageBox.Show("La confirmación de la nueva contraseña no coincide con la ingresada");
                    return;
            }
        }

        private void Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
