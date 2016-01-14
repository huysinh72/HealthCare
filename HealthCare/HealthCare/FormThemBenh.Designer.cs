namespace HealthCare
{
    partial class FormThemBenh
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTrieuChung = new System.Windows.Forms.ListBox();
            this.lbViTriBenh = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenBenh = new System.Windows.Forms.TextBox();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.tbLoiKhuyen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Chọn triệu chứng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Chọn vị trí bệnh";
            // 
            // lbTrieuChung
            // 
            this.lbTrieuChung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrieuChung.FormattingEnabled = true;
            this.lbTrieuChung.ItemHeight = 19;
            this.lbTrieuChung.Location = new System.Drawing.Point(173, 51);
            this.lbTrieuChung.Name = "lbTrieuChung";
            this.lbTrieuChung.ScrollAlwaysVisible = true;
            this.lbTrieuChung.Size = new System.Drawing.Size(120, 213);
            this.lbTrieuChung.TabIndex = 26;
            // 
            // lbViTriBenh
            // 
            this.lbViTriBenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViTriBenh.FormattingEnabled = true;
            this.lbViTriBenh.ItemHeight = 19;
            this.lbViTriBenh.Location = new System.Drawing.Point(30, 51);
            this.lbViTriBenh.Name = "lbViTriBenh";
            this.lbViTriBenh.ScrollAlwaysVisible = true;
            this.lbViTriBenh.Size = new System.Drawing.Size(120, 213);
            this.lbViTriBenh.TabIndex = 25;
            this.lbViTriBenh.SelectedIndexChanged += new System.EventHandler(this.lbViTriBenh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nhập thông tin bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên bệnh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Lời khuyên:";
            // 
            // tbTenBenh
            // 
            this.tbTenBenh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenBenh.Location = new System.Drawing.Point(398, 45);
            this.tbTenBenh.Name = "tbTenBenh";
            this.tbTenBenh.Size = new System.Drawing.Size(118, 25);
            this.tbTenBenh.TabIndex = 32;
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiDung.Location = new System.Drawing.Point(325, 92);
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNoiDung.Size = new System.Drawing.Size(407, 69);
            this.tbNoiDung.TabIndex = 33;
            // 
            // tbLoiKhuyen
            // 
            this.tbLoiKhuyen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoiKhuyen.Location = new System.Drawing.Point(328, 195);
            this.tbLoiKhuyen.Multiline = true;
            this.tbLoiKhuyen.Name = "tbLoiKhuyen";
            this.tbLoiKhuyen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLoiKhuyen.Size = new System.Drawing.Size(404, 69);
            this.tbLoiKhuyen.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nội dung:";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(292, 270);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 23);
            this.btThem.TabIndex = 36;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FormThemBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 303);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLoiKhuyen);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.tbTenBenh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTrieuChung);
            this.Controls.Add(this.lbViTriBenh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormThemBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bệnh";
            this.Load += new System.EventHandler(this.FormThemBenh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbTrieuChung;
        private System.Windows.Forms.ListBox lbViTriBenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenBenh;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.TextBox tbLoiKhuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThem;
    }
}