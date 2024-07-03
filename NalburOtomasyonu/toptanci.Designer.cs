
namespace NalburOtomasyonu
{
    partial class toptanci
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
            this.toptancılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toptancılarToolStripMenuItem,
            this.toptancıEkleToolStripMenuItem,
            this.toptancıSilToolStripMenuItem,
            this.toptancıDüzenleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toptancılarToolStripMenuItem
            // 
            this.toptancılarToolStripMenuItem.Name = "toptancılarToolStripMenuItem";
            this.toptancılarToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.toptancılarToolStripMenuItem.Text = "Toptancı Listele";
            this.toptancılarToolStripMenuItem.Click += new System.EventHandler(this.toptancılarToolStripMenuItem_Click);
            // 
            // toptancıEkleToolStripMenuItem
            // 
            this.toptancıEkleToolStripMenuItem.Name = "toptancıEkleToolStripMenuItem";
            this.toptancıEkleToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.toptancıEkleToolStripMenuItem.Text = "Toptancı Ekle";
            this.toptancıEkleToolStripMenuItem.Click += new System.EventHandler(this.toptancıEkleToolStripMenuItem_Click);
            // 
            // toptancıSilToolStripMenuItem
            // 
            this.toptancıSilToolStripMenuItem.Name = "toptancıSilToolStripMenuItem";
            this.toptancıSilToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.toptancıSilToolStripMenuItem.Text = "Toptancı Sil";
            this.toptancıSilToolStripMenuItem.Click += new System.EventHandler(this.toptancıSilToolStripMenuItem_Click);
            // 
            // toptancıDüzenleToolStripMenuItem
            // 
            this.toptancıDüzenleToolStripMenuItem.Name = "toptancıDüzenleToolStripMenuItem";
            this.toptancıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.toptancıDüzenleToolStripMenuItem.Text = "Toptancı Düzenle";
            this.toptancıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.toptancıDüzenleToolStripMenuItem_Click);
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
            // toptanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NalburOtomasyonu.Properties.Resources._b9c0ef71_df18_45c5_be88_98c96e342181;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "toptanci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "toptanci";
            this.Load += new System.EventHandler(this.toptanci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toptancılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıDüzenleToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}