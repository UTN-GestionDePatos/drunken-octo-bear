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
    public partial class CambiarPassDesdeAdmin : Form
    {
        private String username;

        public CambiarPassDesdeAdmin(String user)
        {
            InitializeComponent();
            username = user;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (passN.Text == "" || passN2.Text == "")
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.CambiarPasswordDesdeAdmin");
            ps.AddParameter("@user", this.username);
            ps.AddParameter("@passNueva", passN.Text);
            ps.AddParameter("@passNueva2", passN2.Text);
            SqlParameter ret = ps.execSP();

            switch (ret.Value.ToString())
            {

                case "0":
                    MessageBox.Show("Contraseña cambiada con éxito");
                    return;

                case "1":
                    MessageBox.Show("La confirmación de la nueva contraseña no coincide con la ingresada");
                    return;
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }

        private void CambiarPassDesdeAdmin_Load(object sender, EventArgs e)
        {

        }

    }
}
