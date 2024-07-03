
namespace NalburOtomasyonu
{
    partial class santiyesil
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
            this.btnsantiyekayitsil = new System.Windows.Forms.Button();
            this.txtSantiyeSahip = new System.Windows.Forms.TextBox();
            this.txtSantiyeSilAdresi = new System.Windows.Forms.TextBox();
            this.txtSantiyeSilId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnsantiyekayitsil);
            this.groupBox1.Controls.Add(this.txtSantiyeSahip);
            this.groupBox1.Controls.Add(this.txtSantiyeSilAdresi);
            this.groupBox1.Controls.Add(this.txtSantiyeSilId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnsantiyekayitsil
            // 
            this.btnsantiyekayitsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsantiyekayitsil.Location = new System.Drawing.Point(22, 147);
            this.btnsantiyekayitsil.Name = "btnsantiyekayitsil";
            this.btnsantiyekayitsil.Size = new System.Drawing.Size(227, 34);
            this.btnsantiyekayitsil.TabIndex = 9;
            this.btnsantiyekayitsil.Text = "Şantiye Sil";
            this.btnsantiyekayitsil.UseVisualStyleBackColor = true;
            this.btnsantiyekayitsil.Click += new System.EventHandler(this.btnstokkayitsil_Click);
            // 
            // txtSantiyeSahip
            // 
            this.txtSantiyeSahip.Enabled = false;
            this.txtSantiyeSahip.Location = new System.Drawing.Point(114, 106);
            this.txtSantiyeSahip.Name = "txtSantiyeSahip";
            this.txtSantiyeSahip.Size = new System.Drawing.Size(135, 20);
            this.txtSantiyeSahip.TabIndex = 4;
            // 
            // txtSantiyeSilAdresi
            // 
            this.txtSantiyeSilAdresi.Enabled = false;
            this.txtSantiyeSilAdresi.Location = new System.Drawing.Point(114, 66);
            this.txtSantiyeSilAdresi.Name = "txtSantiyeSilAdresi";
            this.txtSantiyeSilAdresi.Size = new System.Drawing.Size(135, 20);
            this.txtSantiyeSilAdresi.TabIndex = 4;
            // 
            // txtSantiyeSilId
            // 
            this.txtSantiyeSilId.Enabled = false;
            this.txtSantiyeSilId.Location = new System.Drawing.Point(114, 25);
            this.txtSantiyeSilId.Name = "txtSantiyeSilId";
            this.txtSantiyeSilId.Size = new System.Drawing.Size(135, 20);
            this.txtSantiyeSilId.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "İş Veren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresi";
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
            // santiyesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 225);
            this.Controls.Add(this.groupBox1);
            this.Name = "santiyesil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "santiyesil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsantiyekayitsil;
        public System.Windows.Forms.TextBox txtSantiyeSahip;
        public System.Windows.Forms.TextBox txtSantiyeSilAdresi;
        public System.Windows.Forms.TextBox txtSantiyeSilId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}