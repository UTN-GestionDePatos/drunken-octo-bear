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

namespace GrouponDesktop.GUI.ComprarGiftCard
{
    public partial class ComprarGirftcard : Form
    {
        public ComprarGirftcard()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Session s = (Session)AppContext.getObject(typeof(Session));
            if (ClienteDestino.Text == "" || monto.SelectedItem == null)
            {
                MessageBox.Show("Faltan datos");
                return;
            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.ComprarGiftcard"); 

            ps.AddParameter("@clienteOrigen", s.username);
            ps.AddParameter("@fecha", Core.Properties.getProperty("fecha"));
            ps.AddParameter("@clienteDestino", ClienteDestino.Text);
            ps.AddParameter("@monto", Int64.Parse(monto.SelectedItem.ToString()));

            SqlParameter retval = ps.execSP();

            switch (retval.Value.ToString())
            {
                case "0": MessageBox.Show("Operación finalizada con éxito");
                    break;
                case "1": MessageBox.Show("El cliente destino no puede coincidir con el cliente origen");
                    break;
                case "2": MessageBox.Show("El cliente destino no se encuentra habilitado");
                    break;
                case "3": MessageBox.Show("Cliente destino incorrecto");
                    break;
                case "4": MessageBox.Show("Usted no tiene saldo suficiente para comprar el giftcard requerido");
                    break;
            }
        }

        private void ComprarGirftcard_Load(object sender, EventArgs e)
        {   
            int min = Int32.Parse(Core.Properties.getProperty("gcmin"));
            int max = Int32.Parse(Core.Properties.getProperty("gcmax"));
            for (int i = min; i <= max; i += 5) { //regla de negocio que vaya de a 5 pesos 
                this.monto.Items.Add(i.ToString());
            } 

        }




    }
}
