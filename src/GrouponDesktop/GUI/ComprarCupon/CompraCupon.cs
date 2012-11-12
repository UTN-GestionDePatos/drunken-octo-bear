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

namespace GrouponDesktop.GUI.ComprarCupon
{
    public partial class CompraCupon : Form
    {
         DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        Session s = (Session)AppContext.getObject(typeof(Session));
        SQLResponse r;
        
        public CompraCupon()
        {
            InitializeComponent();

        }

        private void CompraCupon_Load(object sender, EventArgs e)
        {
            r = dbManager.executeQuery("select distinct gc.id_grupo Promoción, gc.descripcion Descripción, gc.precio_real Precio, gc.fecha_vencimiento_canje VencimientoCanje, gc.proveedor Proveedor from GruposCupon gc join Localidad_por_grupo lpg on lpg.id_grupo = gc.id_grupo join Localidad_por_usuario lpu on lpu.id_localidad = lpg.id_localidad where gc.estado = 'Publicado' and gc.fecha_vencimiento_oferta >= '" + Core.Properties.getProperty("fecha") + "'");

            this.cuponesDisponibles.DataSource = r.result;

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (this.cuponesDisponibles.SelectedRows.Count != 1) {

                MessageBox.Show("Seleccione un cupón para la compra");
                return;
           }

            ParamSet ps = new ParamSet();
            ps.NombreSP("dbo.ComprarCupon");

            Dictionary<String, Object> d = new Dictionary<string, object>();
            d.Add("@id_grupo", this.cuponesDisponibles.SelectedRows[0].Cells[0].Value.ToString());
            d.Add("@fecha", Core.Properties.getProperty("fecha"));
            d.Add("@username", s.username);
            ps.Parametros(d);
            
            SqlParameter retval = ps.execSP();
            String ret = retval.Value.ToString();
        
            switch (ret)
            {
                case "1": MessageBox.Show("Ha llegado al límite por usuario para el cupón solicitado.");
                    return;
                case "2": MessageBox.Show("No hay stock para el cupón solicitado.");
                    return;
                case "3": MessageBox.Show("El usuario no tiene saldo suficiente.");
                    return;
    
                default: MessageBox.Show("Compra realizada con éxito. \nCupón Nro: " + ret);
                    return;


            }
        }
    }
}
