namespace GrouponDesktop.GUI.RegistroConsumoCupon
{
    partial class RegistroConsumoCupon
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
            this.Cliente = new System.Windows.Forms.TextBox();
            this.CodigoCupon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(18, 103);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 36;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cliente
            // 
            this.Cliente.Location = new System.Drawing.Point(135, 47);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(209, 20);
            this.Cliente.TabIndex = 35;
            // 
            // CodigoCupon
            // 
            this.CodigoCupon.Location = new System.Drawing.Point(135, 15);
            this.CodigoCupon.Name = "CodigoCupon";
            this.CodigoCupon.Size = new System.Drawing.Size(209, 20);
            this.CodigoCupon.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cliente:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(15, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(89, 13);
            this.Nombre.TabIndex = 32;
            this.Nombre.Text = "Código de Cupón";
            // 
            // RegistroConsumoCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 140);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.CodigoCupon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Name = "RegistroConsumoCupon";
            this.Text = "RegistroConsumoCupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox Cliente;
        private System.Windows.Forms.TextBox CodigoCupon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
    }
}