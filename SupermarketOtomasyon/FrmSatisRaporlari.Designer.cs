namespace SupermarketOtomasyon
{
    partial class FrmSatisRaporlari
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(609, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(277, 42);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Satış Raporları";
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.Location = new System.Drawing.Point(12, 61);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(254, 32);
            this.lblTarihAraligi.TabIndex = 1;
            this.lblTarihAraligi.Text = "Tarih Aralığı Seçin:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(1113, 94);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(269, 32);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "Toplam Tutar: ₺0.00";
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(114, 129);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.RowHeadersWidth = 51;
            this.dgvSatislar.RowTemplate.Height = 24;
            this.dgvSatislar.Size = new System.Drawing.Size(1320, 529);
            this.dgvSatislar.TabIndex = 3;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(272, 55);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(388, 38);
            this.dtpBaslangic.TabIndex = 4;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(693, 55);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(388, 38);
            this.dtpBitis.TabIndex = 5;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(272, 684);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(217, 71);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Raporu Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(693, 684);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(289, 71);
            this.btnPdf.TabIndex = 7;
            this.btnPdf.Text = "PDF Olarak Kaydet";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(1320, 684);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(154, 71);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Geri Dön";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmSatisRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 781);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblTarihAraligi);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmSatisRaporlari";
            this.Text = "FrmSatisRaporlari";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnKapat;
    }
}