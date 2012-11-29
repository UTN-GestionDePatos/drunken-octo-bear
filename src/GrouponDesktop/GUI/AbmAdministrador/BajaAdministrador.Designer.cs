namespace GrouponDesktop.GUI.AbmAdministrador
{
    partial class BajaAdministrador
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
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.administradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSetAdministradores = new GrouponDesktop.GD2C2012DataSetAdministradores();
            this.administradoresTableAdapter = new GrouponDesktop.GD2C2012DataSetAdministradoresTableAdapters.AdministradoresTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetAdministradores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.administradores);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 226);
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
            this.eliminar});
            this.administradores.DataSource = this.administradoresBindingSource;
            this.administradores.Location = new System.Drawing.Point(7, 20);
            this.administradores.Name = "administradores";
            this.administradores.Size = new System.Drawing.Size(454, 190);
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
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            // 
            // administradoresBindingSource
            // 
            this.administradoresBindingSource.DataMember = "Administradores";
            this.administradoresBindingSource.DataSource = this.gD2C2012DataSetAdministradores;
            // 
            // gD2C2012DataSetAdministradores
            // 
            this.gD2C2012DataSetAdministradores.DataSetName = "GD2C2012DataSetAdministradores";
            this.gD2C2012DataSetAdministradores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administradoresTableAdapter
            // 
            this.administradoresTableAdapter.ClearBeforeFill = true;
            // 
            // BajaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "BajaAdministrador";
            this.Text = "Baja Administrador";
            this.Load += new System.EventHandler(this.BajaAdministrador_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.administradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSetAdministradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView administradores;
        private GD2C2012DataSetAdministradores gD2C2012DataSetAdministradores;
        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private GrouponDesktop.GD2C2012DataSetAdministradoresTableAdapters.AdministradoresTableAdapter administradoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}