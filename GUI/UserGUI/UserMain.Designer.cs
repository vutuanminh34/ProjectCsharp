namespace GUI.UserGUI
{
    partial class UserMain
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.grdType = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(38, 169);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 22);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1146, 92);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 41);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // grdType
            // 
            this.grdType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_pass,
            this.user_permission});
            this.grdType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdType.Location = new System.Drawing.Point(38, 269);
            this.grdType.Name = "grdType";
            this.grdType.RowTemplate.Height = 24;
            this.grdType.Size = new System.Drawing.Size(1169, 243);
            this.grdType.TabIndex = 13;
            this.grdType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdType_CellDoubleClick);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "Mã";
            this.user_id.Name = "user_id";
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "User name";
            this.user_name.Name = "user_name";
            // 
            // user_pass
            // 
            this.user_pass.DataPropertyName = "user_pass";
            this.user_pass.HeaderText = "Mật khẩu";
            this.user_pass.Name = "user_pass";
            // 
            // user_permission
            // 
            this.user_permission.DataPropertyName = "user_permission";
            this.user_permission.HeaderText = "Quyền";
            this.user_permission.Name = "user_permission";
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 605);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grdType);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView grdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_permission;
    }
}