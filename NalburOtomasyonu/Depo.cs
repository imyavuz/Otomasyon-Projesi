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
    public partial class Depo : Form
    {
        public Depo()
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
                String Sorgu = "Select * from Depo";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Depo");
                dataGridView1.DataSource = ds.Tables["Depo"];
                BaglantıKapat();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Depo_Load(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void depoliste_Click(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void depoekle_Click(object sender, EventArgs e)
        {
            depoekle frmdepoekle = new depoekle();
            frmdepoekle.ShowDialog();
        }

        private void deposil_Click(object sender, EventArgs e)
        {
            deposil frmdeposil = new deposil();
            frmdeposil.txtDepoSilID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdeposil.txtDepoSilNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdeposil.ShowDialog();
        }

        private void depoduzenle_Click(object sender, EventArgs e)
        {
            depoduzenle frmdepoduzenle = new depoduzenle();
            frmdepoduzenle.txtDepoID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmdepoduzenle.txtDepoNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmdepoduzenle.cmbDepoAdres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmdepoduzenle.txtDepoBoyut.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmdepoduzenle.txtDepoSorumlu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmdepoduzenle.mskSorumluTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmdepoduzenle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
