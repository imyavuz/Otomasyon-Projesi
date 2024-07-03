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
    public partial class stokduzenle : Form
    {
        public stokduzenle()
        {
            InitializeComponent();
        }
        public bool BoslukKontrol()
        {
            txtStokBarkod.BackColor = Color.White;
            txtStokFiyat.BackColor = Color.White;
            txtStokAdedi.BackColor = Color.White;
            cmbStokCins.BackColor = Color.White;
            txtStokAdi.BackColor = Color.White;


            bool bos = false;


            if (txtStokBarkod.Text == "")
            {
                txtStokBarkod.BackColor = Color.Red;
                txtStokBarkod.Focus();
                bos = true;
            }
            if (txtStokFiyat.Text == "")
            {
                txtStokFiyat.BackColor = Color.Red;
                txtStokFiyat.Focus();
                bos = true;
            }

            if (txtStokAdedi.Text == "")
            {
                txtStokAdedi.BackColor = Color.Red;
                txtStokAdedi.Focus();
                bos = true;
            }
            if (cmbStokCins.Text == "Seçim Yapınız" || cmbStokCins.Text == "")
            {
                cmbStokCins.BackColor = Color.Red;
                cmbStokCins.Focus();
                bos = true;
            }
            if (txtStokAdi.Text == "")
            {
                txtStokAdi.BackColor = Color.Red;
                txtStokAdi.Focus();
                bos = true;
            }

            return bos;
        }
        public void KayıtDuzenle()
        {
            try
            {
                Form1.BaglantıAc();
                string Sorgu = "update Stok set Adı=@Adı,Cinsi=@Cinsi,Adedi=@Adedi,AdetFiyatı=@AdetFiyatı,BarkodNo=@BarkodNo where ID=@ID";
                OleDbCommand DuzenleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                DuzenleKomut.Parameters.AddWithValue("@Adı", txtStokAdi.Text);
                DuzenleKomut.Parameters.AddWithValue("@Cinsi", cmbStokCins.Text);
                DuzenleKomut.Parameters.AddWithValue("@Adedi", txtStokAdedi.Text);
                DuzenleKomut.Parameters.AddWithValue("@AdetFiyatı", txtStokFiyat.Text);
                DuzenleKomut.Parameters.AddWithValue("@BarkodNo", txtStokBarkod.Text);                
                DuzenleKomut.Parameters.AddWithValue("@ID", txtStokId.Text);
                if (DuzenleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtStokId.Text + " " + txtStokAdi.Text + " isimli kayıt düzenlendi");
                Form1.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Duzenleme Hata Penceresi");

            }

        }
        private void btnstokkayitdüzenle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz", "Dikkat!");
            else
                KayıtDuzenle();
        }
    }
}
