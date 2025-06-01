using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace SupermarketOtomasyon
{
    public partial class FrmSatis : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        string kullaniciAdi;
        int urunId = 0;
        string urunAdi = "";
        decimal fiyat = 0;
        int mevcutStok = 0;
        decimal toplamTutar = 0;
        public FrmSatis(string kadi)
        {
            InitializeComponent();
            kullaniciAdi = kadi;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM urunler WHERE barkod_no=@barkod";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@barkod", txtBarkodAra.Text.Trim());
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    urunId = Convert.ToInt32(dr["id"]);
                    urunAdi = dr["urun_adi"].ToString();
                    fiyat = Convert.ToDecimal(dr["fiyat"]);
                    mevcutStok = Convert.ToInt32(dr["stok"]);

                    lblUrunAdi.Text = "Ürün Adı: " + urunAdi;
                    lblFiyat.Text = "Birim Fiyat: ₺" + fiyat.ToString("0.00");
                    lblStok.Text = "Stok: " + mevcutStok;
                    lblToplam.Text = "Toplam: ₺0.00";
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı.");
                }
            }
        }

        private void nudMiktar_ValueChanged(object sender, EventArgs e)
        {
            toplamTutar = fiyat * nudMiktar.Value;
            lblToplam.Text = "Toplam: ₺" + toplamTutar.ToString("0.00");
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            int miktar = (int)nudMiktar.Value;

            if (urunId == 0 || miktar == 0)
            {
                MessageBox.Show("Lütfen önce bir ürün seçin ve miktar girin.");
                return;
            }

            if (miktar > mevcutStok)
            {
                MessageBox.Show("Yetersiz stok!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // 1. Satış tablosuna ekle
                string insertQuery = "INSERT INTO satislar (urun_id, miktar, toplam_fiyat, tarih, satis_yapan) VALUES (@uid, @miktar, @toplam, @tarih, @satan)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@uid", urunId);
                insertCmd.Parameters.AddWithValue("@miktar", miktar);
                insertCmd.Parameters.AddWithValue("@toplam", toplamTutar);
                insertCmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                insertCmd.Parameters.AddWithValue("@satan", kullaniciAdi);
                insertCmd.ExecuteNonQuery();

                // 2. Stok düş
                string updateQuery = "UPDATE urunler SET stok = stok - @miktar WHERE id = @uid";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@uid", urunId);
                updateCmd.Parameters.AddWithValue("@miktar", miktar);
                updateCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Satış başarıyla yapıldı. Fiş yazdırılıyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fiş yazdır
            YazdirFiş();

            // Temizle
            urunId = 0;
            txtBarkodAra.Clear();
            lblUrunAdi.Text = "Ürün Adı:";
            lblFiyat.Text = "Birim Fiyat:";
            lblStok.Text = "Stok:";
            lblToplam.Text = "Toplam: ₺0.00";
            nudMiktar.Value = 0;
        }

        private void YazdirFiş()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString("---- Süpermarket Satış Fişi ----", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(10, 20));
                ev.Graphics.DrawString($"Tarih: {DateTime.Now}", new Font("Arial", 10), Brushes.Black, new PointF(10, 60));
                ev.Graphics.DrawString($"Ürün: {urunAdi}", new Font("Arial", 10), Brushes.Black, new PointF(10, 80));
                ev.Graphics.DrawString($"Adet: {nudMiktar.Value}", new Font("Arial", 10), Brushes.Black, new PointF(10, 100));
                ev.Graphics.DrawString($"Toplam: ₺{toplamTutar:0.00}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new PointF(10, 120));
                ev.Graphics.DrawString("------------------------------", new Font("Arial", 10), Brushes.Black, new PointF(10, 150));
                ev.Graphics.DrawString($"Satışı Yapan: {kullaniciAdi}", new Font("Arial", 8), Brushes.Gray, new PointF(10, 170));
            };

            PrintDialog dlg = new PrintDialog();
            dlg.Document = pd;
            if (dlg.ShowDialog() == DialogResult.OK)
                pd.Print();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
