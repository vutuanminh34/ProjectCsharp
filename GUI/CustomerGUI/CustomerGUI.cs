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
using DAL;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class CustomerGUI : Form
    {
        public CustomerGUI()
        {
            InitializeComponent();
        }

        CustomerObject C = new CustomerObject();
        CustomerBUS khachhangh = new CustomerBUS();

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khachhangh.showKH();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[d].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[d].Cells[1].Value.ToString();
            dptNgaysinhKH.Value = Convert.ToDateTime(dgvKhachHang.Rows[d].Cells[2].Value.ToString());
            if (Convert.ToString(dgvKhachHang.Rows[d].Cells[3].Value.ToString()).Trim() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            txtSocmtKH.Text = dgvKhachHang.Rows[d].Cells[4].Value.ToString();
            txtDiachiKH.Text = dgvKhachHang.Rows[d].Cells[5].Value.ToString();
            txtSdtKH.Text = dgvKhachHang.Rows[d].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.TextLength == 0)
                MessageBox.Show("Mã NV không được bỏ trống!");
            else if (txtTenKH.TextLength == 0)
                MessageBox.Show("Tên NV không được bỏ trống!");
            else if (txtSdtKH.TextLength == 0)
                MessageBox.Show("SĐT không được bỏ trống!");
            else if (txtSocmtKH.TextLength == 0 || IsNumber(txtSocmtKH.Text) == false)
                MessageBox.Show("Số CMT không được bỏ trống và giá trị phải nhập là số!");
            else if (txtDiachiKH.TextLength == 0)
                MessageBox.Show("Địa chỉ không được bỏ trống!");
            else
            {
                try
                {
                    C.Makh = txtMaKH.Text;
                    C.Tenkh = txtTenKH.Text;
                    C.Nskh = dptNgaysinhKH.Text;
                    if (rdoNam.Checked)
                    {
                        C.Gtkh = "Nam";
                    }
                    else
                    {
                        C.Gtkh = "Nữ";
                    }
                    C.Scmtkh = txtSocmtKH.Text;
                    C.Dckh = txtDiachiKH.Text;
                    C.Sdtkh = txtSdtKH.Text;
                    khachhangh.InsertKhachHang(C.Makh, C.Tenkh, C.Nskh, C.Gtkh, C.Scmtkh, C.Dckh, C.Sdtkh);
                    MessageBox.Show("Thêm thành công!");
                    CustomerGUI_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.TextLength == 0)
                MessageBox.Show("Mã NV không được bỏ trống!");
            else if (txtTenKH.TextLength == 0)
                MessageBox.Show("Tên NV không được bỏ trống!");
            else if (txtSdtKH.TextLength == 0)
                MessageBox.Show("SĐT không được bỏ trống!");
            else if (txtSocmtKH.TextLength == 0 || IsNumber(txtSocmtKH.Text) == false)
                MessageBox.Show("Số CMT không được bỏ trống và giá trị phải nhập là số!");
            else if (txtDiachiKH.TextLength == 0)
                MessageBox.Show("Địa chỉ không được bỏ trống!");
            else
            {
                try
                {
                    C.Makh = txtMaKH.Text;
                    C.Tenkh = txtTenKH.Text;
                    C.Nskh = dptNgaysinhKH.Text;
                    if (rdoNam.Checked)
                    {
                        C.Gtkh = "Nam";
                    }
                    else
                    {
                        C.Gtkh = "Nữ";
                    }
                    C.Scmtkh = txtSocmtKH.Text;
                    C.Dckh = txtDiachiKH.Text;
                    C.Sdtkh = txtSdtKH.Text;
                    khachhangh.UpdateKhachHang(C.Makh, C.Tenkh, C.Nskh, C.Gtkh, C.Scmtkh, C.Dckh, C.Sdtkh);
                    MessageBox.Show("Sửa thành công!");
                    CustomerGUI_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.TextLength == 0)
                MessageBox.Show("Chưa nhập Mã NV để xóa!");
            else
            {
                try
                {
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.No) return;
                    else
                    {
                        C.Makh = txtMaKH.Text;
                        khachhangh.DeleteKhacHang(C.Makh);
                        MessageBox.Show("Xóa thành công!");
                        CustomerGUI_Load(sender, e);
                    }

                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.TextLength == 0)
                MessageBox.Show("Chưa nhập từ khóa để tìm kiếm!");
            else
            {
                dgvKhachHang.DataSource = khachhangh.SearchKhachHang(txtTimkiem.Text);
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            txtMaKH.Focus();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSocmtKH.Clear();
            txtSdtKH.Clear();
            txtDiachiKH.Clear();
            txtTimkiem.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            CustomerGUI_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
