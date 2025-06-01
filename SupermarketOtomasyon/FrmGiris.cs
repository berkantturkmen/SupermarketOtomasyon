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
    public partial class FrmGiris : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kadi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM kullanicilar WHERE kullanici_adi=@kadi AND sifre=@sifre";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kadi", kadi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string rol = reader["rol"].ToString();
                    this.Hide();

                    if (rol == "Yonetici")
                        new FrmYoneticiPaneli(kadi).Show();
                    else
                        new FrmPersonelPaneli(kadi).Show();
                }
                else
                {
                    lblMesaj.Text = "Hatalı kullanıcı adı veya şifre!";
                }
            }
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayit kayit = new FrmKayit();
            this.Hide();
            kayit.Show();
        }
    }
}
