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
            this.lbDsTrieuChung = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTrieuChungTheoVung = new System.Windows.Forms.ComboBox();
            this.lbBenhChanDoan = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBenh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuẩn đoán";
            // 
            // cbVungDau
            // 
            this.cbVungDau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbVungDau.Location = new System.Drawing.Point(34, 85);
            this.cbVungDau.Name = "cbVungDau";
            this.cbVungDau.Size = new System.Drawing.Size(121, 29);
            this.cbVungDau.TabIndex = 1;
            // 
            // lbDsTrieuChung
            // 
            this.lbDsTrieuChung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsTrieuChung.FormattingEnabled = true;
            this.lbDsTrieuChung.ItemHeight = 21;
            this.lbDsTrieuChung.Location = new System.Drawing.Point(416, 83);
            this.lbDsTrieuChung.Name = "lbDsTrieuChung";
            this.lbDsTrieuChung.ScrollAlwaysVisible = true;
            this.lbDsTrieuChung.Size = new System.Drawing.Size(161, 88);
            this.lbDsTrieuChung.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn vùng đau";
            // 
            // cbTrieuChungTheoVung
            // 
            this.cbTrieuChungTheoVung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrieuChungTheoVung.FormattingEnabled = true;
            this.cbTrieuChungTheoVung.Location = new System.Drawing.Point(203, 85);
            this.cbTrieuChungTheoVung.Name = "cbTrieuChungTheoVung";
            this.cbTrieuChungTheoVung.Size = new System.Drawing.Size(164, 29);
            this.cbTrieuChungTheoVung.TabIndex = 4;
            // 
            // lbBenhChanDoan
            // 
            this.lbBenhChanDoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBenhChanDoan.FormattingEnabled = true;
            this.lbBenhChanDoan.ItemHeight = 21;
            this.lbBenhChanDoan.Location = new System.Drawing.Point(634, 85);
            this.lbBenhChanDoan.Name = "lbBenhChanDoan";
            this.lbBenhChanDoan.ScrollAlwaysVisible = true;
            this.lbBenhChanDoan.Size = new System.Drawing.Size(187, 88);
            this.lbBenhChanDoan.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Triệu chứng theo vùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Triệu chứng bạn chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chẩn đoán của hệ thống";
            // 
            // lbBenh
            // 
            this.lbBenh.AutoSize = true;
            this.lbBenh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBenh.Location = new System.Drawing.Point(54, 232);
            this.lbBenh.Name = "lbBenh";
            this.lbBenh.Size = new System.Drawing.Size(58, 15);
            this.lbBenh.TabIndex = 9;
            this.lbBenh.Text = "Tên bệnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nội dụng bệnh";
            // 
            // ChanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbBenh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbBenhChanDoan);
            this.Controls.Add(this.cbTrieuChungTheoVung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDsTrieuChung);
            this.Controls.Add(this.cbVungDau);
            this.Controls.Add(this.label1);
            this.Name = "ChanDoan";
            this.Size = new System.Drawing.Size(900, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVungDau;
        private System.Windows.Forms.ListBox lbDsTrieuChung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrieuChungTheoVung;
        private System.Windows.Forms.ListBox lbBenhChanDoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBenh;
        private System.Windows.Forms.Label label6;
    }
}
