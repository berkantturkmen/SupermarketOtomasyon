namespace SupermarketOtomasyon
{
    partial class FrmUrunYonetimi
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
            this.lblBarkod = new System.Windows.Forms.Label();
            this.lblAltLimit = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.nudAltLimit = new System.Windows.Forms.NumericUpDown();
            this.nudStok = new System.Windows.Forms.NumericUpDown();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnAzalanlar = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(612, 16);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(414, 46);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ürün Yönetimi Paneli";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(91, 114);
            this.lblBarkod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(165, 36);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "Barkod No:";
            // 
            // lblAltLimit
            // 
            this.lblAltLimit.AutoSize = true;
            this.lblAltLimit.Location = new System.Drawing.Point(127, 398);
            this.lblAltLimit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAltLimit.Name = "lblAltLimit";
            this.lblAltLimit.Size = new System.Drawing.Size(129, 36);
            this.lblAltLimit.TabIndex = 2;
            this.lblAltLimit.Text = "Alt Limit:";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(173, 329);
            this.lblStok.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(83, 36);
            this.lblStok.TabIndex = 3;
            this.lblStok.Text = "Stok:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(162, 261);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(87, 36);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(122, 475);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(134, 36);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(114, 180);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(142, 36);
            this.lblUrunAdi.TabIndex = 6;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(264, 106);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(268, 41);
            this.txtBarkodNo.TabIndex = 7;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(263, 256);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(268, 41);
            this.txtFiyat.TabIndex = 8;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(264, 175);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(268, 41);
            this.txtUrunAdi.TabIndex = 9;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(262, 467);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(269, 44);
            this.cmbKategori.TabIndex = 10;
            // 
            // nudAltLimit
            // 
            this.nudAltLimit.Location = new System.Drawing.Point(264, 393);
            this.nudAltLimit.Name = "nudAltLimit";
            this.nudAltLimit.Size = new System.Drawing.Size(120, 41);
            this.nudAltLimit.TabIndex = 11;
            // 
            // nudStok
            // 
            this.nudStok.Location = new System.Drawing.Point(264, 324);
            this.nudStok.Name = "nudStok";
            this.nudStok.Size = new System.Drawing.Size(120, 41);
            this.nudStok.TabIndex = 12;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(611, 106);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(981, 420);
            this.dgvUrunler.TabIndex = 13;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(138, 600);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 110);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(970, 600);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(218, 110);
            this.btnYazdir.TabIndex = 15;
            this.btnYazdir.Text = "Ürün Listesini Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnAzalanlar
            // 
            this.btnAzalanlar.Location = new System.Drawing.Point(723, 600);
            this.btnAzalanlar.Name = "btnAzalanlar";
            this.btnAzalanlar.Size = new System.Drawing.Size(241, 110);
            this.btnAzalanlar.TabIndex = 16;
            this.btnAzalanlar.Text = "Alt Limit Altı Ürünleri Göster";
            this.btnAzalanlar.UseVisualStyleBackColor = true;
            this.btnAzalanlar.Click += new System.EventHandler(this.btnAzalanlar_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(499, 600);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(201, 110);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Seçili Ürünü Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(278, 600);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(200, 110);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Seçili Ürünü Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(1206, 600);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(118, 110);
            this.btnYenile.TabIndex = 19;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // FrmUrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 766);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAzalanlar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.nudStok);
            this.Controls.Add(this.nudAltLimit);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblAltLimit);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmUrunYonetimi";
            this.Text = "FrmUrunYonetimi";
            this.Load += new System.EventHandler(this.FrmUrunYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAltLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblAltLimit;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown nudAltLimit;
        private System.Windows.Forms.NumericUpDown nudStok;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnAzalanlar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYenile;
    }
}