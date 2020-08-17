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

namespace GUI.ProductGUI
{
    public partial class ProductMain : Form
    {
        public ProductMain()
        {
            InitializeComponent();
        }

        private void ProductMain_Load(object sender, EventArgs e)
        {
            List<TypeObject> listT = TypeBUS.getTypes();
            var bindingListT = new BindingList<TypeObject>(listT);
            var sourceT = new BindingSource(bindingListT, null);

            List<ProductObject> listP = ProductBUS.getProducts();
            var bindingListP = new BindingList<ProductObject>(listP);
            var sourceP = new BindingSource(bindingListP, null);

            (grdProduct.Columns["product_type_id"] as DataGridViewComboBoxColumn).DataSource = sourceT;
            (grdProduct.Columns["product_type_id"] as DataGridViewComboBoxColumn).DisplayMember = "type_name";
            (grdProduct.Columns["product_type_id"] as DataGridViewComboBoxColumn).ValueMember = "type_id";
            grdProduct.DataSource = sourceP;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductInsert f = new ProductInsert();
            f.ShowDialog();
            if(f.IsDisposed)
            {
                ProductMain_Load(sender, e);
            }
        }

        private void grdProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductChange f = new ProductChange();
            
            f.txtId.Text = grdProduct.CurrentRow.Cells[0].Value.ToString();
            f.txtName.Text = grdProduct.CurrentRow.Cells[1].Value.ToString();
            f.txtBrand.Text = grdProduct.CurrentRow.Cells[2].Value.ToString();
            f.txtImg.Text = grdProduct.CurrentRow.Cells[3].Value.ToString();
            f.txtSpecification.Text = grdProduct.CurrentRow.Cells[4].Value.ToString();
            f.txtFeature.Text = grdProduct.CurrentRow.Cells[5].Value.ToString();
            f.txtExprice.Text = grdProduct.CurrentRow.Cells[6].Value.ToString();
            f.txtImprice.Text = grdProduct.CurrentRow.Cells[7].Value.ToString();
            f.txtAmount.Text = grdProduct.CurrentRow.Cells[8].Value.ToString();
            f.cbType.SelectedValue = grdProduct.CurrentRow.Cells[9].Value.ToString();
            try
            {
                f.pictureBox1.Image = Image.FromFile(f.txtImg.Text);
            } catch(Exception ex)
            {

            }
            
            f.ShowDialog();
            if (f.IsDisposed)
            {
                ProductMain_Load(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<TypeObject> listT = TypeBUS.getTypes();
            var bindingListT = new BindingList<TypeObject>(listT);
            var sourceT = new BindingSource(bindingListT, null);

            List<ProductObject> listP = ProductBUS.searchProduct(txtSearch.Text);
            var bindingListP = new BindingList<ProductObject>(listP);
            var sourceP = new BindingSource(bindingListP, null);

            (grdProduct.Columns["product_type_id"] as DataGridViewComboBoxColumn).DataSource = sourceT;
            (grdProduct.Columns["product_type_id"] as DataGridViewComboBoxColumn).DisplayMember = "type_name";
            (grdProduct.Columns["product_type_id"] as DataGridViewComboBoxColumn).ValueMember = "type_id";
            grdProduct.DataSource = sourceP;
        }
    }
}
