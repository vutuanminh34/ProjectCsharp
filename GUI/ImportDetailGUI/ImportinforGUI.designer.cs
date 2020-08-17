namespace GUI
{
    partial class ImportinforGUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.import_detail_import_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_detail_product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPN2 = new System.Windows.Forms.DataGridView();
            this.import_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_distributor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "THÔNG TIN PHIẾU NHẬP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "THÔNG TIN CÁC SẢN PHẨM ĐÃ NHẬP";
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.import_detail_import_id,
            this.import_detail_product_id,
            this.import_amount});
            this.dgvCTPN.Location = new System.Drawing.Point(16, 289);
            this.dgvCTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.Size = new System.Drawing.Size(593, 158);
            this.dgvCTPN.TabIndex = 10;
            // 
            // import_detail_import_id
            // 
            this.import_detail_import_id.DataPropertyName = "import_detail_import_id";
            this.import_detail_import_id.HeaderText = "Mã PN";
            this.import_detail_import_id.Name = "import_detail_import_id";
            this.import_detail_import_id.Width = 133;
            // 
            // import_detail_product_id
            // 
            this.import_detail_product_id.DataPropertyName = "import_detail_product_id";
            this.import_detail_product_id.HeaderText = "Mã SP";
            this.import_detail_product_id.Name = "import_detail_product_id";
            this.import_detail_product_id.Width = 133;
            // 
            // import_amount
            // 
            this.import_amount.DataPropertyName = "import_amount";
            this.import_amount.HeaderText = "Số lượng nhập";
            this.import_amount.Name = "import_amount";
            this.import_amount.Width = 133;
            // 
            // dgvPN2
            // 
            this.dgvPN2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.import_id,
            this.import_date,
            this.import_staff_id,
            this.import_distributor_id});
            this.dgvPN2.Location = new System.Drawing.Point(17, 76);
            this.dgvPN2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPN2.Name = "dgvPN2";
            this.dgvPN2.Size = new System.Drawing.Size(592, 142);
            this.dgvPN2.TabIndex = 11;
            // 
            // import_id
            // 
            this.import_id.DataPropertyName = "import_id";
            this.import_id.HeaderText = "Mã PN";
            this.import_id.Name = "import_id";
            // 
            // import_date
            // 
            this.import_date.DataPropertyName = "import_date";
            this.import_date.HeaderText = "Ngày nhập";
            this.import_date.Name = "import_date";
            // 
            // import_staff_id
            // 
            this.import_staff_id.DataPropertyName = "import_staff_id";
            this.import_staff_id.HeaderText = "Mã NV";
            this.import_staff_id.Name = "import_staff_id";
            // 
            // import_distributor_id
            // 
            this.import_distributor_id.DataPropertyName = "import_distributor_id";
            this.import_distributor_id.HeaderText = "Mã NCC";
            this.import_distributor_id.Name = "import_distributor_id";
            // 
            // ImportinforGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 476);
            this.Controls.Add(this.dgvPN2);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportinforGUI";
            this.Text = "Thông tin phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_detail_import_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_detail_product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn import_distributor_id;
        public System.Windows.Forms.DataGridView dgvPN2;
    }
}