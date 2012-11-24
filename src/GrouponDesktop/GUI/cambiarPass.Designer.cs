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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.passN2 = new System.Windows.Forms.TextBox();
            this.passN = new System.Windows.Forms.TextBox();
            this.passV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña Vieja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña Nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(24, 123);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 6;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(258, 123);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // passN2
            // 
            this.passN2.Location = new System.Drawing.Point(163, 80);
            this.passN2.Name = "passN2";
            this.passN2.PasswordChar = '•';
            this.passN2.Size = new System.Drawing.Size(170, 20);
            this.passN2.TabIndex = 5;
            this.passN2.UseSystemPasswordChar = true;
            // 
            // passN
            // 
            this.passN.Location = new System.Drawing.Point(163, 53);
            this.passN.Name = "passN";
            this.passN.PasswordChar = '•';
            this.passN.Size = new System.Drawing.Size(170, 20);
            this.passN.TabIndex = 4;
            this.passN.UseSystemPasswordChar = true;
            // 
            // passV
            // 
            this.passV.Location = new System.Drawing.Point(163, 24);
            this.passV.Name = "passV";
            this.passV.PasswordChar = '•';
            this.passV.Size = new System.Drawing.Size(170, 20);
            this.passV.TabIndex = 3;
            this.passV.UseSystemPasswordChar = true;
            // 
            // cambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 158);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.passN2);
            this.Controls.Add(this.passN);
            this.Controls.Add(this.passV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cambiarPass";
            this.Text = "cambiarPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.TextBox passN2;
        private System.Windows.Forms.TextBox passN;
        private System.Windows.Forms.TextBox passV;
    }
}