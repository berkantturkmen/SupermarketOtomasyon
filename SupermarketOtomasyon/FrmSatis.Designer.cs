namespace SupermarketOtomasyon
{
    partial class FrmSatis
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
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(472, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(211, 39);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Satış Ekranı";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(70, 93);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(134, 29);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "Barkod No:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(603, 207);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(121, 29);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "Toplam: ₺";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(137, 314);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(67, 29);
            this.lblStok.TabIndex = 3;
            this.lblStok.Text = "Stok:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(93, 264);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(111, 29);
            this.lblUrunAdi.TabIndex = 4;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(72, 363);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(132, 29);
            this.lblFiyat.TabIndex = 5;
            this.lblFiyat.Text = "Birim Fiyat:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(55, 415);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(149, 29);
            this.lblMiktar.TabIndex = 6;
            this.lblMiktar.Text = "Satış Miktarı:";
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Location = new System.Drawing.Point(210, 88);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(249, 34);
            this.txtBarkodAra.TabIndex = 7;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(250, 144);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(168, 67);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ürünü Getir";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(608, 277);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(306, 103);
            this.btnSatisYap.TabIndex = 9;
            this.btnSatisYap.Text = "Satışı Gerçekleştir ve Yazdır";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(210, 410);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(120, 34);
            this.nudMiktar.TabIndex = 10;
            this.nudMiktar.ValueChanged += new System.EventHandler(this.nudMiktar_ValueChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(958, 523);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(144, 69);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.Text = "Geri Dön";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 641);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmSatis";
            this.Text = "FrmSatis";
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Button btnCikis;
    }
}