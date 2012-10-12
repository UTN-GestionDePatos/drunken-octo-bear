namespace GrouponDesktop.GUI.AbmRol
{
    partial class ABMRol
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
            this.Baja = new System.Windows.Forms.Button();
            this.Modificacion = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Baja
            // 
            this.Baja.Location = new System.Drawing.Point(227, 54);
            this.Baja.Name = "Baja";
            this.Baja.Size = new System.Drawing.Size(75, 23);
            this.Baja.TabIndex = 7;
            this.Baja.Text = "Baja";
            this.Baja.UseVisualStyleBackColor = true;
            // 
            // Modificacion
            // 
            this.Modificacion.Location = new System.Drawing.Point(133, 54);
            this.Modificacion.Name = "Modificacion";
            this.Modificacion.Size = new System.Drawing.Size(75, 23);
            this.Modificacion.TabIndex = 6;
            this.Modificacion.Text = "Modificación";
            this.Modificacion.UseVisualStyleBackColor = true;
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(38, 54);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 5;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una operación";
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 100);
            this.Controls.Add(this.Baja);
            this.Controls.Add(this.Modificacion);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.label1);
            this.Name = "ABMRol";
            this.Text = "Roles";
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