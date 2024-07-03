
namespace NalburOtomasyonu
{
    partial class Depo
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
            this.depoListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoliste = new System.Windows.Forms.Button();
            this.depoekle = new System.Windows.Forms.Button();
            this.deposil = new System.Windows.Forms.Button();
            this.depoduzenle = new System.Windows.Forms.Button();
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(416, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depoListeleToolStripMenuItem,
            this.depoEkleToolStripMenuItem,
            this.depoSilToolStripMenuItem,
            this.depoDüzenleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // depoListeleToolStripMenuItem
            // 
            this.depoListeleToolStripMenuItem.Name = "depoListeleToolStripMenuItem";
            this.depoListeleToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // depoEkleToolStripMenuItem
            // 
            this.depoEkleToolStripMenuItem.Name = "depoEkleToolStripMenuItem";
            this.depoEkleToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // depoSilToolStripMenuItem
            // 
            this.depoSilToolStripMenuItem.Name = "depoSilToolStripMenuItem";
            this.depoSilToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // depoDüzenleToolStripMenuItem
            // 
            this.depoDüzenleToolStripMenuItem.Name = "depoDüzenleToolStripMenuItem";
            this.depoDüzenleToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // depoliste
            // 
            this.depoliste.Location = new System.Drawing.Point(507, 54);
            this.depoliste.Name = "depoliste";
            this.depoliste.Size = new System.Drawing.Size(185, 48);
            this.depoliste.TabIndex = 2;
            this.depoliste.Text = "Depo Listele";
            this.depoliste.UseVisualStyleBackColor = true;
            this.depoliste.Click += new System.EventHandler(this.depoliste_Click);
            // 
            // depoekle
            // 
            this.depoekle.Location = new System.Drawing.Point(507, 128);
            this.depoekle.Name = "depoekle";
            this.depoekle.Size = new System.Drawing.Size(185, 48);
            this.depoekle.TabIndex = 2;
            this.depoekle.Text = "Depo Ekle";
            this.depoekle.UseVisualStyleBackColor = true;
            this.depoekle.Click += new System.EventHandler(this.depoekle_Click);
            // 
            // deposil
            // 
            this.deposil.Location = new System.Drawing.Point(507, 209);
            this.deposil.Name = "deposil";
            this.deposil.Size = new System.Drawing.Size(185, 48);
            this.deposil.TabIndex = 2;
            this.deposil.Text = "Depo Sil";
            this.deposil.UseVisualStyleBackColor = true;
            this.deposil.Click += new System.EventHandler(this.deposil_Click);
            // 
            // depoduzenle
            // 
            this.depoduzenle.Location = new System.Drawing.Point(507, 290);
            this.depoduzenle.Name = "depoduzenle";
            this.depoduzenle.Size = new System.Drawing.Size(185, 48);
            this.depoduzenle.TabIndex = 2;
            this.depoduzenle.Text = "Depo Düzenle";
            this.depoduzenle.UseVisualStyleBackColor = true;
            this.depoduzenle.Click += new System.EventHandler(this.depoduzenle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NalburOtomasyonu.Properties.Resources._1db96aa7_3975_48af_a59c_23d8b312da6c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depoduzenle);
            this.Controls.Add(this.deposil);
            this.Controls.Add(this.depoekle);
            this.Controls.Add(this.depoliste);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Depo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depo";
            this.Load += new System.EventHandler(this.Depo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depoListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoDüzenleToolStripMenuItem;
        private System.Windows.Forms.Button depoliste;
        private System.Windows.Forms.Button depoekle;
        private System.Windows.Forms.Button deposil;
        private System.Windows.Forms.Button depoduzenle;
        private System.Windows.Forms.Button button1;
    }
}