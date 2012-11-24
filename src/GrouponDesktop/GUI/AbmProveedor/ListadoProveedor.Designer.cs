namespace GrouponDesktop.GUI.AbmProveedor
{
    partial class ListadoProveedor
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
            this.CUIT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridProveedores = new System.Windows.Forms.DataGridView();
            this.viewproveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSet5 = new GrouponDesktop.GD2C2012DataSet5();
            this.proveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresDataSet = new GrouponDesktop.ProveedoresDataSet();
            this.proveedoresTableAdapter1 = new GrouponDesktop.ProveedoresDataSetTableAdapters.ProveedoresTableAdapter();
            this.viewproveedoresTableAdapter = new GrouponDesktop.GD2C2012DataSet5TableAdapters.viewproveedoresTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_socialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(333, 19);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(135, 20);
            this.CUIT.TabIndex = 26;
            this.CUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CUIT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "CUIT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CUIT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RazonSocial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.Mail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // RazonSocial
            // 
            this.RazonSocial.Location = new System.Drawing.Point(89, 19);
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Size = new System.Drawing.Size(135, 20);
            this.RazonSocial.TabIndex = 24;
            this.RazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RazonSocial_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Razón Social:";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(393, 94);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 20;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(12, 96);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 19;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(89, 61);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(135, 20);
            this.Mail.TabIndex = 19;
            this.Mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mail_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "E-Mail:";
            // 
            // dataGridProveedores
            // 
            this.dataGridProveedores.AutoGenerateColumns = false;
            this.dataGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.razon_socialDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn,
            this.nombre_contactoDataGridViewTextBoxColumn});
            this.dataGridProveedores.DataSource = this.viewproveedoresBindingSource;
            this.dataGridProveedores.Location = new System.Drawing.Point(13, 147);
            this.dataGridProveedores.Name = "dataGridProveedores";
            this.dataGridProveedores.Size = new System.Drawing.Size(495, 308);
            this.dataGridProveedores.TabIndex = 3;
            this.dataGridProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProveedor_CellClick);
            // 
            // viewproveedoresBindingSource
            // 
            this.viewproveedoresBindingSource.DataMember = "viewproveedores";
            this.viewproveedoresBindingSource.DataSource = this.gD2C2012DataSet5;
            // 
            // gD2C2012DataSet5
            // 
            this.gD2C2012DataSet5.DataSetName = "GD2C2012DataSet5";
            this.gD2C2012DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresBindingSource1
            // 
            this.proveedoresBindingSource1.DataMember = "Proveedores";
            this.proveedoresBindingSource1.DataSource = this.proveedoresDataSet;
            // 
            // proveedoresDataSet
            // 
            this.proveedoresDataSet.DataSetName = "ProveedoresDataSet";
            this.proveedoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresTableAdapter1
            // 
            this.proveedoresTableAdapter1.ClearBeforeFill = true;
            // 
            // viewproveedoresTableAdapter
            // 
            this.viewproveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            // 
            // razon_socialDataGridViewTextBoxColumn
            // 
            this.razon_socialDataGridViewTextBoxColumn.DataPropertyName = "razon_social";
            this.razon_socialDataGridViewTextBoxColumn.HeaderText = "Razón Social";
            this.razon_socialDataGridViewTextBoxColumn.Name = "razon_socialDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubroDataGridViewTextBoxColumn
            // 
            this.rubroDataGridViewTextBoxColumn.DataPropertyName = "rubro";
            this.rubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.rubroDataGridViewTextBoxColumn.Name = "rubroDataGridViewTextBoxColumn";
            this.rubroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre_contactoDataGridViewTextBoxColumn
            // 
            this.nombre_contactoDataGridViewTextBoxColumn.DataPropertyName = "nombre_contacto";
            this.nombre_contactoDataGridViewTextBoxColumn.HeaderText = "Nombre de Contacto";
            this.nombre_contactoDataGridViewTextBoxColumn.Name = "nombre_contactoDataGridViewTextBoxColumn";
            this.nombre_contactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListadoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 467);
            this.Controls.Add(this.dataGridProveedores);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoProveedor";
            this.Text = "ListadoProveedor";
            this.Load += new System.EventHandler(this.ListadoProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CUIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridProveedores;
        private ProveedoresDataSet proveedoresDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource1;
        private GrouponDesktop.ProveedoresDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter1;
        private GD2C2012DataSet5 gD2C2012DataSet5;
        private System.Windows.Forms.BindingSource viewproveedoresBindingSource;
        private GrouponDesktop.GD2C2012DataSet5TableAdapters.viewproveedoresTableAdapter viewproveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_socialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_contactoDataGridViewTextBoxColumn;
    }
}