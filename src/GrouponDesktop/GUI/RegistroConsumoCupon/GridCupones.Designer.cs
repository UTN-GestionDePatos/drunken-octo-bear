namespace GrouponDesktop.GUI.RegistroConsumoCupon
{
    partial class GridCupones
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
            this.dataGridCupones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCupones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCupones
            // 
            this.dataGridCupones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCupones.Location = new System.Drawing.Point(26, 55);
            this.dataGridCupones.Name = "dataGridCupones";
            this.dataGridCupones.Size = new System.Drawing.Size(463, 150);
            this.dataGridCupones.TabIndex = 0;
            this.dataGridCupones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCupones_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cupones del cliente seleccionado para canjear";
            // 
            // GridCupones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCupones);
            this.Name = "GridCupones";
            this.Text = "Cupones";
            this.Load += new System.EventHandler(this.GridCupones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCupones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCupones;
        private System.Windows.Forms.Label label1;
    }
}