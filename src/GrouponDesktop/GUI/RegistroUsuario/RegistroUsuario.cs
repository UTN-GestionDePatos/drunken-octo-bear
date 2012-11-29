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

namespace GrouponDesktop.GUI.RegistroUsuario
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));
            try
            {
                
                SQLResponse response = manager.executeQuery("SELECT localidad from GESTION_DE_PATOS.Localidades");

                foreach(DataRow r in response.result.Rows){
                    ListaZonas.Items.Add(r[0]);
                    ciudadP.Items.Add(r[0]);
                    ciudadCliente.Items.Add(r[0]);
                }

                response = manager.executeQuery("SELECT descripcion from GESTION_DE_PATOS.Rubros");
                foreach (DataRow r in response.result.Rows)
                {
                    RubroP.Items.Add(r[0]);
                }
                    RubroP.Items.Add("Otro");
            }
            catch (Exception)
            {
                
            }
        }

        private void Rol_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.Rol.SelectedItem.ToString() == "Proveedor")
            {
                this.ListaZonas.Visible = false;
                this.datosClientes.Visible = false;
                this.zonas.Visible = false;
                this.datosProveedor.Visible = true;
                
            }
            else
            {
                this.zonas.Visible = true;
                this.ListaZonas.Visible = true;
                this.datosProveedor.Visible = false;
                this.datosClientes.Visible = true;

            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Object elRol = this.Rol.SelectedItem;
            if (elRol == null) {
                MessageBox.Show("Seleccione un rol", "Registro de usuario");
                return;
            }


            ParamSet ps = new ParamSet();
            SqlParameter ret;

            switch (elRol.ToString()) { 
            
                    
                case "Cliente":
                    if (UsernameCliente.Text == "" || PasswordCliente.Text == "" ||
                        NombreCliente.Text == "" || ApellidoCliente.Text == "" ||
                        MailCliente.Text == "" || TelefonoCliente.Text == "" ||
                        FchNacimientoCliente.Text == "" || DNICliente.Text == "" ||
                        DireccionC.Text == "" || ListaZonas.CheckedItems.Count == 0 ||
                        CodigoPostalC.Text == "" ||
                        ciudadCliente.SelectedItem.ToString() == "" ) {

                            MessageBox.Show("Faltan datos");
                            return;
                    }

                    ps.NombreSP("GESTION_DE_PATOS.RegistroCliente");
                    ps.AddParameter("@user", UsernameCliente.Text);
                    ps.AddParameter("@pass", PasswordCliente.Text);
                    ps.AddParameter("@nombre", NombreCliente.Text);
                    ps.AddParameter("@apellido", ApellidoCliente.Text);
                    ps.AddParameter("@mail", MailCliente.Text);
                    ps.AddParameter("@tel", Int64.Parse(TelefonoCliente.Text));
                    ps.AddParameter("@fecha", FchNacimientoCliente.Text);
                    ps.AddParameter("@dni", Int64.Parse(DNICliente.Text));
                    ps.AddParameter("@direccion", DireccionC.Text);
                    ps.AddParameter("@ciudad", ciudadCliente.SelectedItem.ToString());
                    ps.AddParameter("@cp", Int64.Parse(CodigoPostalC.Text));

                    try { 
 
                        ret = ps.execSP();
                        switch (ret.Value.ToString()) { 
                            case "0":
                                ps.NombreSP("GESTION_DE_PATOS.RegistrarLocalidades");
                                foreach (Object localidad in this.ListaZonas.CheckedItems) {
                                    ps.AddParameter("@localidad", localidad.ToString());
                                    ps.AddParameter("@user", UsernameCliente.Text);
                                    ps.executeNoReturn();
                                }

                                MessageBox.Show("Registro realizado con éxito","Registro de usuario",MessageBoxButtons.OK);
                                this.Hide();
                                return;
                            
                            case "1":
                                MessageBox.Show("El usuario ya existe","Registro de usuario");
                                return;

                            case "2":
                                MessageBox.Show("Los datos ingresados corresponden a un usuario existente", "Registro de usuario");
                                return;

                            }
                    }
                    
                    catch(SqlException){
                        MessageBox.Show("Ingrese un valor correcto para el teléfono, el dni, el código postal o la fecha de nacimiento", "Registro de usuario");
                        return;
                    }

                    return;

                case "Proveedor":

                    if (UsernameP.Text == "" || PassP.Text == "" ||
                        RazonSocial.Text == "" || CUIT.Text == "" ||
                        MailP.Text == "" || TelefonoP.Text == "" ||
                        Direccion.Text == "" || NombreContacto.Text == "" ||
                        ciudadP.SelectedItem.ToString() == "" ||
                        CodigoPostalP.Text == ""||
                        RubroP.SelectedItem.ToString() == "")
                    {

                        MessageBox.Show("Faltan datos", "Registro de usuario");
                        return;
                    }


                    

                    try{
                        ps.NombreSP("GESTION_DE_PATOS.RegistrarProveedor");
                        ps.AddParameter("@user", UsernameP.Text);
                        ps.AddParameter("@pass", PassP.Text);
                        ps.AddParameter("@rs", RazonSocial.Text);
                        ps.AddParameter("@cuit", CUIT.Text);
                        ps.AddParameter("@mail", MailP.Text);
                        ps.AddParameter("@telefono", Int64.Parse(TelefonoP.Text));
                        ps.AddParameter("@direccion", Direccion.Text);
                        ps.AddParameter("@ciudad", ciudadP.SelectedItem.ToString());
                        ps.AddParameter("@rubro", RubroP.SelectedItem.ToString());
                        ps.AddParameter("@contacto", NombreContacto.Text);
                        ps.AddParameter("@cp", Int64.Parse(CodigoPostalP.Text));

                        ret = ps.execSP();
                        switch (ret.Value.ToString())
                        {
                            case "0":
                                MessageBox.Show("Registro realizado con éxito", "Registro de usuario",MessageBoxButtons.OK);
                                this.Hide();
                                return;

                            case "1":
                                MessageBox.Show("El usuario ya existe", "Registro de usuario");
                                return;

                            case "2":
                                MessageBox.Show("Los datos ingresados corresponden a un usuario existente", "Registro de usuario");
                                return;

                          }

                        return;
    
                }
                 catch(FormatException){
                    MessageBox.Show("Ingrese un valor correcto para el teléfono o el código postal");
                 }

                return;

            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            NombreCliente.Text = "";
            ApellidoCliente.Text = "";
            UsernameCliente.Text = "";
            PasswordCliente.Text = "";
            DNICliente.Text = "";
            MailCliente.Text = "";
            TelefonoCliente.Text = "";
            FchNacimientoCliente.Text = "";
            DireccionC.Text = "";
            for (int i = 0; i < ListaZonas.Items.Count; i++) ListaZonas.SetItemChecked(i, false);
            UsernameP.Text = "";
            PassP.Text = "";
            RazonSocial.Text = "";
            CUIT.Text = "";
            Direccion.Text = "";
            NombreContacto.Text = "";
            TelefonoP.Text = "";
            MailP.Text = "";
            CodigoPostalC.Text = "";
            CodigoPostalP.Text = "";


        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            Fecha.Visible = true;
        }

        private void Fecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = Fecha.SelectionStart;
            string fechaStr = date.Date.ToShortDateString();

            FchNacimientoCliente.Text = fechaStr;

            Fecha.Visible = false;
        }
    }
}
