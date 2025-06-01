using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace SupermarketOtomasyon
{
    public partial class FrmSatisRaporlari : Form
    {
        string connectionString = "Server=localhost;Database=supermarket_otomasyonu;Uid=root;Pwd=porola12;";
        DataTable raporTablosu;
        public FrmSatisRaporlari()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT s.id, u.urun_adi, s.miktar, s.toplam_fiyat, s.tarih, s.satis_yapan
                                 FROM satislar s
                                 INNER JOIN urunler u ON s.urun_id = u.id
                                 WHERE s.tarih BETWEEN @baslangic AND @bitis";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@baslangic", dtpBaslangic.Value);
                cmd.Parameters.AddWithValue("@bitis", dtpBitis.Value);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                raporTablosu = new DataTable();
                da.Fill(raporTablosu);
                dgvSatislar.DataSource = raporTablosu;

                decimal toplam = 0;
                foreach (DataRow row in raporTablosu.Rows)
                {
                    toplam += Convert.ToDecimal(row["toplam_fiyat"]);
                }
                lblToplamTutar.Text = "Toplam Tutar: ₺" + toplam.ToString("0.00");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (raporTablosu == null || raporTablosu.Rows.Count == 0)
            {
                MessageBox.Show("Önce rapor oluşturun.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Dosyası|*.pdf";
            sfd.FileName = "SatisRaporu.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document pdfDoc = new Document();
                PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                pdfDoc.Open();

                pdfDoc.Add(new Paragraph("SÜPERMARKET SATIŞ RAPORU"));
                pdfDoc.Add(new Paragraph("Tarih: " + DateTime.Now.ToString()));
                pdfDoc.Add(new Paragraph("Tarih Aralığı: " + dtpBaslangic.Value.ToShortDateString() + " - " + dtpBitis.Value.ToShortDateString()));
                pdfDoc.Add(new Paragraph("-----------------------------------------------------"));

                PdfPTable table = new PdfPTable(raporTablosu.Columns.Count);
                foreach (DataColumn col in raporTablosu.Columns)
                {
                    table.AddCell(col.ColumnName);
                }

                foreach (DataRow row in raporTablosu.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        table.AddCell(item.ToString());
                    }
                }

                pdfDoc.Add(table);
                pdfDoc.Close();
                MessageBox.Show("PDF başarıyla oluşturuldu.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
