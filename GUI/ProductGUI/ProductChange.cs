using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ProductGUI
{
    public partial class ProductChange : Form
    {
        public ProductChange()
        {
            InitializeComponent();
        }

        private void ProductChange_Load(object sender, EventArgs e)
        {
            List<TypeObject> list = TypeBUS.getTypes();
            var bindingList = new BindingList<TypeObject>(list);
            var source = new BindingSource(bindingList, null);
            cbType.DataSource = source;
            cbType.DisplayMember = "type_name";
            cbType.ValueMember = "type_id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Xóa ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                ProductObject po = new ProductObject();
                po.Product_id = txtId.Text;
                if (ProductBUS.deleteProduct(po))
                {
                    MessageBox.Show("Xóa thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string err = "";
            if (!Regex.IsMatch(txtName.Text, @"[\w]+[\w ]*"))
            {
                err += "\nTên sản phẩm không trống";
            }
            if (!Regex.IsMatch(txtExprice.Text, @"^\d+(\.\d+)?$"))
            {
                err += "\nGiá bán phải là số không âm";
            }
            if (!Regex.IsMatch(txtImprice.Text, @"^\d+(\.\d+)?$"))
            {
                err += "\nGiá mua phải là số không âm";
            }
            if (!Regex.IsMatch(txtAmount.Text, @"^\d+$"))
            {
                err += "\nSố lượng là số dương";
            }
            if (err.Length == 0)
            {
                ProductObject po = new ProductObject();
                po.Product_id = txtId.Text;
                po.Product_name = txtName.Text;
                po.Product_brand = txtBrand.Text;
                po.Product_image = txtImg.Text;
                po.Product_specification = txtSpecification.Text;
                po.Product_feature = txtFeature.Text;
                po.Product_exprice = double.Parse(txtExprice.Text);
                po.Product_imprice = double.Parse(txtImprice.Text);
                po.Product_amount = Int32.Parse(txtAmount.Text);
                po.Product_type_id = cbType.SelectedValue.ToString();
                if (ProductBUS.updateProduct(po))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ProductChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
