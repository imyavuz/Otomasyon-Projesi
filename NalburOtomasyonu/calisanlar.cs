using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NalburOtomasyonu
{
    public partial class calisanlar : Form
    {
        public calisanlar()
        {
            InitializeComponent();
        }
        public void kayıtLısteleme()
        {
            try
            {
                Form1.BaglantıAc();
                DataSet ds = new DataSet();
                String Sorgu = "Select * from Calisanlar";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Form1.Baglanti);
                da.Fill(ds, "Calisanlar");
                dataGridView1.DataSource = ds.Tables["Calisanlar"];
                Form1.BaglantıKapat();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calisanlar_Load(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void btnCalisanListele_Click(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            calisanekle frmcalisanekle = new calisanekle();
            frmcalisanekle.ShowDialog();
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            calisansil frmcalisansil = new calisansil();
            frmcalisansil.txtCalisanSilId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmcalisansil.txtCalisanSilAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmcalisansil.txtCalisanSilNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmcalisansil.ShowDialog();
        }

        private void btnCalisanDuzenle_Click(object sender, EventArgs e)
        {
            calisanduzenle frmcalisanduzenle = new calisanduzenle();
            frmcalisanduzenle.txtCalisanId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmcalisanduzenle.txtCalisanNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmcalisanduzenle.txtCalisanAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmcalisanduzenle.mskCalisanTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmcalisanduzenle.cmbCalisanSaat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmcalisanduzenle.txtCalisanMaas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmcalisanduzenle.mskCalisanTel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmcalisanduzenle.ShowDialog();
            
            kayıtLısteleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
