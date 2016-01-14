namespace HealthCare
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhipTimTB = new System.Windows.Forms.TextBox();
            this.lbNhipTimTB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartNhipTim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EmoVui = new System.Windows.Forms.PictureBox();
            this.EmoBuon = new System.Windows.Forms.PictureBox();
            this.EmoTucGian = new System.Windows.Forms.PictureBox();
            this.EmoNgacNhien = new System.Windows.Forms.PictureBox();
            this.EmoKhinhThuong = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVui = new System.Windows.Forms.Label();
            this.lbBuon = new System.Windows.Forms.Label();
            this.lbKhinhThuong = new System.Windows.Forms.Label();
            this.lbNgacNhien = new System.Windows.Forms.Label();
            this.lbTucGian = new System.Windows.Forms.Label();
            this.lbBinhThuong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EmoBinhThuong = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhipTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoVui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoBuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoTucGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoNgacNhien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoKhinhThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoBinhThuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê";
            // 
            // tbNhipTimTB
            // 
            this.tbNhipTimTB.Enabled = false;
            this.tbNhipTimTB.Location = new System.Drawing.Point(213, 291);
            this.tbNhipTimTB.Name = "tbNhipTimTB";
            this.tbNhipTimTB.ReadOnly = true;
            this.tbNhipTimTB.Size = new System.Drawing.Size(68, 20);
            this.tbNhipTimTB.TabIndex = 9;
            // 
            // lbNhipTimTB
            // 
            this.lbNhipTimTB.AutoSize = true;
            this.lbNhipTimTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhipTimTB.Location = new System.Drawing.Point(80, 290);
            this.lbNhipTimTB.Name = "lbNhipTimTB";
            this.lbNhipTimTB.Size = new System.Drawing.Size(127, 19);
            this.lbNhipTimTB.TabIndex = 8;
            this.lbNhipTimTB.Text = "Nhịp tim trung bình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thống kê cảm xúc trong 50 lần khám gần đây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biểu đồ nhịp tim";
            // 
            // chartNhipTim
            // 
            chartArea9.Name = "ChartArea1";
            this.chartNhipTim.ChartAreas.Add(chartArea9);
            this.chartNhipTim.Location = new System.Drawing.Point(44, 49);
            this.chartNhipTim.Name = "chartNhipTim";
            series9.ChartArea = "ChartArea1";
            series9.Name = "NhipTim";
            this.chartNhipTim.Series.Add(series9);
            this.chartNhipTim.Size = new System.Drawing.Size(311, 206);
            this.chartNhipTim.TabIndex = 10;
            this.chartNhipTim.Text = "chart1";
            // 
            // EmoVui
            // 
            this.EmoVui.Location = new System.Drawing.Point(495, 49);
            this.EmoVui.Name = "EmoVui";
            this.EmoVui.Size = new System.Drawing.Size(46, 46);
            this.EmoVui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmoVui.TabIndex = 17;
            this.EmoVui.TabStop = false;
            // 
            // EmoBuon
            // 
            this.EmoBuon.Location = new System.Drawing.Point(495, 118);
            this.EmoBuon.Name = "EmoBuon";
            this.EmoBuon.Size = new System.Drawing.Size(46, 46);
            this.EmoBuon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmoBuon.TabIndex = 18;
            this.EmoBuon.TabStop = false;
            // 
            // EmoTucGian
            // 
            this.EmoTucGian.Location = new System.Drawing.Point(495, 184);
            this.EmoTucGian.Name = "EmoTucGian";
            this.EmoTucGian.Size = new System.Drawing.Size(46, 46);
            this.EmoTucGian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmoTucGian.TabIndex = 19;
            this.EmoTucGian.TabStop = false;
            // 
            // EmoNgacNhien
            // 
            this.EmoNgacNhien.Location = new System.Drawing.Point(752, 49);
            this.EmoNgacNhien.Name = "EmoNgacNhien";
            this.EmoNgacNhien.Size = new System.Drawing.Size(46, 46);
            this.EmoNgacNhien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmoNgacNhien.TabIndex = 20;
            this.EmoNgacNhien.TabStop = false;
            // 
            // EmoKhinhThuong
            // 
            this.EmoKhinhThuong.Location = new System.Drawing.Point(752, 118);
            this.EmoKhinhThuong.Name = "EmoKhinhThuong";
            this.EmoKhinhThuong.Size = new System.Drawing.Size(46, 46);
            this.EmoKhinhThuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmoKhinhThuong.TabIndex = 21;
            this.EmoKhinhThuong.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Vui";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Buồn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tức giận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngạc nhiên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Khinh thường";
            // 
            // lbVui
            // 
            this.lbVui.AutoSize = true;
            this.lbVui.Location = new System.Drawing.Point(557, 66);
            this.lbVui.Name = "lbVui";
            this.lbVui.Size = new System.Drawing.Size(35, 13);
            this.lbVui.TabIndex = 27;
            this.lbVui.Text = "label9";
            // 
            // lbBuon
            // 
            this.lbBuon.AutoSize = true;
            this.lbBuon.Location = new System.Drawing.Point(557, 135);
            this.lbBuon.Name = "lbBuon";
            this.lbBuon.Size = new System.Drawing.Size(35, 13);
            this.lbBuon.TabIndex = 28;
            this.lbBuon.Text = "label9";
            // 
            // lbKhinhThuong
            // 
            this.lbKhinhThuong.AutoSize = true;
            this.lbKhinhThuong.Location = new System.Drawing.Point(804, 135);
            this.lbKhinhThuong.Name = "lbKhinhThuong";
            this.lbKhinhThuong.Size = new System.Drawing.Size(35, 13);
            this.lbKhinhThuong.TabIndex = 29;
            this.lbKhinhThuong.Text = "label9";
            // 
            // lbNgacNhien
            // 
            this.lbNgacNhien.AutoSize = true;
            this.lbNgacNhien.Location = new System.Drawing.Point(804, 66);
            this.lbNgacNhien.Name = "lbNgacNhien";
            this.lbNgacNhien.Size = new System.Drawing.Size(35, 13);
            this.lbNgacNhien.TabIndex = 30;
            this.lbNgacNhien.Text = "label9";
            // 
            // lbTucGian
            // 
            this.lbTucGian.AutoSize = true;
            this.lbTucGian.Location = new System.Drawing.Point(557, 202);
            this.lbTucGian.Name = "lbTucGian";
            this.lbTucGian.Size = new System.Drawing.Size(35, 13);
            this.lbTucGian.TabIndex = 31;
            this.lbTucGian.Text = "label9";
            // 
            // lbBinhThuong
            // 
            this.lbBinhThuong.AutoSize = true;
            this.lbBinhThuong.Location = new System.Drawing.Point(804, 201);
            this.lbBinhThuong.Name = "lbBinhThuong";
            this.lbBinhThuong.Size = new System.Drawing.Size(35, 13);
            this.lbBinhThuong.TabIndex = 34;
            this.lbBinhThuong.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(644, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Bình thường";
            // 
            // EmoBinhThuong
            // 
            this.EmoBinhThuong.Location = new System.Drawing.Point(752, 184);
            this.EmoBinhThuong.Name = "EmoBinhThuong";
            this.EmoBinhThuong.Size = new System.Drawing.Size(46, 46);
            this.EmoBinhThuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmoBinhThuong.TabIndex = 32;
            this.EmoBinhThuong.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Chuẩn đoán";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 335);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(792, 55);
            this.textBox1.TabIndex = 36;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbBinhThuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmoBinhThuong);
            this.Controls.Add(this.lbTucGian);
            this.Controls.Add(this.lbNgacNhien);
            this.Controls.Add(this.lbKhinhThuong);
            this.Controls.Add(this.lbBuon);
            this.Controls.Add(this.lbVui);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmoKhinhThuong);
            this.Controls.Add(this.EmoNgacNhien);
            this.Controls.Add(this.EmoTucGian);
            this.Controls.Add(this.EmoBuon);
            this.Controls.Add(this.EmoVui);
            this.Controls.Add(this.chartNhipTim);
            this.Controls.Add(this.tbNhipTimTB);
            this.Controls.Add(this.lbNhipTimTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(900, 400);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartNhipTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoVui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoBuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoTucGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoNgacNhien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoKhinhThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmoBinhThuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNhipTimTB;
        private System.Windows.Forms.Label lbNhipTimTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhipTim;
        private System.Windows.Forms.PictureBox EmoVui;
        private System.Windows.Forms.PictureBox EmoBuon;
        private System.Windows.Forms.PictureBox EmoTucGian;
        private System.Windows.Forms.PictureBox EmoNgacNhien;
        private System.Windows.Forms.PictureBox EmoKhinhThuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbVui;
        private System.Windows.Forms.Label lbBuon;
        private System.Windows.Forms.Label lbKhinhThuong;
        private System.Windows.Forms.Label lbNgacNhien;
        private System.Windows.Forms.Label lbTucGian;
        private System.Windows.Forms.Label lbBinhThuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox EmoBinhThuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}
