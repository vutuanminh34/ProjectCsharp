using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class DegreeGUI : Form
    {
        public DegreeGUI()
        {
            InitializeComponent();
        }

        DegreeObject D = new DegreeObject();
        DegreeBUS trinhdoh = new DegreeBUS();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DegreeGUI_Load(object sender, EventArgs e)
        {
            dgvTrinhDo.DataSource = trinhdoh.ShowTrinhDo();
        }

        private void btnThemTD_Click(object sender, EventArgs e)
        {
            if (txtMaTD.TextLength == 0)
                MessageBox.Show("Mã TĐ không được để trống!");
            else if(txtTenTD.TextLength == 0)
                MessageBox.Show("Tên TĐ không được để trống!");
            else
            {
                try
                {
                    D.MaTD = txtMaTD.Text;
                    D.TenTD = txtTenTD.Text;
                    trinhdoh.InsertTrinhDo(D.MaTD, D.TenTD);
                    MessageBox.Show("Thêm thành công!");
                    DegreeGUI_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            if (txtMaTD.TextLength == 0)
                MessageBox.Show("Mã TĐ không được để trống!");
            else if (txtTenTD.TextLength == 0)
                MessageBox.Show("Tên TĐ không được để trống!");
            else
            {
                try
                {
                    D.MaTD = txtMaTD.Text;
                    D.TenTD = txtTenTD.Text;
                    trinhdoh.UpdateTrinhdo(D.MaTD, D.TenTD);
                    MessageBox.Show("Sửa thành công!");
                    DegreeGUI_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            if (txtMaTD.TextLength == 0)
                MessageBox.Show("Mã TĐ không được để trống!");
            
            else
            {
                try
                {
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.No) return;
                    else
                    {
                        D.MaTD = txtMaTD.Text;
                        trinhdoh.DeleteTrinhDo(D.MaTD);
                        MessageBox.Show("Xóa thành công!");
                        DegreeGUI_Load(sender, e);
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnNhaplaiTD_Click(object sender, EventArgs e)
        {
            txtMaTD.Clear();
            txtMaTD.Focus();
            txtTenTD.Clear();
        }

        private void dgvTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaTD.Text = dgvTrinhDo.Rows[d].Cells[0].Value.ToString();
            txtTenTD.Text = dgvTrinhDo.Rows[d].Cells[1].Value.ToString();
        }
    }
}
