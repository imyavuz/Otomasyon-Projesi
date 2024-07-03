
namespace NalburOtomasyonu
{
    partial class toptancisil
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
            this.btntoptancisil = new System.Windows.Forms.Button();
            this.txttoptancituru = new System.Windows.Forms.TextBox();
            this.txttoptanciid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttoptanciadi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btntoptancisil);
            this.groupBox1.Controls.Add(this.txttoptanciadi);
            this.groupBox1.Controls.Add(this.txttoptancituru);
            this.groupBox1.Controls.Add(this.txttoptanciid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btntoptancisil
            // 
            this.btntoptancisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntoptancisil.Location = new System.Drawing.Point(22, 137);
            this.btntoptancisil.Name = "btntoptancisil";
            this.btntoptancisil.Size = new System.Drawing.Size(227, 34);
            this.btntoptancisil.TabIndex = 9;
            this.btntoptancisil.Text = "Toptanci Sil";
            this.btntoptancisil.UseVisualStyleBackColor = true;
            this.btntoptancisil.Click += new System.EventHandler(this.btntoptancisil_Click);
            // 
            // txttoptancituru
            // 
            this.txttoptancituru.Enabled = false;
            this.txttoptancituru.Location = new System.Drawing.Point(130, 66);
            this.txttoptancituru.Name = "txttoptancituru";
            this.txttoptancituru.Size = new System.Drawing.Size(119, 20);
            this.txttoptancituru.TabIndex = 4;
            // 
            // txttoptanciid
            // 
            this.txttoptanciid.Enabled = false;
            this.txttoptanciid.Location = new System.Drawing.Point(130, 25);
            this.txttoptanciid.Name = "txttoptanciid";
            this.txttoptanciid.Size = new System.Drawing.Size(119, 20);
            this.txttoptanciid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toptancı Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Toptancı Adı";
            // 
            // txttoptanciadi
            // 
            this.txttoptanciadi.Enabled = false;
            this.txttoptanciadi.Location = new System.Drawing.Point(130, 106);
            this.txttoptanciadi.Name = "txttoptanciadi";
            this.txttoptanciadi.Size = new System.Drawing.Size(119, 20);
            this.txttoptanciadi.TabIndex = 4;
            // 
            // toptancisil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 204);
            this.Controls.Add(this.groupBox1);
            this.Name = "toptancisil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "toptancisil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntoptancisil;
        public System.Windows.Forms.TextBox txttoptanciadi;
        public System.Windows.Forms.TextBox txttoptancituru;
        public System.Windows.Forms.TextBox txttoptanciid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}