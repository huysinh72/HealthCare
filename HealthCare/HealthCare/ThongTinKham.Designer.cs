namespace HealthCare
{
    partial class ThongTinKham
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
            this.btSuDungCamera = new System.Windows.Forms.Button();
            this.btXong = new System.Windows.Forms.Button();
            this.cbCamXuc = new System.Windows.Forms.ComboBox();
            this.tbNhipTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CamBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCanNang = new System.Windows.Forms.TextBox();
            this.tbChieuCao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btSuDungCamera
            // 
            this.btSuDungCamera.Location = new System.Drawing.Point(339, 30);
            this.btSuDungCamera.Name = "btSuDungCamera";
            this.btSuDungCamera.Size = new System.Drawing.Size(74, 23);
            this.btSuDungCamera.TabIndex = 20;
            this.btSuDungCamera.Text = "Mở camera";
            this.btSuDungCamera.UseVisualStyleBackColor = true;
            this.btSuDungCamera.Click += new System.EventHandler(this.btSuDungCamera_Click);
            // 
            // btXong
            // 
            this.btXong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXong.Location = new System.Drawing.Point(175, 211);
            this.btXong.Name = "btXong";
            this.btXong.Size = new System.Drawing.Size(158, 29);
            this.btXong.TabIndex = 19;
            this.btXong.Text = "Xong";
            this.btXong.UseVisualStyleBackColor = true;
            this.btXong.Click += new System.EventHandler(this.btXong_Click);
            // 
            // cbCamXuc
            // 
            this.cbCamXuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamXuc.FormattingEnabled = true;
            this.cbCamXuc.Items.AddRange(new object[] {
            "Vui",
            "Buồn",
            "Tức giận"});
            this.cbCamXuc.Location = new System.Drawing.Point(175, 75);
            this.cbCamXuc.Name = "cbCamXuc";
            this.cbCamXuc.Size = new System.Drawing.Size(158, 29);
            this.cbCamXuc.TabIndex = 18;
            this.cbCamXuc.Text = "Vui";
            // 
            // tbNhipTim
            // 
            this.tbNhipTim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhipTim.Location = new System.Drawing.Point(175, 30);
            this.tbNhipTim.Name = "tbNhipTim";
            this.tbNhipTim.Size = new System.Drawing.Size(158, 29);
            this.tbNhipTim.TabIndex = 17;
            this.tbNhipTim.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cảm xúc hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhịp tim:";
            // 
            // CamBox
            // 
            this.CamBox.Location = new System.Drawing.Point(433, 30);
            this.CamBox.Name = "CamBox";
            this.CamBox.Size = new System.Drawing.Size(318, 217);
            this.CamBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamBox.TabIndex = 25;
            this.CamBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chiều cao:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cân nặng:";
            // 
            // tbCanNang
            // 
            this.tbCanNang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCanNang.Location = new System.Drawing.Point(175, 156);
            this.tbCanNang.Name = "tbCanNang";
            this.tbCanNang.Size = new System.Drawing.Size(158, 29);
            this.tbCanNang.TabIndex = 24;
            this.tbCanNang.Text = "0";
            // 
            // tbChieuCao
            // 
            this.tbChieuCao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChieuCao.Location = new System.Drawing.Point(175, 116);
            this.tbChieuCao.Name = "tbChieuCao";
            this.tbChieuCao.Size = new System.Drawing.Size(158, 29);
            this.tbChieuCao.TabIndex = 23;
            this.tbChieuCao.Text = "0";
            // 
            // ThongTinKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 279);
            this.Controls.Add(this.CamBox);
            this.Controls.Add(this.tbCanNang);
            this.Controls.Add(this.tbChieuCao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSuDungCamera);
            this.Controls.Add(this.btXong);
            this.Controls.Add(this.cbCamXuc);
            this.Controls.Add(this.tbNhipTim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongTinKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinKham";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closing);
            ((System.ComponentModel.ISupportInitialize)(this.CamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSuDungCamera;
        private System.Windows.Forms.Button btXong;
        private System.Windows.Forms.ComboBox cbCamXuc;
        private System.Windows.Forms.TextBox tbNhipTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCanNang;
        private System.Windows.Forms.TextBox tbChieuCao;
    }
}