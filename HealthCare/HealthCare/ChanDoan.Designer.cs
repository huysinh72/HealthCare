namespace HealthCare
{
    partial class ChanDoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbVungDau = new System.Windows.Forms.ComboBox();
            this.lbDsVungDauChon = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrieuChungTheoVung = new System.Windows.Forms.ComboBox();
            this.lbBenhChanDoan = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn gặp vấn đề ở đâu ?";
            // 
            // cbVungDau
            // 
            this.cbVungDau.FormattingEnabled = true;
            this.cbVungDau.Items.AddRange(new object[] {
            "Đầu",
            "Lưng",
            "Vai",
            "Cánh Tay",
            "Bàn Tay",
            "Đùi",
            "Cẳng chân",
            "Bàn Chân",
            "Mông"});
            this.cbVungDau.Location = new System.Drawing.Point(41, 85);
            this.cbVungDau.Name = "cbVungDau";
            this.cbVungDau.Size = new System.Drawing.Size(121, 21);
            this.cbVungDau.TabIndex = 1;
            // 
            // lbDsVungDauChon
            // 
            this.lbDsVungDauChon.FormattingEnabled = true;
            this.lbDsVungDauChon.Location = new System.Drawing.Point(341, 85);
            this.lbDsVungDauChon.Name = "lbDsVungDauChon";
            this.lbDsVungDauChon.Size = new System.Drawing.Size(120, 95);
            this.lbDsVungDauChon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn vùng đau";
            // 
            // cbTrieuChungTheoVung
            // 
            this.cbTrieuChungTheoVung.FormattingEnabled = true;
            this.cbTrieuChungTheoVung.Location = new System.Drawing.Point(191, 85);
            this.cbTrieuChungTheoVung.Name = "cbTrieuChungTheoVung";
            this.cbTrieuChungTheoVung.Size = new System.Drawing.Size(121, 21);
            this.cbTrieuChungTheoVung.TabIndex = 4;
            // 
            // lbBenhChanDoan
            // 
            this.lbBenhChanDoan.FormattingEnabled = true;
            this.lbBenhChanDoan.Location = new System.Drawing.Point(499, 85);
            this.lbBenhChanDoan.Name = "lbBenhChanDoan";
            this.lbBenhChanDoan.Size = new System.Drawing.Size(120, 95);
            this.lbBenhChanDoan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Triệu chứng theo vùng";
            // 
            // ChanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbBenhChanDoan);
            this.Controls.Add(this.cbTrieuChungTheoVung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDsVungDauChon);
            this.Controls.Add(this.cbVungDau);
            this.Controls.Add(this.label1);
            this.Name = "ChanDoan";
            this.Size = new System.Drawing.Size(661, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVungDau;
        private System.Windows.Forms.ListBox lbDsVungDauChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrieuChungTheoVung;
        private System.Windows.Forms.ListBox lbBenhChanDoan;
        private System.Windows.Forms.Label label3;
    }
}
