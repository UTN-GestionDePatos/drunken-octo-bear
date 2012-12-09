namespace GrouponDesktop.GUI.RegistroUsuario
{
    partial class RegistroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Guardar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.ComboBox();
            this.datosProveedor = new System.Windows.Forms.GroupBox();
            this.ConfirmarPass = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.CodigoPostalP = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ciudadP = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.NombreContacto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.RubroP = new System.Windows.Forms.ComboBox();
            this.PassP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.TelefonoP = new System.Windows.Forms.TextBox();
            this.CUIT = new System.Windows.Forms.TextBox();
            this.RazonSocial = new System.Windows.Forms.TextBox();
            this.MailP = new System.Windows.Forms.TextBox();
            this.UsernameP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.zonas = new System.Windows.Forms.GroupBox();
            this.ListaZonas = new System.Windows.Forms.CheckedListBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UsernameCliente = new System.Windows.Forms.TextBox();
            this.MailCliente = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.ApellidoCliente = new System.Windows.Forms.TextBox();
            this.TelefonoCliente = new System.Windows.Forms.TextBox();
            this.FchNacimientoCliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DNICliente = new System.Windows.Forms.TextBox();
            this.DireccionC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.PasswordCliente = new System.Windows.Forms.TextBox();
            this.ciudadCliente = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CodigoPostalC = new System.Windows.Forms.TextBox();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.MonthCalendar();
            this.datosClientes = new System.Windows.Forms.GroupBox();
            this.ConfirmarPassword = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.datosProveedor.SuspendLayout();
            this.zonas.SuspendLayout();
            this.datosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(539, 486);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(17, 486);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Rol";
            // 
            // Rol
            // 
            this.Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rol.FormattingEnabled = true;
            this.Rol.Items.AddRange(new object[] {
            "Cliente",
            "Proveedor"});
            this.Rol.Location = new System.Drawing.Point(138, 12);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(209, 21);
            this.Rol.TabIndex = 25;
            this.Rol.SelectedIndexChanged += new System.EventHandler(this.Rol_SelectedIndexChanged_1);
            // 
            // datosProveedor
            // 
            this.datosProveedor.Controls.Add(this.ConfirmarPass);
            this.datosProveedor.Controls.Add(this.label24);
            this.datosProveedor.Controls.Add(this.CodigoPostalP);
            this.datosProveedor.Controls.Add(this.label22);
            this.datosProveedor.Controls.Add(this.ciudadP);
            this.datosProveedor.Controls.Add(this.label18);
            this.datosProveedor.Controls.Add(this.NombreContacto);
            this.datosProveedor.Controls.Add(this.label17);
            this.datosProveedor.Controls.Add(this.RubroP);
            this.datosProveedor.Controls.Add(this.PassP);
            this.datosProveedor.Controls.Add(this.label8);
            this.datosProveedor.Controls.Add(this.Direccion);
            this.datosProveedor.Controls.Add(this.TelefonoP);
            this.datosProveedor.Controls.Add(this.CUIT);
            this.datosProveedor.Controls.Add(this.RazonSocial);
            this.datosProveedor.Controls.Add(this.MailP);
            this.datosProveedor.Controls.Add(this.UsernameP);
            this.datosProveedor.Controls.Add(this.label9);
            this.datosProveedor.Controls.Add(this.label10);
            this.datosProveedor.Controls.Add(this.label11);
            this.datosProveedor.Controls.Add(this.label13);
            this.datosProveedor.Controls.Add(this.label14);
            this.datosProveedor.Controls.Add(this.label15);
            this.datosProveedor.Controls.Add(this.label16);
            this.datosProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datosProveedor.Location = new System.Drawing.Point(12, 58);
            this.datosProveedor.Name = "datosProveedor";
            this.datosProveedor.Size = new System.Drawing.Size(353, 409);
            this.datosProveedor.TabIndex = 23;
            this.datosProveedor.TabStop = false;
            this.datosProveedor.Text = "Datos Personales";
            this.datosProveedor.Visible = false;
            // 
            // ConfirmarPass
            // 
            this.ConfirmarPass.Location = new System.Drawing.Point(126, 80);
            this.ConfirmarPass.MaxLength = 30;
            this.ConfirmarPass.Name = "ConfirmarPass";
            this.ConfirmarPass.Size = new System.Drawing.Size(209, 20);
            this.ConfirmarPass.TabIndex = 31;
            this.ConfirmarPass.UseSystemPasswordChar = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "Confirmar password:";
            // 
            // CodigoPostalP
            // 
            this.CodigoPostalP.Location = new System.Drawing.Point(126, 270);
            this.CodigoPostalP.MaxLength = 10;
            this.CodigoPostalP.Name = "CodigoPostalP";
            this.CodigoPostalP.Size = new System.Drawing.Size(209, 20);
            this.CodigoPostalP.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 273);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Código Postal";
            // 
            // ciudadP
            // 
            this.ciudadP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadP.FormattingEnabled = true;
            this.ciudadP.Location = new System.Drawing.Point(126, 339);
            this.ciudadP.Name = "ciudadP";
            this.ciudadP.Size = new System.Drawing.Size(209, 21);
            this.ciudadP.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 342);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Ciudad";
            // 
            // NombreContacto
            // 
            this.NombreContacto.Location = new System.Drawing.Point(126, 372);
            this.NombreContacto.MaxLength = 30;
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(209, 20);
            this.NombreContacto.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 375);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Nombre de Contacto";
            // 
            // RubroP
            // 
            this.RubroP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RubroP.FormattingEnabled = true;
            this.RubroP.Location = new System.Drawing.Point(126, 306);
            this.RubroP.Name = "RubroP";
            this.RubroP.Size = new System.Drawing.Size(209, 21);
            this.RubroP.TabIndex = 23;
            // 
            // PassP
            // 
            this.PassP.Location = new System.Drawing.Point(126, 55);
            this.PassP.MaxLength = 30;
            this.PassP.Name = "PassP";
            this.PassP.Size = new System.Drawing.Size(209, 20);
            this.PassP.TabIndex = 22;
            this.PassP.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Password";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(126, 237);
            this.Direccion.MaxLength = 100;
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(209, 20);
            this.Direccion.TabIndex = 19;
            // 
            // TelefonoP
            // 
            this.TelefonoP.Location = new System.Drawing.Point(126, 205);
            this.TelefonoP.MaxLength = 18;
            this.TelefonoP.Name = "TelefonoP";
            this.TelefonoP.Size = new System.Drawing.Size(209, 20);
            this.TelefonoP.TabIndex = 18;
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(126, 139);
            this.CUIT.MaxLength = 20;
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(209, 20);
            this.CUIT.TabIndex = 17;
            // 
            // RazonSocial
            // 
            this.RazonSocial.Location = new System.Drawing.Point(126, 107);
            this.RazonSocial.MaxLength = 30;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Size = new System.Drawing.Size(209, 20);
            this.RazonSocial.TabIndex = 16;
            this.RazonSocial.TabStop = false;
            // 
            // MailP
            // 
            this.MailP.Location = new System.Drawing.Point(126, 173);
            this.MailP.MaxLength = 30;
            this.MailP.Name = "MailP";
            this.MailP.Size = new System.Drawing.Size(209, 20);
            this.MailP.TabIndex = 16;
            // 
            // UsernameP
            // 
            this.UsernameP.Location = new System.Drawing.Point(126, 26);
            this.UsernameP.MaxLength = 30;
            this.UsernameP.Name = "UsernameP";
            this.UsernameP.Size = new System.Drawing.Size(209, 20);
            this.UsernameP.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Rubro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "CUIT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Mail";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Username";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Razón Social";
            // 
            // zonas
            // 
            this.zonas.Controls.Add(this.ListaZonas);
            this.zonas.Location = new System.Drawing.Point(426, 70);
            this.zonas.Name = "zonas";
            this.zonas.Size = new System.Drawing.Size(253, 287);
            this.zonas.TabIndex = 28;
            this.zonas.TabStop = false;
            this.zonas.Text = "Zonas de Preferencia";
            this.zonas.Visible = false;
            // 
            // ListaZonas
            // 
            this.ListaZonas.FormattingEnabled = true;
            this.ListaZonas.Location = new System.Drawing.Point(16, 23);
            this.ListaZonas.Name = "ListaZonas";
            this.ListaZonas.Size = new System.Drawing.Size(217, 244);
            this.ListaZonas.TabIndex = 8;
            this.ListaZonas.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(2, 109);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 33;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "DNI";
            // 
            // UsernameCliente
            // 
            this.UsernameCliente.Location = new System.Drawing.Point(122, 23);
            this.UsernameCliente.MaxLength = 30;
            this.UsernameCliente.Name = "UsernameCliente";
            this.UsernameCliente.Size = new System.Drawing.Size(209, 20);
            this.UsernameCliente.TabIndex = 39;
            // 
            // MailCliente
            // 
            this.MailCliente.Location = new System.Drawing.Point(122, 172);
            this.MailCliente.MaxLength = 50;
            this.MailCliente.Name = "MailCliente";
            this.MailCliente.Size = new System.Drawing.Size(209, 20);
            this.MailCliente.TabIndex = 41;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Location = new System.Drawing.Point(122, 106);
            this.NombreCliente.MaxLength = 50;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(209, 20);
            this.NombreCliente.TabIndex = 40;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.Location = new System.Drawing.Point(122, 138);
            this.ApellidoCliente.MaxLength = 50;
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.Size = new System.Drawing.Size(209, 20);
            this.ApellidoCliente.TabIndex = 42;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.Location = new System.Drawing.Point(122, 204);
            this.TelefonoCliente.MaxLength = 18;
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.Size = new System.Drawing.Size(209, 20);
            this.TelefonoCliente.TabIndex = 43;
            // 
            // FchNacimientoCliente
            // 
            this.FchNacimientoCliente.Enabled = false;
            this.FchNacimientoCliente.Location = new System.Drawing.Point(122, 236);
            this.FchNacimientoCliente.MaxLength = 50;
            this.FchNacimientoCliente.Name = "FchNacimientoCliente";
            this.FchNacimientoCliente.Size = new System.Drawing.Size(109, 20);
            this.FchNacimientoCliente.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 305);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Direccion";
            // 
            // DNICliente
            // 
            this.DNICliente.Location = new System.Drawing.Point(122, 267);
            this.DNICliente.MaxLength = 18;
            this.DNICliente.Name = "DNICliente";
            this.DNICliente.Size = new System.Drawing.Size(209, 20);
            this.DNICliente.TabIndex = 45;
            // 
            // DireccionC
            // 
            this.DireccionC.Location = new System.Drawing.Point(122, 298);
            this.DireccionC.MaxLength = 100;
            this.DireccionC.Name = "DireccionC";
            this.DireccionC.Size = new System.Drawing.Size(209, 20);
            this.DireccionC.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Password";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 365);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Ciudad";
            // 
            // PasswordCliente
            // 
            this.PasswordCliente.Location = new System.Drawing.Point(122, 52);
            this.PasswordCliente.MaxLength = 30;
            this.PasswordCliente.Name = "PasswordCliente";
            this.PasswordCliente.Size = new System.Drawing.Size(209, 20);
            this.PasswordCliente.TabIndex = 47;
            this.PasswordCliente.UseSystemPasswordChar = true;
            // 
            // ciudadCliente
            // 
            this.ciudadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadCliente.FormattingEnabled = true;
            this.ciudadCliente.Location = new System.Drawing.Point(122, 362);
            this.ciudadCliente.Name = "ciudadCliente";
            this.ciudadCliente.Size = new System.Drawing.Size(209, 21);
            this.ciudadCliente.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(2, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "Código Postal";
            // 
            // CodigoPostalC
            // 
            this.CodigoPostalC.Location = new System.Drawing.Point(121, 333);
            this.CodigoPostalC.MaxLength = 10;
            this.CodigoPostalC.Name = "CodigoPostalC";
            this.CodigoPostalC.Size = new System.Drawing.Size(209, 20);
            this.CodigoPostalC.TabIndex = 53;
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(238, 236);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.Seleccionar.TabIndex = 54;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(140, 179);
            this.Fecha.Name = "Fecha";
            this.Fecha.TabIndex = 55;
            this.Fecha.Visible = false;
            this.Fecha.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Fecha_DateSelected);
            // 
            // datosClientes
            // 
            this.datosClientes.Controls.Add(this.ConfirmarPassword);
            this.datosClientes.Controls.Add(this.label23);
            this.datosClientes.Controls.Add(this.Fecha);
            this.datosClientes.Controls.Add(this.Seleccionar);
            this.datosClientes.Controls.Add(this.CodigoPostalC);
            this.datosClientes.Controls.Add(this.label21);
            this.datosClientes.Controls.Add(this.ciudadCliente);
            this.datosClientes.Controls.Add(this.PasswordCliente);
            this.datosClientes.Controls.Add(this.label19);
            this.datosClientes.Controls.Add(this.label12);
            this.datosClientes.Controls.Add(this.DireccionC);
            this.datosClientes.Controls.Add(this.DNICliente);
            this.datosClientes.Controls.Add(this.label20);
            this.datosClientes.Controls.Add(this.FchNacimientoCliente);
            this.datosClientes.Controls.Add(this.TelefonoCliente);
            this.datosClientes.Controls.Add(this.ApellidoCliente);
            this.datosClientes.Controls.Add(this.NombreCliente);
            this.datosClientes.Controls.Add(this.MailCliente);
            this.datosClientes.Controls.Add(this.UsernameCliente);
            this.datosClientes.Controls.Add(this.label7);
            this.datosClientes.Controls.Add(this.label6);
            this.datosClientes.Controls.Add(this.label5);
            this.datosClientes.Controls.Add(this.label3);
            this.datosClientes.Controls.Add(this.label2);
            this.datosClientes.Controls.Add(this.label1);
            this.datosClientes.Controls.Add(this.Nombre);
            this.datosClientes.Location = new System.Drawing.Point(12, 58);
            this.datosClientes.Name = "datosClientes";
            this.datosClientes.Size = new System.Drawing.Size(379, 409);
            this.datosClientes.TabIndex = 27;
            this.datosClientes.TabStop = false;
            this.datosClientes.Text = "Datos Personales";
            this.datosClientes.Visible = false;
            // 
            // ConfirmarPassword
            // 
            this.ConfirmarPassword.Location = new System.Drawing.Point(121, 80);
            this.ConfirmarPassword.MaxLength = 30;
            this.ConfirmarPassword.Name = "ConfirmarPassword";
            this.ConfirmarPassword.Size = new System.Drawing.Size(209, 20);
            this.ConfirmarPassword.TabIndex = 57;
            this.ConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1, 83);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "Confirmar password:";
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 525);
            this.Controls.Add(this.zonas);
            this.Controls.Add(this.datosClientes);
            this.Controls.Add(this.datosProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Limpiar);
            this.MaximizeBox = false;
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            this.datosProveedor.ResumeLayout(false);
            this.datosProveedor.PerformLayout();
            this.zonas.ResumeLayout(false);
            this.datosClientes.ResumeLayout(false);
            this.datosClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Rol;
        private System.Windows.Forms.GroupBox datosProveedor;
        private System.Windows.Forms.ComboBox RubroP;
        private System.Windows.Forms.TextBox PassP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox TelefonoP;
        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.TextBox RazonSocial;
        private System.Windows.Forms.TextBox MailP;
        private System.Windows.Forms.TextBox UsernameP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox NombreContacto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox ciudadP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox CodigoPostalP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox zonas;
        private System.Windows.Forms.CheckedListBox ListaZonas;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UsernameCliente;
        private System.Windows.Forms.TextBox MailCliente;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.TextBox ApellidoCliente;
        private System.Windows.Forms.TextBox TelefonoCliente;
        private System.Windows.Forms.TextBox FchNacimientoCliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox DNICliente;
        private System.Windows.Forms.TextBox DireccionC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox PasswordCliente;
        private System.Windows.Forms.ComboBox ciudadCliente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox CodigoPostalC;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.MonthCalendar Fecha;
        private System.Windows.Forms.GroupBox datosClientes;
        private System.Windows.Forms.TextBox ConfirmarPassword;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox ConfirmarPass;
        private System.Windows.Forms.Label label24;

    }
}