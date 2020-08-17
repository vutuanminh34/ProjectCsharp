using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ExportGUI
{
    public partial class PrintForm : Form
    {
        List<ExportDetailObject> listED;
        CustomerObject co;
        string date;
        string totalPrice;
        string nameStaff;

        public PrintForm(List<ExportDetailObject> listED, CustomerObject co, string nameStaff, string date, string totalPrice)
        {
            InitializeComponent();
            this.listED = listED;
            this.co = co;
            this.date = date;
            this.totalPrice = totalPrice;
            this.nameStaff = nameStaff;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            ExportDetailObjectBindingSource.DataSource = listED;
            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("txtIdCustomer", co.Makh),
                new ReportParameter("txtNameCustomer", co.Tenkh),
                new ReportParameter("txtIdCardCustomer", co.Scmtkh),
                new ReportParameter("txtAddressCustomer", co.Dckh),
                new ReportParameter("txtPhoneCustomer", co.Sdtkh),
                new ReportParameter("txtIdExport", listED[0].Export_detail_export_id),
                new ReportParameter("txtDate", date),
                new ReportParameter("txtNameStaff", nameStaff),
                new ReportParameter("txtTotalPrice", totalPrice)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
