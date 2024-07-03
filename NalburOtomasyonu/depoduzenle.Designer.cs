
namespace NalburOtomasyonu
{
    partial class depoduzenle
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
            this.mskSorumluTel = new System.Windows.Forms.MaskedTextBox();
            this.btndepodüzenle = new System.Windows.Forms.Button();
            this.cmbDepoAdres = new System.Windows.Forms.ComboBox();
            this.txtDepoSorumlu = new System.Windows.Forms.TextBox();
            this.txtDepoBoyut = new System.Windows.Forms.TextBox();
            this.txtDepoID = new System.Windows.Forms.TextBox();
            this.txtDepoNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelc5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.mskSorumluTel);
            this.groupBox1.Controls.Add(this.btndepodüzenle);
            this.groupBox1.Controls.Add(this.cmbDepoAdres);
            this.groupBox1.Controls.Add(this.txtDepoSorumlu);
            this.groupBox1.Controls.Add(this.txtDepoBoyut);
            this.groupBox1.Controls.Add(this.txtDepoID);
            this.groupBox1.Controls.Add(this.txtDepoNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelc5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // mskSorumluTel
            // 
            this.mskSorumluTel.Location = new System.Drawing.Point(109, 157);
            this.mskSorumluTel.Mask = "(999) 000-0000";
            this.mskSorumluTel.Name = "mskSorumluTel";
            this.mskSorumluTel.Size = new System.Drawing.Size(131, 20);
            this.mskSorumluTel.TabIndex = 9;
            // 
            // btndepodüzenle
            // 
            this.btndepodüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndepodüzenle.Location = new System.Drawing.Point(23, 196);
            this.btndepodüzenle.Name = "btndepodüzenle";
            this.btndepodüzenle.Size = new System.Drawing.Size(217, 34);
            this.btndepodüzenle.TabIndex = 8;
            this.btndepodüzenle.Text = "Depo Düzenle";
            this.btndepodüzenle.UseVisualStyleBackColor = true;
            this.btndepodüzenle.Click += new System.EventHandler(this.btndepodüzenle_Click);
            // 
            // cmbDepoAdres
            // 
            this.cmbDepoAdres.FormattingEnabled = true;
            this.cmbDepoAdres.Items.AddRange(new object[] {
            "Trabzon",
            "Rize",
            "Sakarya",
            "Samsun",
            "Zonguldak"});
            this.cmbDepoAdres.Location = new System.Drawing.Point(109, 76);
            this.cmbDepoAdres.Name = "cmbDepoAdres";
            this.cmbDepoAdres.Size = new System.Drawing.Size(131, 21);
            this.cmbDepoAdres.TabIndex = 7;
            this.cmbDepoAdres.Text = "Adres Seçiniz";
            // 
            // txtDepoSorumlu
            // 
            this.txtDepoSorumlu.Location = new System.Drawing.Point(109, 130);
            this.txtDepoSorumlu.Name = "txtDepoSorumlu";
            this.txtDepoSorumlu.Size = new System.Drawing.Size(131, 20);
            this.txtDepoSorumlu.TabIndex = 6;
            // 
            // txtDepoBoyut
            // 
            this.txtDepoBoyut.Location = new System.Drawing.Point(109, 104);
            this.txtDepoBoyut.Name = "txtDepoBoyut";
            this.txtDepoBoyut.Size = new System.Drawing.Size(131, 20);
            this.txtDepoBoyut.TabIndex = 6;
            // 
            // txtDepoID
            // 
            this.txtDepoID.Enabled = false;
            this.txtDepoID.Location = new System.Drawing.Point(109, 26);
            this.txtDepoID.Name = "txtDepoID";
            this.txtDepoID.Size = new System.Drawing.Size(131, 20);
            this.txtDepoID.TabIndex = 6;
            // 
            // txtDepoNo
            // 
            this.txtDepoNo.Location = new System.Drawing.Point(109, 52);
            this.txtDepoNo.Name = "txtDepoNo";
            this.txtDepoNo.Size = new System.Drawing.Size(131, 20);
            this.txtDepoNo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sorumlu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Boyutu";
            // 
            // labelc5
            // 
            this.labelc5.AutoSize = true;
            this.labelc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelc5.Location = new System.Drawing.Point(19, 26);
            this.labelc5.Name = "labelc5";
            this.labelc5.Size = new System.Drawing.Size(26, 20);
            this.labelc5.TabIndex = 5;
            this.labelc5.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adresi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Depo No";
            // 
            // depoduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "depoduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "depoduzenle";
            this.Load += new System.EventHandler(this.depoduzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbDepoAdres;
        public System.Windows.Forms.TextBox txtDepoSorumlu;
        public System.Windows.Forms.TextBox txtDepoBoyut;
        public System.Windows.Forms.TextBox txtDepoID;
        public System.Windows.Forms.TextBox txtDepoNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelc5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mskSorumluTel;
        public System.Windows.Forms.Button btndepodüzenle;
    }
}