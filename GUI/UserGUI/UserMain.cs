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

namespace GUI.UserGUI
{
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UserInsert f = new UserInsert();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                UserMain_Load(sender, e);
            }
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            List<UserObject> list = UserBUS.getUsers();
            var bindingList = new BindingList<UserObject>(list);
            var source = new BindingSource(bindingList, null);
            grdType.DataSource = source;
        }

        private void grdType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserChange f = new UserChange();
            f.txtId.Text = grdType.CurrentRow.Cells[0].Value.ToString();
            f.txtName.Text = grdType.CurrentRow.Cells[1].Value.ToString();
            f.txtPass.Text = grdType.CurrentRow.Cells[2].Value.ToString();
            f.cbPer.Text = grdType.CurrentRow.Cells[3].Value.ToString();
            f.ShowDialog();
            if (f.IsDisposed)
            {
                UserMain_Load(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<UserObject> list = UserBUS.searchUser(txtSearch.Text);
                var bindingList = new BindingList<UserObject>(list);
                var source = new BindingSource(bindingList, null);
                grdType.DataSource = source;
            } catch
            {

            }
        }
    }
}
