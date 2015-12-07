namespace HealthCare
{
    partial class BaiDang
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
            this.lbBaiDang = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài đăng";
            // 
            // lbBaiDang
            // 
            this.lbBaiDang.FormattingEnabled = true;
            this.lbBaiDang.Items.AddRange(new object[] {
            "Tế Bào Gốc thành kĩ thuật chủ chốt trong điều trị Tai Biến Mạch Máu Não, Đột Quỵ",
            "Theo thông tin của Hội Đột quỵ Việt Nam cho biết, mỗi năm có khoảng 200.000 người" +
                " bị đột quỵ, trong đó gần 11.000 người chết. ",
            "Đây là bệnh của hệ thần kinh phổ biến với tần suất xuất hiện 1,5 ca/1.000 người/n" +
                "ăm, tần suất này ở lứa tuổi trên 75 tuổi là ",
            "10 ca/1.000 người/năm. Theo thống kê, cứ 45 giây thế giới có 1 người bị đột quỵ v" +
                "à 3 phút có 1 ca chết do đột quỵ.",
            " Đột quỵ đang ảnh hưởng đến khoảng 20% dân số thế giới."});
            this.lbBaiDang.Location = new System.Drawing.Point(35, 60);
            this.lbBaiDang.Name = "lbBaiDang";
            this.lbBaiDang.ScrollAlwaysVisible = true;
            this.lbBaiDang.Size = new System.Drawing.Size(826, 316);
            this.lbBaiDang.TabIndex = 1;
            // 
            // BaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lbBaiDang);
            this.Controls.Add(this.label1);
            this.Name = "BaiDang";
            this.Size = new System.Drawing.Size(900, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBaiDang;
    }
}
