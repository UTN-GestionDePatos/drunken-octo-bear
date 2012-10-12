namespace GrouponDesktop.GUI.HistorialCupones
{
    partial class HistorialCupones
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
            this.Ver = new System.Windows.Forms.Button();
            this.FechaHasta = new System.Windows.Forms.TextBox();
            this.FechaDesde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ver
            // 
            this.Ver.Location = new System.Drawing.Point(18, 103);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(75, 23);
            this.Ver.TabIndex = 36;
            this.Ver.Text = "Ver";
            this.Ver.UseVisualStyleBackColor = true;
            // 
            // FechaHasta
            // 
            this.FechaHasta.Location = new System.Drawing.Point(135, 47);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(209, 20);
            this.FechaHasta.TabIndex = 35;
            // 
            // FechaDesde
            // 
            this.FechaDesde.Location = new System.Drawing.Point(135, 15);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.Size = new System.Drawing.Size(209, 20);
            this.FechaDesde.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fecha Hasta:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(15, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(74, 13);
            this.Nombre.TabIndex = 32;
            this.Nombre.Text = "Fecha Desde:";
            // 
            // HistorialCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 140);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.FechaHasta);
            this.Controls.Add(this.FechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Name = "HistorialCupones";
            this.Text = "HistorialCupones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ver;
        private System.Windows.Forms.TextBox FechaHasta;
        private System.Windows.Forms.TextBox FechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;

    }
}