namespace GUI.ProductGUI
{
    partial class ProductMain
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
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_feature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_exprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_imprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProduct
            // 
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.product_brand,
            this.product_image,
            this.product_specification,
            this.product_feature,
            this.product_exprice,
            this.product_imprice,
            this.product_amount,
            this.product_type_id});
            this.grdProduct.Location = new System.Drawing.Point(28, 101);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowTemplate.Height = 24;
            this.grdProduct.Size = new System.Drawing.Size(1251, 560);
            this.grdProduct.TabIndex = 1;
            this.grdProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellDoubleClick);
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Mã sản phẩm";
            this.product_id.Name = "product_id";
            this.product_id.Width = 120;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Tên sp";
            this.product_name.Name = "product_name";
            this.product_name.Width = 120;
            // 
            // product_brand
            // 
            this.product_brand.DataPropertyName = "product_brand";
            this.product_brand.HeaderText = "Hãng sp";
            this.product_brand.Name = "product_brand";
            this.product_brand.Width = 120;
            // 
            // product_image
            // 
            this.product_image.DataPropertyName = "product_image";
            this.product_image.HeaderText = "Ảnh sp";
            this.product_image.Name = "product_image";
            this.product_image.Width = 120;
            // 
            // product_specification
            // 
            this.product_specification.DataPropertyName = "product_specification";
            this.product_specification.HeaderText = "Thông số";
            this.product_specification.Name = "product_specification";
            this.product_specification.Width = 120;
            // 
            // product_feature
            // 
            this.product_feature.DataPropertyName = "product_feature";
            this.product_feature.HeaderText = "Tính năng";
            this.product_feature.Name = "product_feature";
            this.product_feature.Width = 120;
            // 
            // product_exprice
            // 
            this.product_exprice.DataPropertyName = "product_exprice";
            this.product_exprice.HeaderText = "Giá bán";
            this.product_exprice.Name = "product_exprice";
            this.product_exprice.Width = 120;
            // 
            // product_imprice
            // 
            this.product_imprice.DataPropertyName = "product_imprice";
            this.product_imprice.HeaderText = "Giá mua";
            this.product_imprice.Name = "product_imprice";
            this.product_imprice.Width = 120;
            // 
            // product_amount
            // 
            this.product_amount.DataPropertyName = "product_amount";
            this.product_amount.HeaderText = "Sl có";
            this.product_amount.Name = "product_amount";
            this.product_amount.Width = 120;
            // 
            // product_type_id
            // 
            this.product_type_id.DataPropertyName = "product_type_id";
            this.product_type_id.HeaderText = "Mã loại";
            this.product_type_id.Name = "product_type_id";
            this.product_type_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.product_type_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.product_type_id.Width = 120;
            // 
            // button1
            // 
            this.button1.Image = global::GUI.Properties.Resources.baseline_add_circle_white_18dp;
            this.button1.Location = new System.Drawing.Point(1191, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(45, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(628, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ProductMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 673);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductMain";
            this.Text = "ProductMain";
            this.Load += new System.EventHandler(this.ProductMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_feature;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_exprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_imprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_amount;
        private System.Windows.Forms.DataGridViewComboBoxColumn product_type_id;
        private System.Windows.Forms.TextBox txtSearch;
    }
}