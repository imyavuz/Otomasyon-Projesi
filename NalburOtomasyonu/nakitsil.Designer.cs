
namespace NalburOtomasyonu
{
    partial class nakitsil
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
            this.nakitsilbtn = new System.Windows.Forms.Button();
            this.txtnakitsiladi = new System.Windows.Forms.TextBox();
            this.txtnakitsilno = new System.Windows.Forms.TextBox();
            this.txtnakitsilID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.nakitsilbtn);
            this.groupBox1.Controls.Add(this.txtnakitsiladi);
            this.groupBox1.Controls.Add(this.txtnakitsilno);
            this.groupBox1.Controls.Add(this.txtnakitsilID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // nakitsilbtn
            // 
            this.nakitsilbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nakitsilbtn.Location = new System.Drawing.Point(22, 147);
            this.nakitsilbtn.Name = "nakitsilbtn";
            this.nakitsilbtn.Size = new System.Drawing.Size(227, 34);
            this.nakitsilbtn.TabIndex = 9;
            this.nakitsilbtn.Text = "Satış Sil";
            this.nakitsilbtn.UseVisualStyleBackColor = true;
            this.nakitsilbtn.Click += new System.EventHandler(this.btncalisansil_Click);
            // 
            // txtnakitsiladi
            // 
            this.txtnakitsiladi.Enabled = false;
            this.txtnakitsiladi.Location = new System.Drawing.Point(114, 106);
            this.txtnakitsiladi.Name = "txtnakitsiladi";
            this.txtnakitsiladi.Size = new System.Drawing.Size(135, 20);
            this.txtnakitsiladi.TabIndex = 4;
            // 
            // txtnakitsilno
            // 
            this.txtnakitsilno.Enabled = false;
            this.txtnakitsilno.Location = new System.Drawing.Point(134, 66);
            this.txtnakitsilno.Name = "txtnakitsilno";
            this.txtnakitsilno.Size = new System.Drawing.Size(115, 20);
            this.txtnakitsilno.TabIndex = 4;
            // 
            // txtnakitsilID
            // 
            this.txtnakitsilID.Enabled = false;
            this.txtnakitsilID.Location = new System.Drawing.Point(114, 25);
            this.txtnakitsilID.Name = "txtnakitsilID";
            this.txtnakitsilID.Size = new System.Drawing.Size(135, 20);
            this.txtnakitsilID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satış No";
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
            // nakitsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 227);
            this.Controls.Add(this.groupBox1);
            this.Name = "nakitsil";
            this.Text = "nakitsil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button nakitsilbtn;
        public System.Windows.Forms.TextBox txtnakitsiladi;
        public System.Windows.Forms.TextBox txtnakitsilno;
        public System.Windows.Forms.TextBox txtnakitsilID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}