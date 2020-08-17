namespace GUI.TypeGUI
{
    partial class TypeMain
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.grdType = new System.Windows.Forms.DataGridView();
            this.type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1153, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 41);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // grdType
            // 
            this.grdType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type_id,
            this.type_name});
            this.grdType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdType.Location = new System.Drawing.Point(45, 189);
            this.grdType.Name = "grdType";
            this.grdType.RowTemplate.Height = 24;
            this.grdType.Size = new System.Drawing.Size(1169, 243);
            this.grdType.TabIndex = 8;
            this.grdType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdType_CellDoubleClick);
            // 
            // type_id
            // 
            this.type_id.DataPropertyName = "type_id";
            this.type_id.HeaderText = "Mã loại";
            this.type_id.Name = "type_id";
            // 
            // type_name
            // 
            this.type_name.DataPropertyName = "type_name";
            this.type_name.HeaderText = "Tên loại";
            this.type_name.Name = "type_name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(45, 89);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 22);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // TypeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 619);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grdType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnInsert;
    }
}