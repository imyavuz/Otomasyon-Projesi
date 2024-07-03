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
    public partial class toptanciduzenle : Form
    {
        public toptanciduzenle()
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
            if (mskToptanciTel.Text == "")
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
        public void KayıtDuzenle()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "update Toptanci set Türü=@Türü,Adı=@Adı,Sahibi=@Sahibi,Telefon=@Telefon,Adresi=@Adresi where ID=@ID";
                OleDbCommand DuzenleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@Türü", cmbtoptancituru.Text);
                DuzenleKomut.Parameters.AddWithValue("@Adı", txtToptanciAdi.Text);
                DuzenleKomut.Parameters.AddWithValue("@Sahibi", txtToptanciSahip.Text);
                DuzenleKomut.Parameters.AddWithValue("@Telefon", mskToptanciTel.Text);
                DuzenleKomut.Parameters.AddWithValue("@Adresi", cmbToptanciAdres.Text);
                DuzenleKomut.Parameters.AddWithValue("@ID", txttopanciid.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txttopanciid.Text + " " + txtToptanciAdi.Text + " isimli kayıt düzenlendi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Duzenleme Hata Penceresi");

            }

        }
        private void btntoptanciduzenle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtDuzenle();
        }
    }
}
