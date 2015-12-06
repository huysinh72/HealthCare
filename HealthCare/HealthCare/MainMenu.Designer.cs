namespace HealthCare
{
    partial class MainMenu
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
            this.btChanDoan = new System.Windows.Forms.Button();
            this.btKhamDinhKy = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            this.btBaiDang = new System.Windows.Forms.Button();
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNguoiThan = new System.Windows.Forms.Button();
            this.btLienHe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btChanDoan
            // 
            this.btChanDoan.Location = new System.Drawing.Point(38, 15);
            this.btChanDoan.Name = "btChanDoan";
            this.btChanDoan.Size = new System.Drawing.Size(75, 23);
            this.btChanDoan.TabIndex = 0;
            this.btChanDoan.Text = "Chẩn đoán";
            this.btChanDoan.UseVisualStyleBackColor = true;
            this.btChanDoan.Click += new System.EventHandler(this.btChanDoan_Click);
            // 
            // btKhamDinhKy
            // 
            this.btKhamDinhKy.Location = new System.Drawing.Point(173, 15);
            this.btKhamDinhKy.Name = "btKhamDinhKy";
            this.btKhamDinhKy.Size = new System.Drawing.Size(95, 23);
            this.btKhamDinhKy.TabIndex = 1;
            this.btKhamDinhKy.Text = "Khám định kỳ";
            this.btKhamDinhKy.UseVisualStyleBackColor = true;
            this.btKhamDinhKy.Click += new System.EventHandler(this.btKhamDinhKy_Click);
            // 
            // btThongKe
            // 
            this.btThongKe.Location = new System.Drawing.Point(335, 15);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(75, 23);
            this.btThongKe.TabIndex = 2;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            // 
            // btBaiDang
            // 
            this.btBaiDang.Location = new System.Drawing.Point(465, 15);
            this.btBaiDang.Name = "btBaiDang";
            this.btBaiDang.Size = new System.Drawing.Size(75, 23);
            this.btBaiDang.TabIndex = 3;
            this.btBaiDang.Text = "Bài đăng";
            this.btBaiDang.UseVisualStyleBackColor = true;
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Location = new System.Drawing.Point(781, 16);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(80, 13);
            this.lbTenNguoiDung.TabIndex = 4;
            this.lbTenNguoiDung.Text = "TenNguoiDung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Health Care";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btNguoiThan);
            this.groupBox1.Controls.Add(this.btLienHe);
            this.groupBox1.Controls.Add(this.btChanDoan);
            this.groupBox1.Controls.Add(this.btKhamDinhKy);
            this.groupBox1.Controls.Add(this.btThongKe);
            this.groupBox1.Controls.Add(this.btBaiDang);
            this.groupBox1.Location = new System.Drawing.Point(27, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btNguoiThan
            // 
            this.btNguoiThan.Location = new System.Drawing.Point(745, 15);
            this.btNguoiThan.Name = "btNguoiThan";
            this.btNguoiThan.Size = new System.Drawing.Size(75, 23);
            this.btNguoiThan.TabIndex = 5;
            this.btNguoiThan.Text = "Người Thân";
            this.btNguoiThan.UseVisualStyleBackColor = true;
            // 
            // btLienHe
            // 
            this.btLienHe.Location = new System.Drawing.Point(599, 15);
            this.btLienHe.Name = "btLienHe";
            this.btLienHe.Size = new System.Drawing.Size(75, 23);
            this.btLienHe.TabIndex = 4;
            this.btLienHe.Text = "Liên hệ bác sĩ";
            this.btLienHe.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTenNguoiDung);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(924, 133);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChanDoan;
        private System.Windows.Forms.Button btKhamDinhKy;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Button btBaiDang;
        private System.Windows.Forms.Label lbTenNguoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btNguoiThan;
        private System.Windows.Forms.Button btLienHe;
    }
}
