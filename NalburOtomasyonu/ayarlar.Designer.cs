
namespace NalburOtomasyonu
{
    partial class ayarlar
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
            this.btnArkaplan1 = new System.Windows.Forms.Button();
            this.btnArkaplan2 = new System.Windows.Forms.Button();
            this.btnArkaplanTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArkaplan1
            // 
            this.btnArkaplan1.Location = new System.Drawing.Point(12, 12);
            this.btnArkaplan1.Name = "btnArkaplan1";
            this.btnArkaplan1.Size = new System.Drawing.Size(153, 33);
            this.btnArkaplan1.TabIndex = 0;
            this.btnArkaplan1.Text = "Arka Plan 1";
            this.btnArkaplan1.UseVisualStyleBackColor = true;
            // 
            // btnArkaplan2
            // 
            this.btnArkaplan2.Location = new System.Drawing.Point(12, 51);
            this.btnArkaplan2.Name = "btnArkaplan2";
            this.btnArkaplan2.Size = new System.Drawing.Size(153, 33);
            this.btnArkaplan2.TabIndex = 0;
            this.btnArkaplan2.Text = "Arka Plan 2";
            this.btnArkaplan2.UseVisualStyleBackColor = true;
            // 
            // btnArkaplanTemizle
            // 
            this.btnArkaplanTemizle.Location = new System.Drawing.Point(12, 90);
            this.btnArkaplanTemizle.Name = "btnArkaplanTemizle";
            this.btnArkaplanTemizle.Size = new System.Drawing.Size(153, 33);
            this.btnArkaplanTemizle.TabIndex = 0;
            this.btnArkaplanTemizle.Text = "Arka Plan Sil";
            this.btnArkaplanTemizle.UseVisualStyleBackColor = true;
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NalburOtomasyonu.Properties.Resources._288eb129_f4d9_4fab_a0cf_d5144dc8f8101;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArkaplanTemizle);
            this.Controls.Add(this.btnArkaplan2);
            this.Controls.Add(this.btnArkaplan1);
            this.Name = "ayarlar";
            this.Text = "ayarlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArkaplan1;
        private System.Windows.Forms.Button btnArkaplan2;
        private System.Windows.Forms.Button btnArkaplanTemizle;
    }
}