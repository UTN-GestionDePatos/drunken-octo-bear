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
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSetClientes = new GrouponDesktop.GD2C2012DataSetClientes();
            this.clientesTableAdapter2 = new GrouponDesktop.ClientesTableAdapters.ClientesTableAdapter();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientes = new GrouponDesktop.Clientes();
            this.clientesTableAdapter = new GrouponDesktop.GD2C2012DataSet1TableAdapters.ClientesTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSet1 = new GrouponDesktop.GD2C2012DataSet1();
            this.clientesTableAdapter1 = new GrouponDesktop.GD2C2012DataSetClientesTableAdapters.ClientesTableAdapter();
            this.gD2C2012DataSetClientesLocalidades = new GrouponDesktop.GD2C2012DataSetClientesLocalidades();
            this.gD2C2012DataSetClientesLocalidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.viewclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSet4 = new GrouponDesktop.GD2C2012DataSet4();
            this.viewclientesTableAdapter = new GrouponDesktop.GD2C2012DataSet4TableAdapters.viewclientesTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetClientesLocalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetClientesLocalidadesBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet4)).BeginInit();
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
            this.Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellido_KeyPress);
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
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(89, 63);
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
            this.Buscar.Location = new System.Drawing.Point(393, 89);
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
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(333, 59);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(135, 20);
            this.Mail.TabIndex = 19;
            this.Mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mail_KeyPress);
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
            this.usernameDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn});
            this.dataGridClientes.DataSource = this.viewclientesBindingSource;
            this.dataGridClientes.Location = new System.Drawing.Point(13, 142);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(490, 241);
            this.dataGridClientes.TabIndex = 2;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.gD2C2012DataSetClientes;
            // 
            // gD2C2012DataSetClientes
            // 
            this.gD2C2012DataSetClientes.DataSetName = "GD2C2012DataSetClientes";
            this.gD2C2012DataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter2
            // 
            this.clientesTableAdapter2.ClearBeforeFill = true;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            // 
            // clientes
            // 
            this.clientes.DataSetName = "Clientes";
            this.clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // gD2C2012DataSet1
            // 
            this.gD2C2012DataSet1.DataSetName = "GD2C2012DataSet1";
            this.gD2C2012DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // gD2C2012DataSetClientesLocalidades
            // 
            this.gD2C2012DataSetClientesLocalidades.DataSetName = "GD2C2012DataSetClientesLocalidades";
            this.gD2C2012DataSetClientesLocalidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD2C2012DataSetClientesLocalidadesBindingSource
            // 
            this.gD2C2012DataSetClientesLocalidadesBindingSource.DataSource = this.gD2C2012DataSetClientesLocalidades;
            this.gD2C2012DataSetClientesLocalidadesBindingSource.Position = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(528, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // viewclientesBindingSource
            // 
            this.viewclientesBindingSource.DataMember = "viewclientes";
            this.viewclientesBindingSource.DataSource = this.gD2C2012DataSet4;
            // 
            // gD2C2012DataSet4
            // 
            this.gD2C2012DataSet4.DataSetName = "GD2C2012DataSet4";
            this.gD2C2012DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewclientesTableAdapter
            // 
            this.viewclientesTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 403);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoCliente";
            this.Text = "ListadoCliente";
            this.Load += new System.EventHandler(this.ListadoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetClientesLocalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetClientesLocalidadesBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GrouponDesktop.ClientesTableAdapters.ClientesTableAdapter clientesTableAdapter2;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private Clientes clientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private GrouponDesktop.GD2C2012DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private GD2C2012DataSet1 gD2C2012DataSet1;
        private GD2C2012DataSetClientes gD2C2012DataSetClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private GrouponDesktop.GD2C2012DataSetClientesTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private GD2C2012DataSetClientesLocalidades gD2C2012DataSetClientesLocalidades;
        private System.Windows.Forms.BindingSource gD2C2012DataSetClientesLocalidadesBindingSource;
        private GD2C2012DataSet4 gD2C2012DataSet4;
        private System.Windows.Forms.BindingSource viewclientesBindingSource;
        private GrouponDesktop.GD2C2012DataSet4TableAdapters.viewclientesTableAdapter viewclientesTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;

    }
}