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
    public partial class FrmUrunYonetimi : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        string kullaniciAdi;
        public FrmUrunYonetimi(string kadi)
        {
            InitializeComponent();
            kullaniciAdi = kadi;
        }

        private void FrmUrunYonetimi_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
            UrunleriListele();
        }

        private void KategorileriYukle()
        {
            cmbKategori.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT kategori_adi FROM kategori", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbKategori.Items.Add(dr.GetString("kategori_adi"));
                }
            }
        }


        private void UrunleriListele()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM urunler", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO urunler (barkod_no, urun_adi, kategori, fiyat, stok, alt_limit) VALUES (@barkod, @ad, @kategori, @fiyat, @stok, @alt)", conn);
                cmd.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
                cmd.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                cmd.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));
                cmd.Parameters.AddWithValue("@stok", (int)nudStok.Value);
                cmd.Parameters.AddWithValue("@alt", (int)nudAltLimit.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla eklendi.");
                UrunleriListele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow != null)
            {
                int secilenId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE urunler SET barkod_no=@barkod, urun_adi=@ad, kategori=@kategori, fiyat=@fiyat, stok=@stok, alt_limit=@alt WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
                    cmd.Parameters.AddWithValue("@ad", txtUrunAdi.Text);
                    cmd.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));
                    cmd.Parameters.AddWithValue("@stok", (int)nudStok.Value);
                    cmd.Parameters.AddWithValue("@alt", (int)nudAltLimit.Value);
                    cmd.Parameters.AddWithValue("@id", secilenId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün güncellendi.");
                    UrunleriListele();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow != null)
            {
                int secilenId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM urunler WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", secilenId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün silindi.");
                    UrunleriListele();
                }
            }
        }

        private void btnAzalanlar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM urunler WHERE stok < alt_limit";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString("Ürün Listesi", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new PointF(100, 20));
                int y = 60;
                foreach (DataGridViewRow row in dgvUrunler.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string line = $"ID: {row.Cells["id"].Value}, Ürün: {row.Cells["urun_adi"].Value}, Stok: {row.Cells["stok"].Value}";
                        ev.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, new PointF(50, y));
                        y += 20;
                    }
                }
            };
            PrintDialog dlg = new PrintDialog();
            dlg.Document = pd;
            if (dlg.ShowDialog() == DialogResult.OK)
                pd.Print();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUrunler.Rows[e.RowIndex];
                txtBarkodNo.Text = row.Cells["barkod_no"].Value.ToString();
                txtUrunAdi.Text = row.Cells["urun_adi"].Value.ToString();
                cmbKategori.Text = row.Cells["kategori"].Value.ToString();
                txtFiyat.Text = row.Cells["fiyat"].Value.ToString();
                nudStok.Value = Convert.ToInt32(row.Cells["stok"].Value);
                nudAltLimit.Value = Convert.ToInt32(row.Cells["alt_limit"].Value);
            }
        }
    }
}
    

