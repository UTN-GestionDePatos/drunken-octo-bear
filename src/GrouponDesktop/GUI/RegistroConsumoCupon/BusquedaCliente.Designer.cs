namespace GrouponDesktop.GUI.RegistroConsumoCupon
{
    partial class BusquedaCliente
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
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(427, 23);
            this.Apellido.MaxLength = 50;
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(135, 20);
            this.Apellido.TabIndex = 26;
            this.Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellido_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(89, 23);
            this.Nombre.MaxLength = 50;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(135, 20);
            this.Nombre.TabIndex = 24;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Apellido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 122);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(89, 63);
            this.DNI.MaxLength = 18;
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(135, 20);
            this.DNI.TabIndex = 22;
            this.DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DNI_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "DNI:";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(487, 89);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 20;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(12, 89);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 19;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(24, 140);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(561, 206);
            this.dataGridClientes.TabIndex = 6;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "BusquedaCliente";
            this.Text = "BusquedaCliente";
            this.Load += new System.EventHandler(this.BusquedaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.DataGridView dataGridClientes;
    }
}