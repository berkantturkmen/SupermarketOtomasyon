namespace SupermarketOtomasyon
{
    partial class FrmAzalanUrunler
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
            this.dgvAzalan = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAzalan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAzalan
            // 
            this.dgvAzalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAzalan.Location = new System.Drawing.Point(35, 68);
            this.dgvAzalan.Name = "dgvAzalan";
            this.dgvAzalan.RowHeadersWidth = 51;
            this.dgvAzalan.RowTemplate.Height = 24;
            this.dgvAzalan.Size = new System.Drawing.Size(1130, 507);
            this.dgvAzalan.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(956, 602);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(156, 57);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Geri Dön";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(365, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(430, 36);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Azalan (Alt Limit Altı) Ürünler";
            // 
            // FrmAzalanUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.dgvAzalan);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAzalanUrunler";
            this.Text = "FrmAzalanUrunler";
            this.Load += new System.EventHandler(this.FrmAzalanUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAzalan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAzalan;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblBaslik;
    }
}