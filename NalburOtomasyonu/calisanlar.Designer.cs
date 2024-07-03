
namespace NalburOtomasyonu
{
    partial class calisanlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.btnCalisanListele = new System.Windows.Forms.Button();
            this.btnCalisanDuzenle = new System.Windows.Forms.Button();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(12, 123);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(178, 64);
            this.btnCalisanEkle.TabIndex = 1;
            this.btnCalisanEkle.Text = "Çalışan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // btnCalisanListele
            // 
            this.btnCalisanListele.Location = new System.Drawing.Point(12, 24);
            this.btnCalisanListele.Name = "btnCalisanListele";
            this.btnCalisanListele.Size = new System.Drawing.Size(178, 64);
            this.btnCalisanListele.TabIndex = 1;
            this.btnCalisanListele.Text = "Çalışanları Listele";
            this.btnCalisanListele.UseVisualStyleBackColor = true;
            this.btnCalisanListele.Click += new System.EventHandler(this.btnCalisanListele_Click);
            // 
            // btnCalisanDuzenle
            // 
            this.btnCalisanDuzenle.Location = new System.Drawing.Point(12, 359);
            this.btnCalisanDuzenle.Name = "btnCalisanDuzenle";
            this.btnCalisanDuzenle.Size = new System.Drawing.Size(178, 64);
            this.btnCalisanDuzenle.TabIndex = 1;
            this.btnCalisanDuzenle.Text = "Çalışan Duzenle";
            this.btnCalisanDuzenle.UseVisualStyleBackColor = true;
            this.btnCalisanDuzenle.Click += new System.EventHandler(this.btnCalisanDuzenle_Click);
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.Location = new System.Drawing.Point(12, 238);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(178, 64);
            this.btnCalisanSil.TabIndex = 1;
            this.btnCalisanSil.Text = "Çalışan Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = true;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(736, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalisanSil);
            this.Controls.Add(this.btnCalisanDuzenle);
            this.Controls.Add(this.btnCalisanListele);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "calisanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "calisanlar";
            this.Load += new System.EventHandler(this.calisanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnCalisanListele;
        private System.Windows.Forms.Button btnCalisanDuzenle;
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.Button button1;
    }
}