namespace HealthCare
{
    partial class KhamDinhKy
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNhietDO = new System.Windows.Forms.TextBox();
            this.tbNhipTim = new System.Windows.Forms.TextBox();
            this.cbCamXuc = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhiệt độ của bạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhịp tim của bạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cảm xúc hiện tại của bạn";
            // 
            // TBNhietDO
            // 
            this.TBNhietDO.Location = new System.Drawing.Point(214, 60);
            this.TBNhietDO.Name = "TBNhietDO";
            this.TBNhietDO.Size = new System.Drawing.Size(121, 20);
            this.TBNhietDO.TabIndex = 4;
            // 
            // tbNhipTim
            // 
            this.tbNhipTim.Location = new System.Drawing.Point(214, 90);
            this.tbNhipTim.Name = "tbNhipTim";
            this.tbNhipTim.Size = new System.Drawing.Size(121, 20);
            this.tbNhipTim.TabIndex = 5;
            // 
            // cbCamXuc
            // 
            this.cbCamXuc.FormattingEnabled = true;
            this.cbCamXuc.Items.AddRange(new object[] {
            "Vui",
            "Buồn",
            "Tức giận"});
            this.cbCamXuc.Location = new System.Drawing.Point(214, 120);
            this.cbCamXuc.Name = "cbCamXuc";
            this.cbCamXuc.Size = new System.Drawing.Size(121, 21);
            this.cbCamXuc.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KhamDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCamXuc);
            this.Controls.Add(this.tbNhipTim);
            this.Controls.Add(this.TBNhietDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KhamDinhKy";
            this.Size = new System.Drawing.Size(409, 237);
            this.Load += new System.EventHandler(this.KhamDinhKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNhietDO;
        private System.Windows.Forms.TextBox tbNhipTim;
        private System.Windows.Forms.ComboBox cbCamXuc;
        private System.Windows.Forms.Button button1;
    }
}
