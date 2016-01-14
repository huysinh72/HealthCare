namespace HealthCare
{
    partial class FormBenh
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
            this.tbNoiDungBenh = new System.Windows.Forms.TextBox();
            this.tbLoiKhuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNoiDungBenh
            // 
            this.tbNoiDungBenh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiDungBenh.Location = new System.Drawing.Point(28, 35);
            this.tbNoiDungBenh.Multiline = true;
            this.tbNoiDungBenh.Name = "tbNoiDungBenh";
            this.tbNoiDungBenh.Size = new System.Drawing.Size(625, 174);
            this.tbNoiDungBenh.TabIndex = 0;
            // 
            // tbLoiKhuyen
            // 
            this.tbLoiKhuyen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoiKhuyen.Location = new System.Drawing.Point(28, 240);
            this.tbLoiKhuyen.Multiline = true;
            this.tbLoiKhuyen.Name = "tbLoiKhuyen";
            this.tbLoiKhuyen.Size = new System.Drawing.Size(625, 187);
            this.tbLoiKhuyen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nội dung bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lời khuyên";
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(293, 433);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(86, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "SAVE";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // FormBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoiKhuyen);
            this.Controls.Add(this.tbNoiDungBenh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bệnh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNoiDungBenh;
        private System.Windows.Forms.TextBox tbLoiKhuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
    }
}