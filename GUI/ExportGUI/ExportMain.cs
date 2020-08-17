using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using GUI.ExportDetailGUI;

namespace GUI.ExportGUI
{
    public partial class ExportMain : Form
    {
        public ExportMain()
        {
            InitializeComponent();
        }
        StaffBUS fb = new StaffBUS();
        CustomerBUS cb = new CustomerBUS();
        String idExp;

        private void updateTotalPrice()
        {
            float totalPrice = 0;
            for (int i = 0; i < grdExport.Rows.Count - 1; i++)
            {
                totalPrice += float.Parse(grdExport.Rows[i].Cells[4].Value.ToString());
            }
            txtAmount.Text = totalPrice.ToString();
        }

        private void updateListProduct()
        {
            grdProduct.Rows.Clear();
            List<ProductObject> listP = ProductBUS.getProducts();
            grdProduct.RowTemplate.Height = 100;
            Bitmap a;
            foreach (ProductObject item in listP)
            {

                try
                {
                    a = new Bitmap(Bitmap.FromFile(item.Product_image), new Size(100, 100));
                }
                catch (Exception ex)
                {
                    a = null;
                }
                grdProduct.Rows.Add(item.Product_id, item.Product_name, item.Product_amount, item.Product_exprice, item.Product_brand, a);
            }
        }

        private void ExportMain_Load(object sender, EventArgs e)
        {
            cbIdStaff.DataSource = fb.ShowNhanVien();
            cbIdStaff.ValueMember = "staff_id";
            txtDateTime.Value = DateTime.Now;

            cbIdCustomer.DataSource = cb.showKH();
            cbIdCustomer.ValueMember = "customer_id";

            

            updateListProduct();
        }

        private void cbIdStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView staffRow = cbIdStaff.SelectedItem as DataRowView;
            txtNameStaff.Text = staffRow.Row["staff_name"] as String;
        }

        private void cbIdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView cusRow = cbIdCustomer.SelectedItem as DataRowView;
            txtNameCustomer.Text = cusRow.Row["customer_name"] as String;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            grdProduct.Rows.Clear();
            List<ProductObject> listP = ProductBUS.searchProduct(txtSearch.Text);
            grdProduct.RowTemplate.Height = 100;
            Bitmap a;
            foreach (ProductObject item in listP)
            {

                try
                {
                    a = new Bitmap(Bitmap.FromFile(item.Product_image), new Size(100, 100));
                }
                catch (Exception ex)
                {
                    a = null;
                }
                grdProduct.Rows.Add(item.Product_id, item.Product_name, item.Product_amount, item.Product_exprice, item.Product_brand, a);
            }
        }

        private void grdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = grdProduct.CurrentRow.Cells[0].Value.ToString();
            String name = grdProduct.CurrentRow.Cells[1].Value.ToString();
            String exprice = grdProduct.CurrentRow.Cells[3].Value.ToString();
            String amount = grdProduct.CurrentRow.Cells[2].Value.ToString();
            bool checkIsExisting = false;
            if(grdExport.RowCount < 2)
            {
                grdExport.Rows.Add(id, name, exprice, 1, exprice, "X", amount, 0);
            }
            else
            {
                for(int i = 0; i<grdExport.RowCount-1; i++)
                {
                    if(grdExport.Rows[i].Cells[0].Value.ToString().Equals(id))
                    {
                        checkIsExisting = true;
                    } 
                }
                if(checkIsExisting)
                {
                    MessageBox.Show("Sản phẩm đã tồn tại trong giỏ");
                } else
                {
                    grdExport.Rows.Add(id, name, exprice, 1, exprice, "X", amount, 0);
                }
            }

            updateTotalPrice();
        }

        private void grdExport_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if(e.RowIndex != -1 )
            {
                int price = Int32.Parse(grdExport.Rows[r].Cells[2].Value.ToString());
                
                float amount = float.Parse(grdExport.Rows[r].Cells[3].Value.ToString());
                if (amount > Int32.Parse(grdExport.Rows[r].Cells[6].Value.ToString()))
                {
                    MessageBox.Show("Vượt quá số lượng hiện có");
                    grdExport.Rows[r].Cells[3].Value = 1;
                }

                float amountDiscount = 0;

                if(amount < 10)
                {
                    amountDiscount = 0;
                }
                else if(amount > 10000)
                {
                    amountDiscount = amount;
                } else
                {
                    amountDiscount = (float)Math.Log(amount, 1000000000);
                }

                grdExport.Rows[r].Cells["discount"].Value = amountDiscount;


                float total = (amount * price) - amountDiscount * (amount * price);
                grdExport.Rows[r].Cells[4].Value = total;
                updateTotalPrice();
            }
        }

        private void grdExport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == grdExport.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                int r = e.RowIndex;
                grdExport.Rows.RemoveAt(r);
                updateTotalPrice();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String err = "";
            

            if (grdExport.RowCount < 2)
            {
                err += "Chưa có sản phẩm trong giỏ";
                MessageBox.Show(err);
            } else
            {
                DateTime dt = DateTime.Now;
                String aanteMeridiem = dt.ToString("tt", System.Globalization.CultureInfo.InvariantCulture);
                String id = "HD" + dt.Year + dt.Month + dt.Day + dt.Hour + dt.Minute + dt.Millisecond + aanteMeridiem;
                String date = dt.Year + "/" + dt.Month + "/" + dt.Day;
                String idStaff = cbIdStaff.SelectedValue.ToString();
                String idCustomer = cbIdCustomer.SelectedValue.ToString();
                ExportObject eo = new ExportObject(id, date, idStaff, idCustomer);
                ExportBUS.createExport(eo);
                for(int i = 0; i< grdExport.RowCount - 1; i++)
                {
                    ExportDetailObject edo = new ExportDetailObject();
                    edo.Export_detail_export_id = id;
                    edo.Export_detail_product_id = grdExport.Rows[i].Cells[0].Value.ToString();
                    edo.Export_detail_amount = Int32.Parse(grdExport.Rows[i].Cells[3].Value.ToString());
                    ExportDetailBUS.createExportDetail(edo);
                    int amountUpdate = Int32.Parse(grdExport.Rows[i].Cells[6].Value.ToString()) - Int32.Parse(grdExport.Rows[i].Cells[3].Value.ToString());
                    ProductBUS.updateProductAmount(edo.Export_detail_product_id, amountUpdate.ToString());

                }
                MessageBox.Show("Lưu hóa đơn thành công");
                grdExport.Rows.Clear();
                updateListProduct();
                idExp = id;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportDetailMain f = new ExportDetailMain();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<ExportDetailObject> listED = ExportDetailBUS.searchExportDetail(idExp);
            DataTable dt = cb.SearchKhachHang(cbIdCustomer.SelectedValue.ToString());
            CustomerObject co = new CustomerObject();
            co.Makh = dt.Rows[0].Field<string>("customer_id");
            co.Tenkh = dt.Rows[0].Field<string>("customer_name");
            co.Scmtkh = dt.Rows[0].Field<string>("customer_id_card");
            co.Dckh = dt.Rows[0].Field<string>("customer_address");
            co.Sdtkh = dt.Rows[0].Field<string>("customer_phone");
            string staffName = txtNameStaff.Text;
            string date = txtDateTime.Text;
            string totalPrice = txtAmount.Text;
            PrintForm f = new PrintForm(listED, co, staffName, date, totalPrice);
            f.ShowDialog();
        }
    }
}
