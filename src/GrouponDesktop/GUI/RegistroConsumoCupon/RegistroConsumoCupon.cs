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

namespace GrouponDesktop.GUI.RegistroConsumoCupon
{
    public partial class RegistroConsumoCupon : Form
    {
        public RegistroConsumoCupon()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (CodigoCupon.Text == "" || Cliente.Text == "" )
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            try
            {
                Session s = (Session)AppContext.getObject(typeof(Session));
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.ConsumoCupon");

                ps.AddParameter("@idcupon", Int32.Parse(CodigoCupon.Text));
                ps.AddParameter("@username", Cliente.Text);
                ps.AddParameter("@fecha_actual", Core.Properties.getProperty("fecha"));
                ps.AddParameter("@proveedor", s.username);

                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "1": MessageBox.Show("El cupón ingresado no es válido para el cliente, o el cliente no existe");
                        return;
                    case "2": MessageBox.Show("El cupón no pertenece al proveedor logueado");
                        return;
                    case "3": MessageBox.Show("Se venció el canje del cupón");
                        return;
                    case "0": MessageBox.Show("Registro de consumo de cupón exitoso");
                        return;
                    case "5": MessageBox.Show("El cupón está devuelto o ya canjeado");
                        return;
                }
            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un valor numérico de cupón");
            }
        }

    }
}
