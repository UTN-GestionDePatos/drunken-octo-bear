namespace GrouponDesktop.GUI.PedirDevolucion
{
    partial class PedirDevolucion
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
            this.Cupon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(15, 150);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 36;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cupon
            // 
            this.Cupon.Location = new System.Drawing.Point(132, 6);
            this.Cupon.Name = "Cupon";
            this.Cupon.Size = new System.Drawing.Size(209, 20);
            this.Cupon.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Motivo:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 9);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(96, 13);
            this.Nombre.TabIndex = 32;
            this.Nombre.Text = "Número de Cupón:";
            // 
            // Motivo
            // 
            this.Motivo.Location = new System.Drawing.Point(132, 35);
            this.Motivo.Multiline = true;
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(209, 93);
            this.Motivo.TabIndex = 37;
            // 
            // PedirDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 185);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cupon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.MaximizeBox = false;
            this.Name = "PedirDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedir devolución";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox Cupon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox Motivo;
    }
}