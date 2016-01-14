namespace HealthCare
{
    partial class FormThemTrieuChung
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
            this.lbViTri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTenTrieuChung = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbViTri
            // 
            this.lbViTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViTri.FormattingEnabled = true;
            this.lbViTri.ItemHeight = 19;
            this.lbViTri.Location = new System.Drawing.Point(20, 52);
            this.lbViTri.Name = "lbViTri";
            this.lbViTri.Size = new System.Drawing.Size(134, 118);
            this.lbViTri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn vị trí của triệu chứng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên triệu chứng";
            // 
            // tbTenTrieuChung
            // 
            this.tbTenTrieuChung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTrieuChung.Location = new System.Drawing.Point(201, 52);
            this.tbTenTrieuChung.Multiline = true;
            this.tbTenTrieuChung.Name = "tbTenTrieuChung";
            this.tbTenTrieuChung.Size = new System.Drawing.Size(122, 43);
            this.tbTenTrieuChung.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(201, 143);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(122, 27);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FormThemTrieuChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 194);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbTenTrieuChung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbViTri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormThemTrieuChung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm triệu chứng bệnh";
            this.Load += new System.EventHandler(this.FormThemTrieuChung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbViTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTenTrieuChung;
        private System.Windows.Forms.Button btThem;
    }
}