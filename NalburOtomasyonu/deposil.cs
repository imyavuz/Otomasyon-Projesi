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
    public partial class deposil : Form
    {
        public deposil()
        {
            InitializeComponent();
        }
        public void KayitSil()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "Delete from Depo where ID=" + txtDepoSilID.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtDepoSilID.Text + "Kayıt Silindi", "Uyarı");
                Form1.Baglanti.Close();
                this.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");

            }
        }
        private void btnstokkayitsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtDepoSilID.Text + " Nolu Kayıt Silinecek!\nOnaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)
                KayitSil();

            else
                MessageBox.Show("Silme işlemi iptal edildi", "Uyarı");
        }
    }
}
