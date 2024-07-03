
namespace NalburOtomasyonu
{
    partial class santiyeekle
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
            this.mskBitisTarih = new System.Windows.Forms.MaskedTextBox();
            this.mskBaslamaTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtSantiyeSahip = new System.Windows.Forms.TextBox();
            this.cmbSantiyeAdres = new System.Windows.Forms.ComboBox();
            this.btnsantiyeekle = new System.Windows.Forms.Button();
            this.txtCalisanSayi = new System.Windows.Forms.TextBox();
            this.txtIsSuresi = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.mskBitisTarih);
            this.groupBox1.Controls.Add(this.mskBaslamaTarih);
            this.groupBox1.Controls.Add(this.txtSantiyeSahip);
            this.groupBox1.Controls.Add(this.cmbSantiyeAdres);
            this.groupBox1.Controls.Add(this.btnsantiyeekle);
            this.groupBox1.Controls.Add(this.txtCalisanSayi);
            this.groupBox1.Controls.Add(this.txtIsSuresi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // mskBitisTarih
            // 
            this.mskBitisTarih.Location = new System.Drawing.Point(109, 133);
            this.mskBitisTarih.Mask = "00/00/0000";
            this.mskBitisTarih.Name = "mskBitisTarih";
            this.mskBitisTarih.Size = new System.Drawing.Size(131, 20);
            this.mskBitisTarih.TabIndex = 11;
            this.mskBitisTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mskBaslamaTarih
            // 
            this.mskBaslamaTarih.Location = new System.Drawing.Point(131, 107);
            this.mskBaslamaTarih.Mask = "00/00/0000";
            this.mskBaslamaTarih.Name = "mskBaslamaTarih";
            this.mskBaslamaTarih.Size = new System.Drawing.Size(109, 20);
            this.mskBaslamaTarih.TabIndex = 11;
            this.mskBaslamaTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtSantiyeSahip
            // 
            this.txtSantiyeSahip.Location = new System.Drawing.Point(109, 55);
            this.txtSantiyeSahip.Name = "txtSantiyeSahip";
            this.txtSantiyeSahip.Size = new System.Drawing.Size(131, 20);
            this.txtSantiyeSahip.TabIndex = 10;
            // 
            // cmbSantiyeAdres
            // 
            this.cmbSantiyeAdres.FormattingEnabled = true;
            this.cmbSantiyeAdres.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbSantiyeAdres.Location = new System.Drawing.Point(109, 28);
            this.cmbSantiyeAdres.Name = "cmbSantiyeAdres";
            this.cmbSantiyeAdres.Size = new System.Drawing.Size(131, 21);
            this.cmbSantiyeAdres.TabIndex = 9;
            this.cmbSantiyeAdres.Text = "Seçim Yapınız";
            // 
            // btnsantiyeekle
            // 
            this.btnsantiyeekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsantiyeekle.Location = new System.Drawing.Point(23, 181);
            this.btnsantiyeekle.Name = "btnsantiyeekle";
            this.btnsantiyeekle.Size = new System.Drawing.Size(217, 34);
            this.btnsantiyeekle.TabIndex = 8;
            this.btnsantiyeekle.Text = "Santiye Ekle";
            this.btnsantiyeekle.UseVisualStyleBackColor = true;
            this.btnsantiyeekle.Click += new System.EventHandler(this.btnstokkayitekle_Click);
            // 
            // txtCalisanSayi
            // 
            this.txtCalisanSayi.Location = new System.Drawing.Point(131, 156);
            this.txtCalisanSayi.MaxLength = 11;
            this.txtCalisanSayi.Name = "txtCalisanSayi";
            this.txtCalisanSayi.Size = new System.Drawing.Size(109, 20);
            this.txtCalisanSayi.TabIndex = 6;
            // 
            // txtIsSuresi
            // 
            this.txtIsSuresi.Location = new System.Drawing.Point(109, 81);
            this.txtIsSuresi.Name = "txtIsSuresi";
            this.txtIsSuresi.Size = new System.Drawing.Size(131, 20);
            this.txtIsSuresi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Çalışan Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bitiş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Başlama Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "İş Süresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İş Veren";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adresi";
            // 
            // santiyeekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 248);
            this.Controls.Add(this.groupBox1);
            this.Name = "santiyeekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "santiyeekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsantiyeekle;
        private System.Windows.Forms.TextBox txtIsSuresi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskBitisTarih;
        private System.Windows.Forms.MaskedTextBox mskBaslamaTarih;
        private System.Windows.Forms.TextBox txtSantiyeSahip;
        private System.Windows.Forms.ComboBox cmbSantiyeAdres;
        private System.Windows.Forms.TextBox txtCalisanSayi;
        private System.Windows.Forms.Label label6;
    }
}