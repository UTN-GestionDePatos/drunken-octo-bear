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

namespace GrouponDesktop.GUI.PedirDevolucion
{
    public partial class Devolucion : Form
    {

        public int idCupon;
        public String idGrupo;
        public String motivo;

        public TextBox GetDatos() {
            return this.datosCupon;
        }

        public void SetDatos (String datosCupon){
            this.datosCupon.Text += datosCupon;
        }
        public Devolucion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Devolver_Click(object sender, EventArgs e)
        {
            Session s = (Session)AppContext.getObject(typeof(Session));

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.ConfirmarDevolucion");
            ps.AddParameter("@idCupon", this.idCupon);
            ps.AddParameter("@fecha_actual", Core.Properties.getProperty("fecha"));
            ps.AddParameter("@motivo", this.motivo);
            
            SqlParameter retval = ps.execSP();
            switch (retval.Value.ToString()) {
                case "0": MessageBox.Show("Devolución exitosa");
                    return;

                case "1": MessageBox.Show("El cupón ya está devuelto");
                    return;


            }
            this.Hide();  
        }


       
    }
}
