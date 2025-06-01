namespace SupermarketOtomasyon
{
    partial class FrmYoneticiPaneli
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
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.btnLoglar = new System.Windows.Forms.Button();
            this.btnSatisRaporlari = new System.Windows.Forms.Button();
            this.btnKategoriYonetimi = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(366, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(189, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Yönetici Paneli";
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.AutoSize = true;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(617, 87);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(101, 20);
            this.lblHosgeldiniz.TabIndex = 1;
            this.lblHosgeldiniz.Text = "Hoşgeldiniz,";
            // 
            // btnUrunYonetimi
            // 
            this.btnUrunYonetimi.Location = new System.Drawing.Point(144, 222);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size = new System.Drawing.Size(149, 69);
            this.btnUrunYonetimi.TabIndex = 2;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // btnLoglar
            // 
            this.btnLoglar.Location = new System.Drawing.Point(665, 222);
            this.btnLoglar.Name = "btnLoglar";
            this.btnLoglar.Size = new System.Drawing.Size(149, 69);
            this.btnLoglar.TabIndex = 3;
            this.btnLoglar.Text = "Log Kayıtları";
            this.btnLoglar.UseVisualStyleBackColor = true;
            this.btnLoglar.Click += new System.EventHandler(this.btnLoglar_Click);
            // 
            // btnSatisRaporlari
            // 
            this.btnSatisRaporlari.Location = new System.Drawing.Point(493, 222);
            this.btnSatisRaporlari.Name = "btnSatisRaporlari";
            this.btnSatisRaporlari.Size = new System.Drawing.Size(149, 69);
            this.btnSatisRaporlari.TabIndex = 5;
            this.btnSatisRaporlari.Text = "Satış Raporları";
            this.btnSatisRaporlari.UseVisualStyleBackColor = true;
            this.btnSatisRaporlari.Click += new System.EventHandler(this.btnSatisRaporlari_Click);
            // 
            // btnKategoriYonetimi
            // 
            this.btnKategoriYonetimi.Location = new System.Drawing.Point(319, 222);
            this.btnKategoriYonetimi.Name = "btnKategoriYonetimi";
            this.btnKategoriYonetimi.Size = new System.Drawing.Size(149, 69);
            this.btnKategoriYonetimi.TabIndex = 6;
            this.btnKategoriYonetimi.Text = "Kategori Yönetimi";
            this.btnKategoriYonetimi.UseVisualStyleBackColor = true;
            this.btnKategoriYonetimi.Click += new System.EventHandler(this.btnKategoriYonetimi_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(738, 434);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(149, 69);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmYoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKategoriYonetimi);
            this.Controls.Add(this.btnSatisRaporlari);
            this.Controls.Add(this.btnLoglar);
            this.Controls.Add(this.btnUrunYonetimi);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmYoneticiPaneli";
            this.Text = "FrmYoneticiPaneli";
            this.Load += new System.EventHandler(this.FrmYoneticiPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.Button btnUrunYonetimi;
        private System.Windows.Forms.Button btnLoglar;
        private System.Windows.Forms.Button btnSatisRaporlari;
        private System.Windows.Forms.Button btnKategoriYonetimi;
        private System.Windows.Forms.Button btnCikis;
    }
}