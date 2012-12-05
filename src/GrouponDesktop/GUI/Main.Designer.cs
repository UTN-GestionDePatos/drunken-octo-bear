namespace GrouponDesktop.GUI
{
    partial class Main
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
            this.funcionalidades = new System.Windows.Forms.ComboBox();
            this.bienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cambiarPass = new System.Windows.Forms.Button();
            this.DarDeBaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.Label();
            this.LabelSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // funcionalidades
            // 
            this.funcionalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcionalidades.FormattingEnabled = true;
            this.funcionalidades.Location = new System.Drawing.Point(30, 86);
            this.funcionalidades.Name = "funcionalidades";
            this.funcionalidades.Size = new System.Drawing.Size(268, 21);
            this.funcionalidades.TabIndex = 0;
            this.funcionalidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcionalidades_KeyPress);
            // 
            // bienvenida
            // 
            this.bienvenida.AutoSize = true;
            this.bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(12, 9);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(90, 16);
            this.bienvenida.TabIndex = 1;
            this.bienvenida.Text = "Bienvenido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cambiarPass
            // 
            this.cambiarPass.Location = new System.Drawing.Point(30, 158);
            this.cambiarPass.Name = "cambiarPass";
            this.cambiarPass.Size = new System.Drawing.Size(118, 23);
            this.cambiarPass.TabIndex = 5;
            this.cambiarPass.Text = "Cambiar Contraseña";
            this.cambiarPass.UseVisualStyleBackColor = true;
            this.cambiarPass.Visible = false;
            this.cambiarPass.Click += new System.EventHandler(this.cambiarPass_Click_1);
            // 
            // DarDeBaja
            // 
            this.DarDeBaja.Location = new System.Drawing.Point(183, 158);
            this.DarDeBaja.Name = "DarDeBaja";
            this.DarDeBaja.Size = new System.Drawing.Size(118, 22);
            this.DarDeBaja.TabIndex = 6;
            this.DarDeBaja.Text = "Darse de Baja";
            this.DarDeBaja.UseVisualStyleBackColor = true;
            this.DarDeBaja.Visible = false;
            this.DarDeBaja.Click += new System.EventHandler(this.DarDeBaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(236, 29);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(65, 13);
            this.Fecha.TabIndex = 8;
            this.Fecha.Text = "00/00/0000";
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saldo.Location = new System.Drawing.Point(76, 29);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(70, 13);
            this.Saldo.TabIndex = 10;
            this.Saldo.Text = "$ 000000000";
            // 
            // LabelSaldo
            // 
            this.LabelSaldo.AutoSize = true;
            this.LabelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSaldo.Location = new System.Drawing.Point(27, 29);
            this.LabelSaldo.Name = "LabelSaldo";
            this.LabelSaldo.Size = new System.Drawing.Size(43, 13);
            this.LabelSaldo.TabIndex = 9;
            this.LabelSaldo.Text = "Saldo:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 186);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.LabelSaldo);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DarDeBaja);
            this.Controls.Add(this.cambiarPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bienvenida);
            this.Controls.Add(this.funcionalidades);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionalidades";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox funcionalidades;
        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cambiarPass;
        private System.Windows.Forms.Button DarDeBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Label LabelSaldo;

    }
}