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
    public partial class FrmYoneticiPaneli : Form
    {
        private string kullaniciAdi;
        public FrmYoneticiPaneli(string kadi)
        {
            InitializeComponent();
            kullaniciAdi = kadi;
        }

        private void FrmYoneticiPaneli_Load(object sender, EventArgs e)
        {
            lblHosgeldiniz.Text = "Hoşgeldiniz, " + kullaniciAdi;
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            FrmUrunYonetimi frm = new FrmUrunYonetimi(kullaniciAdi);
            frm.Show();
        }

        private void btnKategoriYonetimi_Click(object sender, EventArgs e)
        {
            FrmKategoriYonetimi frm = new FrmKategoriYonetimi(kullaniciAdi);
            frm.Show();
        }

        private void btnSatisRaporlari_Click(object sender, EventArgs e)
        {
            FrmSatisRaporlari frm = new FrmSatisRaporlari();
            frm.Show();
        }

        

        private void btnLoglar_Click(object sender, EventArgs e)
        {
            FrmLoglar frm = new FrmLoglar();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
