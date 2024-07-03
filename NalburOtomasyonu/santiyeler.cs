using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NalburOtomasyonu
{
    public partial class santiyeler : Form
    {
        public santiyeler()
        {
            InitializeComponent();
        }
        public static OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");
        public static void BaglantıAc()
        {
            try
            {
                Baglanti.Open();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Acma Hata Penceresi");

            }
        }
        public static void BaglantıKapat()
        {
            try
            {
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Acma Hata Penceresi");

            }
        }
        public void kayıtLısteleme()
        {
            try
            {
                BaglantıAc();
                DataSet ds = new DataSet();
                String Sorgu = "Select * from Santiyeler";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Santiyeler");
                dataGridView1.DataSource = ds.Tables["Santiyeler"];
                BaglantıKapat();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");

            }
        }
        private void santiyeler_Load(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void şantiyelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void şantiyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            santiyeekle frmsantiyeekle = new santiyeekle();
            frmsantiyeekle.ShowDialog();
        }

        private void şantiyeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            santiyesil frmsantiyesil = new santiyesil();
            frmsantiyesil.txtSantiyeSilId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsantiyesil.txtSantiyeSilAdresi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsantiyesil.txtSantiyeSahip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsantiyesil.ShowDialog();
        }

        private void şantiyeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            santiyeduzenle frmsantiyeduzenle = new santiyeduzenle();
            frmsantiyeduzenle.txtsantiyeid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmsantiyeduzenle.cmbSantiyeAdres.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmsantiyeduzenle.txtSantiyeSahip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmsantiyeduzenle.txtIsSuresi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmsantiyeduzenle.mskBaslamaTarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmsantiyeduzenle.mskBitisTarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmsantiyeduzenle.txtCalisanSayi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmsantiyeduzenle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
