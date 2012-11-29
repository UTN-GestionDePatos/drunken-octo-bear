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
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cuponesDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(206, 9);
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
            this.cuponesDisponibles.Size = new System.Drawing.Size(646, 200);
            this.cuponesDisponibles.TabIndex = 25;
            this.cuponesDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cuponesDisponibles_CellContentClick);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(586, 265);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(89, 23);
            this.Cerrar.TabIndex = 26;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // CompraCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 300);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.cuponesDisponibles);
            this.Controls.Add(this.Nombre);
            this.MaximizeBox = false;
            this.Name = "CompraCupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Cupón";
            this.Load += new System.EventHandler(this.CompraCupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuponesDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridView cuponesDisponibles;
        private System.Windows.Forms.Button Cerrar;
    }
}