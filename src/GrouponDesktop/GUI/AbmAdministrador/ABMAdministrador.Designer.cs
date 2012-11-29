namespace GrouponDesktop.GUI.AbmAdministrador
{
    partial class ABMAdministrador
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
            this.Alta = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(47, 55);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // Listado
            // 
            this.Listado.Location = new System.Drawing.Point(156, 55);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(75, 23);
            this.Listado.TabIndex = 1;
            this.Listado.Text = "Listado";
            this.Listado.UseVisualStyleBackColor = true;
            this.Listado.Click += new System.EventHandler(this.Listado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una operación";
            // 
            // ABMAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.Alta);
            this.Name = "ABMAdministrador";
            this.Text = "ABMAdministrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Button Listado;
        private System.Windows.Forms.Label label1;
    }
}