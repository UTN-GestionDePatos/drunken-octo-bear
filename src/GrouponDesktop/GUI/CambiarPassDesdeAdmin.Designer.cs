namespace GrouponDesktop.GUI
{
    partial class CambiarPassDesdeAdmin
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.passN = new System.Windows.Forms.TextBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passN2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.passN);
            this.groupBox1.Controls.Add(this.Confirmar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passN2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password:";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(248, 98);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // passN
            // 
            this.passN.Location = new System.Drawing.Point(153, 28);
            this.passN.Name = "passN";
            this.passN.PasswordChar = '•';
            this.passN.Size = new System.Drawing.Size(170, 20);
            this.passN.TabIndex = 10;
            this.passN.UseSystemPasswordChar = true;
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(14, 98);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 12;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña Nueva";
            // 
            // passN2
            // 
            this.passN2.Location = new System.Drawing.Point(153, 55);
            this.passN2.Name = "passN2";
            this.passN2.PasswordChar = '•';
            this.passN2.Size = new System.Drawing.Size(170, 20);
            this.passN2.TabIndex = 11;
            this.passN2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // CambiarPassDesdeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 167);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CambiarPassDesdeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Password";
            this.Load += new System.EventHandler(this.CambiarPassDesdeAdmin_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CambiarPassDesdeAdmin_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox passN;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passN2;
        private System.Windows.Forms.Label label3;
    }
}