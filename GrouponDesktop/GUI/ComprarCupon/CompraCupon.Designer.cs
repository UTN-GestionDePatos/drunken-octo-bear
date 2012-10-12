namespace GrouponDesktop.GUI.ComprarCupon
{
    partial class CompraCupon
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
            this.CodigoCupon = new System.Windows.Forms.TextBox();
            this.Grupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodigoCupon
            // 
            this.CodigoCupon.Location = new System.Drawing.Point(132, 47);
            this.CodigoCupon.Name = "CodigoCupon";
            this.CodigoCupon.Size = new System.Drawing.Size(209, 20);
            this.CodigoCupon.TabIndex = 23;
            // 
            // Grupo
            // 
            this.Grupo.Location = new System.Drawing.Point(132, 15);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(209, 20);
            this.Grupo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Código de Cupón";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 13);
            this.Nombre.TabIndex = 19;
            this.Nombre.Text = "Cupón o Promoción";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(15, 109);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 24;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // CompraCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 140);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.CodigoCupon);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Name = "CompraCupon";
            this.Text = "CompraCupon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoCupon;
        private System.Windows.Forms.TextBox Grupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button Guardar;
    }
}