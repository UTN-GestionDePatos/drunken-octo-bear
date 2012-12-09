namespace GrouponDesktop.ArmarCupon
{
    partial class ArmarCupon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescripcionCupon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LimitePorUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TextBox();
            this.PrecioReal = new System.Windows.Forms.TextBox();
            this.PrecioFicticio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListaZonas = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FechaPublicacion = new System.Windows.Forms.MonthCalendar();
            this.PublicacionAbrir = new System.Windows.Forms.Button();
            this.Publicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VencimientoCanjeCalendario = new System.Windows.Forms.MonthCalendar();
            this.VencimientoOfertaCalendario = new System.Windows.Forms.MonthCalendar();
            this.CanjeAbrir = new System.Windows.Forms.Button();
            this.OfertaAbrir = new System.Windows.Forms.Button();
            this.VencimientoCanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VencimientoOferta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescripcionCupon);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LimitePorUsuario);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Stock);
            this.groupBox1.Controls.Add(this.PrecioReal);
            this.groupBox1.Controls.Add(this.PrecioFicticio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 302);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Armar Cupón";
            // 
            // DescripcionCupon
            // 
            this.DescripcionCupon.Location = new System.Drawing.Point(217, 165);
            this.DescripcionCupon.MaxLength = 250;
            this.DescripcionCupon.Multiline = true;
            this.DescripcionCupon.Name = "DescripcionCupon";
            this.DescripcionCupon.Size = new System.Drawing.Size(209, 131);
            this.DescripcionCupon.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Descripción";
            // 
            // LimitePorUsuario
            // 
            this.LimitePorUsuario.Location = new System.Drawing.Point(217, 128);
            this.LimitePorUsuario.MaxLength = 9;
            this.LimitePorUsuario.Name = "LimitePorUsuario";
            this.LimitePorUsuario.Size = new System.Drawing.Size(209, 20);
            this.LimitePorUsuario.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Límite por usuario";
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(217, 94);
            this.Stock.MaxLength = 18;
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(209, 20);
            this.Stock.TabIndex = 20;
            // 
            // PrecioReal
            // 
            this.PrecioReal.Location = new System.Drawing.Point(217, 59);
            this.PrecioReal.MaxLength = 15;
            this.PrecioReal.Name = "PrecioReal";
            this.PrecioReal.Size = new System.Drawing.Size(209, 20);
            this.PrecioReal.TabIndex = 15;
            // 
            // PrecioFicticio
            // 
            this.PrecioFicticio.Location = new System.Drawing.Point(217, 27);
            this.PrecioFicticio.MaxLength = 15;
            this.PrecioFicticio.Name = "PrecioFicticio";
            this.PrecioFicticio.Size = new System.Drawing.Size(209, 20);
            this.PrecioFicticio.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio Real";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 34);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(73, 13);
            this.Nombre.TabIndex = 9;
            this.Nombre.Text = "Precio Ficticio";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(43, 504);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(68, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListaZonas);
            this.groupBox2.Location = new System.Drawing.Point(613, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 477);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localidades";
            // 
            // ListaZonas
            // 
            this.ListaZonas.FormattingEnabled = true;
            this.ListaZonas.Location = new System.Drawing.Point(42, 32);
            this.ListaZonas.Name = "ListaZonas";
            this.ListaZonas.Size = new System.Drawing.Size(217, 409);
            this.ListaZonas.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FechaPublicacion);
            this.groupBox3.Controls.Add(this.PublicacionAbrir);
            this.groupBox3.Controls.Add(this.Publicacion);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.VencimientoCanjeCalendario);
            this.groupBox3.Controls.Add(this.VencimientoOfertaCalendario);
            this.groupBox3.Controls.Add(this.CanjeAbrir);
            this.groupBox3.Controls.Add(this.OfertaAbrir);
            this.groupBox3.Controls.Add(this.VencimientoCanje);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.VencimientoOferta);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(43, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 171);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fechas";
            // 
            // FechaPublicacion
            // 
            this.FechaPublicacion.Location = new System.Drawing.Point(331, 17);
            this.FechaPublicacion.Name = "FechaPublicacion";
            this.FechaPublicacion.TabIndex = 11;
            this.FechaPublicacion.Visible = false;
            this.FechaPublicacion.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.FechaPublicacion_DateSelected);
            // 
            // PublicacionAbrir
            // 
            this.PublicacionAbrir.Location = new System.Drawing.Point(234, 79);
            this.PublicacionAbrir.Name = "PublicacionAbrir";
            this.PublicacionAbrir.Size = new System.Drawing.Size(75, 23);
            this.PublicacionAbrir.TabIndex = 10;
            this.PublicacionAbrir.Text = "Seleccionar";
            this.PublicacionAbrir.UseVisualStyleBackColor = true;
            this.PublicacionAbrir.Click += new System.EventHandler(this.PublicacionAbrir_Click);
            // 
            // Publicacion
            // 
            this.Publicacion.Enabled = false;
            this.Publicacion.Location = new System.Drawing.Point(128, 82);
            this.Publicacion.Name = "Publicacion";
            this.Publicacion.Size = new System.Drawing.Size(100, 20);
            this.Publicacion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Publicación:";
            // 
            // VencimientoCanjeCalendario
            // 
            this.VencimientoCanjeCalendario.Location = new System.Drawing.Point(331, 17);
            this.VencimientoCanjeCalendario.Name = "VencimientoCanjeCalendario";
            this.VencimientoCanjeCalendario.TabIndex = 7;
            this.VencimientoCanjeCalendario.Visible = false;
            this.VencimientoCanjeCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.VencimientoCanjeCalendario_DateSelected);
            // 
            // VencimientoOfertaCalendario
            // 
            this.VencimientoOfertaCalendario.Location = new System.Drawing.Point(331, 17);
            this.VencimientoOfertaCalendario.Name = "VencimientoOfertaCalendario";
            this.VencimientoOfertaCalendario.TabIndex = 6;
            this.VencimientoOfertaCalendario.Visible = false;
            this.VencimientoOfertaCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.VencimientoOfertaCalendario_DateSelected);
            // 
            // CanjeAbrir
            // 
            this.CanjeAbrir.Location = new System.Drawing.Point(234, 47);
            this.CanjeAbrir.Name = "CanjeAbrir";
            this.CanjeAbrir.Size = new System.Drawing.Size(75, 23);
            this.CanjeAbrir.TabIndex = 5;
            this.CanjeAbrir.Text = "Seleccionar";
            this.CanjeAbrir.UseVisualStyleBackColor = true;
            this.CanjeAbrir.Click += new System.EventHandler(this.CanjeAbrir_Click);
            // 
            // OfertaAbrir
            // 
            this.OfertaAbrir.Location = new System.Drawing.Point(234, 17);
            this.OfertaAbrir.Name = "OfertaAbrir";
            this.OfertaAbrir.Size = new System.Drawing.Size(75, 23);
            this.OfertaAbrir.TabIndex = 4;
            this.OfertaAbrir.Text = "Seleccionar";
            this.OfertaAbrir.UseVisualStyleBackColor = true;
            this.OfertaAbrir.Click += new System.EventHandler(this.OfertaAbrir_Click);
            // 
            // VencimientoCanje
            // 
            this.VencimientoCanje.Enabled = false;
            this.VencimientoCanje.Location = new System.Drawing.Point(128, 50);
            this.VencimientoCanje.Name = "VencimientoCanje";
            this.VencimientoCanje.Size = new System.Drawing.Size(100, 20);
            this.VencimientoCanje.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vencimiento Canje:";
            // 
            // VencimientoOferta
            // 
            this.VencimientoOferta.Enabled = false;
            this.VencimientoOferta.Location = new System.Drawing.Point(128, 17);
            this.VencimientoOferta.Name = "VencimientoOferta";
            this.VencimientoOferta.Size = new System.Drawing.Size(100, 20);
            this.VencimientoOferta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vencimiento Oferta:";
            // 
            // ArmarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ArmarCupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Armar cupón";
            this.Load += new System.EventHandler(this.ArmarCupon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LimitePorUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.TextBox PrecioReal;
        private System.Windows.Forms.TextBox PrecioFicticio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DescripcionCupon;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox ListaZonas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CanjeAbrir;
        private System.Windows.Forms.Button OfertaAbrir;
        private System.Windows.Forms.TextBox VencimientoCanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VencimientoOferta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar VencimientoOfertaCalendario;
        private System.Windows.Forms.MonthCalendar VencimientoCanjeCalendario;
        private System.Windows.Forms.MonthCalendar FechaPublicacion;
        private System.Windows.Forms.Button PublicacionAbrir;
        private System.Windows.Forms.TextBox Publicacion;
        private System.Windows.Forms.Label label1;
    }
}