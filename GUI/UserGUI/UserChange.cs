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

namespace GUI.UserGUI
{
    public partial class UserChange : Form
    {
        public UserChange()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String err = "";

            if (!Regex.IsMatch(txtName.Text, @"[\w]+[\w]+"))
            {
                err += "\nTên không để trống";
            }

            if (!Regex.IsMatch(txtPass.Text, @"[\w]+[\w]+"))
            {
                err += "\nTên không để trống";
            }

            if (err.Length == 0)
            {
                UserObject to = new UserObject(Int32.Parse(txtId.Text), txtName.Text, txtPass.Text, cbPer.GetItemText(cbPer.SelectedItem));
                if (UserBUS.updateUser(to))
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Xóa ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                UserObject to = new UserObject(Int32.Parse(txtId.Text), txtName.Text, txtPass.Text, "");
                if (UserBUS.deleteUser(to))
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
    }
}
