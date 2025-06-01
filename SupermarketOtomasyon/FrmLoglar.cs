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
    public partial class FrmLoglar : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        public FrmLoglar()
        {
            InitializeComponent();
        }

        private void FrmLoglar_Load(object sender, EventArgs e)
        {
            LoglariYukle();
        }

        private void LoglariYukle()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT kullanici_adi, islem_aciklamasi, tarih FROM loglar ORDER BY tarih DESC";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLoglar.DataSource = dt;
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoglariYukle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
