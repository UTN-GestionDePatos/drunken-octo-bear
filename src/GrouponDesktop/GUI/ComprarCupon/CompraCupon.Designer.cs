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
            this.Nombre = new System.Windows.Forms.Label();
            this.cuponesDisponibles = new System.Windows.Forms.DataGridView();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cuponesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(141, 9);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(298, 13);
            this.Nombre.TabIndex = 19;
            this.Nombre.Text = "Cupones disponibles en sus zonas de interés en el día de hoy";
            // 
            // cuponesDisponibles
            // 
            this.cuponesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuponesDisponibles.Location = new System.Drawing.Point(29, 42);
            this.cuponesDisponibles.Name = "cuponesDisponibles";
            this.cuponesDisponibles.Size = new System.Drawing.Size(519, 200);
            this.cuponesDisponibles.TabIndex = 25;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(29, 265);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 24;
            this.Guardar.Text = "Comprar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(473, 265);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 26;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // CompraCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 300);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.cuponesDisponibles);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nombre);
            this.Name = "CompraCupon";
            this.Text = "CompraCupon";
            this.Load += new System.EventHandler(this.CompraCupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuponesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridView cuponesDisponibles;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cerrar;
    }
}