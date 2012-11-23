using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.AbmCliente
{
    public partial class ModificacionCliente : Form
    {
       private DBManager dbManager = null;
       private FilaSeleccionada cliente;

        public ModificacionCliente(FilaSeleccionada cliente_seleccionado)
        {
            InitializeComponent();
            dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            cliente = cliente_seleccionado;
        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {
            UsernameCliente.Text = cliente.getDato("usernameDataGridView").ToString();
            NombreCliente.Text = cliente.getDato("nombreDataGridView").ToString();
            ApellidoCliente.Text = cliente.getDato("apellidoDataGridView").ToString();
            MailCliente.Text = cliente.getDato("mailDataGridView").ToString();
            TelefonoCliente.Text = cliente.getDato("telefonoDataGridView").ToString();
            FchNacimientoCliente.Text = cliente.getDato("fecha_nacimientoDataGridView").ToString();
            DNICliente.Text = cliente.getDato("dniDataGridView").ToString();
            Calle.Text = "";
            Piso.Text = "";
            Departamento.Text = "";
            Localidad.Text = cliente.getDato("ciudadDataGridView").ToString();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            UsernameCliente.Text = "";
            NombreCliente.Text = "";
            ApellidoCliente.Text = "";
            MailCliente.Text = "";
            TelefonoCliente.Text = "";
            FchNacimientoCliente.Text = "";
            DNICliente.Text = "";
            Calle.Text = "";
            Piso.Text = "";
            Departamento.Text = "";
            Localidad.Text = "";
        }

      
    }
}
