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
    public partial class BajaAdministrador : Form
    {
        public BajaAdministrador()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (user.Text == "") {
                MessageBox.Show("Ingrese el username");
                return;
            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.EliminarAdministrador");
            ps.AddParameter("@user", user.Text);

            switch (ps.execSP().Value.ToString()) { 
            
                case "0":
                    MessageBox.Show("Baja realizada con éxito");
                    return;
                case "1":
                    MessageBox.Show("El usuario no existe");
                    return;
                case "2":
                    MessageBox.Show("El usuario ya se encuentra dado de baja");
                    return;
            
            }
        }
    }
}
