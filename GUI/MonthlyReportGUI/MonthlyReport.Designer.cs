namespace GUI.MonthlyReportGUI
{
    partial class MonthlyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbbstaff = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUnit_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChartAmount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbbstaff
            // 
            this.cbbstaff.FormattingEnabled = true;
            this.cbbstaff.Location = new System.Drawing.Point(83, 184);
            this.cbbstaff.Name = "cbbstaff";
            this.cbbstaff.Size = new System.Drawing.Size(121, 21);
            this.cbbstaff.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Xuất báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUnit_name
            // 
            this.lblUnit_name.AutoSize = true;
            this.lblUnit_name.Location = new System.Drawing.Point(-60, 143);
            this.lblUnit_name.Name = "lblUnit_name";
            this.lblUnit_name.Size = new System.Drawing.Size(39, 13);
            this.lblUnit_name.TabIndex = 27;
            this.lblUnit_name.Text = "Chinsu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Người lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-135, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên đơn vị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(122, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Báo cáo hàng tháng";
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.AllowUserToAddRows = false;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.product_name,
            this.donvitinh,
            this.product_amount,
            this.ghichu});
            this.dgvdanhsach.Location = new System.Drawing.Point(-47, 211);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(508, 257);
            this.dgvdanhsach.TabIndex = 22;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 30;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Tên mặt hàng";
            this.product_name.Name = "product_name";
            this.product_name.Width = 150;
            // 
            // donvitinh
            // 
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.Name = "donvitinh";
            // 
            // product_amount
            // 
            this.product_amount.HeaderText = "Số lượng tồn";
            this.product_amount.Name = "product_amount";
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 80;
            // 
            // ChartAmount
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartAmount.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartAmount.Legends.Add(legend1);
            this.ChartAmount.Location = new System.Drawing.Point(467, 211);
            this.ChartAmount.Name = "ChartAmount";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng tồn";
            this.ChartAmount.Series.Add(series1);
            this.ChartAmount.Size = new System.Drawing.Size(511, 371);
            this.ChartAmount.TabIndex = 32;
            this.ChartAmount.Text = "chart1";
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(326, 496);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 31;
            this.btnprint.Text = "In";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(83, 143);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 20);
            this.txtdate.TabIndex = 30;
            // 
            // MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 664);
            this.Controls.Add(this.cbbstaff);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblUnit_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdanhsach);
            this.Controls.Add(this.ChartAmount);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MonthlyReport";
            this.Text = "MonthlyReport";
            this.Load += new System.EventHandler(this.MonthlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cbbstaff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblUnit_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAmount;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DateTimePicker txtdate;
    }
}