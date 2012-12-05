namespace GrouponDesktop.GUI.ComprarGiftCard
{
    partial class ComprarGirftcard
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
            this.Guardar = new System.Windows.Forms.Button();
            this.ClienteDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(15, 105);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(94, 23);
            this.Guardar.TabIndex = 31;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // ClienteDestino
            // 
            this.ClienteDestino.Location = new System.Drawing.Point(187, 17);
            this.ClienteDestino.Name = "ClienteDestino";
            this.ClienteDestino.Size = new System.Drawing.Size(159, 20);
            this.ClienteDestino.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Monto";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 20);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(132, 13);
            this.Nombre.TabIndex = 26;
            this.Nombre.Text = "Username Cliente Destino:";
            // 
            // monto
            // 
            this.monto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monto.FormattingEnabled = true;
            this.monto.Location = new System.Drawing.Point(187, 56);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(159, 21);
            this.monto.TabIndex = 32;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(252, 105);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(94, 23);
            this.Buscar.TabIndex = 33;
            this.Buscar.Text = "Buscar Cliente";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ComprarGirftcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 134);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.ClienteDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.MaximizeBox = false;
            this.Name = "ComprarGirftcard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar de Giftcard";
            this.Load += new System.EventHandler(this.ComprarGirftcard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox ClienteDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox monto;
        private System.Windows.Forms.Button Buscar;
    }
}