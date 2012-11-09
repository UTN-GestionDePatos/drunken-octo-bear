namespace GrouponDesktop.GUI.PedirDevolucion
{
    partial class Devolucion
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
            this.Devolver = new System.Windows.Forms.Button();
            this.datosCupon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Devolver
            // 
            this.Devolver.Location = new System.Drawing.Point(76, 233);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(172, 23);
            this.Devolver.TabIndex = 1;
            this.Devolver.Text = "Confirmar Devolución";
            this.Devolver.UseVisualStyleBackColor = true;
            this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
            // 
            // datosCupon
            // 
            this.datosCupon.Location = new System.Drawing.Point(76, 12);
            this.datosCupon.Multiline = true;
            this.datosCupon.Name = "datosCupon";
            this.datosCupon.ReadOnly = true;
            this.datosCupon.Size = new System.Drawing.Size(699, 172);
            this.datosCupon.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Devolver);
            this.Controls.Add(this.datosCupon);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Devolver;
        private System.Windows.Forms.TextBox datosCupon;
        private System.Windows.Forms.Button button1;
    }
}