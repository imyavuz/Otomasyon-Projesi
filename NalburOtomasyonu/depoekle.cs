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
    public partial class depoekle : Form
    {
        public depoekle()
        {
            InitializeComponent();
        }
        public bool BoslukKontrol()
        {
            mskSorumluTel.BackColor = Color.White;
            txtDepoSorumlu.BackColor = Color.White;
            txtDepoBoyut.BackColor = Color.White;
            cmbDepoAdres.BackColor = Color.White;
            txtDepoNo.BackColor = Color.White;


            bool bos = false;


            if (mskSorumluTel.Text == "(   )    -" || mskSorumluTel.Text.Length < mskSorumluTel.TextLength)
            {
                mskSorumluTel.BackColor = Color.Red;
                mskSorumluTel.Focus();
                bos = true;
            }
            if (txtDepoSorumlu.Text == "")
            {
                txtDepoSorumlu.BackColor = Color.Red;
                txtDepoSorumlu.Focus();
                bos = true;
            }

            if (txtDepoBoyut.Text == "")
            {
                txtDepoBoyut.BackColor = Color.Red;
                txtDepoBoyut.Focus();
                bos = true;
            }
            if (cmbDepoAdres.Text == "Adres Seçiniz" || cmbDepoAdres.Text == "")
            {
                cmbDepoAdres.BackColor = Color.Red;
                cmbDepoAdres.Focus();
                bos = true;
            }
            if (txtDepoNo.Text == "")
            {
                txtDepoNo.BackColor = Color.Red;
                txtDepoNo.Focus();
                bos = true;
            }

            return bos;
        }
        public void KayıtEkle1()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "Insert Into Depo (DepoNo,Adresi,Boyutu,Sorumlu,Telefon) Values (@DepoNo,@Adresi,@Boyutu,@Sorumlu,@Telefon)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@DepoNo", txtDepoNo.Text);
                EkleKomut.Parameters.AddWithValue("@Adresi", cmbDepoAdres.Text);
                EkleKomut.Parameters.AddWithValue("@Boyutu", txtDepoBoyut.Text);
                EkleKomut.Parameters.AddWithValue("@Sorumlu", txtDepoSorumlu.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", mskSorumluTel.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("kayıt ekleme başarılı");
                }
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Mesajı: " + Hata.Message, "Kayıt Ekleme Hatası");
                MessageBox.Show("Hata Ayrıntıları: " + Hata.ToString(), "Hata Ayrıntıları");
            }
        }
        private void btndepoekle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtEkle1();
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
