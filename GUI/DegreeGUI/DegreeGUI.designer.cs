namespace GUI
{
    partial class DegreeGUI
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
            this.dgvTrinhDo = new System.Windows.Forms.DataGridView();
            this.degree_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.txtTenTD = new System.Windows.Forms.TextBox();
            this.btnThemTD = new System.Windows.Forms.Button();
            this.btnSuaTD = new System.Windows.Forms.Button();
            this.btnXoaTD = new System.Windows.Forms.Button();
            this.btnNhaplaiTD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrinhDo
            // 
            this.dgvTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrinhDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degree_id,
            this.degree_name});
            this.dgvTrinhDo.Location = new System.Drawing.Point(16, 15);
            this.dgvTrinhDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTrinhDo.Name = "dgvTrinhDo";
            this.dgvTrinhDo.Size = new System.Drawing.Size(325, 170);
            this.dgvTrinhDo.TabIndex = 0;
            this.dgvTrinhDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrinhDo_CellClick);
            // 
            // degree_id
            // 
            this.degree_id.DataPropertyName = "degree_id";
            this.degree_id.HeaderText = "Mã trình độ";
            this.degree_id.Name = "degree_id";
            // 
            // degree_name
            // 
            this.degree_name.DataPropertyName = "degree_name";
            this.degree_name.HeaderText = "Tên trình độ";
            this.degree_name.Name = "degree_name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã trình độ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên trình độ";
            // 
            // txtMaTD
            // 
            this.txtMaTD.Location = new System.Drawing.Point(460, 41);
            this.txtMaTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(132, 22);
            this.txtMaTD.TabIndex = 3;
            // 
            // txtTenTD
            // 
            this.txtTenTD.Location = new System.Drawing.Point(720, 41);
            this.txtTenTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(132, 22);
            this.txtTenTD.TabIndex = 4;
            // 
            // btnThemTD
            // 
            this.btnThemTD.Location = new System.Drawing.Point(373, 106);
            this.btnThemTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemTD.Name = "btnThemTD";
            this.btnThemTD.Size = new System.Drawing.Size(100, 28);
            this.btnThemTD.TabIndex = 5;
            this.btnThemTD.Text = "Thêm";
            this.btnThemTD.UseVisualStyleBackColor = true;
            this.btnThemTD.Click += new System.EventHandler(this.btnThemTD_Click);
            // 
            // btnSuaTD
            // 
            this.btnSuaTD.Location = new System.Drawing.Point(493, 106);
            this.btnSuaTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaTD.Name = "btnSuaTD";
            this.btnSuaTD.Size = new System.Drawing.Size(100, 28);
            this.btnSuaTD.TabIndex = 6;
            this.btnSuaTD.Text = "Sửa";
            this.btnSuaTD.UseVisualStyleBackColor = true;
            this.btnSuaTD.Click += new System.EventHandler(this.btnSuaTD_Click);
            // 
            // btnXoaTD
            // 
            this.btnXoaTD.Location = new System.Drawing.Point(620, 106);
            this.btnXoaTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaTD.Name = "btnXoaTD";
            this.btnXoaTD.Size = new System.Drawing.Size(100, 28);
            this.btnXoaTD.TabIndex = 7;
            this.btnXoaTD.Text = "Xóa";
            this.btnXoaTD.UseVisualStyleBackColor = true;
            this.btnXoaTD.Click += new System.EventHandler(this.btnXoaTD_Click);
            // 
            // btnNhaplaiTD
            // 
            this.btnNhaplaiTD.Location = new System.Drawing.Point(753, 106);
            this.btnNhaplaiTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhaplaiTD.Name = "btnNhaplaiTD";
            this.btnNhaplaiTD.Size = new System.Drawing.Size(100, 28);
            this.btnNhaplaiTD.TabIndex = 8;
            this.btnNhaplaiTD.Text = "Nhập lại";
            this.btnNhaplaiTD.UseVisualStyleBackColor = true;
            this.btnNhaplaiTD.Click += new System.EventHandler(this.btnNhaplaiTD_Click);
            // 
            // DegreeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 199);
            this.Controls.Add(this.btnNhaplaiTD);
            this.Controls.Add(this.btnXoaTD);
            this.Controls.Add(this.btnSuaTD);
            this.Controls.Add(this.btnThemTD);
            this.Controls.Add(this.txtTenTD);
            this.Controls.Add(this.txtMaTD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTrinhDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DegreeGUI";
            this.Text = "Trình độ";
            this.Load += new System.EventHandler(this.DegreeGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrinhDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.TextBox txtTenTD;
        private System.Windows.Forms.Button btnThemTD;
        private System.Windows.Forms.Button btnSuaTD;
        private System.Windows.Forms.Button btnXoaTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree_name;
        private System.Windows.Forms.Button btnNhaplaiTD;
    }
}