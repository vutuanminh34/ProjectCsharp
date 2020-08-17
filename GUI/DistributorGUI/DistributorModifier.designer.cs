namespace GUI.DistributorGUI
{
    partial class DistributorModifier
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnConfirminsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmUpd = new System.Windows.Forms.Button();
            this.btnConfirmDel = new System.Windows.Forms.Button();
            this.btnreinsert = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(214, 48);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(180, 20);
            this.txtid.TabIndex = 5;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(214, 74);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(180, 20);
            this.txtname.TabIndex = 6;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(214, 100);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(180, 20);
            this.txtaddress.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(214, 126);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(180, 20);
            this.txtphone.TabIndex = 8;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(214, 153);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(180, 20);
            this.txtemail.TabIndex = 9;
            // 
            // btnConfirminsert
            // 
            this.btnConfirminsert.Location = new System.Drawing.Point(181, 213);
            this.btnConfirminsert.Name = "btnConfirminsert";
            this.btnConfirminsert.Size = new System.Drawing.Size(113, 23);
            this.btnConfirminsert.TabIndex = 10;
            this.btnConfirminsert.Text = "Thêm";
            this.btnConfirminsert.UseVisualStyleBackColor = true;
            this.btnConfirminsert.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmUpd
            // 
            this.btnConfirmUpd.Location = new System.Drawing.Point(181, 213);
            this.btnConfirmUpd.Name = "btnConfirmUpd";
            this.btnConfirmUpd.Size = new System.Drawing.Size(113, 23);
            this.btnConfirmUpd.TabIndex = 12;
            this.btnConfirmUpd.Text = "Sửa";
            this.btnConfirmUpd.UseVisualStyleBackColor = true;
            this.btnConfirmUpd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmDel
            // 
            this.btnConfirmDel.Location = new System.Drawing.Point(181, 213);
            this.btnConfirmDel.Name = "btnConfirmDel";
            this.btnConfirmDel.Size = new System.Drawing.Size(113, 23);
            this.btnConfirmDel.TabIndex = 13;
            this.btnConfirmDel.Text = "Xóa";
            this.btnConfirmDel.UseVisualStyleBackColor = true;
            this.btnConfirmDel.Click += new System.EventHandler(this.btnConfirmDel_Click);
            // 
            // btnreinsert
            // 
            this.btnreinsert.Location = new System.Drawing.Point(62, 213);
            this.btnreinsert.Name = "btnreinsert";
            this.btnreinsert.Size = new System.Drawing.Size(113, 23);
            this.btnreinsert.TabIndex = 14;
            this.btnreinsert.Text = "Nhập lại";
            this.btnreinsert.UseVisualStyleBackColor = true;
            this.btnreinsert.Click += new System.EventHandler(this.btnreinsert_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(300, 213);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(113, 23);
            this.btnfind.TabIndex = 15;
            this.btnfind.Text = "Tìm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // DistributorModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 307);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnreinsert);
            this.Controls.Add(this.btnConfirmDel);
            this.Controls.Add(this.btnConfirmUpd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirminsert);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DistributorModifier";
            this.Text = "DistributorMain";
            this.Load += new System.EventHandler(this.DistributorAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.TextBox txtphone;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.Button btnConfirminsert;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnConfirmUpd;
        public System.Windows.Forms.Button btnConfirmDel;
        public System.Windows.Forms.Button btnfind;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnreinsert;
    }
}