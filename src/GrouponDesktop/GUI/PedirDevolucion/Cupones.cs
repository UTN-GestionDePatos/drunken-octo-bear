using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.PedirDevolucion
{
    public partial class Cupones : Form
    {
        private DBManager dbManager = null;
        public Listado listado;
        private Session sesion = null;
        private TextBox cupon;

        public Cupones(TextBox cupon)
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            this.cupon = cupon;
        }

        private void Cupones_Load(object sender, EventArgs e)
        {
            this.sesion = (Session)AppContext.getObject(typeof(Session));
            String query = "SELECT c.id_cupon AS 'ID Cupón', pr.cuit AS 'Proveedor', c.id_promocion AS 'ID Promoción', GESTION_DE_PATOS.promocion(c.id_promocion) AS 'Promocion', c.fecha_compra AS 'Fecha de Compra', p.fecha_vencimiento_canje AS 'Vencimiento del canje' FROM GESTION_DE_PATOS.Cupones c LEFT JOIN GESTION_DE_PATOS.Devoluciones d ON c.id_cupon = d.id_cupon LEFT JOIN GESTION_DE_PATOS.Canjes cj ON c.id_cupon = cj.id_cupon JOIN GESTION_DE_PATOS.Promociones p ON p.id_promocion = c.id_promocion join GESTION_DE_PATOS.Proveedores pr on pr.username = p.proveedor WHERE fecha_devolucion is null AND fecha_canje is null AND cliente = '" + sesion.username + "' AND p.fecha_vencimiento_canje >= '" + (String)AppContext.getObject(typeof(String)) + "'";
            this.listado = new Listado(dataGridCupones, query);
            this.listado.actualizar_datagridview();
            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = "seleccionar";
            seleccionar.HeaderText = "Seleccionar";
            this.dataGridCupones.Columns.Add(seleccionar);
            this.dataGridCupones.ReadOnly = true;
            this.dataGridCupones.AllowUserToAddRows = false;
            
        }

        private void dataGridCupones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String columna_seleccionada = this.dataGridCupones.Columns[e.ColumnIndex].Name;

                if (columna_seleccionada == "seleccionar")
                {
                    String id_cupon = dataGridCupones[0, e.RowIndex].Value.ToString();
                    cupon.Text = id_cupon;
                    this.listado.actualizar_datagridview();
                    this.Hide();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay cupones para seleccionar", "Cupones disponibles para devolver");
                return;
            }

        }
    }
}
