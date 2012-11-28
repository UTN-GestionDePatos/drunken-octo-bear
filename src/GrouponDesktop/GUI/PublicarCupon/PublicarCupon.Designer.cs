namespace GrouponDesktop.GUI.PublicarCupon
{
    partial class PublicarCupon
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
            this.fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Proveedores = new System.Windows.Forms.ComboBox();
            this.VerCupones = new System.Windows.Forms.Button();
            this.cupones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cupones)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(9, 9);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(186, 13);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "Publicación de cupones para la fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proveedor:";
            // 
            // Proveedores
            // 
            this.Proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Proveedores.FormattingEnabled = true;
            this.Proveedores.Location = new System.Drawing.Point(108, 55);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(272, 21);
            this.Proveedores.TabIndex = 5;
            // 
            // VerCupones
            // 
            this.VerCupones.Location = new System.Drawing.Point(591, 53);
            this.VerCupones.Name = "VerCupones";
            this.VerCupones.Size = new System.Drawing.Size(95, 23);
            this.VerCupones.TabIndex = 6;
            this.VerCupones.Text = "Ver Cupones";
            this.VerCupones.UseVisualStyleBackColor = true;
            this.VerCupones.Click += new System.EventHandler(this.VerCupones_Click);
            // 
            // cupones
            // 
            this.cupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cupones.Location = new System.Drawing.Point(12, 82);
            this.cupones.Name = "cupones";
            this.cupones.Size = new System.Drawing.Size(674, 218);
            this.cupones.TabIndex = 7;
            this.cupones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cupones_CellClick);
            // 
            // PublicarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 312);
            this.Controls.Add(this.cupones);
            this.Controls.Add(this.VerCupones);
            this.Controls.Add(this.Proveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha);
            this.Name = "PublicarCupon";
            this.Text = "PublicarCupon";
            this.Load += new System.EventHandler(this.PublicarCupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cupones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Proveedores;
        private System.Windows.Forms.Button VerCupones;
        private System.Windows.Forms.DataGridView cupones;
    }
}