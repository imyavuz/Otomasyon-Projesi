
namespace NalburOtomasyonu
{
    partial class toptanciduzenle
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
            this.mskToptanciTel = new System.Windows.Forms.MaskedTextBox();
            this.btntoptanciduzenle = new System.Windows.Forms.Button();
            this.cmbtoptancituru = new System.Windows.Forms.ComboBox();
            this.cmbToptanciAdres = new System.Windows.Forms.ComboBox();
            this.txtToptanciAdi = new System.Windows.Forms.TextBox();
            this.txtToptanciSahip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttopanciid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.mskToptanciTel);
            this.groupBox1.Controls.Add(this.btntoptanciduzenle);
            this.groupBox1.Controls.Add(this.cmbtoptancituru);
            this.groupBox1.Controls.Add(this.cmbToptanciAdres);
            this.groupBox1.Controls.Add(this.txttopanciid);
            this.groupBox1.Controls.Add(this.txtToptanciAdi);
            this.groupBox1.Controls.Add(this.txtToptanciSahip);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // mskToptanciTel
            // 
            this.mskToptanciTel.Location = new System.Drawing.Point(92, 138);
            this.mskToptanciTel.Mask = "(999) 000-0000";
            this.mskToptanciTel.Name = "mskToptanciTel";
            this.mskToptanciTel.Size = new System.Drawing.Size(160, 20);
            this.mskToptanciTel.TabIndex = 9;
            // 
            // btntoptanciduzenle
            // 
            this.btntoptanciduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntoptanciduzenle.Location = new System.Drawing.Point(23, 202);
            this.btntoptanciduzenle.Name = "btntoptanciduzenle";
            this.btntoptanciduzenle.Size = new System.Drawing.Size(217, 34);
            this.btntoptanciduzenle.TabIndex = 8;
            this.btntoptanciduzenle.Text = "Toptancı Düzenle";
            this.btntoptanciduzenle.UseVisualStyleBackColor = true;
            this.btntoptanciduzenle.Click += new System.EventHandler(this.btntoptanciduzenle_Click);
            // 
            // cmbtoptancituru
            // 
            this.cmbtoptancituru.FormattingEnabled = true;
            this.cmbtoptancituru.Items.AddRange(new object[] {
            "Yapı Malzemeleri",
            "İzolasyon Malzemeleri",
            "Kaplama Malzemeleri",
            "Boya Ürünleri",
            "Sıvı Ürünler"});
            this.cmbtoptancituru.Location = new System.Drawing.Point(92, 57);
            this.cmbtoptancituru.Name = "cmbtoptancituru";
            this.cmbtoptancituru.Size = new System.Drawing.Size(160, 21);
            this.cmbtoptancituru.TabIndex = 7;
            this.cmbtoptancituru.Text = "Türü Seçiniz";
            // 
            // cmbToptanciAdres
            // 
            this.cmbToptanciAdres.FormattingEnabled = true;
            this.cmbToptanciAdres.Items.AddRange(new object[] {
            "Rize",
            "Sakarya",
            "Trabzon",
            "Zonguldak",
            "Samsun"});
            this.cmbToptanciAdres.Location = new System.Drawing.Point(92, 164);
            this.cmbToptanciAdres.Name = "cmbToptanciAdres";
            this.cmbToptanciAdres.Size = new System.Drawing.Size(160, 21);
            this.cmbToptanciAdres.TabIndex = 7;
            this.cmbToptanciAdres.Text = "Adres Seçiniz";
            // 
            // txtToptanciAdi
            // 
            this.txtToptanciAdi.Location = new System.Drawing.Point(92, 85);
            this.txtToptanciAdi.Name = "txtToptanciAdi";
            this.txtToptanciAdi.Size = new System.Drawing.Size(160, 20);
            this.txtToptanciAdi.TabIndex = 6;
            // 
            // txtToptanciSahip
            // 
            this.txtToptanciSahip.Location = new System.Drawing.Point(92, 110);
            this.txtToptanciSahip.Name = "txtToptanciSahip";
            this.txtToptanciSahip.Size = new System.Drawing.Size(160, 20);
            this.txtToptanciSahip.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sahibi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Türü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID";
            // 
            // txttopanciid
            // 
            this.txttopanciid.Enabled = false;
            this.txttopanciid.Location = new System.Drawing.Point(92, 31);
            this.txttopanciid.Name = "txttopanciid";
            this.txttopanciid.Size = new System.Drawing.Size(160, 20);
            this.txttopanciid.TabIndex = 6;
            // 
            // toptanciduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 282);
            this.Controls.Add(this.groupBox1);
            this.Name = "toptanciduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "toptanciduzenle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox mskToptanciTel;
        public System.Windows.Forms.Button btntoptanciduzenle;
        public System.Windows.Forms.ComboBox cmbtoptancituru;
        public System.Windows.Forms.ComboBox cmbToptanciAdres;
        public System.Windows.Forms.TextBox txtToptanciAdi;
        public System.Windows.Forms.TextBox txtToptanciSahip;
        public System.Windows.Forms.TextBox txttopanciid;
    }
}