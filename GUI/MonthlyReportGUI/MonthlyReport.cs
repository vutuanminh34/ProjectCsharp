using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MonthlyReportGUI
{
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }
        StaffBUS stb = new StaffBUS();

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MonthlyReportObject mrobj = new MonthlyReportObject();
            dgvdanhsach.Rows.Clear();
            ChartAmount.Series["Số lượng tồn"].Points.Clear();
            List<MonthlyReportObject> lstim = MonthlyReportBUS.getImamount(txtdate.Value);
            List<MonthlyReportObject> lstex = MonthlyReportBUS.getExamount(txtdate.Value);
            foreach (var im in lstim)
            {
                foreach (var ex in lstex)
                {
                    if (im.Product_id == ex.Product_id)
                    {
                        dgvdanhsach.Rows.Add(stt, im.Product_name, "Sản phẩm", im.Product_imamount - ex.Product_examount, "Hàng tồn");
                    }
                }
                dgvdanhsach.Rows.Add(stt, im.Product_name, "Sản phẩm", im.Product_imamount, "Hàng tồn");
            }
            for (int i = 1; i < dgvdanhsach.RowCount; i++)
            {
                if (dgvdanhsach.Rows[i - 1].Cells[1].Value == dgvdanhsach.Rows[i].Cells[1].Value)
                {
                    dgvdanhsach.Rows.RemoveAt(i);
                }
            }
            int index = 1;
            foreach (DataGridViewRow row in dgvdanhsach.Rows)
            {
                row.Cells[0].Value = index;
                index++;
            }
            foreach (DataGridViewRow row in dgvdanhsach.Rows)
            {
                try
                {
                    ChartAmount.Series["Số lượng tồn"].Points.AddXY(row.Cells["product_name"].Value, row.Cells["product_amount"].Value);
                    ChartAmount.Series["Số lượng tồn"].Points[row.Index].Label = row.Cells["product_amount"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            cbbstaff.DataSource = stb.ShowNhanVien();
            cbbstaff.ValueMember = "staff_id";
            cbbstaff.DisplayMember = "staff_name";
        }


    }
}
