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
    public partial class toptanciekle : Form
    {
        public toptanciekle()
        {
            InitializeComponent();
        }
        public bool BoslukKontrol()
        {
            cmbToptanciAdres.BackColor = Color.White;
            mskToptanciTel.BackColor = Color.White;
            txtToptanciSahip.BackColor = Color.White;
            txtToptanciAdi.BackColor = Color.White;
            cmbtoptancituru.BackColor = Color.White;


            bool bos = false;
            if (cmbToptanciAdres.Text == "Adres Seçiniz" || cmbToptanciAdres.Text == "")
            {
                cmbToptanciAdres.BackColor = Color.Red;
                cmbToptanciAdres.Focus();
                bos = true;
            }
            
            if (mskToptanciTel.Text == "(   )    -" || mskToptanciTel.Text.Length < mskToptanciTel.TextLength)
            {
                mskToptanciTel.BackColor = Color.Red;
                mskToptanciTel.Focus();
                bos = true;
            }
            if (txtToptanciSahip.Text == "")
            {
                txtToptanciSahip.BackColor = Color.Red;
                txtToptanciSahip.Focus();
                bos = true;
            }
            if (txtToptanciAdi.Text == "")
            {
                txtToptanciAdi.BackColor = Color.Red;
                txtToptanciAdi.Focus();
                bos = true;
            }

            if (cmbtoptancituru.Text == "Türü Seçiniz" || cmbtoptancituru.Text == "")
            {
                cmbtoptancituru.BackColor = Color.Red;
                cmbtoptancituru.Focus();
                bos = true;
            }

            return bos;
        }
        public void KayıtEkle1()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "Insert Into Toptanci (Türü,Adı,Sahibi,Telefon,Adresi) Values (@Türü,@Adı,@Sahibi,@Telefon,@Adresi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Türü", cmbtoptancituru.Text);
                EkleKomut.Parameters.AddWithValue("@Adı", txtToptanciAdi.Text);
                EkleKomut.Parameters.AddWithValue("@Sahibi", txtToptanciSahip.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", mskToptanciTel.Text);
                EkleKomut.Parameters.AddWithValue("@Adresi", cmbToptanciAdres.Text);
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
        }
    }
}
