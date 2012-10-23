namespace GrouponDesktop.AbmProveedor
{
    partial class ABMProveedor
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
            this.Baja = new System.Windows.Forms.Button();
            this.Modificacion = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Baja
            // 
            this.Baja.Location = new System.Drawing.Point(222, 57);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(75, 23);
            this.Baja.TabIndex = 7;
            this.Baja.Text = "Baja";
            this.Baja.UseVisualStyleBackColor = true;
            // 
            // Modificacion
            // 
            this.Modificacion.Location = new System.Drawing.Point(128, 57);
            this.Modificacion.Name = "Modificacion";
            this.Modificacion.Size = new System.Drawing.Size(75, 23);
            this.Modificacion.TabIndex = 6;
            this.Modificacion.Text = "Modificación";
            this.Modificacion.UseVisualStyleBackColor = true;
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(33, 57);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 5;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una operación";
            // 
            // ABMProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 92);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.Modificacion);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.label1);
            this.Name = "ABMProveedor";
            this.Text = "ABMProveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Baja;
        private System.Windows.Forms.Button Modificacion;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Label label1;
    }
}