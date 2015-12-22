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
            this.lbChuDe = new System.Windows.Forms.ListBox();
            this.lalbel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbChuDe = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
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
            // lbChuDe
            // 
            this.lbChuDe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuDe.FormattingEnabled = true;
            this.lbChuDe.ItemHeight = 19;
            this.lbChuDe.Location = new System.Drawing.Point(41, 86);
            this.lbChuDe.Name = "lbChuDe";
            this.lbChuDe.ScrollAlwaysVisible = true;
            this.lbChuDe.Size = new System.Drawing.Size(209, 289);
            this.lbChuDe.TabIndex = 1;
            this.lbChuDe.SelectedIndexChanged += new System.EventHandler(this.lbChuDe_SelectedIndexChanged);
            // 
            // lalbel
            // 
            this.lalbel.AutoSize = true;
            this.lalbel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalbel.Location = new System.Drawing.Point(37, 59);
            this.lalbel.Name = "lalbel";
            this.lalbel.Size = new System.Drawing.Size(64, 21);
            this.lalbel.TabIndex = 3;
            this.lalbel.Text = "Chủ đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nội dung";
            // 
            // tbChuDe
            // 
            this.tbChuDe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChuDe.Location = new System.Drawing.Point(102, 56);
            this.tbChuDe.Name = "tbChuDe";
            this.tbChuDe.Size = new System.Drawing.Size(118, 25);
            this.tbChuDe.TabIndex = 6;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackgroundImage = global::HealthCare.Properties.Resources.IconFind1;
            this.btTimKiem.Location = new System.Drawing.Point(226, 57);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(24, 24);
            this.btTimKiem.TabIndex = 7;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Location = new System.Drawing.Point(283, 83);
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(575, 292);
            this.tbNoiDung.TabIndex = 8;
            // 
            // BaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.tbChuDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lalbel);
            this.Controls.Add(this.lbChuDe);
            this.Controls.Add(this.label1);
            this.Name = "BaiDang";
            this.Size = new System.Drawing.Size(900, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbChuDe;
        private System.Windows.Forms.Label lalbel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbChuDe;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbNoiDung;
    }
}
