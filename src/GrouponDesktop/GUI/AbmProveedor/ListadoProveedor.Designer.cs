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
            this.usernameDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_socialDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddirDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecontactoDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSetProveedor = new GrouponDesktop.GD2C2012DataSetProveedor();
            this.proveedoresTableAdapter = new GrouponDesktop.GD2C2012DataSetProveedorTableAdapters.ProveedoresTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // CUIT
            // 
            this.CUIT.Location = new System.Drawing.Point(333, 19);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(135, 20);
            this.CUIT.TabIndex = 26;
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
            this.groupBox1.Size = new System.Drawing.Size(496, 152);
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
            this.Buscar.Location = new System.Drawing.Point(393, 119);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 20;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(12, 119);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 19;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(89, 61);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(135, 20);
            this.Mail.TabIndex = 19;
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
            this.usernameDataGridView,
            this.cuitDataGridView,
            this.razon_socialDataGridView,
            this.mailDataGridView,
            this.telefonoDataGridView,
            this.iddirDataGridView,
            this.ciudadDataGridView,
            this.rubroDataGridView,
            this.nombrecontactoDataGridView});
            this.dataGridProveedores.DataSource = this.proveedoresBindingSource;
            this.dataGridProveedores.Location = new System.Drawing.Point(13, 171);
            this.dataGridProveedores.Name = "dataGridProveedores";
            this.dataGridProveedores.Size = new System.Drawing.Size(495, 284);
            this.dataGridProveedores.TabIndex = 3;
            this.dataGridProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProveedor_CellClick);
            // 
            // usernameDataGridView
            // 
            this.usernameDataGridView.DataPropertyName = "username";
            this.usernameDataGridView.HeaderText = "username";
            this.usernameDataGridView.Name = "usernameDataGridView";
            // 
            // cuitDataGridView
            // 
            this.cuitDataGridView.DataPropertyName = "cuit";
            this.cuitDataGridView.HeaderText = "cuit";
            this.cuitDataGridView.Name = "cuitDataGridView";
            // 
            // razon_socialDataGridView
            // 
            this.razon_socialDataGridView.DataPropertyName = "razon_social";
            this.razon_socialDataGridView.HeaderText = "razon_social";
            this.razon_socialDataGridView.Name = "razon_socialDataGridView";
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
            // ciudadDataGridView
            // 
            this.ciudadDataGridView.DataPropertyName = "ciudad";
            this.ciudadDataGridView.HeaderText = "ciudad";
            this.ciudadDataGridView.Name = "ciudadDataGridView";
            // 
            // rubroDataGridView
            // 
            this.rubroDataGridView.DataPropertyName = "rubro";
            this.rubroDataGridView.HeaderText = "rubro";
            this.rubroDataGridView.Name = "rubroDataGridView";
            // 
            // nombrecontactoDataGridView
            // 
            this.nombrecontactoDataGridView.DataPropertyName = "nombre_contacto";
            this.nombrecontactoDataGridView.HeaderText = "nombre_contacto";
            this.nombrecontactoDataGridView.Name = "nombrecontactoDataGridView";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.gD2C2012DataSetProveedor;
            // 
            // gD2C2012DataSetProveedor
            // 
            this.gD2C2012DataSetProveedor.DataSetName = "GD2C2012DataSetProveedor";
            this.gD2C2012DataSetProveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetProveedor)).EndInit();
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
        private GD2C2012DataSetProveedor gD2C2012DataSetProveedor;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private GrouponDesktop.GD2C2012DataSetProveedorTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_socialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddirDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecontactoDataGridView;
    }
}