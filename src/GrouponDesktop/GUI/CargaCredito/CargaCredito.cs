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

namespace GrouponDesktop.GUI.CargaCredito
{
    public partial class CargaCredito : Form
    {
        private Session s;

        public CargaCredito()
        {
            InitializeComponent();
            this.s = (Session)AppContext.getObject(typeof(Session));
        }

        private void TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.TipoPago.SelectedItem.Equals("Crédito") || this.TipoPago.SelectedItem.Equals("Débito"))
            {
                this.NumeroTarjeta.Enabled = true;
            }
            else {
                this.NumeroTarjeta.Text = "";
                this.NumeroTarjeta.Enabled = false;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Cliente.Text == "" || Monto.Text == "" || TipoPago.SelectedItem == null || (NumeroTarjeta.Text == "" && NumeroTarjeta.Enabled)) {
                MessageBox.Show("Faltan datos");
                return;
            }
            
            try
            {
                Int64.Parse(Monto.Text);
            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un monto entero válido");
                return;
            }
            ParamSet ps = new ParamSet("GESTION_DE_PATOS.CargarCredito");
            ps.AddParameter("@username", Cliente.Text);
            ps.AddParameter("@fecha", (DateTime)AppContext.getObject(typeof(DateTime)));
            ps.AddParameter("@tipoPago", TipoPago.SelectedItem.ToString());
            ps.AddParameter("@monto", Int64.Parse(Monto.Text));
            
            if (!this.NumeroTarjeta.Enabled)
            {
                ps.AddParameter("@numeroTarjeta", 0);

            }
            else {
                try
                {
                    ps.AddParameter("@numeroTarjeta", Int64.Parse(this.NumeroTarjeta.Text));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese un número de tarjeta válido");
                    return;
                }
               
            }

            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString()) {
                case "0": MessageBox.Show("Carga correcta");
                    break;
                case "1" : MessageBox.Show("Monto menor a $15");
                    break;
                case "2": MessageBox.Show("Tarjeta incorrecta");
                    break;
                case "3": MessageBox.Show("Cliente incorrecto");
                    break;
                case "4": MessageBox.Show("El cliente no está habilitado para la carga de crédito");
                    break;
            }

            Main.actualizar();
        }

        private void CargaCredito_Load(object sender, EventArgs e)
        {
            if (s.rol.Equals("Cliente"))
            {
                this.Cliente.Text = s.username;
                this.Cliente.Enabled = false;

            }
        }
       

      
    }
}
