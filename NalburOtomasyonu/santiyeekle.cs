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
    public partial class santiyeekle : Form
    {
        public santiyeekle()
        {
            InitializeComponent();
        }
        public bool BoslukKontrol()
        {
            txtCalisanSayi.BackColor = Color.White;
            mskBitisTarih.BackColor = Color.White;
            mskBaslamaTarih.BackColor = Color.White;
            txtIsSuresi.BackColor = Color.White;
            txtSantiyeSahip.BackColor = Color.White;
            cmbSantiyeAdres.BackColor = Color.White;


            bool bos = false;


            if (txtCalisanSayi.Text == "")
            {
                txtCalisanSayi.BackColor = Color.Red;
                txtCalisanSayi.Focus();
                bos = true;
            }
            if (mskBitisTarih.Text == "")
            {
                mskBitisTarih.BackColor = Color.Red;
                mskBitisTarih.Focus();
                bos = true;
            }

            if (mskBaslamaTarih.Text == "")
            {
                mskBaslamaTarih.BackColor = Color.Red;
                mskBaslamaTarih.Focus();
                bos = true;
            }
            if (txtIsSuresi.Text == "")
            {
                txtIsSuresi.BackColor = Color.Red;
                txtIsSuresi.Focus();
                bos = true;
            }
            if (txtSantiyeSahip.Text == "")
            {
                txtSantiyeSahip.BackColor = Color.Red;
                txtSantiyeSahip.Focus();
                bos = true;
            }
            if (cmbSantiyeAdres.Text == "Seçim Yapınız" || cmbSantiyeAdres.Text == "")
            {
                cmbSantiyeAdres.BackColor = Color.Red;
                cmbSantiyeAdres.Focus();
                bos = true;
            }
            return bos;
        }
        public void KayıtEkle()
        {
            try
            {
                Form1.BaglantıAc();

                string Sorgu = "Insert Into Santiyeler (Adresi,İşVeren,İşSüresi,BaşlangıçTarihi,TahminiBitişTarihi,ÇalışanElemanSayısı) Values (@Adresi,@İşVeren,@İşSüresi,@BaşlangıçTarihi,@TahminiBitişTarihi,@ÇalışanElemanSayısı)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Adresi", cmbSantiyeAdres.Text);
                EkleKomut.Parameters.AddWithValue("@İşVeren", txtSantiyeSahip.Text);
                EkleKomut.Parameters.AddWithValue("@İşSüresi", txtIsSuresi.Text);
                EkleKomut.Parameters.AddWithValue("@BaşlangıçTarihi", mskBaslamaTarih.Text);
                EkleKomut.Parameters.AddWithValue("@TahminiBitişTarihi", mskBitisTarih.Text);
                EkleKomut.Parameters.AddWithValue("@ÇalışanElemanSayısı", txtCalisanSayi.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("kayıt ekleme başarılı");
                }
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hatası Penceresi");

            }
        }
        private void btnstokkayitekle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtEkle();
        }
    }
}
