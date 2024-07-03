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
    public partial class toptancisil : Form
    {
        public toptancisil()
        {
            InitializeComponent();
        }
        public void KayitSil()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "Delete from Toptanci where ID=" + txttoptanciid.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txttoptanciid.Text + "Kayıt Silindi", "Uyarı");
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");

            }
        }
        private void btntoptancisil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txttoptanciid.Text + " Nolu Kayıt Silinecek!\nOnaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)
                KayitSil();
            else
                MessageBox.Show("Silme işlemi iptal edildi", "Uyarı");
        }
    }
}
