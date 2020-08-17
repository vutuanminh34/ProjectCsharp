namespace GUI
{
    partial class ImportGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportGUI));
            this.txtSoPN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_imprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoluongPN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.grbThongTinPhieuNhap = new System.Windows.Forms.GroupBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.dtpNgaynhapPN = new System.Windows.Forms.DateTimePicker();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.txtTongsoluong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtNhanhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTietPhieuNhap = new System.Windows.Forms.GroupBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnXoaPN = new System.Windows.Forms.Button();
            this.btnSuaPN = new System.Windows.Forms.Button();
            this.btnInPN = new System.Windows.Forms.Button();
            this.btnLuuPN = new System.Windows.Forms.Button();
            this.btnHuyPN = new System.Windows.Forms.Button();
            this.btnNhaplaiPN = new System.Windows.Forms.Button();
            this.btnXemPN = new System.Windows.Forms.Button();
            this.btnChonPN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            this.grbThongTinPhieuNhap.SuspendLayout();
            this.grbChiTietPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoPN
            // 
            this.txtSoPN.Location = new System.Drawing.Point(145, 27);
            this.txtSoPN.Name = "txtSoPN";
            this.txtSoPN.Size = new System.Drawing.Size(200, 23);
            this.txtSoPN.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập";
            // 
            // dgvPN
            // 
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.product_brand,
            this.import_amount,
            this.product_imprice,
            this.total});
            this.dgvPN.Location = new System.Drawing.Point(29, 432);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.Size = new System.Drawing.Size(745, 190);
            this.dgvPN.TabIndex = 35;
            this.dgvPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellClick);
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Mã SP";
            this.product_id.Name = "product_id";
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Tên sản phẩm";
            this.product_name.Name = "product_name";
            this.product_name.Width = 200;
            // 
            // product_brand
            // 
            this.product_brand.HeaderText = "Hãng sản xuất";
            this.product_brand.Name = "product_brand";
            // 
            // import_amount
            // 
            this.import_amount.HeaderText = "Số lượng";
            this.import_amount.Name = "import_amount";
            // 
            // product_imprice
            // 
            this.product_imprice.HeaderText = "Đơn giá";
            this.product_imprice.Name = "product_imprice";
            // 
            // total
            // 
            this.total.HeaderText = "Thành tiền";
            this.total.Name = "total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu nhập";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Tổng tiền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(407, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tổng số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(407, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tên sản phẩm";
            // 
            // txtSoluongPN
            // 
            this.txtSoluongPN.Location = new System.Drawing.Point(145, 61);
            this.txtSoluongPN.Name = "txtSoluongPN";
            this.txtSoluongPN.Size = new System.Drawing.Size(200, 23);
            this.txtSoluongPN.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nhãn hiệu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã sản phẩm";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(148, 122);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(197, 23);
            this.txtTenNCC.TabIndex = 13;
            // 
            // grbThongTinPhieuNhap
            // 
            this.grbThongTinPhieuNhap.Controls.Add(this.txtTenNCC);
            this.grbThongTinPhieuNhap.Controls.Add(this.cboMaNCC);
            this.grbThongTinPhieuNhap.Controls.Add(this.dtpNgaynhapPN);
            this.grbThongTinPhieuNhap.Controls.Add(this.cboMaNV);
            this.grbThongTinPhieuNhap.Controls.Add(this.txtTenNV);
            this.grbThongTinPhieuNhap.Controls.Add(this.txtSoPN);
            this.grbThongTinPhieuNhap.Controls.Add(this.label7);
            this.grbThongTinPhieuNhap.Controls.Add(this.label6);
            this.grbThongTinPhieuNhap.Controls.Add(this.label5);
            this.grbThongTinPhieuNhap.Controls.Add(this.label4);
            this.grbThongTinPhieuNhap.Controls.Add(this.label3);
            this.grbThongTinPhieuNhap.Controls.Add(this.label2);
            this.grbThongTinPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinPhieuNhap.Location = new System.Drawing.Point(29, 45);
            this.grbThongTinPhieuNhap.Name = "grbThongTinPhieuNhap";
            this.grbThongTinPhieuNhap.Size = new System.Drawing.Size(745, 156);
            this.grbThongTinPhieuNhap.TabIndex = 25;
            this.grbThongTinPhieuNhap.TabStop = false;
            this.grbThongTinPhieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(148, 90);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(197, 23);
            this.cboMaNCC.TabIndex = 12;
            this.cboMaNCC.SelectedIndexChanged += new System.EventHandler(this.cboMaNCC_SelectedIndexChanged);
            // 
            // dtpNgaynhapPN
            // 
            this.dtpNgaynhapPN.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaynhapPN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaynhapPN.Location = new System.Drawing.Point(145, 57);
            this.dtpNgaynhapPN.Name = "dtpNgaynhapPN";
            this.dtpNgaynhapPN.Size = new System.Drawing.Size(200, 23);
            this.dtpNgaynhapPN.TabIndex = 11;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(520, 27);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(160, 23);
            this.cboMaNV.TabIndex = 10;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(520, 60);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(160, 23);
            this.txtTenNV.TabIndex = 8;
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(145, 32);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(200, 23);
            this.cboMaSP.TabIndex = 13;
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged);
            // 
            // txtTongsoluong
            // 
            this.txtTongsoluong.Location = new System.Drawing.Point(520, 61);
            this.txtTongsoluong.Name = "txtTongsoluong";
            this.txtTongsoluong.Size = new System.Drawing.Size(160, 23);
            this.txtTongsoluong.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(520, 32);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(160, 23);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtNhanhieu
            // 
            this.txtNhanhieu.Location = new System.Drawing.Point(145, 119);
            this.txtNhanhieu.Name = "txtNhanhieu";
            this.txtNhanhieu.Size = new System.Drawing.Size(200, 23);
            this.txtNhanhieu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "THÔNG TIN PHIẾU NHẬP";
            this.label1.UseMnemonic = false;
            // 
            // grbChiTietPhieuNhap
            // 
            this.grbChiTietPhieuNhap.Controls.Add(this.cboMaSP);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtTongtien);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtTongsoluong);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtTenSP);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtNhanhieu);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtDongia);
            this.grbChiTietPhieuNhap.Controls.Add(this.txtSoluongPN);
            this.grbChiTietPhieuNhap.Controls.Add(this.label14);
            this.grbChiTietPhieuNhap.Controls.Add(this.label13);
            this.grbChiTietPhieuNhap.Controls.Add(this.label12);
            this.grbChiTietPhieuNhap.Controls.Add(this.label11);
            this.grbChiTietPhieuNhap.Controls.Add(this.label10);
            this.grbChiTietPhieuNhap.Controls.Add(this.label9);
            this.grbChiTietPhieuNhap.Controls.Add(this.label8);
            this.grbChiTietPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChiTietPhieuNhap.Location = new System.Drawing.Point(29, 219);
            this.grbChiTietPhieuNhap.Name = "grbChiTietPhieuNhap";
            this.grbChiTietPhieuNhap.Size = new System.Drawing.Size(744, 153);
            this.grbChiTietPhieuNhap.TabIndex = 26;
            this.grbChiTietPhieuNhap.TabStop = false;
            this.grbChiTietPhieuNhap.Text = "Chi tiết phiếu nhập";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(520, 90);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(160, 23);
            this.txtTongtien.TabIndex = 12;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(145, 90);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(200, 23);
            this.txtDongia.TabIndex = 8;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPN.Location = new System.Drawing.Point(699, 378);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.Size = new System.Drawing.Size(75, 48);
            this.btnXoaPN.TabIndex = 34;
            this.btnXoaPN.Text = "Xóa";
            this.btnXoaPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPN.UseVisualStyleBackColor = true;
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPN.Location = new System.Drawing.Point(604, 378);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.Size = new System.Drawing.Size(75, 48);
            this.btnSuaPN.TabIndex = 33;
            this.btnSuaPN.Text = "Sửa";
            this.btnSuaPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaPN.UseVisualStyleBackColor = true;
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click);
            // 
            // btnInPN
            // 
            this.btnInPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInPN.Location = new System.Drawing.Point(511, 378);
            this.btnInPN.Name = "btnInPN";
            this.btnInPN.Size = new System.Drawing.Size(75, 48);
            this.btnInPN.TabIndex = 32;
            this.btnInPN.Text = "In PN";
            this.btnInPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInPN.UseVisualStyleBackColor = true;
            this.btnInPN.Click += new System.EventHandler(this.btnInPN_Click);
            // 
            // btnLuuPN
            // 
            this.btnLuuPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuPN.Location = new System.Drawing.Point(412, 378);
            this.btnLuuPN.Name = "btnLuuPN";
            this.btnLuuPN.Size = new System.Drawing.Size(75, 48);
            this.btnLuuPN.TabIndex = 31;
            this.btnLuuPN.Text = "Lưu";
            this.btnLuuPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuPN.UseVisualStyleBackColor = true;
            this.btnLuuPN.Click += new System.EventHandler(this.btnLuuPN_Click);
            // 
            // btnHuyPN
            // 
            this.btnHuyPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyPN.Location = new System.Drawing.Point(313, 378);
            this.btnHuyPN.Name = "btnHuyPN";
            this.btnHuyPN.Size = new System.Drawing.Size(75, 48);
            this.btnHuyPN.TabIndex = 30;
            this.btnHuyPN.Text = "Hủy";
            this.btnHuyPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyPN.UseVisualStyleBackColor = true;
            this.btnHuyPN.Click += new System.EventHandler(this.btnHuyPN_Click);
            // 
            // btnNhaplaiPN
            // 
            this.btnNhaplaiPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaplaiPN.Location = new System.Drawing.Point(212, 378);
            this.btnNhaplaiPN.Name = "btnNhaplaiPN";
            this.btnNhaplaiPN.Size = new System.Drawing.Size(84, 48);
            this.btnNhaplaiPN.TabIndex = 29;
            this.btnNhaplaiPN.Text = "Nhập lại";
            this.btnNhaplaiPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhaplaiPN.UseVisualStyleBackColor = true;
            this.btnNhaplaiPN.Click += new System.EventHandler(this.btnNhaplaiPN_Click);
            // 
            // btnXemPN
            // 
            this.btnXemPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemPN.Location = new System.Drawing.Point(117, 378);
            this.btnXemPN.Name = "btnXemPN";
            this.btnXemPN.Size = new System.Drawing.Size(75, 48);
            this.btnXemPN.TabIndex = 28;
            this.btnXemPN.Text = "Xem";
            this.btnXemPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemPN.UseVisualStyleBackColor = true;
            this.btnXemPN.Click += new System.EventHandler(this.btnXemPN_Click);
            // 
            // btnChonPN
            // 
            this.btnChonPN.Image = global::GUI.Properties.Resources.icons8_playstore_96;
            this.btnChonPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonPN.Location = new System.Drawing.Point(25, 378);
            this.btnChonPN.Name = "btnChonPN";
            this.btnChonPN.Size = new System.Drawing.Size(75, 48);
            this.btnChonPN.TabIndex = 27;
            this.btnChonPN.Text = "Chọn";
            this.btnChonPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonPN.UseVisualStyleBackColor = true;
            this.btnChonPN.Click += new System.EventHandler(this.btnChonPN_Click);
            // 
            // ImportGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 638);
            this.Controls.Add(this.dgvPN);
            this.Controls.Add(this.btnXoaPN);
            this.Controls.Add(this.btnSuaPN);
            this.Controls.Add(this.btnInPN);
            this.Controls.Add(this.btnLuuPN);
            this.Controls.Add(this.btnHuyPN);
            this.Controls.Add(this.btnNhaplaiPN);
            this.Controls.Add(this.btnXemPN);
            this.Controls.Add(this.btnChonPN);
            this.Controls.Add(this.grbThongTinPhieuNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbChiTietPhieuNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportGUI";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.ImportGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            this.grbThongTinPhieuNhap.ResumeLayout(false);
            this.grbThongTinPhieuNhap.PerformLayout();
            this.grbChiTietPhieuNhap.ResumeLayout(false);
            this.grbChiTietPhieuNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoPN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_imprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoaPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaPN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInPN;
        private System.Windows.Forms.Button btnLuuPN;
        private System.Windows.Forms.Button btnHuyPN;
        private System.Windows.Forms.Button btnNhaplaiPN;
        private System.Windows.Forms.Button btnXemPN;
        private System.Windows.Forms.Button btnChonPN;
        private System.Windows.Forms.TextBox txtSoluongPN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.GroupBox grbThongTinPhieuNhap;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.DateTimePicker dtpNgaynhapPN;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.TextBox txtTongsoluong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtNhanhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChiTietPhieuNhap;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}