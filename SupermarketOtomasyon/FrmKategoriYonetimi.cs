using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SupermarketOtomasyon
{
    public partial class FrmKategoriYonetimi : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        public FrmKategoriYonetimi(string kullaniciAdi)
        {
            InitializeComponent();
        }

        private void FrmKategoriYonetimi_Load(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        private void KategorileriListele()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kategori", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKategoriler.DataSource = dt;
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kategori adı boş olamaz.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO kategori (kategori_adi) VALUES (@ad)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", txtKategoriAdi.Text.Trim());

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori eklendi.");
                    KategorileriListele();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("Bu kategori zaten mevcut!");
                    else
                        MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (dgvKategoriler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvKategoriler.CurrentRow.Cells["id"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM kategori WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori silindi.");
                        KategorileriListele();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        private void dgvKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtKategoriAdi.Text = dgvKategoriler.Rows[e.RowIndex].Cells["kategori_adi"].Value.ToString();
            }
        }
    }
}
