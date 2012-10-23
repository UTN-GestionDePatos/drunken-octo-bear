namespace GrouponDesktop.GUI.AbmRol
{
    partial class ListadoRol
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
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.FuncionalidadRol = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.NombreRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.FuncionalidadRol);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.NombreRol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(393, 50);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 20;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(12, 50);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 19;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // FuncionalidadRol
            // 
            this.FuncionalidadRol.Location = new System.Drawing.Point(333, 19);
            this.FuncionalidadRol.Name = "FuncionalidadRol";
            this.FuncionalidadRol.Size = new System.Drawing.Size(135, 20);
            this.FuncionalidadRol.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(253, 22);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(76, 13);
            this.Nombre.TabIndex = 18;
            this.Nombre.Text = "Funcionalidad:";
            // 
            // NombreRol
            // 
            this.NombreRol.Location = new System.Drawing.Point(89, 19);
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.Size = new System.Drawing.Size(135, 20);
            this.NombreRol.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre:";
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 359);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoRol";
            this.Text = "Rol - Listado de selección";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FuncionalidadRol;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
    }
}