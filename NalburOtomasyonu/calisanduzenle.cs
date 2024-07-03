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
    public partial class calisanduzenle : Form
    {
        public calisanduzenle()
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
        public void KayıtDuzenle()
        {
            try
            {                
                Form1.BaglantıAc();
                string Sorgu = "update Calisanlar set ÇalışanNo=@ÇalışanNo,AdıSoyadı=@AdıSoyadı,İşeBaşlamaTarihi=@İşeBaşlamaTarihi,ÇalışmaSaatleri=@ÇalışmaSaatleri,Maaş=@Maaş,TelefonNo=@TelefonNo where ID=@ID";
                OleDbCommand DuzenleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@ÇalışanNo", txtCalisanNo.Text);
                DuzenleKomut.Parameters.AddWithValue("@AdıSoyadı", txtCalisanAd.Text);
                DuzenleKomut.Parameters.AddWithValue("@İşeBaşlamaTarihi", mskCalisanTarih.Text);
                DuzenleKomut.Parameters.AddWithValue("@ÇalışmaSaatleri", cmbCalisanSaat.Text);
                DuzenleKomut.Parameters.AddWithValue("@Maaş", txtCalisanMaas.Text);
                DuzenleKomut.Parameters.AddWithValue("@TelefonNo", mskCalisanTel.Text);
                DuzenleKomut.Parameters.AddWithValue("@ID", txtCalisanId.Text); 
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtCalisanId.Text + " " + txtCalisanAd.Text + " isimli kayıt düzenlendi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Duzenleme Hata Penceresi");

            }

        }
        private void calisanduzenle_Load(object sender, EventArgs e)
        {

        }

        private void txtCalisanNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalisanduzenle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtDuzenle();
                this.Close();
           
        }
    }
}
