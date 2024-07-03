
namespace NalburOtomasyonu
{
    partial class santiyeler
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şantiyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şantiyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şantiyeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şantiyeDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şantiyelerToolStripMenuItem,
            this.şantiyeEkleToolStripMenuItem,
            this.şantiyeSilToolStripMenuItem,
            this.şantiyeDüzenleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şantiyelerToolStripMenuItem
            // 
            this.şantiyelerToolStripMenuItem.Name = "şantiyelerToolStripMenuItem";
            this.şantiyelerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.şantiyelerToolStripMenuItem.Text = "Şantiyeler";
            this.şantiyelerToolStripMenuItem.Click += new System.EventHandler(this.şantiyelerToolStripMenuItem_Click);
            // 
            // şantiyeEkleToolStripMenuItem
            // 
            this.şantiyeEkleToolStripMenuItem.Name = "şantiyeEkleToolStripMenuItem";
            this.şantiyeEkleToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.şantiyeEkleToolStripMenuItem.Text = "Şantiye Ekle";
            this.şantiyeEkleToolStripMenuItem.Click += new System.EventHandler(this.şantiyeEkleToolStripMenuItem_Click);
            // 
            // şantiyeSilToolStripMenuItem
            // 
            this.şantiyeSilToolStripMenuItem.Name = "şantiyeSilToolStripMenuItem";
            this.şantiyeSilToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.şantiyeSilToolStripMenuItem.Text = "Şantiye Sil";
            this.şantiyeSilToolStripMenuItem.Click += new System.EventHandler(this.şantiyeSilToolStripMenuItem_Click);
            // 
            // şantiyeDüzenleToolStripMenuItem
            // 
            this.şantiyeDüzenleToolStripMenuItem.Name = "şantiyeDüzenleToolStripMenuItem";
            this.şantiyeDüzenleToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.şantiyeDüzenleToolStripMenuItem.Text = "Şantiye Düzenle";
            this.şantiyeDüzenleToolStripMenuItem.Click += new System.EventHandler(this.şantiyeDüzenleToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(600, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // santiyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NalburOtomasyonu.Properties.Resources._1695df0e_9a9d_48a4_bb37_5a8013dcee2e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "santiyeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "santiyeler";
            this.Load += new System.EventHandler(this.santiyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şantiyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şantiyeSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şantiyeDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şantiyelerToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}