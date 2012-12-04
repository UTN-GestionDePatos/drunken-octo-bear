namespace GrouponDesktop.GUI.FacturarProveedor
{
    partial class FacturacionProveedor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Listar = new System.Windows.Forms.Button();
            this.FechaHastaCalendario = new System.Windows.Forms.MonthCalendar();
            this.FechaDesdeCalendario = new System.Windows.Forms.MonthCalendar();
            this.FechaHastaAbrirCalendario = new System.Windows.Forms.Button();
            this.FechaDesdeAbrirCalendario = new System.Windows.Forms.Button();
            this.FechaHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCupones = new System.Windows.Forms.DataGridView();
            this.idcuponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuponesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSet3 = new GrouponDesktop.GD2C2012DataSet3();
            this.Facturar = new System.Windows.Forms.Button();
            this.cuponesTableAdapter = new GrouponDesktop.GD2C2012DataSet3TableAdapters.CuponesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCupones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proveedores);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturación";
            // 
            // proveedores
            // 
            this.proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedores.FormattingEnabled = true;
            this.proveedores.Location = new System.Drawing.Point(89, 24);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(157, 21);
            this.proveedores.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Proveedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Listar);
            this.groupBox2.Controls.Add(this.FechaHastaCalendario);
            this.groupBox2.Controls.Add(this.FechaDesdeCalendario);
            this.groupBox2.Controls.Add(this.FechaHastaAbrirCalendario);
            this.groupBox2.Controls.Add(this.FechaDesdeAbrirCalendario);
            this.groupBox2.Controls.Add(this.FechaHasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FechaDesde);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 171);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(12, 135);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(75, 23);
            this.Listar.TabIndex = 35;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // FechaHastaCalendario
            // 
            this.FechaHastaCalendario.Location = new System.Drawing.Point(279, 9);
            this.FechaHastaCalendario.Name = "FechaHastaCalendario";
            this.FechaHastaCalendario.TabIndex = 34;
            this.FechaHastaCalendario.Visible = false;
            this.FechaHastaCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.FechaHastaCalendario_DateSelected);
            // 
            // FechaDesdeCalendario
            // 
            this.FechaDesdeCalendario.Location = new System.Drawing.Point(279, -3);
            this.FechaDesdeCalendario.Name = "FechaDesdeCalendario";
            this.FechaDesdeCalendario.TabIndex = 33;
            this.FechaDesdeCalendario.Visible = false;
            this.FechaDesdeCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.FechaDesdeCalendario_DateSelected);
            // 
            // FechaHastaAbrirCalendario
            // 
            this.FechaHastaAbrirCalendario.Location = new System.Drawing.Point(171, 46);
            this.FechaHastaAbrirCalendario.Name = "FechaHastaAbrirCalendario";
            this.FechaHastaAbrirCalendario.Size = new System.Drawing.Size(75, 23);
            this.FechaHastaAbrirCalendario.TabIndex = 5;
            this.FechaHastaAbrirCalendario.Text = "Seleccionar";
            this.FechaHastaAbrirCalendario.UseVisualStyleBackColor = true;
            this.FechaHastaAbrirCalendario.Click += new System.EventHandler(this.FechaHastaAbrirCalendario_Click);
            // 
            // FechaDesdeAbrirCalendario
            // 
            this.FechaDesdeAbrirCalendario.Location = new System.Drawing.Point(171, 17);
            this.FechaDesdeAbrirCalendario.Name = "FechaDesdeAbrirCalendario";
            this.FechaDesdeAbrirCalendario.Size = new System.Drawing.Size(75, 23);
            this.FechaDesdeAbrirCalendario.TabIndex = 4;
            this.FechaDesdeAbrirCalendario.Text = "Seleccionar";
            this.FechaDesdeAbrirCalendario.UseVisualStyleBackColor = true;
            this.FechaDesdeAbrirCalendario.Click += new System.EventHandler(this.FechaDesdeAbrirCalendario_Click);
            // 
            // FechaHasta
            // 
            this.FechaHasta.Enabled = false;
            this.FechaHasta.Location = new System.Drawing.Point(55, 50);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(100, 20);
            this.FechaHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // FechaDesde
            // 
            this.FechaDesde.Enabled = false;
            this.FechaDesde.Location = new System.Drawing.Point(55, 17);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.Size = new System.Drawing.Size(100, 20);
            this.FechaDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // dataGridCupones
            // 
            this.dataGridCupones.AutoGenerateColumns = false;
            this.dataGridCupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCupones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcuponDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.fechacompraDataGridViewTextBoxColumn,
            this.fechacanjeDataGridViewTextBoxColumn});
            this.dataGridCupones.DataSource = this.cuponesBindingSource;
            this.dataGridCupones.Location = new System.Drawing.Point(13, 278);
            this.dataGridCupones.Name = "dataGridCupones";
            this.dataGridCupones.ReadOnly = true;
            this.dataGridCupones.Size = new System.Drawing.Size(505, 150);
            this.dataGridCupones.TabIndex = 33;
            // 
            // idcuponDataGridViewTextBoxColumn
            // 
            this.idcuponDataGridViewTextBoxColumn.DataPropertyName = "id_cupon";
            this.idcuponDataGridViewTextBoxColumn.HeaderText = "ID Cupón";
            this.idcuponDataGridViewTextBoxColumn.Name = "idcuponDataGridViewTextBoxColumn";
            this.idcuponDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechacompraDataGridViewTextBoxColumn
            // 
            this.fechacompraDataGridViewTextBoxColumn.DataPropertyName = "fecha_compra";
            this.fechacompraDataGridViewTextBoxColumn.HeaderText = "Fecha de Compra";
            this.fechacompraDataGridViewTextBoxColumn.Name = "fechacompraDataGridViewTextBoxColumn";
            this.fechacompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechacompraDataGridViewTextBoxColumn.Width = 130;
            // 
            // fechacanjeDataGridViewTextBoxColumn
            // 
            this.fechacanjeDataGridViewTextBoxColumn.DataPropertyName = "fecha_canje";
            this.fechacanjeDataGridViewTextBoxColumn.HeaderText = "Fecha de Canje";
            this.fechacanjeDataGridViewTextBoxColumn.Name = "fechacanjeDataGridViewTextBoxColumn";
            this.fechacanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechacanjeDataGridViewTextBoxColumn.Width = 130;
            // 
            // cuponesBindingSource
            // 
            this.cuponesBindingSource.DataMember = "Cupones";
            this.cuponesBindingSource.DataSource = this.gD2C2012DataSet3;
            // 
            // gD2C2012DataSet3
            // 
            this.gD2C2012DataSet3.DataSetName = "GD2C2012DataSet3";
            this.gD2C2012DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Facturar
            // 
            this.Facturar.Location = new System.Drawing.Point(24, 438);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(75, 23);
            this.Facturar.TabIndex = 34;
            this.Facturar.Text = "Facturar";
            this.Facturar.UseVisualStyleBackColor = true;
            this.Facturar.Click += new System.EventHandler(this.Facturar_Click);
            // 
            // cuponesTableAdapter
            // 
            this.cuponesTableAdapter.ClearBeforeFill = true;
            // 
            // FacturacionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 473);
            this.Controls.Add(this.Facturar);
            this.Controls.Add(this.dataGridCupones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FacturacionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar a Proveedor";
            this.Load += new System.EventHandler(this.FacturacionProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCupones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox proveedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FechaHastaAbrirCalendario;
        private System.Windows.Forms.Button FechaDesdeAbrirCalendario;
        private System.Windows.Forms.TextBox FechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar FechaDesdeCalendario;
        private System.Windows.Forms.MonthCalendar FechaHastaCalendario;
        private System.Windows.Forms.DataGridView dataGridCupones;
        private GD2C2012DataSet3 gD2C2012DataSet3;
        private System.Windows.Forms.BindingSource cuponesBindingSource;
        private GrouponDesktop.GD2C2012DataSet3TableAdapters.CuponesTableAdapter cuponesTableAdapter;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.Button Facturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacanjeDataGridViewTextBoxColumn;
    }
}