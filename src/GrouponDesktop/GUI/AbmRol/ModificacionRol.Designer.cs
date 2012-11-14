namespace GrouponDesktop.GUI.AbmRol
{
    partial class ModificacionRol
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.ListaFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.NombreRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.ListaFuncionalidades);
            this.groupBox1.Controls.Add(this.NombreRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(260, 216);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 18;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(9, 216);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 17;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // ListaFuncionalidades
            // 
            this.ListaFuncionalidades.FormattingEnabled = true;
            this.ListaFuncionalidades.Location = new System.Drawing.Point(102, 59);
            this.ListaFuncionalidades.Name = "ListaFuncionalidades";
            this.ListaFuncionalidades.Size = new System.Drawing.Size(233, 109);
            this.ListaFuncionalidades.TabIndex = 16;
            // 
            // NombreRol
            // 
            this.NombreRol.Location = new System.Drawing.Point(102, 26);
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.Size = new System.Drawing.Size(233, 20);
            this.NombreRol.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 59);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(84, 13);
            this.Nombre.TabIndex = 9;
            this.Nombre.Text = "Funcionalidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Estado";
            // 
            // Estado
            // 
            this.Estado.FormattingEnabled = true;
            this.Estado.Location = new System.Drawing.Point(102, 178);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(233, 21);
            this.Estado.TabIndex = 20;
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 256);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificacionRol";
            this.Text = "Rol - Modificacion";
            this.Load += new System.EventHandler(this.ModificacionRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.CheckedListBox ListaFuncionalidades;
        private System.Windows.Forms.TextBox NombreRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Label label2;

    }
}