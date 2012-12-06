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
                ps.AddParameter("@fecha_actual", (String)AppContext.getObject(typeof(String)));
                ps.AddParameter("@proveedor", s.username);

                SqlParameter retval = ps.execSP();

                switch (retval.Value.ToString())
                {
                    case "1": MessageBox.Show("El cupón no es válido para el cliente ingresado");
                        return;
                    case "2": MessageBox.Show("El cupón no pertenece al proveedor logueado");
                        return;
                    case "3": MessageBox.Show("Se venció el canje del cupón");
                        return;
                    case "0": MessageBox.Show("Registro de consumo de cupón exitoso");
                        return;
                    case "5": MessageBox.Show("El cupón está devuelto o ya canjeado");
                        return;
                    case "6": MessageBox.Show("El cliente ingresado no existe");
                        return;

                }
            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un valor numérico de cupón");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BusquedaCliente(this).Show();
        }

        public void SetDatos(String cupon, String cliente) {
            this.Cliente.Text = cliente;
            this.CodigoCupon.Text = cupon;
        }
    }
}
