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

namespace GUI.ExportDetailGUI
{
    public partial class ExportDetailMain : Form
    {
        StaffBUS sb = new StaffBUS();
        CustomerBUS cb = new CustomerBUS();

        public ExportDetailMain()
        {
            InitializeComponent();
        }

        private void ExportDetailMain_Load(object sender, EventArgs e)
        {
            List<ExportObject> listE = ExportBUS.getExports();
            foreach(ExportObject item in listE)
            {
                grdExport.Rows.Add(item.Export_id, item.Export_date, item.Export_staff_id, item.Export_customer_id);
            }
            
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            grdExport.Rows.Clear();
            List<ExportObject> listE = ExportBUS.searchExport(txtSearch.Text);
            foreach (ExportObject item in listE)
            {
                grdExport.Rows.Add(item.Export_id, item.Export_date, item.Export_staff_id, item.Export_customer_id);
            }
        }

        private void grdExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            try
            {
                txtIdStaff.Text = grdExport.Rows[r].Cells["export_staff_id"].Value.ToString();
                txtIdCustomer.Text = grdExport.Rows[r].Cells["export_customer_id"].Value.ToString();
                string nameStaff = sb.SearchNhanvien(txtIdStaff.Text).Rows[0].Field<string>(1);
                string nameCustomer = cb.SearchKhachHang(txtIdCustomer.Text).Rows[0].Field<string>(1);
                txtNameStaff.Text = nameStaff;
                txtNameCustomer.Text = nameCustomer;

                string id = grdExport.Rows[r].Cells[0].Value.ToString();
                List<ExportDetailObject> listED = ExportDetailBUS.searchExportDetail(id);
                grdProduct.Rows.Clear();
                foreach(ExportDetailObject item in listED)
                {
                    float totalPrice = float.Parse(item.Product_exprice.ToString()) * float.Parse(item.Export_detail_amount.ToString());
                    grdProduct.Rows.Add(item.Product_id, item.Product_name, item.Product_brand, item.Export_detail_amount, item.Product_exprice, totalPrice.ToString());
                }

            }catch
            {

            }
            
        }
    }
}
