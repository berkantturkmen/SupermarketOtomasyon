namespace SupermarketOtomasyon
{
    partial class FrmPersonelPaneli
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnStokGor = new System.Windows.Forms.Button();
            this.btnAzalanUrun = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(365, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(199, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Personel Paneli";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(546, 74);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(101, 20);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Hoşgeldiniz,";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(171, 230);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(180, 79);
            this.btnSatisYap.TabIndex = 2;
            this.btnSatisYap.Text = "Satış Ekranı";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnStokGor
            // 
            this.btnStokGor.Location = new System.Drawing.Point(392, 230);
            this.btnStokGor.Name = "btnStokGor";
            this.btnStokGor.Size = new System.Drawing.Size(180, 79);
            this.btnStokGor.TabIndex = 3;
            this.btnStokGor.Text = "Stok Durumu";
            this.btnStokGor.UseVisualStyleBackColor = true;
            this.btnStokGor.Click += new System.EventHandler(this.btnStokGor_Click);
            // 
            // btnAzalanUrun
            // 
            this.btnAzalanUrun.Location = new System.Drawing.Point(618, 230);
            this.btnAzalanUrun.Name = "btnAzalanUrun";
            this.btnAzalanUrun.Size = new System.Drawing.Size(180, 79);
            this.btnAzalanUrun.TabIndex = 4;
            this.btnAzalanUrun.Text = "Azalan Ürünler";
            this.btnAzalanUrun.UseVisualStyleBackColor = true;
            this.btnAzalanUrun.Click += new System.EventHandler(this.btnAzalanUrun_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(731, 441);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(180, 79);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmPersonelPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAzalanUrun);
            this.Controls.Add(this.btnStokGor);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPersonelPaneli";
            this.Text = "FrmPersonelPaneli";
            this.Load += new System.EventHandler(this.FrmPersonelPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnStokGor;
        private System.Windows.Forms.Button btnAzalanUrun;
        private System.Windows.Forms.Button btnCikis;
    }
}