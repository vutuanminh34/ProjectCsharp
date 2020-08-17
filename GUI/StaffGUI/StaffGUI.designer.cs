namespace GUI
{
    partial class StaffGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSCMTNV = new System.Windows.Forms.TextBox();
            this.txtDiachiNV = new System.Windows.Forms.TextBox();
            this.txtDienThoaiNV = new System.Windows.Forms.TextBox();
            this.dtpNgaysinhNV = new System.Windows.Forms.DateTimePicker();
            this.cboTrinhdoNV = new System.Windows.Forms.ComboBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnNhaplaiNV = new System.Windows.Forms.Button();
            this.btnTimNV = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimkiemNV = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_id_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_degree_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoNamNV = new System.Windows.Forms.RadioButton();
            this.rdoNuNV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "SCMTND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điện thoại";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trình độ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(227, 63);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(264, 22);
            this.txtMaNV.TabIndex = 8;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(227, 116);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(264, 22);
            this.txtTenNV.TabIndex = 9;
            // 
            // txtSCMTNV
            // 
            this.txtSCMTNV.Location = new System.Drawing.Point(631, 63);
            this.txtSCMTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSCMTNV.Name = "txtSCMTNV";
            this.txtSCMTNV.Size = new System.Drawing.Size(217, 22);
            this.txtSCMTNV.TabIndex = 10;
            // 
            // txtDiachiNV
            // 
            this.txtDiachiNV.Location = new System.Drawing.Point(631, 116);
            this.txtDiachiNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachiNV.Name = "txtDiachiNV";
            this.txtDiachiNV.Size = new System.Drawing.Size(217, 22);
            this.txtDiachiNV.TabIndex = 11;
            // 
            // txtDienThoaiNV
            // 
            this.txtDienThoaiNV.Location = new System.Drawing.Point(631, 165);
            this.txtDienThoaiNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienThoaiNV.Name = "txtDienThoaiNV";
            this.txtDienThoaiNV.Size = new System.Drawing.Size(217, 22);
            this.txtDienThoaiNV.TabIndex = 12;
            // 
            // dtpNgaysinhNV
            // 
            this.dtpNgaysinhNV.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaysinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinhNV.Location = new System.Drawing.Point(225, 165);
            this.dtpNgaysinhNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaysinhNV.Name = "dtpNgaysinhNV";
            this.dtpNgaysinhNV.Size = new System.Drawing.Size(265, 22);
            this.dtpNgaysinhNV.TabIndex = 15;
            // 
            // cboTrinhdoNV
            // 
            this.cboTrinhdoNV.FormattingEnabled = true;
            this.cboTrinhdoNV.Location = new System.Drawing.Point(631, 212);
            this.cboTrinhdoNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTrinhdoNV.Name = "cboTrinhdoNV";
            this.cboTrinhdoNV.Size = new System.Drawing.Size(217, 24);
            this.cboTrinhdoNV.TabIndex = 16;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(927, 15);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(100, 28);
            this.btnThemNV.TabIndex = 17;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(927, 60);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(100, 28);
            this.btnSuaNV.TabIndex = 18;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(927, 112);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(100, 28);
            this.btnXoaNV.TabIndex = 19;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnNhaplaiNV
            // 
            this.btnNhaplaiNV.Location = new System.Drawing.Point(927, 161);
            this.btnNhaplaiNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhaplaiNV.Name = "btnNhaplaiNV";
            this.btnNhaplaiNV.Size = new System.Drawing.Size(100, 28);
            this.btnNhaplaiNV.TabIndex = 20;
            this.btnNhaplaiNV.Text = "Nhập lại";
            this.btnNhaplaiNV.UseVisualStyleBackColor = true;
            this.btnNhaplaiNV.Click += new System.EventHandler(this.btnNhaplaiNV_Click);
            // 
            // btnTimNV
            // 
            this.btnTimNV.Location = new System.Drawing.Point(927, 258);
            this.btnTimNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimNV.Name = "btnTimNV";
            this.btnTimNV.Size = new System.Drawing.Size(100, 28);
            this.btnTimNV.TabIndex = 21;
            this.btnTimNV.Text = "Tìm kiếm";
            this.btnTimNV.UseVisualStyleBackColor = true;
            this.btnTimNV.Click += new System.EventHandler(this.btnTimNV_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tìm kiếm";
            // 
            // txtTimkiemNV
            // 
            this.txtTimkiemNV.Location = new System.Drawing.Point(631, 260);
            this.txtTimkiemNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemNV.Name = "txtTimkiemNV";
            this.txtTimkiemNV.Size = new System.Drawing.Size(217, 22);
            this.txtTimkiemNV.TabIndex = 23;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.staff_name,
            this.staff_birth,
            this.staff_gender,
            this.staff_id_number,
            this.staff_address,
            this.staff_phone,
            this.staff_degree_id});
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 297);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1124, 180);
            this.dgvNhanVien.TabIndex = 24;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhanVien_CellMouseClick);
            this.dgvNhanVien.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_RowEnter);
            this.dgvNhanVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvNhanVien_RowPrePaint);
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "Mã NV";
            this.staff_id.Name = "staff_id";
            // 
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "Tên NV";
            this.staff_name.Name = "staff_name";
            // 
            // staff_birth
            // 
            this.staff_birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staff_birth.DataPropertyName = "staff_birth";
            this.staff_birth.HeaderText = "Ngày Sinh";
            this.staff_birth.Name = "staff_birth";
            // 
            // staff_gender
            // 
            this.staff_gender.DataPropertyName = "staff_gender";
            this.staff_gender.HeaderText = "Giới tính";
            this.staff_gender.Name = "staff_gender";
            // 
            // staff_id_number
            // 
            this.staff_id_number.DataPropertyName = "staff_id_number";
            this.staff_id_number.HeaderText = "Số CMTND";
            this.staff_id_number.Name = "staff_id_number";
            // 
            // staff_address
            // 
            this.staff_address.DataPropertyName = "staff_address";
            this.staff_address.HeaderText = "Địa chỉ";
            this.staff_address.Name = "staff_address";
            // 
            // staff_phone
            // 
            this.staff_phone.DataPropertyName = "staff_phone";
            this.staff_phone.HeaderText = "SĐT";
            this.staff_phone.Name = "staff_phone";
            // 
            // staff_degree_id
            // 
            this.staff_degree_id.DataPropertyName = "staff_degree_id";
            this.staff_degree_id.HeaderText = "Mã TD";
            this.staff_degree_id.Name = "staff_degree_id";
            // 
            // rdoNamNV
            // 
            this.rdoNamNV.AutoSize = true;
            this.rdoNamNV.Location = new System.Drawing.Point(29, 16);
            this.rdoNamNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNamNV.Name = "rdoNamNV";
            this.rdoNamNV.Size = new System.Drawing.Size(58, 21);
            this.rdoNamNV.TabIndex = 25;
            this.rdoNamNV.TabStop = true;
            this.rdoNamNV.Text = "Nam";
            this.rdoNamNV.UseVisualStyleBackColor = true;
            // 
            // rdoNuNV
            // 
            this.rdoNuNV.AutoSize = true;
            this.rdoNuNV.Location = new System.Drawing.Point(187, 16);
            this.rdoNuNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNuNV.Name = "rdoNuNV";
            this.rdoNuNV.Size = new System.Drawing.Size(47, 21);
            this.rdoNuNV.TabIndex = 26;
            this.rdoNuNV.TabStop = true;
            this.rdoNuNV.Text = "Nữ";
            this.rdoNuNV.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNuNV);
            this.groupBox1.Controls.Add(this.rdoNamNV);
            this.groupBox1.Location = new System.Drawing.Point(213, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(279, 44);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(927, 212);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 28);
            this.btnXem.TabIndex = 28;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(927, 484);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // StaffGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 523);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtTimkiemNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTimNV);
            this.Controls.Add(this.btnNhaplaiNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.cboTrinhdoNV);
            this.Controls.Add(this.dtpNgaysinhNV);
            this.Controls.Add(this.txtDienThoaiNV);
            this.Controls.Add(this.txtDiachiNV);
            this.Controls.Add(this.txtSCMTNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffGUI";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSCMTNV;
        private System.Windows.Forms.TextBox txtDiachiNV;
        private System.Windows.Forms.TextBox txtDienThoaiNV;
        private System.Windows.Forms.DateTimePicker dtpNgaysinhNV;
        private System.Windows.Forms.ComboBox cboTrinhdoNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnNhaplaiNV;
        private System.Windows.Forms.Button btnTimNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimkiemNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.RadioButton rdoNamNV;
        private System.Windows.Forms.RadioButton rdoNuNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_degree_id;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
    }
}

