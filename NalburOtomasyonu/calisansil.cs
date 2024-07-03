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
    public partial class calisansil : Form
    {
        public calisansil()
        {
            InitializeComponent();
        }
        public void KayitSil()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "Delete from Calisanlar where ID=" + txtCalisanSilId.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtCalisanSilId.Text + "Kayıt Silindi", "Uyarı");
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");

            }
        }
        private void btncalisansil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtCalisanSilId.Text + " Nolu Kayıt Silinecek!\nOnaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)
                KayitSil();

            else
                MessageBox.Show("Silme işlemi iptal edildi", "Uyarı");
        }
    }
}
