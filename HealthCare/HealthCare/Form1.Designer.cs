namespace HealthCare
{
    partial class Form1
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
            this.chanDoan = new HealthCare.ChanDoan();
            this.dangKy = new HealthCare.DangKy();
            this.mainMenu = new HealthCare.MainMenu();
            this.dangNhapDangKy = new HealthCare.DangNhapDangKy();
            this.khamDinhKy = new HealthCare.KhamDinhKy();
            this.SuspendLayout();
            // 
            // chanDoan
            // 
            this.chanDoan.AutoScroll = true;
            this.chanDoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chanDoan.Location = new System.Drawing.Point(52, 144);
            this.chanDoan.Name = "chanDoan";
            this.chanDoan.Size = new System.Drawing.Size(878, 359);
            this.chanDoan.TabIndex = 3;
            // 
            // dangKy
            // 
            this.dangKy.Location = new System.Drawing.Point(245, 31);
            this.dangKy.Name = "dangKy";
            this.dangKy.Size = new System.Drawing.Size(496, 389);
            this.dangKy.TabIndex = 2;
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(27, 22);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(924, 133);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Load += new System.EventHandler(this.mainMenu_Load);
            // 
            // dangNhapDangKy
            // 
            this.dangNhapDangKy.Location = new System.Drawing.Point(282, 130);
            this.dangNhapDangKy.Name = "dangNhapDangKy";
            this.dangNhapDangKy.Size = new System.Drawing.Size(398, 204);
            this.dangNhapDangKy.TabIndex = 0;
            this.dangNhapDangKy.Load += new System.EventHandler(this.dangNhapDangKy_Load);
            // 
            // khamDinhKy
            // 
            this.khamDinhKy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.khamDinhKy.Location = new System.Drawing.Point(52, 144);
            this.khamDinhKy.Name = "khamDinhKy";
            this.khamDinhKy.Size = new System.Drawing.Size(878, 359);
            this.khamDinhKy.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 529);
            this.Controls.Add(this.khamDinhKy);
            this.Controls.Add(this.chanDoan);
            this.Controls.Add(this.dangKy);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.dangNhapDangKy);
            this.Name = "Form1";
            this.Text = "Health Care";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DangNhapDangKy dangNhapDangKy;
        private MainMenu mainMenu;
        private DangKy dangKy;
        private ChanDoan chanDoan;
        private KhamDinhKy khamDinhKy;
    }
}

