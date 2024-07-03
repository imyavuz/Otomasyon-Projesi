
namespace NalburOtomasyonu
{
    partial class calisansil
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
            this.btncalisansil = new System.Windows.Forms.Button();
            this.txtCalisanSilNo = new System.Windows.Forms.TextBox();
            this.txtCalisanSilId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalisanSilAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btncalisansil);
            this.groupBox1.Controls.Add(this.txtCalisanSilNo);
            this.groupBox1.Controls.Add(this.txtCalisanSilAdi);
            this.groupBox1.Controls.Add(this.txtCalisanSilId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btncalisansil
            // 
            this.btncalisansil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncalisansil.Location = new System.Drawing.Point(22, 147);
            this.btncalisansil.Name = "btncalisansil";
            this.btncalisansil.Size = new System.Drawing.Size(227, 34);
            this.btncalisansil.TabIndex = 9;
            this.btncalisansil.Text = "Çalışan Sil";
            this.btncalisansil.UseVisualStyleBackColor = true;
            this.btncalisansil.Click += new System.EventHandler(this.btncalisansil_Click);
            // 
            // txtCalisanSilNo
            // 
            this.txtCalisanSilNo.Enabled = false;
            this.txtCalisanSilNo.Location = new System.Drawing.Point(114, 106);
            this.txtCalisanSilNo.Name = "txtCalisanSilNo";
            this.txtCalisanSilNo.Size = new System.Drawing.Size(135, 20);
            this.txtCalisanSilNo.TabIndex = 4;
            // 
            // txtCalisanSilId
            // 
            this.txtCalisanSilId.Enabled = false;
            this.txtCalisanSilId.Location = new System.Drawing.Point(114, 25);
            this.txtCalisanSilId.Name = "txtCalisanSilId";
            this.txtCalisanSilId.Size = new System.Drawing.Size(135, 20);
            this.txtCalisanSilId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Çalışan No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çalışan Adı";
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
            // txtCalisanSilAdi
            // 
            this.txtCalisanSilAdi.Enabled = false;
            this.txtCalisanSilAdi.Location = new System.Drawing.Point(134, 66);
            this.txtCalisanSilAdi.Name = "txtCalisanSilAdi";
            this.txtCalisanSilAdi.Size = new System.Drawing.Size(115, 20);
            this.txtCalisanSilAdi.TabIndex = 4;
            // 
            // calisansil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 229);
            this.Controls.Add(this.groupBox1);
            this.Name = "calisansil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "calisansil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtCalisanSilNo;
        public System.Windows.Forms.TextBox txtCalisanSilId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCalisanSilAdi;
        public System.Windows.Forms.Button btncalisansil;
    }
}