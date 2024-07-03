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
    public partial class santiyeduzenle : Form
    {
        public santiyeduzenle()
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
        public void KayıtDuzenle()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "update Santiyeler set Adresi=@Adresi,İşVeren=@İşVeren,İşSüresi=@İşSüresi,BaşlangıçTarihi=@BaşlangıçTarihi,TahminiBitişTarihi=@TahminiBitişTarihi,ÇalışanElemanSayısı=@ÇalışanElemanSayısı where ID=@ID";
                OleDbCommand DuzenleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@Adresi", cmbSantiyeAdres.Text);
                DuzenleKomut.Parameters.AddWithValue("@İşVeren", txtSantiyeSahip.Text);
                DuzenleKomut.Parameters.AddWithValue("@İşSüresi", txtIsSuresi.Text);
                DuzenleKomut.Parameters.AddWithValue("@AdetBaşlangıçTarihiFiyatı", mskBaslamaTarih.Text);
                DuzenleKomut.Parameters.AddWithValue("@TahminiBitişTarihi", mskBitisTarih.Text);
                DuzenleKomut.Parameters.AddWithValue("@ÇalışanElemanSayısı", txtCalisanSayi.Text);
                DuzenleKomut.Parameters.AddWithValue("@ID", txtsantiyeid.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtsantiyeid.Text + " " + cmbSantiyeAdres.Text + " isimli kayıt düzenlendi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Duzenleme Hata Penceresi");

            }

        }
        private void btnsantiyeduzenle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtDuzenle();
        }
    }
}
