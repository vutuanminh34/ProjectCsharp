namespace GUI.DailyReportGUI
{
    partial class DailyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.cbbstaff = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUnit_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_exprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartExamount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExamount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(543, 426);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(101, 23);
            this.btnprint.TabIndex = 21;
            this.btnprint.Text = "In";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(119, 110);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 20);
            this.txtdate.TabIndex = 20;
            // 
            // cbbstaff
            // 
            this.cbbstaff.FormattingEnabled = true;
            this.cbbstaff.Location = new System.Drawing.Point(119, 136);
            this.cbbstaff.Name = "cbbstaff";
            this.cbbstaff.Size = new System.Drawing.Size(121, 21);
            this.cbbstaff.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xuất báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUnit_name
            // 
            this.lblUnit_name.AutoSize = true;
            this.lblUnit_name.Location = new System.Drawing.Point(116, 84);
            this.lblUnit_name.Name = "lblUnit_name";
            this.lblUnit_name.Size = new System.Drawing.Size(39, 13);
            this.lblUnit_name.TabIndex = 17;
            this.lblUnit_name.Text = "Chinsu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Người lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên đơn vị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Báo cáo hàng ngày";
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.AllowUserToAddRows = false;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.product_name,
            this.donvitinh,
            this.export_amount,
            this.product_exprice,
            this.thanhtien});
            this.dgvdanhsach.Location = new System.Drawing.Point(1, 163);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.Size = new System.Drawing.Size(591, 257);
            this.dgvdanhsach.TabIndex = 12;
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
            // export_amount
            // 
            this.export_amount.HeaderText = "Số lượng bán";
            this.export_amount.Name = "export_amount";
            // 
            // product_exprice
            // 
            this.product_exprice.HeaderText = "Đơn giá";
            this.product_exprice.Name = "product_exprice";
            this.product_exprice.Width = 80;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 80;
            // 
            // chartExamount
            // 
            chartArea3.Name = "ChartArea1";
            this.chartExamount.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartExamount.Legends.Add(legend3);
            this.chartExamount.Location = new System.Drawing.Point(652, 110);
            this.chartExamount.Name = "chartExamount";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Số lượng bán ra";
            this.chartExamount.Series.Add(series3);
            this.chartExamount.Size = new System.Drawing.Size(552, 300);
            this.chartExamount.TabIndex = 22;
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 580);
            this.Controls.Add(this.chartExamount);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.cbbstaff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUnit_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdanhsach);
            this.Name = "DailyReport";
            this.Text = "DailyReportGUI";
            this.Load += new System.EventHandler(this.DailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartExamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.ComboBox cbbstaff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUnit_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn export_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_exprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExamount;
    }
}