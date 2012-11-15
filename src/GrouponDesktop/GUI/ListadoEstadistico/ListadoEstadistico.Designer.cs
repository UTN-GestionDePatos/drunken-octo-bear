namespace GrouponDesktop.GUI.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.label2 = new System.Windows.Forms.Label();
            this.Anio = new System.Windows.Forms.ComboBox();
            this.Semestre = new System.Windows.Forms.ComboBox();
            this.TipoListado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ver = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semestre:";
            // 
            // Anio
            // 
            this.Anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Anio.FormattingEnabled = true;
            this.Anio.Location = new System.Drawing.Point(136, 34);
            this.Anio.Name = "Anio";
            this.Anio.Size = new System.Drawing.Size(169, 21);
            this.Anio.TabIndex = 2;
            // 
            // Semestre
            // 
            this.Semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semestre.FormattingEnabled = true;
            this.Semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semestre.Location = new System.Drawing.Point(136, 66);
            this.Semestre.Name = "Semestre";
            this.Semestre.Size = new System.Drawing.Size(169, 21);
            this.Semestre.TabIndex = 3;
            // 
            // TipoListado
            // 
            this.TipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoListado.FormattingEnabled = true;
            this.TipoListado.Items.AddRange(new object[] {
            "Top 5 Devoluciones",
            "Top 5 Acreditación de Giftcards"});
            this.TipoListado.Location = new System.Drawing.Point(136, 102);
            this.TipoListado.Name = "TipoListado";
            this.TipoListado.Size = new System.Drawing.Size(169, 21);
            this.TipoListado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Listado:";
            // 
            // Ver
            // 
            this.Ver.Location = new System.Drawing.Point(43, 194);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(75, 23);
            this.Ver.TabIndex = 7;
            this.Ver.Text = "Ver";
            this.Ver.UseVisualStyleBackColor = true;
            this.Ver.Click += new System.EventHandler(this.Ver_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(230, 194);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 8;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 240);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.TipoListado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Semestre);
            this.Controls.Add(this.Anio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListadoEstadistico";
            this.Text = "ListadoEstadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Anio;
        private System.Windows.Forms.ComboBox Semestre;
        private System.Windows.Forms.ComboBox TipoListado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ver;
        private System.Windows.Forms.Button Cerrar;
    }
}