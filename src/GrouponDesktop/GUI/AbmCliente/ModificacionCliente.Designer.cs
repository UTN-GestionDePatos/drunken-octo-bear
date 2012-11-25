namespace GrouponDesktop.GUI.AbmCliente
{
    partial class ModificacionCliente
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
            this.zonas = new System.Windows.Forms.Label();
            this.ListaZonas = new System.Windows.Forms.CheckedListBox();
            this.datosClientes = new System.Windows.Forms.GroupBox();
            this.CodigoPostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ciudadCliente = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DireccionC = new System.Windows.Forms.TextBox();
            this.DNICliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.FchNacimientoCliente = new System.Windows.Forms.TextBox();
            this.TelefonoCliente = new System.Windows.Forms.TextBox();
            this.ApellidoCliente = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.MailCliente = new System.Windows.Forms.TextBox();
            this.UsernameCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CambiarPassword = new System.Windows.Forms.Button();
            this.datosClientes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(624, 449);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(17, 447);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 6;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // zonas
            // 
            this.zonas.AutoSize = true;
            this.zonas.Location = new System.Drawing.Point(374, 33);
            this.zonas.Name = "zonas";
            this.zonas.Size = new System.Drawing.Size(109, 13);
            this.zonas.TabIndex = 33;
            this.zonas.Text = "Zonas de Preferencia";
            this.zonas.Visible = false;
            // 
            // ListaZonas
            // 
            this.ListaZonas.FormattingEnabled = true;
            this.ListaZonas.Location = new System.Drawing.Point(377, 76);
            this.ListaZonas.Name = "ListaZonas";
            this.ListaZonas.Size = new System.Drawing.Size(330, 244);
            this.ListaZonas.TabIndex = 32;
            // 
            // datosClientes
            // 
            this.datosClientes.Controls.Add(this.CambiarPassword);
            this.datosClientes.Controls.Add(this.CodigoPostal);
            this.datosClientes.Controls.Add(this.label4);
            this.datosClientes.Controls.Add(this.ciudadCliente);
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
            this.datosClientes.Location = new System.Drawing.Point(17, 12);
            this.datosClientes.Name = "datosClientes";
            this.datosClientes.Size = new System.Drawing.Size(335, 405);
            this.datosClientes.TabIndex = 31;
            this.datosClientes.TabStop = false;
            this.datosClientes.Text = "Datos Personales";
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.Location = new System.Drawing.Point(121, 358);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(209, 20);
            this.CodigoPostal.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Código Postal";
            // 
            // ciudadCliente
            // 
            this.ciudadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadCliente.FormattingEnabled = true;
            this.ciudadCliente.Location = new System.Drawing.Point(122, 314);
            this.ciudadCliente.Name = "ciudadCliente";
            this.ciudadCliente.Size = new System.Drawing.Size(209, 21);
            this.ciudadCliente.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 317);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Ciudad";
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
            // DireccionC
            // 
            this.DireccionC.Location = new System.Drawing.Point(122, 273);
            this.DireccionC.Name = "DireccionC";
            this.DireccionC.Size = new System.Drawing.Size(209, 20);
            this.DireccionC.TabIndex = 49;
            // 
            // DNICliente
            // 
            this.DNICliente.Location = new System.Drawing.Point(122, 242);
            this.DNICliente.Name = "DNICliente";
            this.DNICliente.Size = new System.Drawing.Size(209, 20);
            this.DNICliente.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Direccion";
            // 
            // FchNacimientoCliente
            // 
            this.FchNacimientoCliente.Location = new System.Drawing.Point(122, 211);
            this.FchNacimientoCliente.Name = "FchNacimientoCliente";
            this.FchNacimientoCliente.Size = new System.Drawing.Size(209, 20);
            this.FchNacimientoCliente.TabIndex = 44;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.Location = new System.Drawing.Point(122, 179);
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.Size = new System.Drawing.Size(209, 20);
            this.TelefonoCliente.TabIndex = 43;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.Location = new System.Drawing.Point(122, 113);
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.Size = new System.Drawing.Size(209, 20);
            this.ApellidoCliente.TabIndex = 42;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Location = new System.Drawing.Point(122, 81);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(209, 20);
            this.NombreCliente.TabIndex = 40;
            // 
            // MailCliente
            // 
            this.MailCliente.Location = new System.Drawing.Point(122, 147);
            this.MailCliente.Name = "MailCliente";
            this.MailCliente.Size = new System.Drawing.Size(209, 20);
            this.MailCliente.TabIndex = 41;
            // 
            // UsernameCliente
            // 
            this.UsernameCliente.Location = new System.Drawing.Point(122, 23);
            this.UsernameCliente.Name = "UsernameCliente";
            this.UsernameCliente.Size = new System.Drawing.Size(209, 20);
            this.UsernameCliente.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mail";
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
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(2, 84);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 33;
            this.Nombre.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Estado);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(367, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 45);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de Usuario";
            // 
            // Estado
            // 
            this.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Estado.FormattingEnabled = true;
            this.Estado.Location = new System.Drawing.Point(123, 12);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(209, 21);
            this.Estado.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Estado";
            // 
            // CambiarPassword
            // 
            this.CambiarPassword.Location = new System.Drawing.Point(122, 49);
            this.CambiarPassword.Name = "CambiarPassword";
            this.CambiarPassword.Size = new System.Drawing.Size(104, 23);
            this.CambiarPassword.TabIndex = 54;
            this.CambiarPassword.Text = "Cambiar password";
            this.CambiarPassword.UseVisualStyleBackColor = true;
            this.CambiarPassword.Click += new System.EventHandler(this.CambiarPassword_Click);
            // 
            // ModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.zonas);
            this.Controls.Add(this.ListaZonas);
            this.Controls.Add(this.datosClientes);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Limpiar);
            this.Name = "ModificacionCliente";
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.ModificacionCliente_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificacionCliente_FormClosing);
            this.datosClientes.ResumeLayout(false);
            this.datosClientes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label zonas;
        private System.Windows.Forms.CheckedListBox ListaZonas;
        private System.Windows.Forms.GroupBox datosClientes;
        private System.Windows.Forms.TextBox CodigoPostal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ciudadCliente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DireccionC;
        private System.Windows.Forms.TextBox DNICliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox FchNacimientoCliente;
        private System.Windows.Forms.TextBox TelefonoCliente;
        private System.Windows.Forms.TextBox ApellidoCliente;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.TextBox MailCliente;
        private System.Windows.Forms.TextBox UsernameCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CambiarPassword;
    }
}