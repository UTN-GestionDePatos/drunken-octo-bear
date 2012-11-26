namespace GrouponDesktop.GUI.HistorialCupones
{
    partial class HistorialCupones
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
            this.Cupones = new System.Windows.Forms.DataGridView();
            this.gD2C2012DataSetHistorial = new GrouponDesktop.GD2C2012DataSetHistorial();
            this.viewcuponesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewcuponesTableAdapter = new GrouponDesktop.GD2C2012DataSetHistorialTableAdapters.viewcuponesTableAdapter();
            this.idcuponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promocionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cupones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcuponesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(71, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 189);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(34, 148);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(75, 23);
            this.Listar.TabIndex = 35;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // FechaHastaCalendario
            // 
            this.FechaHastaCalendario.Location = new System.Drawing.Point(250, 9);
            this.FechaHastaCalendario.Name = "FechaHastaCalendario";
            this.FechaHastaCalendario.TabIndex = 34;
            this.FechaHastaCalendario.Visible = false;
            this.FechaHastaCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.FechaHastaCalendario_DateSelected);
            // 
            // FechaDesdeCalendario
            // 
            this.FechaDesdeCalendario.Location = new System.Drawing.Point(250, -3);
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
            // Cupones
            // 
            this.Cupones.AutoGenerateColumns = false;
            this.Cupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cupones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcuponDataGridViewTextBoxColumn,
            this.promocionDataGridViewTextBoxColumn,
            this.fechacompraDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.Cupones.DataSource = this.viewcuponesBindingSource;
            this.Cupones.Location = new System.Drawing.Point(30, 238);
            this.Cupones.Name = "Cupones";
            this.Cupones.Size = new System.Drawing.Size(663, 205);
            this.Cupones.TabIndex = 34;
            // 
            // gD2C2012DataSetHistorial
            // 
            this.gD2C2012DataSetHistorial.DataSetName = "GD2C2012DataSetHistorial";
            this.gD2C2012DataSetHistorial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewcuponesBindingSource
            // 
            this.viewcuponesBindingSource.DataMember = "viewcupones";
            this.viewcuponesBindingSource.DataSource = this.gD2C2012DataSetHistorial;
            // 
            // viewcuponesTableAdapter
            // 
            this.viewcuponesTableAdapter.ClearBeforeFill = true;
            // 
            // idcuponDataGridViewTextBoxColumn
            // 
            this.idcuponDataGridViewTextBoxColumn.DataPropertyName = "id_cupon";
            this.idcuponDataGridViewTextBoxColumn.HeaderText = "ID Cupón";
            this.idcuponDataGridViewTextBoxColumn.Name = "idcuponDataGridViewTextBoxColumn";
            // 
            // promocionDataGridViewTextBoxColumn
            // 
            this.promocionDataGridViewTextBoxColumn.DataPropertyName = "promocion";
            this.promocionDataGridViewTextBoxColumn.HeaderText = "Promoción";
            this.promocionDataGridViewTextBoxColumn.Name = "promocionDataGridViewTextBoxColumn";
            this.promocionDataGridViewTextBoxColumn.ReadOnly = true;
            this.promocionDataGridViewTextBoxColumn.Width = 300;
            // 
            // fechacompraDataGridViewTextBoxColumn
            // 
            this.fechacompraDataGridViewTextBoxColumn.DataPropertyName = "fecha_compra";
            this.fechacompraDataGridViewTextBoxColumn.HeaderText = "Fecha de Compra";
            this.fechacompraDataGridViewTextBoxColumn.Name = "fechacompraDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado de Cupón";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HistorialCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 503);
            this.Controls.Add(this.Cupones);
            this.Controls.Add(this.groupBox2);
            this.Name = "HistorialCupones";
            this.Text = "HistorialCupones";
            this.Load += new System.EventHandler(this.HistorialCupones_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cupones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcuponesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.MonthCalendar FechaHastaCalendario;
        private System.Windows.Forms.MonthCalendar FechaDesdeCalendario;
        private System.Windows.Forms.Button FechaHastaAbrirCalendario;
        private System.Windows.Forms.Button FechaDesdeAbrirCalendario;
        private System.Windows.Forms.TextBox FechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Cupones;
        private GD2C2012DataSetHistorial gD2C2012DataSetHistorial;
        private System.Windows.Forms.BindingSource viewcuponesBindingSource;
        private GrouponDesktop.GD2C2012DataSetHistorialTableAdapters.viewcuponesTableAdapter viewcuponesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promocionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;



    }
}