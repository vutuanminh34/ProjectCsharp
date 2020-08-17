using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Reflection;

namespace GUI
{
    public partial class StaffGUI : Form
    {
        public StaffGUI()
        {
            InitializeComponent();
        }

        StaffObject S = new StaffObject();
        StaffBUS nhanvienh = new StaffBUS();

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanvienh.ShowNhanVien();
            cboTrinhdoNV.DataSource = nhanvienh.ShowTrinhDo();
            cboTrinhdoNV.DisplayMember = "degree_name";
            cboTrinhdoNV.ValueMember = "degree_id";
        }

        private void dgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[d].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[d].Cells[1].Value.ToString();
            dtpNgaysinhNV.Value = Convert.ToDateTime(dgvNhanVien.Rows[d].Cells[2].Value.ToString());

            string gt = this.dgvNhanVien.Rows[d].Cells[3].Value.ToString();
            if (gt.Trim() == "Nam")
            {
                rdoNamNV.Checked = true;
            }
            else
            {
                rdoNuNV.Checked = true;
            }
            txtSCMTNV.Text = dgvNhanVien.Rows[d].Cells[4].Value.ToString();
            txtDiachiNV.Text = dgvNhanVien.Rows[d].Cells[5].Value.ToString();
            txtDienThoaiNV.Text = dgvNhanVien.Rows[d].Cells[6].Value.ToString();
            cboTrinhdoNV.SelectedValue = dgvNhanVien.Rows[d].Cells[7].Value.ToString();



        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNhaplaiNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSCMTNV.Clear();
            txtTimkiemNV.Clear();
            txtDiachiNV.Clear();
            txtDienThoaiNV.Clear();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength == 0)
                MessageBox.Show("Mã NV không được bỏ trống!");
            else if (txtTenNV.TextLength == 0)
                MessageBox.Show("Tên NV không được bỏ trống!");
            else if (txtDienThoaiNV.TextLength == 0)
                MessageBox.Show("SĐT không được bỏ trống!");
            else if (txtSCMTNV.TextLength == 0 || IsNumber(txtSCMTNV.Text) == false)
                MessageBox.Show("Số CMT không được bỏ trống và giá trị phải nhập là số!");
            else if (txtDiachiNV.TextLength == 0)
                MessageBox.Show("Địa chỉ không được bỏ trống!");
            else
            {
                try
                {
                    S.Manv = txtMaNV.Text;
                    S.Tennv = txtTenNV.Text;
                    S.Ngaysinhnv = dtpNgaysinhNV.Text;
                    if (rdoNamNV.Checked)
                    {
                        S.Gioitinhnv = "Nam";
                    }
                    else
                    {
                        S.Gioitinhnv = "Nữ";
                    }
                    S.Socmtnv = txtSCMTNV.Text;
                    S.Diachinv = txtDiachiNV.Text;
                    S.Sdtnv = txtDienThoaiNV.Text;
                    S.Trinhdonv = Convert.ToString(cboTrinhdoNV.SelectedValue);
                    nhanvienh.InsertNhanvien(S.Manv, S.Tennv, S.Ngaysinhnv, S.Gioitinhnv, S.Socmtnv, S.Diachinv, S.Sdtnv, S.Trinhdonv);
                    MessageBox.Show("Thêm thành công!");
                    Form1_Load(sender, e);
                }catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength == 0)
                MessageBox.Show("Mã NV không được bỏ trống!");
            else if (txtTenNV.TextLength == 0)
                MessageBox.Show("Tên NV không được bỏ trống!");
            else if (txtDienThoaiNV.TextLength == 0)
                MessageBox.Show("SĐT không được bỏ trống!");
            else if (txtSCMTNV.TextLength == 0 || IsNumber(txtSCMTNV.Text) == false)
                MessageBox.Show("Số CMT không được bỏ trống và giá trị phải nhập là số!");
            else if (txtDiachiNV.TextLength == 0)
                MessageBox.Show("Địa chỉ không được bỏ trống!");
            else
            {
                try
                {
                    S.Manv = txtMaNV.Text;
                    S.Tennv = txtTenNV.Text;
                    S.Ngaysinhnv = dtpNgaysinhNV.Text;
                    if (rdoNamNV.Checked)
                    {
                        S.Gioitinhnv = "Nam";
                    }
                    else
                    {
                        S.Gioitinhnv = "Nữ";
                    }
                    S.Socmtnv = txtSCMTNV.Text;
                    S.Diachinv = txtDiachiNV.Text;
                    S.Sdtnv = txtDienThoaiNV.Text;
                    S.Trinhdonv = Convert.ToString(cboTrinhdoNV.SelectedValue);
                    nhanvienh.UpdateNhanvien(S.Manv, S.Tennv, S.Ngaysinhnv, S.Gioitinhnv, S.Socmtnv, S.Diachinv, S.Sdtnv, S.Trinhdonv);
                    MessageBox.Show("Sửa thành công!");
                    Form1_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength == 0)
                MessageBox.Show("Chưa nhập Mã NV để xóa!");
            else
            {
                try
                {
                    DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.No) return;
                    else
                    {
                        S.Manv = txtMaNV.Text;
                        nhanvienh.DeleteNhanvien(S.Manv);
                        MessageBox.Show("Xóa thành công!");
                        Form1_Load(sender, e);
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }
        
        private void btnTimNV_Click(object sender, EventArgs e)
        {
            if (txtTimkiemNV.TextLength == 0)
                MessageBox.Show("Chưa nhập từ khóa để tìm kiếm!");
            else
            {
                dgvNhanVien.DataSource = nhanvienh.SearchNhanvien(txtTimkiemNV.Text);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
