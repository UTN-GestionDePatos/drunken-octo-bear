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
            r = dbManager.executeQuery("select distinct gc.id_promocion Promoción, gc.descripcion Descripción, gc.precio_real Precio, gc.fecha_vencimiento_canje VencimientoCanje, gc.proveedor Proveedor from GESTION_DE_PATOS.Promociones gc join GESTION_DE_PATOS.Localidad_por_promocion lpg on lpg.id_promocion = gc.id_promocion join GESTION_DE_PATOS.Localidad_por_usuario lpu on lpu.id_localidad = lpg.id_localidad where gc.estado = 'Publicado' and gc.fecha_vencimiento_oferta >= '" + Core.Properties.getProperty("fecha") + "'");

            this.cuponesDisponibles.DataSource = r.result;

            this.cuponesDisponibles.ReadOnly = true;

            DataGridViewButtonColumn comprar = new DataGridViewButtonColumn();
            comprar.Name = "comprar";
            comprar.HeaderText = "Comprar";
            this.cuponesDisponibles.Columns.Add(comprar);
            this.cuponesDisponibles.Columns["comprar"].ReadOnly = false;

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cuponesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.cuponesDisponibles.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "comprar")
            {

                if (this.cuponesDisponibles.Rows.Count == 1)
                {

                    MessageBox.Show("No hay cupones para comprar");
                    return;
                }

                ParamSet ps = new ParamSet("GESTION_DE_PATOS.ComprarCupon");

                ps.AddParameter("@id_promocion", this.cuponesDisponibles.SelectedRows[0].Cells[0].Value.ToString());
                ps.AddParameter("@fecha", Core.Properties.getProperty("fecha"));
                ps.AddParameter("@username", s.username);
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
}
