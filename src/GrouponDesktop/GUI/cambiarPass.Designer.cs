namespace GrouponDesktop.GUI
{
    partial class cambiarPass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Confirmar = new System.Windows.Forms.Button();
            this.passN2 = new System.Windows.Forms.TextBox();
            this.passN = new System.Windows.Forms.TextBox();
            this.passV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.Confirmar);
            this.groupBox1.Controls.Add(this.passN2);
            this.groupBox1.Controls.Add(this.passN);
            this.groupBox1.Controls.Add(this.passV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password:";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(242, 127);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 15;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click_1);
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(8, 127);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 14;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click_1);
            // 
            // passN2
            // 
            this.passN2.Location = new System.Drawing.Point(147, 84);
            this.passN2.Name = "passN2";
            this.passN2.PasswordChar = '•';
            this.passN2.Size = new System.Drawing.Size(170, 20);
            this.passN2.TabIndex = 13;
            this.passN2.UseSystemPasswordChar = true;
            // 
            // passN
            // 
            this.passN.Location = new System.Drawing.Point(147, 57);
            this.passN.Name = "passN";
            this.passN.PasswordChar = '•';
            this.passN.Size = new System.Drawing.Size(170, 20);
            this.passN.TabIndex = 12;
            this.passN.UseSystemPasswordChar = true;
            // 
            // passV
            // 
            this.passV.Location = new System.Drawing.Point(147, 28);
            this.passV.Name = "passV";
            this.passV.PasswordChar = '•';
            this.passV.Size = new System.Drawing.Size(170, 20);
            this.passV.TabIndex = 11;
            this.passV.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña Nueva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña Vieja";
            // 
            // cambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 187);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "cambiarPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cambiarPass_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox passN2;
        private System.Windows.Forms.TextBox passN;
        private System.Windows.Forms.TextBox passV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}