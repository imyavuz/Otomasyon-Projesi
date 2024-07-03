
namespace NalburOtomasyonu
{
    partial class nakitduzenle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nktdzntarih = new System.Windows.Forms.MaskedTextBox();
            this.btncalisanduzenle = new System.Windows.Forms.Button();
            this.nktdznbrm = new System.Windows.Forms.TextBox();
            this.nktdzngrv = new System.Windows.Forms.TextBox();
            this.nktdzntplm = new System.Windows.Forms.TextBox();
            this.nktdznadi = new System.Windows.Forms.TextBox();
            this.nktdznno = new System.Windows.Forms.TextBox();
            this.nktdznadet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nktdznID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.nktdzntarih);
            this.groupBox2.Controls.Add(this.btncalisanduzenle);
            this.groupBox2.Controls.Add(this.nktdznbrm);
            this.groupBox2.Controls.Add(this.nktdzngrv);
            this.groupBox2.Controls.Add(this.nktdzntplm);
            this.groupBox2.Controls.Add(this.nktdznadi);
            this.groupBox2.Controls.Add(this.nktdznID);
            this.groupBox2.Controls.Add(this.nktdznno);
            this.groupBox2.Controls.Add(this.nktdznadet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 305);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nktdzntarih
            // 
            this.nktdzntarih.Location = new System.Drawing.Point(153, 79);
            this.nktdzntarih.Mask = "00/00/0000";
            this.nktdzntarih.Name = "nktdzntarih";
            this.nktdzntarih.Size = new System.Drawing.Size(113, 20);
            this.nktdzntarih.TabIndex = 11;
            this.nktdzntarih.ValidatingType = typeof(System.DateTime);
            // 
            // btncalisanduzenle
            // 
            this.btncalisanduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncalisanduzenle.Location = new System.Drawing.Point(29, 255);
            this.btncalisanduzenle.Name = "btncalisanduzenle";
            this.btncalisanduzenle.Size = new System.Drawing.Size(217, 34);
            this.btncalisanduzenle.TabIndex = 8;
            this.btncalisanduzenle.Text = "Çalışan Düzenle";
            this.btncalisanduzenle.UseVisualStyleBackColor = true;
            this.btncalisanduzenle.Click += new System.EventHandler(this.btncalisanduzenle_Click);
            // 
            // nktdznbrm
            // 
            this.nktdznbrm.Location = new System.Drawing.Point(153, 155);
            this.nktdznbrm.Name = "nktdznbrm";
            this.nktdznbrm.Size = new System.Drawing.Size(113, 20);
            this.nktdznbrm.TabIndex = 6;
            // 
            // nktdzngrv
            // 
            this.nktdzngrv.Location = new System.Drawing.Point(153, 204);
            this.nktdzngrv.Name = "nktdzngrv";
            this.nktdzngrv.Size = new System.Drawing.Size(113, 20);
            this.nktdzngrv.TabIndex = 6;
            // 
            // nktdzntplm
            // 
            this.nktdzntplm.Location = new System.Drawing.Point(153, 180);
            this.nktdzntplm.Name = "nktdzntplm";
            this.nktdzntplm.Size = new System.Drawing.Size(113, 20);
            this.nktdzntplm.TabIndex = 6;
            // 
            // nktdznadi
            // 
            this.nktdznadi.Location = new System.Drawing.Point(153, 104);
            this.nktdznadi.Name = "nktdznadi";
            this.nktdznadi.Size = new System.Drawing.Size(113, 20);
            this.nktdznadi.TabIndex = 6;
            // 
            // nktdznno
            // 
            this.nktdznno.Enabled = false;
            this.nktdznno.Location = new System.Drawing.Point(153, 53);
            this.nktdznno.Name = "nktdznno";
            this.nktdznno.Size = new System.Drawing.Size(113, 20);
            this.nktdznno.TabIndex = 6;
            // 
            // nktdznadet
            // 
            this.nktdznadet.Location = new System.Drawing.Point(153, 131);
            this.nktdznadet.Name = "nktdznadet";
            this.nktdznadet.Size = new System.Drawing.Size(113, 20);
            this.nktdznadet.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Satış Görevlisi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Toplam Fiyat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Birim Fiyat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Adet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ürün Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Satış No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Satış Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // nktdznID
            // 
            this.nktdznID.Enabled = false;
            this.nktdznID.Location = new System.Drawing.Point(153, 27);
            this.nktdznID.Name = "nktdznID";
            this.nktdznID.Size = new System.Drawing.Size(113, 20);
            this.nktdznID.TabIndex = 6;
            // 
            // nakitduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 329);
            this.Controls.Add(this.groupBox2);
            this.Name = "nakitduzenle";
            this.Text = "nakitduzenle";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.MaskedTextBox nktdzntarih;
        public System.Windows.Forms.Button btncalisanduzenle;
        public System.Windows.Forms.TextBox nktdzntplm;
        public System.Windows.Forms.TextBox nktdznadi;
        public System.Windows.Forms.TextBox nktdznno;
        public System.Windows.Forms.TextBox nktdznadet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox nktdznbrm;
        public System.Windows.Forms.TextBox nktdzngrv;
        public System.Windows.Forms.TextBox nktdznID;
        private System.Windows.Forms.Label label1;
    }
}