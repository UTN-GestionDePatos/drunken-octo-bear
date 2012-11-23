namespace GrouponDesktop.GUI.AbmCliente
{
    partial class ListadoCliente
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.usernameDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddirDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimientoDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSet1 = new GrouponDesktop.GD2C2012DataSet1();
            this.clientesTableAdapter = new GrouponDesktop.GD2C2012DataSet1TableAdapters.ClientesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.Mail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(333, 19);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(135, 20);
            this.Apellido.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Apellido:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(89, 19);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(135, 20);
            this.Nombre.TabIndex = 24;
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
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(89, 63);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(135, 20);
            this.DNI.TabIndex = 22;
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
            this.Buscar.Location = new System.Drawing.Point(393, 89);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 20;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
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
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(333, 59);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(135, 20);
            this.Mail.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "E-Mail:";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AutoGenerateColumns = false;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridView,
            this.nombreDataGridView,
            this.apellidoDataGridView,
            this.mailDataGridView,
            this.telefonoDataGridView,
            this.iddirDataGridView,
            this.fecha_nacimientoDataGridView,
            this.ciudadDataGridView,
            this.dniDataGridView,
            this.saldoDataGridView});
            this.dataGridClientes.DataSource = this.clientesBindingSource;
            this.dataGridClientes.Location = new System.Drawing.Point(13, 142);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(490, 241);
            this.dataGridClientes.TabIndex = 2;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // usernameDataGridView
            // 
            this.usernameDataGridView.DataPropertyName = "username";
            this.usernameDataGridView.HeaderText = "username";
            this.usernameDataGridView.Name = "usernameDataGridView";
            // 
            // nombreDataGridView
            // 
            this.nombreDataGridView.DataPropertyName = "nombre";
            this.nombreDataGridView.HeaderText = "nombre";
            this.nombreDataGridView.Name = "nombreDataGridView";
            // 
            // apellidoDataGridView
            // 
            this.apellidoDataGridView.DataPropertyName = "apellido";
            this.apellidoDataGridView.HeaderText = "apellido";
            this.apellidoDataGridView.Name = "apellidoDataGridView";
            // 
            // mailDataGridView
            // 
            this.mailDataGridView.DataPropertyName = "mail";
            this.mailDataGridView.HeaderText = "mail";
            this.mailDataGridView.Name = "mailDataGridView";
            // 
            // telefonoDataGridView
            // 
            this.telefonoDataGridView.DataPropertyName = "telefono";
            this.telefonoDataGridView.HeaderText = "telefono";
            this.telefonoDataGridView.Name = "telefonoDataGridView";
            // 
            // iddirDataGridView
            // 
            this.iddirDataGridView.DataPropertyName = "id_dir";
            this.iddirDataGridView.HeaderText = "id_dir";
            this.iddirDataGridView.Name = "iddirDataGridView";
            // 
            // fecha_nacimientoDataGridView
            // 
            this.fecha_nacimientoDataGridView.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimientoDataGridView.HeaderText = "fecha_nacimiento";
            this.fecha_nacimientoDataGridView.Name = "fecha_nacimientoDataGridView";
            // 
            // ciudadDataGridView
            // 
            this.ciudadDataGridView.DataPropertyName = "ciudad";
            this.ciudadDataGridView.HeaderText = "ciudad";
            this.ciudadDataGridView.Name = "ciudadDataGridView";
            // 
            // dniDataGridView
            // 
            this.dniDataGridView.DataPropertyName = "dni";
            this.dniDataGridView.HeaderText = "dni";
            this.dniDataGridView.Name = "dniDataGridView";
            // 
            // saldoDataGridView
            // 
            this.saldoDataGridView.DataPropertyName = "saldo";
            this.saldoDataGridView.HeaderText = "saldo";
            this.saldoDataGridView.Name = "saldoDataGridView";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.gD2C2012DataSet1;
            // 
            // gD2C2012DataSet1
            // 
            this.gD2C2012DataSet1.DataSetName = "GD2C2012DataSet1";
            this.gD2C2012DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 395);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoCliente";
            this.Text = "ListadoCliente";
            this.Load += new System.EventHandler(this.ListadoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private GD2C2012DataSet1 gD2C2012DataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GrouponDesktop.GD2C2012DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddirDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimientoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridView;

    }
}