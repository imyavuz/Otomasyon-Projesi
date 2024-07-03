
namespace NalburOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şantiyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.stokİşlemleriToolStripMenuItem,
            this.depoToolStripMenuItem,
            this.fiyatListesiToolStripMenuItem,
            this.şantiyelerToolStripMenuItem,
            this.toptancılarToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            this.çalışanlarToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarToolStripMenuItem_Click);
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.stokİşlemleriToolStripMenuItem.Text = "Stok İşlemleri";
            this.stokİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.stokİşlemleriToolStripMenuItem_Click);
            // 
            // depoToolStripMenuItem
            // 
            this.depoToolStripMenuItem.Name = "depoToolStripMenuItem";
            this.depoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.depoToolStripMenuItem.Text = "Depo";
            this.depoToolStripMenuItem.Click += new System.EventHandler(this.depoToolStripMenuItem_Click);
            // 
            // fiyatListesiToolStripMenuItem
            // 
            this.fiyatListesiToolStripMenuItem.Name = "fiyatListesiToolStripMenuItem";
            this.fiyatListesiToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fiyatListesiToolStripMenuItem.Text = "Fiyat Listesi";
            this.fiyatListesiToolStripMenuItem.Click += new System.EventHandler(this.fiyatListesiToolStripMenuItem_Click);
            // 
            // şantiyelerToolStripMenuItem
            // 
            this.şantiyelerToolStripMenuItem.Name = "şantiyelerToolStripMenuItem";
            this.şantiyelerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.şantiyelerToolStripMenuItem.Text = "Şantiyeler";
            this.şantiyelerToolStripMenuItem.Click += new System.EventHandler(this.şantiyelerToolStripMenuItem_Click);
            // 
            // toptancılarToolStripMenuItem
            // 
            this.toptancılarToolStripMenuItem.Name = "toptancılarToolStripMenuItem";
            this.toptancılarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.toptancılarToolStripMenuItem.Text = "Toptancılar";
            this.toptancılarToolStripMenuItem.Click += new System.EventHandler(this.toptancılarToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.satışToolStripMenuItem.Text = "Satış";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "KÜRŞAT YAVUZ YILMAZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMLAK OTOMASYONU v0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NalburOtomasyonu.Properties.Resources._7ae0d50f_d644_4974_aa00_ed08b7f7988b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiyatListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şantiyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

