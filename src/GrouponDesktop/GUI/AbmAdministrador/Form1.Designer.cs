namespace GrouponDesktop.GUI.AbmAdministrador
{
    partial class Form1
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
            this.datosClientes = new System.Windows.Forms.GroupBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombreA = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.datosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // datosClientes
            // 
            this.datosClientes.Controls.Add(this.pass);
            this.datosClientes.Controls.Add(this.label12);
            this.datosClientes.Controls.Add(this.apellido);
            this.datosClientes.Controls.Add(this.nombreA);
            this.datosClientes.Controls.Add(this.user);
            this.datosClientes.Controls.Add(this.label3);
            this.datosClientes.Controls.Add(this.label1);
            this.datosClientes.Controls.Add(this.Nombre);
            this.datosClientes.Location = new System.Drawing.Point(31, 21);
            this.datosClientes.Name = "datosClientes";
            this.datosClientes.Size = new System.Drawing.Size(343, 148);
            this.datosClientes.TabIndex = 29;
            this.datosClientes.TabStop = false;
            this.datosClientes.Text = "Datos Personales";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(122, 52);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(209, 20);
            this.pass.TabIndex = 47;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Password";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(122, 23);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(209, 20);
            this.user.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(122, 113);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(209, 20);
            this.apellido.TabIndex = 42;
            // 
            // nombreA
            // 
            this.nombreA.Location = new System.Drawing.Point(122, 81);
            this.nombreA.Name = "nombreA";
            this.nombreA.Size = new System.Drawing.Size(209, 20);
            this.nombreA.TabIndex = 40;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(2, 84);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 33;
            this.Nombre.Text = "Nombre";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(287, 187);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 30;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(36, 187);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 31;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 227);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.datosClientes);
            this.Name = "Form1";
            this.Text = "Alta Administrador";
            this.datosClientes.ResumeLayout(false);
            this.datosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datosClientes;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombreA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
    }
}