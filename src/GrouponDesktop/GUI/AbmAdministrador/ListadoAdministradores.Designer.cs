namespace GrouponDesktop.GUI.AbmAdministrador
{
    partial class ListadoAdministradores
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
            this.administradores = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.viewadministradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSetviewAdministradores = new GrouponDesktop.GD2C2012DataSetviewAdministradores();
            this.viewadministradoresTableAdapter = new GrouponDesktop.GD2C2012DataSetviewAdministradoresTableAdapters.viewadministradoresTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewadministradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetviewAdministradores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.administradores);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 226);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administradores";
            // 
            // administradores
            // 
            this.administradores.AutoGenerateColumns = false;
            this.administradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.administradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.habilitar,
            this.deshabilitar,
            this.eliminar});
            this.administradores.DataSource = this.viewadministradoresBindingSource;
            this.administradores.Location = new System.Drawing.Point(7, 20);
            this.administradores.Name = "administradores";
            this.administradores.Size = new System.Drawing.Size(755, 190);
            this.administradores.TabIndex = 0;
            this.administradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.administradores_CellClick);
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
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // habilitar
            // 
            this.habilitar.HeaderText = "Habilitar";
            this.habilitar.Name = "habilitar";
            // 
            // deshabilitar
            // 
            this.deshabilitar.HeaderText = "Deshabilitar";
            this.deshabilitar.Name = "deshabilitar";
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            // 
            // viewadministradoresBindingSource
            // 
            this.viewadministradoresBindingSource.DataMember = "viewadministradores";
            this.viewadministradoresBindingSource.DataSource = this.gD2C2012DataSetviewAdministradores;
            // 
            // gD2C2012DataSetviewAdministradores
            // 
            this.gD2C2012DataSetviewAdministradores.DataSetName = "GD2C2012DataSetviewAdministradores";
            this.gD2C2012DataSetviewAdministradores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewadministradoresTableAdapter
            // 
            this.viewadministradoresTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoAdministradores";
            this.Text = "Administradores - Listado de selección";
            this.Load += new System.EventHandler(this.BajaAdministrador_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.administradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewadministradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetviewAdministradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView administradores;
        private GD2C2012DataSetviewAdministradores gD2C2012DataSetviewAdministradores;
        private System.Windows.Forms.BindingSource viewadministradoresBindingSource;
        private GrouponDesktop.GD2C2012DataSetviewAdministradoresTableAdapters.viewadministradoresTableAdapter viewadministradoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn habilitar;
        private System.Windows.Forms.DataGridViewButtonColumn deshabilitar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}