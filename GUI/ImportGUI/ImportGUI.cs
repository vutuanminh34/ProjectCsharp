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
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace GUI
{
    public partial class ImportGUI : Form
    {
        public ImportGUI()
        {
            InitializeComponent();
        }

        ImportObject I = new ImportObject();
        ImportdetailObject ID = new ImportdetailObject();
        ImportBUS phieunhaph = new ImportBUS();
        ProductObject P = new ProductObject();

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        private void btnXemPN_Click(object sender, EventArgs e)
        {

            if (txtSoPN.TextLength == 0)
                MessageBox.Show("Số phiếu nhập không được để trống!");
            else if (phieunhaph.check2(txtSoPN.Text) == false)
                MessageBox.Show("Số phiếu nhập không tồn tại!");
            else
            {
                ImportinforGUI frm = new ImportinforGUI();
                frm.dgvCTPN.DataSource = phieunhaph.showCTPN(txtSoPN.Text);
                frm.dgvPN2.DataSource = phieunhaph.showPN(txtSoPN.Text);
                frm.Show();
            }
        }

        private void ImportGUI_Load(object sender, EventArgs e)
        {
            cboMaNCC.DataSource = phieunhaph.showNCC();
            cboMaNCC.DisplayMember = "distributor_id";
            cboMaNCC.ValueMember = "distributor_id";

            cboMaNV.DataSource = phieunhaph.showNV();
            cboMaNV.DisplayMember = "staff_id";
            cboMaNV.ValueMember = "staff_id";

            cboMaSP.DataSource = phieunhaph.showSP();
            cboMaSP.DisplayMember = "product_id";
            cboMaSP.ValueMember = "product_id";

            txtTenNCC.Enabled = false;
            txtTenNV.Enabled = false;
            txtNhanhieu.Enabled = false;
            txtTenSP.Enabled = false;
            txtTongsoluong.Enabled = false;
            txtTongtien.Enabled = false;
            txtDongia.Enabled = false;

        }

        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)cboMaNCC.SelectedItem;
            txtTenNCC.Text = vrow.Row["distributor_name"].ToString();
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)cboMaNV.SelectedItem;
            txtTenNV.Text = vrow.Row["staff_name"].ToString();
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)cboMaSP.SelectedItem;
            txtTenSP.Text = vrow.Row["product_name"].ToString();
            txtDongia.Text = vrow.Row["product_imprice"].ToString();
            txtNhanhieu.Text = vrow.Row["product_brand"].ToString();
            //txtTongsoluong.Text = vrow.Row["product_amount"].ToString();
        }

        private void btnChonPN_Click(object sender, EventArgs e)
        {
            if (txtSoluongPN.TextLength == 0 || IsNumber(txtSoluongPN.Text) == false || Convert.ToInt32(txtSoluongPN.Text) == 0)
                MessageBox.Show("Số lượng không đc để trống và phải là số nguyên khác 0!");
            else
            {
                int n = dgvPN.Rows.Add();
                dgvPN.Rows[n].Cells[0].Value = cboMaSP.SelectedValue.ToString();
                dgvPN.Rows[n].Cells[1].Value = txtTenSP.Text;
                dgvPN.Rows[n].Cells[2].Value = txtNhanhieu.Text;
                dgvPN.Rows[n].Cells[3].Value = txtSoluongPN.Text;
                dgvPN.Rows[n].Cells[4].Value = txtDongia.Text;
                dgvPN.Rows[n].Cells[5].Value = Convert.ToString(Convert.ToInt32(txtSoluongPN.Text) * Convert.ToInt32(txtDongia.Text));

                int tien = dgvPN.Rows.Count;
                int thanhtien = 0;
                int tongsoluong = 0;
                for (int i = 0; i < tien - 1; i++)
                {
                    thanhtien += Convert.ToInt32(dgvPN.Rows[i].Cells[5].Value.ToString());
                    tongsoluong = tongsoluong + Convert.ToInt32(dgvPN.Rows[i].Cells[3].Value.ToString());
                }
                txtTongtien.Text = thanhtien.ToString();
                txtTongsoluong.Text = tongsoluong.ToString();
            }
        }

        private void dgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            cboMaSP.SelectedValue = dgvPN.Rows[d].Cells[0].Value.ToString();
            txtTenSP.Text = dgvPN.Rows[d].Cells[1].Value.ToString();
            txtNhanhieu.Text = dgvPN.Rows[d].Cells[2].Value.ToString();
            txtSoluongPN.Text = dgvPN.Rows[d].Cells[3].Value.ToString();
            txtDongia.Text = dgvPN.Rows[d].Cells[4].Value.ToString();
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            int r = dgvPN.CurrentCell.RowIndex;
            dgvPN.Rows[r].Cells[0].Value = cboMaSP.SelectedValue.ToString();
            dgvPN.Rows[r].Cells[1].Value = txtTenSP.Text;
            dgvPN.Rows[r].Cells[2].Value = txtNhanhieu.Text;
            dgvPN.Rows[r].Cells[3].Value = txtSoluongPN.Text;
            dgvPN.Rows[r].Cells[4].Value = txtDongia.Text;
            dgvPN.Rows[r].Cells[5].Value = Convert.ToString(Convert.ToInt32(txtSoluongPN.Text) * Convert.ToInt32(txtDongia.Text));

            int tien = dgvPN.Rows.Count;
            int thanhtien = 0;
            int tongsoluong = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += Convert.ToInt32(dgvPN.Rows[i].Cells[5].Value.ToString());
                tongsoluong = tongsoluong + Convert.ToInt32(dgvPN.Rows[i].Cells[3].Value.ToString());
            }
            txtTongtien.Text = thanhtien.ToString();
            txtTongsoluong.Text = tongsoluong.ToString();
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            DialogResult rp = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rp == DialogResult.No) return;
            else
            {
                int r = dgvPN.CurrentCell.RowIndex;
                dgvPN.Rows.RemoveAt(r);

            }
        }

        private void btnHuyPN_Click(object sender, EventArgs e)
        {
            dgvPN.Rows.Clear();
            dgvPN.Refresh();
            txtTongsoluong.Clear();
            txtTongtien.Clear();
        }

        private void btnNhaplaiPN_Click(object sender, EventArgs e)
        {
            txtSoluongPN.Clear();
            txtSoPN.Clear();
        }

        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            if (txtSoPN.TextLength == 0)
                MessageBox.Show("Số phiếu nhập không được để trống!");
            else if (phieunhaph.check2(txtSoPN.Text) == true)
                MessageBox.Show("Số phiếu nhận đã tồn tại!");
            else if (txtSoluongPN.TextLength == 0 || IsNumber(txtSoluongPN.Text) == false || Convert.ToInt32(txtSoluongPN.Text) == 0)
                MessageBox.Show("Số lượng không đc để trống và phải là số nguyên khác 0!");
            else
            {
                try
                {
                    I.Mapn = txtSoPN.Text;

                    String[] temp = dtpNgaynhapPN.Text.Split('-');
                    String year = temp[2];
                    String month = temp[1];
                    String dates = temp[0];


                    I.Ngaylappn = year + "/" + month + "/" + dates;
                    
                    I.Manvpn = Convert.ToString(cboMaNV.SelectedValue);
                    I.Manccpn = Convert.ToString(cboMaNCC.SelectedValue);
                    phieunhaph.InsertPN(I.Mapn, I.Ngaylappn, I.Manvpn, I.Manccpn);

                    ID.Mapn = txtSoPN.Text;
                    ID.Masp = Convert.ToString(cboMaSP.SelectedValue);
                    ID.Slnhap = Convert.ToInt32(txtSoluongPN.Text);
                    phieunhaph.InvertCTPN(ID.Mapn, ID.Masp, ID.Slnhap);

                    P.Product_id = Convert.ToString(cboMaSP.SelectedValue);
                    int sln = Convert.ToInt32(txtSoluongPN.Text);
                    phieunhaph.UpdateSLSP(P.Product_id, sln);

                    MessageBox.Show("Lưu thành công!");
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnInPN_Click(object sender, EventArgs e)
        {
            if (txtSoPN.TextLength == 0)
                MessageBox.Show("Số phiếu nhập không được để trống!");
            else if (phieunhaph.check2(txtSoPN.Text) == true)
                MessageBox.Show("Số phiếu nhận đã tồn tại!");
            else
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            DataRowView vrow = (DataRowView)cboMaNCC.SelectedItem;
            
            e.Graphics.DrawString("SIÊU THỊ ĐIỆN MÁY ECO - MART", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(60, 50));
            e.Graphics.DrawString("Km 13 - Quốc lộ 3 - TT Đông Anh - Hà Nội", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(50, 75));
            e.Graphics.DrawString("PHIẾU NHẬP", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(370, 110));
            e.Graphics.DrawString("Số PN:", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(365, 140));
            e.Graphics.DrawString(txtSoPN.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(430, 140));
            e.Graphics.DrawString("Ngày nhập:", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(360, 170));
            e.Graphics.DrawString(dtpNgaynhapPN.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(465, 170));
            e.Graphics.DrawString("Mã nhà cung cấp:", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(50, 200));
            e.Graphics.DrawString(Convert.ToString(cboMaNCC.SelectedValue), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(200, 200));
            e.Graphics.DrawString("Tên nhà cung cấp:", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(50, 230));
            e.Graphics.DrawString(vrow.Row["distributor_name"].ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(200, 230));
            e.Graphics.DrawString("Địa chỉ:", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(50, 260));
            e.Graphics.DrawString(vrow.Row["distributor_address"].ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(150, 260));
            e.Graphics.DrawString("Email:", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(50, 290));
            e.Graphics.DrawString(vrow.Row["distributor_email"].ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(120, 290));
            e.Graphics.DrawString("Số điện thoại:", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(360, 290));
            e.Graphics.DrawString(vrow.Row["distributor_phone"].ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(475, 290));

            Bitmap bm = new Bitmap(this.dgvPN.Width, this.dgvPN.Height);
            dgvPN.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvPN.Width, this.dgvPN.Height));
            e.Graphics.DrawImage(bm, 40, 350);

            e.Graphics.DrawString("Tổng tiền  :", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(615, 560));
            e.Graphics.DrawString(txtTongtien.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(730, 560));

            e.Graphics.DrawString("Người lập", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(575, 600));
            e.Graphics.DrawString("Vũ Tuấn Minh", new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(560, 640));
        }
    }
}
