namespace GrouponDesktop.AbmCliente
{
    partial class AltaProveedor
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
            this.datosProveedor = new System.Windows.Forms.GroupBox();
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
            this.datosProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(269, 410);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 5;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(18, 410);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 4;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // datosProveedor
            // 
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
            this.datosProveedor.Location = new System.Drawing.Point(12, 12);
            this.datosProveedor.Name = "datosProveedor";
            this.datosProveedor.Size = new System.Drawing.Size(353, 385);
            this.datosProveedor.TabIndex = 24;
            this.datosProveedor.TabStop = false;
            this.datosProveedor.Text = "Datos Personales";
            // 
            // CodigoPostalP
            // 
            this.CodigoPostalP.Location = new System.Drawing.Point(126, 247);
            this.CodigoPostalP.Name = "CodigoPostalP";
            this.CodigoPostalP.Size = new System.Drawing.Size(209, 20);
            this.CodigoPostalP.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 250);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Código Postal";
            // 
            // ciudadP
            // 
            this.ciudadP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadP.FormattingEnabled = true;
            this.ciudadP.Location = new System.Drawing.Point(126, 316);
            this.ciudadP.Name = "ciudadP";
            this.ciudadP.Size = new System.Drawing.Size(209, 21);
            this.ciudadP.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Ciudad";
            // 
            // NombreContacto
            // 
            this.NombreContacto.Location = new System.Drawing.Point(126, 349);
            this.NombreContacto.Name = "NombreContacto";
            this.NombreContacto.Size = new System.Drawing.Size(209, 20);
            this.NombreContacto.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 352);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Nombre de Contacto";
            // 
            // RubroP
            // 
            this.RubroP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RubroP.FormattingEnabled = true;
            this.RubroP.Location = new System.Drawing.Point(126, 283);
            this.RubroP.Name = "RubroP";
            this.RubroP.Size = new System.Drawing.Size(209, 21);
            this.RubroP.TabIndex = 23;
            // 
            // PassP
            // 
            this.PassP.Location = new System.Drawing.Point(126, 55);
            this.PassP.Name = "PassP";
            this.PassP.Size = new System.Drawing.Size(209, 20);
            this.PassP.TabIndex = 22;
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
            this.Direccion.Location = new System.Drawing.Point(126, 214);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(209, 20);
            this.Direccion.TabIndex = 19;
            // 
            // TelefonoP
            // 
            this.TelefonoP.Location = new System.Drawing.Point(126, 182);
            this.TelefonoP.Name = "TelefonoP";
            this.TelefonoP.Size = new System.Drawing.Size(209, 20);
            this.TelefonoP.TabIndex = 18;
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(126, 116);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(209, 20);
            this.CUIT.TabIndex = 17;
            // 
            // RazonSocial
            // 
            this.RazonSocial.Location = new System.Drawing.Point(126, 84);
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Size = new System.Drawing.Size(209, 20);
            this.RazonSocial.TabIndex = 16;
            // 
            // MailP
            // 
            this.MailP.Location = new System.Drawing.Point(126, 150);
            this.MailP.Name = "MailP";
            this.MailP.Size = new System.Drawing.Size(209, 20);
            this.MailP.TabIndex = 16;
            // 
            // UsernameP
            // 
            this.UsernameP.Location = new System.Drawing.Point(126, 26);
            this.UsernameP.Name = "UsernameP";
            this.UsernameP.Size = new System.Drawing.Size(209, 20);
            this.UsernameP.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Rubro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "CUIT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 154);
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
            this.label16.Location = new System.Drawing.Point(6, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Razón Social";
            // 
            // AltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 440);
            this.Controls.Add(this.datosProveedor);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Limpiar);
            this.Name = "AltaProveedor";
            this.Text = "AltaProveedor";
            this.Load += new System.EventHandler(this.AltaProveedor_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaProveedor_FormClosing);
            this.datosProveedor.ResumeLayout(false);
            this.datosProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.GroupBox datosProveedor;
        private System.Windows.Forms.TextBox CodigoPostalP;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox ciudadP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox NombreContacto;
        private System.Windows.Forms.Label label17;
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
    }
}