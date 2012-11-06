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
            if (this.TipoPago.SelectedItem.Equals("Tarjeta de Crédito") || this.TipoPago.SelectedItem.Equals("Tarjeta de Débito"))
            {
                this.NumeroTarjeta.Enabled = true;
            }
            else {
                this.NumeroTarjeta.Enabled = false;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));

            SqlCommand query = new SqlCommand("dbo.CargarCredito");
            query.CommandType = CommandType.StoredProcedure;

            SqlParameter username = new SqlParameter("@username", SqlDbType.VarChar);
            username.Direction = ParameterDirection.Input;
            username.Value = Username.Text;

            SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.DateTime);
            fecha.Direction = ParameterDirection.Input;
            fecha.Value = Core.Properties.getProperty("fecha");

            SqlParameter tipoPago = new SqlParameter("@tipoPago", SqlDbType.VarChar);
            tipoPago.Direction = ParameterDirection.Input;
            tipoPago.Value = TipoPago.Text;

            SqlParameter monto = new SqlParameter("@monto", SqlDbType.BigInt);
            monto.Direction = ParameterDirection.Input;
            monto.Value = Int64.Parse(Monto.Text);

            SqlParameter tarjeta = new SqlParameter("@numeroTarjeta", SqlDbType.BigInt);
            tarjeta.Direction = ParameterDirection.Input;
            tarjeta.Value = 0;

            query.Parameters.Add(username);
            query.Parameters.Add(fecha);
            query.Parameters.Add(tipoPago);
            query.Parameters.Add(monto);
            query.Parameters.Add(tarjeta);
            SqlParameter retval = query.Parameters.Add("@ret", SqlDbType.Int);
            retval.Direction = ParameterDirection.Output;

            query.Connection = db.getConnection();
            query.ExecuteNonQuery();
            Console.Write(query.Parameters["@ret"].Value);
        }

       

      
    }
}
