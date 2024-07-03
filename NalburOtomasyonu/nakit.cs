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
    public partial class nakit : Form
    {
        public nakit()
        {
            InitializeComponent();
        }

        public bool BoslukKontrol()
        {
            mskSatisTarih.BackColor = Color.White;
            txtSatisNo.BackColor = Color.White;
            nakiturunadi.BackColor = Color.White;
            nakitadet.BackColor = Color.White;
            nakitbirimfiyat.BackColor = Color.White;
            nakittoplamfiyat.BackColor = Color.White;
            nakitstsgrv.BackColor = Color.White;


            bool bos = false;


            if (mskSatisTarih.Text == "  .  .")
            {
                mskSatisTarih.BackColor = Color.Red;
                mskSatisTarih.Focus();
                bos = true;
            }
            if (txtSatisNo.Text == "")
            {
                txtSatisNo.BackColor = Color.Red;
                txtSatisNo.Focus();
                bos = true;
            }

            if (nakiturunadi.Text == "")
            {
                nakiturunadi.BackColor = Color.Red;
                nakiturunadi.Focus();
                bos = true;
            }
            if (nakitadet.Text == "")
            {
                nakitadet.BackColor = Color.Red;
                nakitadet.Focus();
                bos = true;
            }
            if (nakitbirimfiyat.Text == "")
            {
                nakitbirimfiyat.BackColor = Color.Red;
                nakitbirimfiyat.Focus();
                bos = true;
            }
            if (nakittoplamfiyat.Text == "")
            {
                nakittoplamfiyat.BackColor = Color.Red;
                nakittoplamfiyat.Focus();
                bos = true;
            }
            if (nakitstsgrv.Text == "")
            {
                nakitstsgrv.BackColor = Color.Red;
                nakitstsgrv.Focus();
                bos = true;
            }

            return bos;
        }
        public void KayıtEkle1()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "Insert Into Nakit (SatışNo,SatisTarihi,ÜrünAdi,ÜrünMiktari,BirimFiyatı,ToplamFiyatı,SatışGörevlisi) Values (@SatışNo,@SatisTarihi,@ÜrünAdi,@ÜrünMiktari,@BirimFiyatı,@ToplamFiyatı,@SatışGörevlisi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@SatışNo", txtSatisNo.Text);
                EkleKomut.Parameters.AddWithValue("@SatisTarihi", mskSatisTarih.Text);
                EkleKomut.Parameters.AddWithValue("@ÜrünAdi", nakiturunadi.Text);
                EkleKomut.Parameters.AddWithValue("@ÜrünMiktari", nakitadet.Text);
                EkleKomut.Parameters.AddWithValue("@BirimFiyatı", nakitbirimfiyat.Text);
                EkleKomut.Parameters.AddWithValue("@ToplamFiyatı", nakittoplamfiyat.Text);
                EkleKomut.Parameters.AddWithValue("@SatışGörevlisi", nakitstsgrv.Text);
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

        private void mskCalisanTarih_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nakitsatis_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtEkle1();
            this.Close();
        }
    }
}
