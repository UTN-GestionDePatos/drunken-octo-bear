using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.PublicarCupon
{
    public partial class PublicarCupon : Form
    {
        
        
        public PublicarCupon()
        {
            InitializeComponent();
        }

        DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        Session s = (Session)AppContext.getObject(typeof(Session));
        SQLResponse r;

        private void PublicarCupon_Load(object sender, EventArgs e)
        {
            
            this.fecha.Text += " " + Core.Properties.getProperty("fecha");

            this.Proveedores.Items.Clear();
            this.Proveedores.Items.Add("");

                
            r = dbManager.executeQuery("SELECT cuit FROM Proveedores");
            foreach (DataRow row in r.result.Rows)
            {
                this.Proveedores.Items.Add(row[0]);
            }
            this.Proveedores.SelectedIndex = 0;

        }

        private void VerCupones_Click(object sender, EventArgs e)
        {
            String proveedor = this.Proveedores.SelectedItem.ToString();
            if ( proveedor == "")
            {
                //todos los proveedores
                r = dbManager.executeQuery("select  id_grupo, proveedor, descripcion from GruposCupon where estado = 'A publicar'");
                cupones.DataSource = r.result;
                cupones.Columns[2].Width = 300;
            }
            else { 
                //un proveedor en particular
                r = dbManager.executeQuery("select  id_grupo, proveedor, descripcion from GruposCupon where estado = 'A publicar' and proveedor = " + proveedor);
                cupones.DataSource = r.result;
                cupones.Columns[2].Width = 300;
            }

            
        }

       }
}
