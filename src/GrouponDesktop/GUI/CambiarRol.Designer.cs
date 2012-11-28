namespace GrouponDesktop.GUI
{
    partial class CambiarRol
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
            this.Rol = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rol
            // 
            this.Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rol.FormattingEnabled = true;
            this.Rol.Location = new System.Drawing.Point(128, 21);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(209, 21);
            this.Rol.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Rol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 91);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.label13);
            this.Name = "CambiarRol";
            this.Text = "CambiarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.CambiarRol_Load);
        }

        #endregion

        private System.Windows.Forms.ComboBox Rol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
    }
}