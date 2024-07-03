
namespace NalburOtomasyonu
{
    partial class depoekle
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
            this.btndepoekle = new System.Windows.Forms.Button();
            this.cmbDepoAdres = new System.Windows.Forms.ComboBox();
            this.txtDepoSorumlu = new System.Windows.Forms.TextBox();
            this.txtDepoBoyut = new System.Windows.Forms.TextBox();
            this.txtDepoNo = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.mskSorumluTel);
            this.groupBox1.Controls.Add(this.btndepoekle);
            this.groupBox1.Controls.Add(this.cmbDepoAdres);
            this.groupBox1.Controls.Add(this.txtDepoSorumlu);
            this.groupBox1.Controls.Add(this.txtDepoBoyut);
            this.groupBox1.Controls.Add(this.txtDepoNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // mskSorumluTel
            // 
            this.mskSorumluTel.Location = new System.Drawing.Point(139, 135);
            this.mskSorumluTel.Mask = "(999) 000-0000";
            this.mskSorumluTel.Name = "mskSorumluTel";
            this.mskSorumluTel.Size = new System.Drawing.Size(113, 20);
            this.mskSorumluTel.TabIndex = 9;
            // 
            // btndepoekle
            // 
            this.btndepoekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndepoekle.Location = new System.Drawing.Point(23, 175);
            this.btndepoekle.Name = "btndepoekle";
            this.btndepoekle.Size = new System.Drawing.Size(217, 34);
            this.btndepoekle.TabIndex = 8;
            this.btndepoekle.Text = "Depo Ekle";
            this.btndepoekle.UseVisualStyleBackColor = true;
            this.btndepoekle.Click += new System.EventHandler(this.btndepoekle_Click);
            // 
            // cmbDepoAdres
            // 
            this.cmbDepoAdres.FormattingEnabled = true;
            this.cmbDepoAdres.Items.AddRange(new object[] {
            "Rize",
            "Sakarya",
            "Trabzon",
            "Zonguldak",
            "Samsun"});
            this.cmbDepoAdres.Location = new System.Drawing.Point(139, 55);
            this.cmbDepoAdres.Name = "cmbDepoAdres";
            this.cmbDepoAdres.Size = new System.Drawing.Size(113, 21);
            this.cmbDepoAdres.TabIndex = 7;
            this.cmbDepoAdres.Text = "Adres Seçiniz";
            // 
            // txtDepoSorumlu
            // 
            this.txtDepoSorumlu.Location = new System.Drawing.Point(139, 109);
            this.txtDepoSorumlu.Name = "txtDepoSorumlu";
            this.txtDepoSorumlu.Size = new System.Drawing.Size(113, 20);
            this.txtDepoSorumlu.TabIndex = 6;
            // 
            // txtDepoBoyut
            // 
            this.txtDepoBoyut.Location = new System.Drawing.Point(139, 83);
            this.txtDepoBoyut.Name = "txtDepoBoyut";
            this.txtDepoBoyut.Size = new System.Drawing.Size(113, 20);
            this.txtDepoBoyut.TabIndex = 6;
            // 
            // txtDepoNo
            // 
            this.txtDepoNo.Location = new System.Drawing.Point(139, 31);
            this.txtDepoNo.Name = "txtDepoNo";
            this.txtDepoNo.Size = new System.Drawing.Size(113, 20);
            this.txtDepoNo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sorumlu Tel No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Depo Sorumlusu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Depo Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Depo Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Depo No";
            // 
            // depoekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 271);
            this.Controls.Add(this.groupBox1);
            this.Name = "depoekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "depoekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndepoekle;
        private System.Windows.Forms.ComboBox cmbDepoAdres;
        private System.Windows.Forms.TextBox txtDepoSorumlu;
        private System.Windows.Forms.TextBox txtDepoBoyut;
        private System.Windows.Forms.TextBox txtDepoNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskSorumluTel;
    }
}