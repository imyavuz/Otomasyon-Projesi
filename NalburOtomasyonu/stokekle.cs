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
    public partial class stokekle : Form
    {
        public stokekle()
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
        public void KayıtEkle()
        {
            try
            {
                Form1.BaglantıAc();

                string Sorgu = "Insert Into Stok (Adı,Cinsi,Adedi,AdetFiyatı,BarkodNo) Values (@Adı,@Cinsi,@Adedi,@AdetFiyatı,@BarkodNo)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Adı", txtStokAdi.Text);
                EkleKomut.Parameters.AddWithValue("@Cinsi", cmbStokCins.Text);
                EkleKomut.Parameters.AddWithValue("@Adedi", txtStokAdedi.Text);
                EkleKomut.Parameters.AddWithValue("@AdetFiyatı", txtStokFiyat.Text);
                EkleKomut.Parameters.AddWithValue("@BarkodNo", txtStokBarkod.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("kayıt ekleme başarılı");
                }
                Form1.Baglanti.Close();
                this.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hatası Penceresi");

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
