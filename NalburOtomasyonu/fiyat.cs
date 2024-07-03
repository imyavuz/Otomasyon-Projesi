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
    public partial class fiyat : Form
    {
        public fiyat()
        {
            InitializeComponent();
        }
        public void kayıtLısteleme()
        {
            try
            {
                Form1.BaglantıAc();
                DataSet ds = new DataSet();
                String Sorgu = "Select * from Stok";
               
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Form1.Baglanti);
                da.Fill(ds, "Stok");
                dataGridView1.DataSource = ds.Tables["Stok"];
                Form1.BaglantıKapat();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fiyat_Load(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void fiyatBilgisiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fytbtn_Click(object sender, EventArgs e)
        {
            stokduzenle frmstokdznle = new stokduzenle();
            frmstokdznle.txtStokId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmstokdznle.txtStokAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmstokdznle.cmbStokCins.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmstokdznle.txtStokAdedi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmstokdznle.txtStokFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmstokdznle.txtStokBarkod.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            frmstokdznle.ShowDialog();
        }

        private void btnfytliste_Click(object sender, EventArgs e)
        {
            kayıtLısteleme();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokekle frmstokekle = new stokekle();
            frmstokekle.ShowDialog();
        }

        private void stokSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stoksil frmstoksil = new stoksil();
            frmstoksil.txtStokSilId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmstoksil.txtStokSilAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmstoksil.txtStokSilBNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmstoksil.ShowDialog();
        }
    }
}
