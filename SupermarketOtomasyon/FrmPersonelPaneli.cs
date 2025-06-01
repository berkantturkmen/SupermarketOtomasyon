using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketOtomasyon
{
    public partial class FrmPersonelPaneli : Form
    {
        private string kullaniciAdi;
        public FrmPersonelPaneli(string kadi)
        {
            InitializeComponent();
            kullaniciAdi = kadi;
        }

        private void FrmPersonelPaneli_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = "Hoşgeldiniz, " + kullaniciAdi;
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            FrmSatis satis = new FrmSatis(kullaniciAdi);
            satis.Show();
        }

        private void btnStokGor_Click(object sender, EventArgs e)
        {
            FrmStokDurumu stok = new FrmStokDurumu();
            stok.Show();
        }

        private void btnAzalanUrun_Click(object sender, EventArgs e)
        {
            FrmAzalanUrunler frm = new FrmAzalanUrunler();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
