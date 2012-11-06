namespace GrouponDesktop.GUI.CargaCredito
{
    partial class CargaCredito
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
            this.NumeroTarjeta = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoPago = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumeroTarjeta
            // 
            this.NumeroTarjeta.Enabled = false;
            this.NumeroTarjeta.Location = new System.Drawing.Point(183, 115);
            this.NumeroTarjeta.Name = "NumeroTarjeta";
            this.NumeroTarjeta.Size = new System.Drawing.Size(209, 20);
            this.NumeroTarjeta.TabIndex = 23;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(183, 41);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(209, 20);
            this.Monto.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Número de Tarjeta:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(18, 48);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(40, 13);
            this.Nombre.TabIndex = 19;
            this.Nombre.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo de Pago";
            // 
            // TipoPago
            // 
            this.TipoPago.FormattingEnabled = true;
            this.TipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Crédito",
            "Débito"});
            this.TipoPago.Location = new System.Drawing.Point(183, 77);
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.Size = new System.Drawing.Size(209, 21);
            this.TipoPago.TabIndex = 25;
            this.TipoPago.SelectedIndexChanged += new System.EventHandler(this.TipoPago_SelectedIndexChanged);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(21, 150);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 26;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(183, 11);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(209, 20);
            this.Username.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Username:";
            // 
            // CargaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 180);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.TipoPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroTarjeta);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Name = "CargaCredito";
            this.Text = "CargaCredito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroTarjeta;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoPago;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;

    }
}