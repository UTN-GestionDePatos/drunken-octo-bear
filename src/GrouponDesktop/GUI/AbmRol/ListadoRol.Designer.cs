﻿namespace GrouponDesktop.GUI.AbmRol
{
    partial class ListadoRol
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
            this.AltaRol = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2012DataSet8 = new GrouponDesktop.GD2C2012DataSet8();
            this.rolesTableAdapter = new GrouponDesktop.GD2C2012DataSet8TableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // AltaRol
            // 
            this.AltaRol.Location = new System.Drawing.Point(12, 186);
            this.AltaRol.Name = "AltaRol";
            this.AltaRol.Size = new System.Drawing.Size(69, 24);
            this.AltaRol.TabIndex = 2;
            this.AltaRol.Text = "Alta Rol";
            this.AltaRol.UseVisualStyleBackColor = true;
            this.AltaRol.Click += new System.EventHandler(this.AltaRol_Click);
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.AutoGenerateColumns = false;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Modificar,
            this.Borrar});
            this.Datos.DataSource = this.rolesBindingSource;
            this.Datos.Location = new System.Drawing.Point(12, 12);
            this.Datos.MultiSelect = false;
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(365, 168);
            this.Datos.TabIndex = 1;
            this.Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Width = 60;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Text = "Borar";
            this.Borrar.Width = 60;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.gD2C2012DataSet8;
            // 
            // gD2C2012DataSet8
            // 
            this.gD2C2012DataSet8.DataSetName = "GD2C2012DataSet8";
            this.gD2C2012DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 217);
            this.Controls.Add(this.AltaRol);
            this.Controls.Add(this.Datos);
            this.Name = "ListadoRol";
            this.Text = "Rol - Listado de selección";
            this.Load += new System.EventHandler(this.ListadoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2012DataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AltaRol;
        private System.Windows.Forms.DataGridView Datos;
        private GD2C2012DataSet8 gD2C2012DataSet8;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private GrouponDesktop.GD2C2012DataSet8TableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}