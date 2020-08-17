using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI.TypeGUI
{
    public partial class TypeMain : Form
    {
        public TypeMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<TypeObject> list = TypeBUS.getTypes();
            var bindingList = new BindingList<TypeObject>(list);
            var source = new BindingSource(bindingList, null);
            grdType.DataSource = source;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TypeInsert f = new TypeInsert();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                Main_Load(sender, e);
            }
        }


        private void grdType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TypeChange f = new TypeChange();
            f.txtId.Text = grdType.CurrentRow.Cells[0].Value.ToString();
            f.txtName.Text = grdType.CurrentRow.Cells[1].Value.ToString();
            f.ShowDialog();
            if(f.IsDisposed)
            {
                Main_Load(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<TypeObject> list = TypeBUS.searchType(txtSearch.Text);
            var bindingList = new BindingList<TypeObject>(list);
            var source = new BindingSource(bindingList, null);
            grdType.DataSource = source;
        }
    }
}
