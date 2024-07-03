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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }

        public static OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Data.accdb");

        public void kayıtLısteleme()
        {
            try
            {
                Form1.BaglantıAc();
                DataSet ds = new DataSet();
                String Sorgu = "Select * from Nakit";
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Form1.Baglanti);
                da.Fill(ds, "Nakit");
                dataGridView1.DataSource = ds.Tables["Nakit"];
                Form1.BaglantıKapat();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");

            }
        }

        private void satis_Load(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kayıtLısteleme();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            nakit frmnakitekle = new nakit();
            frmnakitekle.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            nakitsil frmnakitsil = new nakitsil();
            frmnakitsil.txtnakitsilID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmnakitsil.txtnakitsiladi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmnakitsil.txtnakitsilno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmnakitsil.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            nakitduzenle frmnakitduzenle = new nakitduzenle();
            frmnakitduzenle.nktdznID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmnakitduzenle.nktdznno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmnakitduzenle.nktdzntarih.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmnakitduzenle.nktdznadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmnakitduzenle.nktdznadet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frmnakitduzenle.nktdznbrm.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmnakitduzenle.nktdzntplm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmnakitduzenle.nktdzngrv.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmnakitduzenle.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
