namespace GrouponDesktop.AbmCliente
{
    partial class ABMCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.Alta = new System.Windows.Forms.Button();
            this.Modificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una operación";
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(35, 53);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 1;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modificacion
            // 
            this.Modificacion.Location = new System.Drawing.Point(143, 53);
            this.Modificacion.Name = "Modificacion";
            this.Modificacion.Size = new System.Drawing.Size(75, 23);
            this.Modificacion.TabIndex = 2;
            this.Modificacion.Text = "Búsqueda";
            this.Modificacion.UseVisualStyleBackColor = true;
            this.Modificacion.Click += new System.EventHandler(this.Modificacion_Click);
            // 
            // ABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 95);
            this.Controls.Add(this.Modificacion);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.label1);
            this.Name = "ABMCliente";
            this.Text = "ABM Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Button Modificacion;
    }
}