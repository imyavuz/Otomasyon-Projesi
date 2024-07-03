
namespace NalburOtomasyonu
{
    partial class nakit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskSatisTarih = new System.Windows.Forms.MaskedTextBox();
            this.nakitsatis = new System.Windows.Forms.Button();
            this.nakittoplamfiyat = new System.Windows.Forms.TextBox();
            this.nakitadet = new System.Windows.Forms.TextBox();
            this.nakitstsgrv = new System.Windows.Forms.TextBox();
            this.nakiturunadi = new System.Windows.Forms.TextBox();
            this.nakitbirimfiyat = new System.Windows.Forms.TextBox();
            this.txtSatisNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mskSatisTarih);
            this.groupBox1.Controls.Add(this.nakitsatis);
            this.groupBox1.Controls.Add(this.nakittoplamfiyat);
            this.groupBox1.Controls.Add(this.nakitadet);
            this.groupBox1.Controls.Add(this.nakitstsgrv);
            this.groupBox1.Controls.Add(this.nakiturunadi);
            this.groupBox1.Controls.Add(this.nakitbirimfiyat);
            this.groupBox1.Controls.Add(this.txtSatisNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 284);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Satış Görevlisi";
            // 
            // mskSatisTarih
            // 
            this.mskSatisTarih.Location = new System.Drawing.Point(153, 58);
            this.mskSatisTarih.Mask = "00/00/0000";
            this.mskSatisTarih.Name = "mskSatisTarih";
            this.mskSatisTarih.Size = new System.Drawing.Size(113, 20);
            this.mskSatisTarih.TabIndex = 11;
            this.mskSatisTarih.ValidatingType = typeof(System.DateTime);
            this.mskSatisTarih.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCalisanTarih_MaskInputRejected);
            // 
            // nakitsatis
            // 
            this.nakitsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nakitsatis.Location = new System.Drawing.Point(31, 235);
            this.nakitsatis.Name = "nakitsatis";
            this.nakitsatis.Size = new System.Drawing.Size(217, 34);
            this.nakitsatis.TabIndex = 8;
            this.nakitsatis.Text = "Satış Ekle";
            this.nakitsatis.UseVisualStyleBackColor = true;
            this.nakitsatis.Click += new System.EventHandler(this.nakitsatis_Click);
            // 
            // nakittoplamfiyat
            // 
            this.nakittoplamfiyat.Location = new System.Drawing.Point(153, 162);
            this.nakittoplamfiyat.Name = "nakittoplamfiyat";
            this.nakittoplamfiyat.Size = new System.Drawing.Size(113, 20);
            this.nakittoplamfiyat.TabIndex = 6;
            // 
            // nakitadet
            // 
            this.nakitadet.Location = new System.Drawing.Point(153, 110);
            this.nakitadet.Name = "nakitadet";
            this.nakitadet.Size = new System.Drawing.Size(113, 20);
            this.nakitadet.TabIndex = 6;
            // 
            // nakitstsgrv
            // 
            this.nakitstsgrv.Location = new System.Drawing.Point(153, 188);
            this.nakitstsgrv.Name = "nakitstsgrv";
            this.nakitstsgrv.Size = new System.Drawing.Size(113, 20);
            this.nakitstsgrv.TabIndex = 6;
            // 
            // nakiturunadi
            // 
            this.nakiturunadi.Location = new System.Drawing.Point(153, 84);
            this.nakiturunadi.Name = "nakiturunadi";
            this.nakiturunadi.Size = new System.Drawing.Size(113, 20);
            this.nakiturunadi.TabIndex = 6;
            // 
            // nakitbirimfiyat
            // 
            this.nakitbirimfiyat.Location = new System.Drawing.Point(153, 136);
            this.nakitbirimfiyat.Name = "nakitbirimfiyat";
            this.nakitbirimfiyat.Size = new System.Drawing.Size(113, 20);
            this.nakitbirimfiyat.TabIndex = 6;
            // 
            // txtSatisNo
            // 
            this.txtSatisNo.Location = new System.Drawing.Point(153, 31);
            this.txtSatisNo.Name = "txtSatisNo";
            this.txtSatisNo.Size = new System.Drawing.Size(113, 20);
            this.txtSatisNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Toplam Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Birim Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Satış Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Satış No";
            // 
            // nakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "nakit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nakit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nakitsatis;
        private System.Windows.Forms.TextBox nakitbirimfiyat;
        private System.Windows.Forms.TextBox txtSatisNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskSatisTarih;
        private System.Windows.Forms.TextBox nakittoplamfiyat;
        private System.Windows.Forms.TextBox nakitadet;
        private System.Windows.Forms.TextBox nakitstsgrv;
        private System.Windows.Forms.TextBox nakiturunadi;
    }
}