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
            this.lbDsTrieuChungChon = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBenhChanDoan = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btDel = new System.Windows.Forms.Button();
            this.btChanDoan = new System.Windows.Forms.Button();
            this.lbDSTrieuChungTheoVung = new System.Windows.Forms.ListBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btLayThongtin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chẩn đoán";
            // 
            // cbVungDau
            // 
            this.cbVungDau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVungDau.FormattingEnabled = true;
            this.cbVungDau.Location = new System.Drawing.Point(36, 164);
            this.cbVungDau.Name = "cbVungDau";
            this.cbVungDau.Size = new System.Drawing.Size(121, 29);
            this.cbVungDau.TabIndex = 1;
            this.cbVungDau.SelectedIndexChanged += new System.EventHandler(this.cbVungDau_SelectedIndexChanged);
            // 
            // lbDsTrieuChungChon
            // 
            this.lbDsTrieuChungChon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsTrieuChungChon.FormattingEnabled = true;
            this.lbDsTrieuChungChon.ItemHeight = 21;
            this.lbDsTrieuChungChon.Location = new System.Drawing.Point(416, 91);
            this.lbDsTrieuChungChon.Name = "lbDsTrieuChungChon";
            this.lbDsTrieuChungChon.ScrollAlwaysVisible = true;
            this.lbDsTrieuChungChon.Size = new System.Drawing.Size(161, 235);
            this.lbDsTrieuChungChon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn vùng đau";
            // 
            // lbBenhChanDoan
            // 
            this.lbBenhChanDoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBenhChanDoan.FormattingEnabled = true;
            this.lbBenhChanDoan.ItemHeight = 21;
            this.lbBenhChanDoan.Location = new System.Drawing.Point(674, 91);
            this.lbBenhChanDoan.Name = "lbBenhChanDoan";
            this.lbBenhChanDoan.ScrollAlwaysVisible = true;
            this.lbBenhChanDoan.Size = new System.Drawing.Size(187, 235);
            this.lbBenhChanDoan.TabIndex = 5;
            this.lbBenhChanDoan.SelectedIndexChanged += new System.EventHandler(this.lbBenhChanDoan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Triệu chứng theo vùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Triệu chứng bạn chọn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(670, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chẩn đoán của hệ thống";
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(416, 338);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 12;
            this.btDel.Text = "Xóa";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btChanDoan
            // 
            this.btChanDoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChanDoan.Location = new System.Drawing.Point(586, 91);
            this.btChanDoan.Name = "btChanDoan";
            this.btChanDoan.Size = new System.Drawing.Size(75, 23);
            this.btChanDoan.TabIndex = 13;
            this.btChanDoan.Text = "Chẩn đoán";
            this.btChanDoan.UseVisualStyleBackColor = true;
            this.btChanDoan.Click += new System.EventHandler(this.btChanDoan_Click);
            // 
            // lbDSTrieuChungTheoVung
            // 
            this.lbDSTrieuChungTheoVung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSTrieuChungTheoVung.FormattingEnabled = true;
            this.lbDSTrieuChungTheoVung.ItemHeight = 21;
            this.lbDSTrieuChungTheoVung.Location = new System.Drawing.Point(204, 91);
            this.lbDSTrieuChungTheoVung.Name = "lbDSTrieuChungTheoVung";
            this.lbDSTrieuChungTheoVung.Size = new System.Drawing.Size(165, 235);
            this.lbDSTrieuChungTheoVung.TabIndex = 14;
            this.lbDSTrieuChungTheoVung.SelectedIndexChanged += new System.EventHandler(this.lbDSTrieuChungTheoVung_SelectedIndexChanged);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(674, 333);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(187, 28);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Lưu thông tin khám";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLayThongtin
            // 
            this.btLayThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLayThongtin.Location = new System.Drawing.Point(36, 91);
            this.btLayThongtin.Name = "btLayThongtin";
            this.btLayThongtin.Size = new System.Drawing.Size(121, 36);
            this.btLayThongtin.TabIndex = 18;
            this.btLayThongtin.Text = "Nhâp thông tin ";
            this.btLayThongtin.UseVisualStyleBackColor = true;
            this.btLayThongtin.Click += new System.EventHandler(this.btLayThongtin_Click);
            // 
            // ChanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btLayThongtin);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbDSTrieuChungTheoVung);
            this.Controls.Add(this.btChanDoan);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbBenhChanDoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDsTrieuChungChon);
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
        private System.Windows.Forms.ListBox lbDsTrieuChungChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbBenhChanDoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btChanDoan;
        private System.Windows.Forms.ListBox lbDSTrieuChungTheoVung;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLayThongtin;
    }
}
