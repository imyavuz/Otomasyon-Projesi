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
    public partial class nakitduzenle : Form
    {
        public nakitduzenle()
        {
            InitializeComponent();
        }

        public bool BoslukKontrol()
        {
            nktdznno.BackColor = Color.White;
            nktdzntarih.BackColor = Color.White;
            nktdznadi.BackColor = Color.White;
            nktdznadet.BackColor = Color.White;
            nktdznbrm.BackColor = Color.White;
            nktdzntplm.BackColor = Color.White;
            nktdzngrv.BackColor = Color.White;


            bool bos = false;


            if (nktdzntarih.Text == "  .  .")
            {
                nktdzntarih.BackColor = Color.Red;
                nktdzntarih.Focus();
                bos = true;
            }
            if (nktdznno.Text == "")
            {
                nktdznno.BackColor = Color.Red;
                nktdznno.Focus();
                bos = true;
            }

            if (nktdznadi.Text == "")
            {
                nktdznadi.BackColor = Color.Red;
                nktdznadi.Focus();
                bos = true;
            }
            if (nktdznadet.Text == "")
            {
                nktdznadet.BackColor = Color.Red;
                nktdznadet.Focus();
                bos = true;
            }
            if (nktdznbrm.Text == "")
            {
                nktdznbrm.BackColor = Color.Red;
                nktdznbrm.Focus();
                bos = true;
            }
            if (nktdzntplm.Text == "")
            {
                nktdzntplm.BackColor = Color.Red;
                nktdzntplm.Focus();
                bos = true;
            }
            if (nktdzngrv.Text == "")
            {
                nktdzngrv.BackColor = Color.Red;
                nktdzngrv.Focus();
                bos = true;
            }

            return bos;
        }

        public void KayıtDuzenle()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "update Nakit set SatışNo=@SatışNo,SatisTarihi=@SatisTarihi,ÜrünAdi=@ÜrünAdi,ÜrünMiktari=@ÜrünMiktari,BirimFiyatı=@BirimFiyatı,ToplamFiyatı=@ToplamFiyatı,SatışGörevlisi=@SatışGörevlisi where ID=@ID";
                OleDbCommand DuzenleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@SatışNo", nktdznno.Text);
                DuzenleKomut.Parameters.AddWithValue("@SatisTarihi", nktdzntarih.Text);
                DuzenleKomut.Parameters.AddWithValue("@ÜrünAdi", nktdznadi.Text);
                DuzenleKomut.Parameters.AddWithValue("@ÜrünMiktari", nktdznadet.Text);
                DuzenleKomut.Parameters.AddWithValue("@BirimFiyatı", nktdznbrm.Text);
                DuzenleKomut.Parameters.AddWithValue("@ToplamFiyatı", nktdzntplm.Text);
                DuzenleKomut.Parameters.AddWithValue("@SatışGörevlisi", nktdzngrv.Text);
                DuzenleKomut.Parameters.AddWithValue("@ID", nktdznID.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(nktdznno.Text + " " + nktdznadi.Text + " isimli kayıt düzenlendi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Duzenleme Hata Penceresi");

            }

        }



        private void btncalisanduzenle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtDuzenle();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
