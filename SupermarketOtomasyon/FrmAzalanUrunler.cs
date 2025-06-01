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
    public partial class FrmAzalanUrunler : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        public FrmAzalanUrunler()
        {
            InitializeComponent();
        }

        private void FrmAzalanUrunler_Load(object sender, EventArgs e)
        {
            ListeleAzalan();
        }

        private void ListeleAzalan()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT urun_adi, kategori, stok, alt_limit FROM urunler WHERE stok < alt_limit";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAzalan.DataSource = dt;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
