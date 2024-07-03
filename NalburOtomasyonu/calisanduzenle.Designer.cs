
namespace NalburOtomasyonu
{
    partial class calisanduzenle
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
            this.mskCalisanTarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbCalisanSaat = new System.Windows.Forms.ComboBox();
            this.mskCalisanTel = new System.Windows.Forms.MaskedTextBox();
            this.btncalisanduzenle = new System.Windows.Forms.Button();
            this.txtCalisanMaas = new System.Windows.Forms.TextBox();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.txtCalisanId = new System.Windows.Forms.TextBox();
            this.txtCalisanNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.mskCalisanTarih);
            this.groupBox1.Controls.Add(this.cmbCalisanSaat);
            this.groupBox1.Controls.Add(this.mskCalisanTel);
            this.groupBox1.Controls.Add(this.btncalisanduzenle);
            this.groupBox1.Controls.Add(this.txtCalisanMaas);
            this.groupBox1.Controls.Add(this.txtCalisanAd);
            this.groupBox1.Controls.Add(this.txtCalisanId);
            this.groupBox1.Controls.Add(this.txtCalisanNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // mskCalisanTarih
            // 
            this.mskCalisanTarih.Location = new System.Drawing.Point(153, 111);
            this.mskCalisanTarih.Mask = "00/00/0000";
            this.mskCalisanTarih.Name = "mskCalisanTarih";
            this.mskCalisanTarih.Size = new System.Drawing.Size(113, 20);
            this.mskCalisanTarih.TabIndex = 11;
            this.mskCalisanTarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCalisanSaat
            // 
            this.cmbCalisanSaat.FormattingEnabled = true;
            this.cmbCalisanSaat.Items.AddRange(new object[] {
            "09:00-13:00",
            "13:00-17:00"});
            this.cmbCalisanSaat.Location = new System.Drawing.Point(153, 137);
            this.cmbCalisanSaat.Name = "cmbCalisanSaat";
            this.cmbCalisanSaat.Size = new System.Drawing.Size(113, 21);
            this.cmbCalisanSaat.TabIndex = 10;
            this.cmbCalisanSaat.Text = "Saat Seçiniz";
            // 
            // mskCalisanTel
            // 
            this.mskCalisanTel.Location = new System.Drawing.Point(153, 186);
            this.mskCalisanTel.Mask = "(999) 000-0000";
            this.mskCalisanTel.Name = "mskCalisanTel";
            this.mskCalisanTel.Size = new System.Drawing.Size(113, 20);
            this.mskCalisanTel.TabIndex = 9;
            // 
            // btncalisanduzenle
            // 
            this.btncalisanduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncalisanduzenle.Location = new System.Drawing.Point(26, 212);
            this.btncalisanduzenle.Name = "btncalisanduzenle";
            this.btncalisanduzenle.Size = new System.Drawing.Size(217, 34);
            this.btncalisanduzenle.TabIndex = 8;
            this.btncalisanduzenle.Text = "Çalışan Düzenle";
            this.btncalisanduzenle.UseVisualStyleBackColor = true;
            this.btncalisanduzenle.Click += new System.EventHandler(this.btncalisanduzenle_Click);
            // 
            // txtCalisanMaas
            // 
            this.txtCalisanMaas.Location = new System.Drawing.Point(153, 160);
            this.txtCalisanMaas.Name = "txtCalisanMaas";
            this.txtCalisanMaas.Size = new System.Drawing.Size(113, 20);
            this.txtCalisanMaas.TabIndex = 6;
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.Location = new System.Drawing.Point(153, 84);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(113, 20);
            this.txtCalisanAd.TabIndex = 6;
            // 
            // txtCalisanId
            // 
            this.txtCalisanId.Enabled = false;
            this.txtCalisanId.Location = new System.Drawing.Point(153, 33);
            this.txtCalisanId.Name = "txtCalisanId";
            this.txtCalisanId.Size = new System.Drawing.Size(113, 20);
            this.txtCalisanId.TabIndex = 6;
            this.txtCalisanId.TextChanged += new System.EventHandler(this.txtCalisanNo_TextChanged);
            // 
            // txtCalisanNo
            // 
            this.txtCalisanNo.Location = new System.Drawing.Point(153, 59);
            this.txtCalisanNo.Name = "txtCalisanNo";
            this.txtCalisanNo.Size = new System.Drawing.Size(113, 20);
            this.txtCalisanNo.TabIndex = 6;
            this.txtCalisanNo.TextChanged += new System.EventHandler(this.txtCalisanNo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Çalışan Tel No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Çalışma Saatleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "İşe Başlama Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Çalışan No";
            // 
            // calisanduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 277);
            this.Controls.Add(this.groupBox1);
            this.Name = "calisanduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calisanduzenle";
            this.Load += new System.EventHandler(this.calisanduzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mskCalisanTarih;
        public System.Windows.Forms.ComboBox cmbCalisanSaat;
        public System.Windows.Forms.MaskedTextBox mskCalisanTel;
        public System.Windows.Forms.Button btncalisanduzenle;
        public System.Windows.Forms.TextBox txtCalisanMaas;
        public System.Windows.Forms.TextBox txtCalisanAd;
        public System.Windows.Forms.TextBox txtCalisanNo;
        public System.Windows.Forms.TextBox txtCalisanId;
    }
}