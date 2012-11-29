﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;
using GrouponDesktop.AbmCliente;

namespace GrouponDesktop.GUI
{
    public partial class CambiarRol : Form
    {
        

        
        static DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));
        static Session sesion = (Session)AppContext.getObject(typeof(Session));
        String user;
        String actual; 
        public CambiarRol(String user)
        {
            InitializeComponent();
            this.user = user;
            this.actual = db.executeQuery("select rol from GESTION_DE_PATOS.Usuarios where username = '" + user + "'").result.Rows[0][0].ToString();
       
        }

        private void CambiarRol_Load(object sender, EventArgs e)
        {

            SQLResponse re = db.executeQuery("select nombre from GESTION_DE_PATOS.Roles");
            foreach (DataRow r in re.result.Rows)
            {
                Rol.Items.Add(r[0]);
            } 
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rol = this.Rol.SelectedItem.ToString();
            if (rol.Equals(actual))
            {
                MessageBox.Show("El rol asignado ya corresponde al usuario");
                return;
            }

           
            if (this.Rol.SelectedItem.ToString() == "Proveedor")
            {
                AltaProveedor ap = new AltaProveedor(user);
                ap.Show();
            }
            else if (this.Rol.SelectedItem.ToString() == "Cliente")
            {
                AltaCliente ac = new AltaCliente(user);
                ac.Show();
            }

            db.executeQuery("UPDATE GESTION_DE_PATOS.Usuarios SET rol = '" + rol + "' where username = '" + user + "'");

        }

        private void CambiarRol_Load()
        {

        }
   }
}