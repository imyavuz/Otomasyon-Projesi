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
    public partial class depoduzenle : Form
    {
        public depoduzenle()
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
        public void KayıtDuzenle()
        {
            try
            {
                Form1.BaglantıAc();                
                string Sorgu = "update Depo set DepoNo=@DepoNo,Adresi=@Adresi,Boyutu=@Boyutu,Sorumlu=@Sorumlu,Telefon=@Telefon where ID=@ID";
                OleDbCommand DuzenleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@DepoNo", txtDepoNo.Text);
                DuzenleKomut.Parameters.AddWithValue("@Adresi", cmbDepoAdres.Text);
                DuzenleKomut.Parameters.AddWithValue("@Boyutu", txtDepoBoyut.Text);
                DuzenleKomut.Parameters.AddWithValue("@Sorumlu", txtDepoSorumlu.Text);
                DuzenleKomut.Parameters.AddWithValue("@Telefon", mskSorumluTel.Text);
                DuzenleKomut.Parameters.AddWithValue("@ID", txtDepoID.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtDepoID.Text + " " + txtDepoNo.Text + " isimli kayıt düzenlendi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Duzenleme Hata Penceresi");

            }

        }
        private void btndepodüzenle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtDuzenle();
            this.Close();
        }

        private void depoduzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
