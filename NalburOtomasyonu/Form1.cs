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
    public partial class Form1 : Form
    {
        public Form1()
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


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Nalbur Otomasyonu - Kürşat Yavuz YILMAZ";
        }


        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calisanlar frmcalisanlar = new calisanlar();
            frmcalisanlar.ShowDialog();
        }

        private void stokİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiyat frmfiyat = new fiyat();
            frmfiyat.ShowDialog();
        }

        private void depoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depo frmdepo = new Depo();
            frmdepo.ShowDialog();
        }

        private void fiyatListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fiyat frmfiyat = new fiyat();
            frmfiyat.ShowDialog();
        }

        private void şantiyelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            santiyeler frmsantiye = new santiyeler();
            frmsantiye.ShowDialog();
        }

        private void toptancılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toptanci frmtoptanci = new toptanci();
            frmtoptanci.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satis frmsatis = new satis();
            frmsatis.ShowDialog();
        }

    }
}
