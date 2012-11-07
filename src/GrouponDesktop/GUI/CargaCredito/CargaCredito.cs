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
        public CargaCredito()
        {
            InitializeComponent();
        }

        private void TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.TipoPago.SelectedItem.Equals("Crédito") || this.TipoPago.SelectedItem.Equals("Débito"))
            {
                this.NumeroTarjeta.Enabled = true;
            }
            else {
                this.NumeroTarjeta.Enabled = false;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Monto.Text == "" || TipoPago.SelectedItem == null || (NumeroTarjeta.Text == "" && NumeroTarjeta.Enabled)) {
                MessageBox.Show("Faltan datos");
                return;
            }
            ParamSet ps = new ParamSet();
            ps.NombreSP("dbo.CargarCredito");

            Dictionary<String,Object> s = new Dictionary<string,object>();
            s.Add("@username", Username.Text);
            s.Add("@fecha", Core.Properties.getProperty("fecha"));
            s.Add("@tipoPago", TipoPago.SelectedItem.ToString());
            s.Add("@monto", Int64.Parse(Monto.Text));
            
            if (!this.NumeroTarjeta.Enabled)
            {
                s.Add("@numeroTarjeta", 0);

            }
            else {
                s.Add("@numeroTarjeta", Int64.Parse(this.NumeroTarjeta.Text));
            }

            ps.Parametros(s);

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
            }

        }

       

      
    }
}
