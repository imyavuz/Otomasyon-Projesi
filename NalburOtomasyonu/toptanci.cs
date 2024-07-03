using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NalburOtomasyonu
{
    public partial class toptanci : Form
    {
        public toptanci()
        {
            InitializeComponent();
        }
        public void kayıtLısteleme()
        {
            try
            {
                Form1.BaglantıAc();
                DataSet ds = new DataSet();
                String Sorgu = "Select * from Toptanci";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Form1.Baglanti);
                da.Fill(ds, "Toptanci");
                dataGridView1.DataSource = ds.Tables["Toptanci"];
                Form1.BaglantıKapat();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");

            }
        }
        private void toptanci_Load(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toptancılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void toptancıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toptanciekle frmtoptanciekle = new toptanciekle();
            frmtoptanciekle.ShowDialog();
        }

        private void toptancıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toptancisil frmtoptancisil = new toptancisil();
            frmtoptancisil.txttoptanciid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmtoptancisil.txttoptancituru.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmtoptancisil.txttoptanciadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmtoptancisil.ShowDialog();
        }

        private void toptancıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toptanciduzenle frmtoptanciduzenle = new toptanciduzenle();
            frmtoptanciduzenle.txttopanciid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmtoptanciduzenle.cmbtoptancituru.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmtoptanciduzenle.txtToptanciAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmtoptanciduzenle.txtToptanciSahip.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmtoptanciduzenle.mskToptanciTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmtoptanciduzenle.cmbToptanciAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmtoptanciduzenle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
