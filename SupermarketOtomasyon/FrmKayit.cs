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
    public partial class FrmKayit : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();

            if (ad == "" || soyad == "" || kullaniciAdi == "" || sifre == "" || rol == null)
            {
                lblMesaj.Text = "Lütfen tüm alanları doldurun!";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO kullanicilar (ad, soyad, kullanici_adi, sifre, rol) VALUES (@ad, @soyad, @kadi, @sifre, @rol)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@rol", rol);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı! Giriş ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmGiris giris = new FrmGiris();
                    this.Hide();
                    giris.Show();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        lblMesaj.Text = "Bu kullanıcı adı zaten var!";
                    else
                        lblMesaj.Text = "Hata: " + ex.Message;
                }
            }
        }

        private void linkGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            this.Hide();
            giris.Show();
        }
    }
}
