using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;

namespace GUI.DistributorGUI
{
    public partial class DistributorMain : Form
    {
        int i;
        public DistributorMain()
        {
            InitializeComponent();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            List<DistributorObject> list = DistributorBUS.getDistributors();
            var bindingList = new BindingList<DistributorObject>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void DistributorMain_Load(object sender, EventArgs e)
        {
            btnReload_Click(sender,e);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DistributorModifier du = new DistributorModifier();
            du.btnConfirmDel.Visible = false;
            du.btnConfirmUpd.Visible = false;
            du.btnfind.Visible = false;
            du.ShowDialog(this);
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DistributorModifier du = new DistributorModifier();
            du.btnConfirminsert.Visible = false;
            du.btnConfirmDel.Visible = false;
            du.btnfind.Visible = false;
            du.ShowDialog(this);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DistributorModifier du = new DistributorModifier();
            du.btnConfirminsert.Visible = false;
            du.btnConfirmUpd.Visible = false;
            du.btnfind.Visible = false;
            du.ShowDialog(this);
        }
        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnReload_Click(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorModifier du = new DistributorModifier();
            du.btnConfirminsert.Visible = false;
            du.btnConfirmDel.Visible = false;
            du.btnfind.Visible = false;
            du.txtid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString().Replace(" ","");
            du.txtname.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            du.txtaddress.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            du.txtphone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString().Replace(" ", "");
            du.txtemail.Text = dataGridView1.Rows[i].Cells[4].Value.ToString().Replace(" ", "");
            du.ShowDialog(this);
        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
            i = e.RowIndex;
        }

        private void dataGridView1_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorObject dobj = new DistributorObject();
            dobj.Distributor_id = dataGridView1.Rows[i].Cells[0].Value.ToString();
            dobj.Distributor_name = dataGridView1.Rows[i].Cells[1].Value.ToString();
            DialogResult dlr = MessageBox.Show("Bạn thực sự muốn xóa?","Chinsu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (DistributorBUS.removeDistributor(dobj))
                {
                    MessageBox.Show("Thành công.", "Chinsu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnReload_Click(sender,e);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            DistributorModifier du = new DistributorModifier();
            du.btnConfirminsert.Visible = false;
            du.btnConfirmDel.Visible = false;
            du.btnConfirmUpd.Visible = false;
            du.btnCancel.Visible = false;
            du.label2.Visible = false;
            du.label3.Visible = false;
            du.label4.Visible = false;
            du.label5.Visible = false;
            du.txtname.Visible = false;
            du.txtaddress.Visible = false;
            du.txtphone.Visible = false;
            du.txtemail.Visible = false;
            du.ShowDialog(this);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng ứng dụng này?", "Chinsu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                Application.Exit();
            else return;
        }
    }
}
