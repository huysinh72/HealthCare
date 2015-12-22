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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhipTimTB = new System.Windows.Forms.TextBox();
            this.lbNhipTimTB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartNhipTim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhipTim)).BeginInit();
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
            this.tbNhipTimTB.Location = new System.Drawing.Point(226, 314);
            this.tbNhipTimTB.Name = "tbNhipTimTB";
            this.tbNhipTimTB.ReadOnly = true;
            this.tbNhipTimTB.Size = new System.Drawing.Size(100, 20);
            this.tbNhipTimTB.TabIndex = 9;
            // 
            // lbNhipTimTB
            // 
            this.lbNhipTimTB.AutoSize = true;
            this.lbNhipTimTB.Location = new System.Drawing.Point(79, 322);
            this.lbNhipTimTB.Name = "lbNhipTimTB";
            this.lbNhipTimTB.Size = new System.Drawing.Size(98, 13);
            this.lbNhipTimTB.TabIndex = 8;
            this.lbNhipTimTB.Text = "Nhịp tim trung bình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Biểu đồ cảm xúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biểu đồ nhịp tim";
            // 
            // chartNhipTim
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNhipTim.ChartAreas.Add(chartArea2);
            this.chartNhipTim.Location = new System.Drawing.Point(44, 69);
            this.chartNhipTim.Name = "chartNhipTim";
            series2.ChartArea = "ChartArea1";
            series2.Name = "NhipTim";
            this.chartNhipTim.Series.Add(series2);
            this.chartNhipTim.Size = new System.Drawing.Size(311, 190);
            this.chartNhipTim.TabIndex = 10;
            this.chartNhipTim.Text = "chart1";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
    }
}
