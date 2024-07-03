using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NalburOtomasyonu
{
    public partial class İntroForm : Form
    {
        public İntroForm()
        {
            InitializeComponent();
        }

        private void İntroForm_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.TransparencyKey = Color.Green;
            this.BackColor = Color.Green;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.01;
                progressBar1.Value += 1;
                this.Top++;
            }
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.01;
                progressBar1.Value -= 1;
                this.Top--;

                if (this.Opacity == 0)
                {

                    MessageBox.Show("İntro geçiliyor! \nPrograma Hoş Geldiniz!", "Hoşgeldiniz");
                    Form1 anafrm = new Form1();
                    anafrm.Show();
                    this.Hide();
                    timer2.Enabled = false;
                }
            }
        }


        private void bntGec_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
