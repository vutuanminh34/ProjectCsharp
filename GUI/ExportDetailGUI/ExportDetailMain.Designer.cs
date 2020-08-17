namespace GUI.ExportDetailGUI
{
    partial class ExportDetailMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdExport = new System.Windows.Forms.DataGridView();
            this.export_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.export_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_exprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.txtIdStaff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExport)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdExport);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 731);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // grdExport
            // 
            this.grdExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.export_id,
            this.export_date,
            this.export_staff_id,
            this.export_customer_id});
            this.grdExport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdExport.Location = new System.Drawing.Point(0, 21);
            this.grdExport.Name = "grdExport";
            this.grdExport.RowTemplate.Height = 24;
            this.grdExport.Size = new System.Drawing.Size(593, 704);
            this.grdExport.TabIndex = 0;
            this.grdExport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExport_CellClick);
            // 
            // export_id
            // 
            this.export_id.HeaderText = "Mã hóa đơn";
            this.export_id.Name = "export_id";
            this.export_id.ReadOnly = true;
            this.export_id.Width = 200;
            // 
            // export_date
            // 
            this.export_date.HeaderText = "Ngày lập";
            this.export_date.Name = "export_date";
            this.export_date.ReadOnly = true;
            this.export_date.Width = 150;
            // 
            // export_staff_id
            // 
            this.export_staff_id.HeaderText = "Staff";
            this.export_staff_id.Name = "export_staff_id";
            // 
            // export_customer_id
            // 
            this.export_customer_id.HeaderText = "Customer";
            this.export_customer_id.Name = "export_customer_id";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(165, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập hóa đơn cần tìm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdProduct);
            this.groupBox2.Controls.Add(this.txtNameCustomer);
            this.groupBox2.Controls.Add(this.txtIdCustomer);
            this.groupBox2.Controls.Add(this.txtNameStaff);
            this.groupBox2.Controls.Add(this.txtIdStaff);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(611, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 731);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // grdProduct
            // 
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.product_brand,
            this.amount,
            this.product_exprice,
            this.totalPrice});
            this.grdProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProduct.Location = new System.Drawing.Point(25, 128);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowTemplate.Height = 24;
            this.grdProduct.Size = new System.Drawing.Size(931, 597);
            this.grdProduct.TabIndex = 8;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Mã sản phẩm";
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
            // amount
            // 
            this.amount.HeaderText = "Số lượng";
            this.amount.Name = "amount";
            // 
            // product_exprice
            // 
            this.product_exprice.HeaderText = "Đơn giá";
            this.product_exprice.Name = "product_exprice";
            this.product_exprice.Width = 150;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Thành tiền";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Width = 200;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(533, 68);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(218, 22);
            this.txtNameCustomer.TabIndex = 7;
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(533, 29);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(218, 22);
            this.txtIdCustomer.TabIndex = 6;
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Location = new System.Drawing.Point(127, 68);
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(212, 22);
            this.txtNameStaff.TabIndex = 5;
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.Location = new System.Drawing.Point(127, 29);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.Size = new System.Drawing.Size(212, 22);
            this.txtIdStaff.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // ExportDetailMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportDetailMain";
            this.Text = "ExportDetailMain";
            this.Load += new System.EventHandler(this.ExportDetailMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdExport;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.TextBox txtIdStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_exprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn export_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn export_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn export_staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn export_customer_id;
    }
}