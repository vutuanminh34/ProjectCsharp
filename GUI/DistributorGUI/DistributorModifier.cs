using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI.DistributorGUI
{
    public partial class DistributorModifier : Form
    {
        public DistributorModifier()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String Warnings = "";
            if (!Regex.IsMatch(txtid.Text, @"ncc{1}[0-9]+$"))
            {
                Warnings += "Mã nhà cung cấp không được để trống và có định dạng ncc---.";
            }
            if (!Regex.IsMatch(txtname.Text, @"[\w]"))
            {
                Warnings += "\rTên nhà cung cấp không được để trống.";
            }
            if (!Regex.IsMatch(txtaddress.Text, @"[\w]"))
            {
                Warnings += "\rĐịa chỉ nhà cung cấp không được để trống.";
            }
            if(!Regex.IsMatch(txtphone.Text, @"[\d]"))
            {
                Warnings += "\rSố điện thoại vừa nhập không đúng định dạng.";
            }
            if(!Regex.IsMatch(txtemail.Text, @"^[a-zA-Z][a-zA-Z0-9_\.]{1,50}@[a-zA-Z0-9]{1,}.[a-zA-Z0-9]{1,7}"))
            {
                Warnings += "\remail không đúng định dạng. VD:ABC@ABC.COM";
            }
            if (Warnings.Length == 0)
            {
                DistributorObject dobj = new DistributorObject();
                dobj.Distributor_id = txtid.Text;
                dobj.Distributor_name = txtname.Text;
                dobj.Distributor_address = txtaddress.Text;
                dobj.Distributor_phone = txtphone.Text;
                dobj.Distributor_email = txtemail.Text;
                if (DistributorBUS.createDistributor(dobj))
                {
                    MessageBox.Show("Thành công.", "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DistributorMain parent = (DistributorMain)this.Owner;
                    parent.btnReload.PerformClick();

                }
                else
                {
                    MessageBox.Show("Thất bại, kiểm tra lại trường nhập(Id trùng hoặc tên trùng).", "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show(Warnings,"Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void DistributorAdd_Load(object sender, EventArgs e)
        {
            txtid.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Warnings ="";
            if (!Regex.IsMatch(txtid.Text, @"ncc{1}[0-9]+$"))
            {
                Warnings += "Mã nhà cung cấp không được để trống và có định dạng ncc---.";
            }
            if (!Regex.IsMatch(txtname.Text, @"[\w]"))
            {
                Warnings += "\rTên nhà cung cấp không được để trống.";
            }
            if (!Regex.IsMatch(txtaddress.Text, @"[\w]"))
            {
                Warnings += "\rĐịa chỉ nhà cung cấp không được để trống.";
            }
            if (!Regex.IsMatch(txtphone.Text, @"[\d]"))
            {
                Warnings += "\rSố điện thoại vừa nhập không đúng định dạng.";
            }
            if (!Regex.IsMatch(txtemail.Text, @"^[a-zA-Z][a-zA-Z0-9_\.]{1,50}@[a-zA-Z0-9]{1,}.[a-zA-Z0-9]{1,7}"))
            {
                Warnings += "\remail không đúng định dạng. VD:ABC@ABC.COM";
            }
            if (Warnings.Length == 0)
            {
                DistributorObject dobj = new DistributorObject();
                dobj.Distributor_id = txtid.Text;
                dobj.Distributor_name = txtname.Text;
                dobj.Distributor_address = txtaddress.Text;
                dobj.Distributor_phone = txtphone.Text;
                dobj.Distributor_email = txtemail.Text;
                if (DistributorBUS.updateDistributor(dobj))
                {
                    MessageBox.Show("Thành công.", "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DistributorMain parent = (DistributorMain)this.Owner;
                    parent.btnReload.PerformClick();
                }
                else
                {
                    MessageBox.Show("Không tồn tại id", "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Warnings, "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            DistributorObject dobj = new DistributorObject();
            dobj.Distributor_id = txtid.Text;
            dobj.Distributor_name = txtname.Text;
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa?","Chinsu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dlr == DialogResult.Yes){
                if (DistributorBUS.removeDistributor(dobj))
                {
                    MessageBox.Show("Thành công.", "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DistributorMain parent = (DistributorMain)this.Owner;
                    parent.btnReload.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thất bại (không tồn tại mã hoặc tên nhà cung cấp)", "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void btnreinsert_Click(object sender, EventArgs e)
        {
                txtid.Focus();
                txtid.ResetText();
                txtname.ResetText();
                txtaddress.ResetText();
                txtphone.ResetText();
                txtemail.ResetText();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            DistributorObject dobj = new DistributorObject();
            dobj.Distributor_id = txtid.Text;
            var source = DistributorBUS.findDistributor(dobj);
            DistributorMain parent = (DistributorMain)this.Owner;
            parent.dataGridView1.DataSource = source;
            this.Dispose();
        }
    }
}
