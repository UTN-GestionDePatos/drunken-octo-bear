using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.RegistroConsumoCupon
{
    public partial class GridCupones : Form
    {
        public GridCupones(String username,RegistroConsumoCupon rcc)
        {
            InitializeComponent();
            this.username = username;
            
            this.registro = rcc;
        }

        public String username;
    

        public RegistroConsumoCupon registro;
        Session s = (Session)AppContext.getObject(typeof(Session));

        private void GridCupones_Load(object sender, EventArgs e)
        {
            this.dataGridCupones.ReadOnly = true;
            DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));
            SQLResponse result = db.executeQuery("select c.id_cupon, c.id_promocion, p.descripcion from GESTION_DE_PATOS.Cupones c  join GESTION_DE_PATOS.Promociones p on p.id_promocion = c.id_promocion where cliente = '" + this.username + "' and p.proveedor = '" + s.username + "' and not exists (select * from GESTION_DE_PATOS.Canjes ca where ca.id_cupon = c.id_cupon) and not exists (select * from GESTION_DE_PATOS.Devoluciones d where d.id_cupon = c.id_cupon)");
            this.dataGridCupones.DataSource = result.result;

            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();
            seleccionar.Name = "Seleccionar";
            seleccionar.HeaderText = "Seleccionar";
            this.dataGridCupones.Columns.Add(seleccionar);

            this.dataGridCupones.ReadOnly = true;
            this.dataGridCupones.Columns["Seleccionar"].ReadOnly = false;
            this.dataGridCupones.AllowUserToAddRows = false;
        }

        private void dataGridCupones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.dataGridCupones.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "Seleccionar")
            {
                this.registro.SetDatos(this.dataGridCupones[0,this.dataGridCupones.CurrentCell.RowIndex].Value.ToString(),this.username);
                this.Hide();
            }
        }

    }
}
