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
            this.Busqueda = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(157, 57);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(75, 23);
            this.Busqueda.TabIndex = 7;
            this.Busqueda.Text = "Búsqueda";
            this.Busqueda.UseVisualStyleBackColor = true;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
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
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una operación";
            // 
            // ABMProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 89);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.label1);
            this.Name = "ABMProveedor";
            this.Text = "ABM Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Label label1;
    }
}