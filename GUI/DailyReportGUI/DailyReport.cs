using BUS;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DailyReportGUI
{
    public partial class DailyReport : Form
    {
        StaffBUS stb = new StaffBUS();
        public DailyReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int STT = 1;
            dgvdanhsach.Rows.Clear();
            chartExamount.Series["Số lượng bán ra"].Points.Clear();
            DailyReportBUS dr = new DailyReportBUS();
            DailyReportObject dobj = new DailyReportObject();
            dobj.Export_date = txtdate.Value;
            List<DailyReportObject> lst = DailyReportBUS.getInfos(dobj);

            foreach (DailyReportObject p in lst)
            {
                dgvdanhsach.Rows.Add(STT++, p.Product_name, "Sản phẩm", p.Export_amount, p.Product_exprice, (p.Export_amount) * (p.Product_exprice));
            }
            foreach (DataGridViewRow row in dgvdanhsach.Rows)
            {
                /* chartExAmount.Series.Add(row.Cells["product_name"].Value.ToString());
                 chartExAmount.Series[row.Cells["product_name"].Value.ToString()].Points[row.Index].Label = row.Cells["export_amount"].Value.ToString();*/
                chartExamount.Series["Số lượng bán ra"].Points.AddXY(row.Cells["product_name"].Value, row.Cells["export_amount"].Value);
                chartExamount.Series["Số lượng bán ra"].Points[row.Index].Label = row.Cells["export_amount"].Value.ToString();
            }
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            cbbstaff.DataSource = stb.ShowNhanVien();
            cbbstaff.ValueMember = "staff_id";
            cbbstaff.DisplayMember = "staff_name";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PdfPTable pdf = new PdfPTable(dgvdanhsach.Columns.Count);
            //basefont for utf-8
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //font-title
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 36);
            Paragraph titleName = new Paragraph(label1.Text, titleFont);
            titleName.Alignment = Element.ALIGN_CENTER;
            //content-font
            iTextSharp.text.Font contentFont = new iTextSharp.text.Font(bf, 12);
            //totalinformation
            Paragraph UnitText = new Paragraph("Tên đơn vị: Chinsu", contentFont);
            Paragraph DateText = new Paragraph("Ngày lập: " + txtdate.Value, contentFont);
            Paragraph StaffText = new Paragraph("Người lập: " + cbbstaff.GetItemText(this.cbbstaff.SelectedItem), contentFont);
            //table
            foreach (DataGridViewColumn col in dgvdanhsach.Columns)
            {
                pdf.AddCell(new Phrase(col.HeaderText, contentFont));
            }
            foreach (DataGridViewRow row in dgvdanhsach.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdf.AddCell(new Phrase(cell.Value.ToString(), contentFont));
                }
            }
            pdf.SpacingBefore = 10f;
            pdf.SpacingAfter = 10f;
            //chart
            MemoryStream memoryStream = new MemoryStream();
            chartExamount.SaveImage(memoryStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
            img.ScalePercent(75f);
            img.Alignment = Element.ALIGN_CENTER;
            //create+add pdf
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(titleName);
                        doc.Add(UnitText);
                        doc.Add(DateText);
                        doc.Add(StaffText);
                        doc.Add(pdf);
                        doc.Add(img);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
