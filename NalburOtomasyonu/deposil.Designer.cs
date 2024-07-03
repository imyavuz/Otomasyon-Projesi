
namespace NalburOtomasyonu
{
    partial class deposil
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
            this.btnstokkayitsil = new System.Windows.Forms.Button();
            this.txtDepoSilNo = new System.Windows.Forms.TextBox();
            this.txtDepoSilID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnstokkayitsil);
            this.groupBox1.Controls.Add(this.txtDepoSilNo);
            this.groupBox1.Controls.Add(this.txtDepoSilID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnstokkayitsil
            // 
            this.btnstokkayitsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstokkayitsil.Location = new System.Drawing.Point(22, 106);
            this.btnstokkayitsil.Name = "btnstokkayitsil";
            this.btnstokkayitsil.Size = new System.Drawing.Size(227, 34);
            this.btnstokkayitsil.TabIndex = 9;
            this.btnstokkayitsil.Text = "Depo Sil";
            this.btnstokkayitsil.UseVisualStyleBackColor = true;
            this.btnstokkayitsil.Click += new System.EventHandler(this.btnstokkayitsil_Click);
            // 
            // txtDepoSilNo
            // 
            this.txtDepoSilNo.Enabled = false;
            this.txtDepoSilNo.Location = new System.Drawing.Point(114, 66);
            this.txtDepoSilNo.Name = "txtDepoSilNo";
            this.txtDepoSilNo.Size = new System.Drawing.Size(135, 20);
            this.txtDepoSilNo.TabIndex = 4;
            // 
            // txtDepoSilID
            // 
            this.txtDepoSilID.Enabled = false;
            this.txtDepoSilID.Location = new System.Drawing.Point(114, 25);
            this.txtDepoSilID.Name = "txtDepoSilID";
            this.txtDepoSilID.Size = new System.Drawing.Size(135, 20);
            this.txtDepoSilID.TabIndex = 4;
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
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depo No";
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
            // deposil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 214);
            this.Controls.Add(this.groupBox1);
            this.Name = "deposil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "deposil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnstokkayitsil;
        public System.Windows.Forms.TextBox txtDepoSilNo;
        public System.Windows.Forms.TextBox txtDepoSilID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}