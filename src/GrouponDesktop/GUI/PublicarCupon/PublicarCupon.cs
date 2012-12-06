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

            this.fecha.Text += " " + ((DateTime)AppContext.getObject(typeof(DateTime))).ToShortDateString(); ;

            this.Proveedores.Items.Clear();
            this.Proveedores.Items.Add("");


            r = dbManager.executeQuery("SELECT p.username FROM GESTION_DE_PATOS.Proveedores p JOIN GESTION_DE_PATOS.Usuarios u on p.username = u.username and u.rol = 'Proveedor'");
            foreach (DataRow row in r.result.Rows)
            {
                this.Proveedores.Items.Add(row[0]);
            }
            this.Proveedores.SelectedIndex = 0;

            this.cupones.ReadOnly = true;

            this.cupones.AllowUserToAddRows = false;

        }

        private void setDataGridView(){
            String proveedor = Proveedores.SelectedItem.ToString();

            if (proveedor == "")
            {
                this.cupones.Columns.Clear();
                //todos los proveedores
                r = dbManager.executeQuery("select  id_promocion, proveedor, descripcion from GESTION_DE_PATOS.Promociones where GESTION_DE_PATOS.NombreEstadoPromocion(estado) = 'A publicar'");
                cupones.DataSource = r.result;
                cupones.Columns[2].Width = 300;

            }
            else
            {
                //un proveedor en particular
                this.cupones.Columns.Clear();

                r = dbManager.executeQuery("select  id_promocion, proveedor, descripcion from GESTION_DE_PATOS.Promociones where GESTION_DE_PATOS.NombreEstadoPromocion(estado) = 'A publicar' and proveedor = '" + proveedor + "'");
                cupones.DataSource = r.result;
                cupones.Columns[2].Width = 300;

            }


            DataGridViewButtonColumn boton = new DataGridViewButtonColumn();
            boton.HeaderText = "Publicar";
            boton.Name = "Publicar";
            cupones.Columns.Add(boton);

            this.cupones.Columns["Publicar"].ReadOnly = false;

        }

        private void VerCupones_Click(object sender, EventArgs e)
        {
            setDataGridView();
           
        }

        private void cupones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.cupones.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "Publicar")
            {
                String codigo = this.cupones.Rows[e.RowIndex].Cells[0].Value.ToString();
                if(codigo == ""){
                    MessageBox.Show("No hay promociones para publicar");
                    return;
                }
                
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.PublicarCupon");
                ps.AddParameter("@codigoPromocion", codigo);
                ps.AddParameter("@fecha", (String)AppContext.getObject(typeof(String)));
                ps.executeNoReturn();

                MessageBox.Show("Promoción publicada");

                setDataGridView();
                
            }


                return;
            }

        }


       }

