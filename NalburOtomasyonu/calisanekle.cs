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
    public partial class calisanekle : Form
    {
        public calisanekle()
        {
            InitializeComponent();
        }


        public bool BoslukKontrol()
        {
            mskCalisanTel.BackColor = Color.White;
            txtCalisanMaas.BackColor = Color.White;
            cmbCalisanSaat.BackColor = Color.White;
            mskCalisanTarih.BackColor = Color.White;
            txtCalisanAd.BackColor = Color.White;
            txtCalisanNo.BackColor = Color.White;


            bool bos = false;


            if (mskCalisanTel.Text == "(   )    -" || mskCalisanTel.Text.Length < mskCalisanTel.TextLength)
            {
                mskCalisanTel.BackColor = Color.Red;
                mskCalisanTel.Focus();
                bos = true;
            }
            if (txtCalisanMaas.Text == "")
            {
                txtCalisanMaas.BackColor = Color.Red;
                txtCalisanMaas.Focus();
                bos = true;
            }
            if (cmbCalisanSaat.Text == "Saat Seçiniz" || cmbCalisanSaat.Text == "")
            {
                cmbCalisanSaat.BackColor = Color.Red;
                cmbCalisanSaat.Focus();
                bos = true;
            }
            if (mskCalisanTarih.Text == "  .  .")
            {
                mskCalisanTarih.BackColor = Color.Red;
                mskCalisanTarih.Focus();
                bos = true;
            }
            if (txtCalisanAd.Text == "")
            {
                txtCalisanAd.BackColor = Color.Red;
                txtCalisanAd.Focus();
                bos = true;
            }
            
            if (txtCalisanNo.Text == "")
            {
                txtCalisanNo.BackColor = Color.Red;
                txtCalisanNo.Focus();
                bos = true;
            }

            return bos;
        }
        public void KayıtEkle1()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "Insert Into Calisanlar (ÇalışanNo,AdıSoyadı,İşeBaşlamaTarihi,ÇalışmaSaatleri,Maaş,TelefonNo) Values (@ÇalışanNo,@AdıSoyadı,@İşeBaşlamaTarihi,@ÇalışmaSaatleri,Maaş,@TelefonNo)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@ÇalışanNo", txtCalisanNo.Text);
                EkleKomut.Parameters.AddWithValue("@AdıSoyadı", txtCalisanAd.Text);
                EkleKomut.Parameters.AddWithValue("@İşeBaşlamaTarihi", mskCalisanTarih.Text);
                EkleKomut.Parameters.AddWithValue("@ÇalışmaSaatleri", cmbCalisanSaat.Text);
                EkleKomut.Parameters.AddWithValue("@Maaş", txtCalisanMaas.Text);
                EkleKomut.Parameters.AddWithValue("@TelefonNo", mskCalisanTel.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("kayıt ekleme başarılı");
                }
                Form1.Baglanti.Close();
                this.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Mesajı: " + Hata.Message, "Kayıt Ekleme Hatası");
                MessageBox.Show("Hata Ayrıntıları: " + Hata.ToString(), "Hata Ayrıntıları");
            }
        }
        private void btncalisanekle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtEkle1();

        }
    }
}
