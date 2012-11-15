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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FechaHastaCalendario = new System.Windows.Forms.MonthCalendar();
            this.FechaDesdeCalendario = new System.Windows.Forms.MonthCalendar();
            this.FechaHastaAbrirCalendario = new System.Windows.Forms.Button();
            this.FechaDesdeAbrirCalendario = new System.Windows.Forms.Button();
            this.FechaHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Listar = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FechaHastaCalendario);
            this.groupBox2.Controls.Add(this.FechaDesdeCalendario);
            this.groupBox2.Controls.Add(this.FechaHastaAbrirCalendario);
            this.groupBox2.Controls.Add(this.FechaDesdeAbrirCalendario);
            this.groupBox2.Controls.Add(this.FechaHasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FechaDesde);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(43, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 171);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
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
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(53, 287);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(75, 23);
            this.Listar.TabIndex = 35;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // Estado
            // 
            this.Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "Comprado",
            "Entregado",
            "Devuelto"});
            this.Estado.Location = new System.Drawing.Point(214, 237);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(306, 21);
            this.Estado.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Estado Cupón";
            // 
            // HistorialCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Listar);
            this.Controls.Add(this.groupBox2);
            this.Name = "HistorialCupones";
            this.Text = "HistorialCupones";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Label label3;



    }
}