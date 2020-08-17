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
    public partial class UserInsert : Form
    {
        public UserInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String err = "";

            if (!Regex.IsMatch(txtId.Text, @"[0-9]+"))
            {
                err += "\nId là số";
            }

            if (!Regex.IsMatch(txtName.Text, @"[\w0-9]+[\w0-9]+"))
            {
                err += "\nTên không để trống";
            }

            if (!Regex.IsMatch(txtPass.Text, @"[\w0-9]+[\w0-9]+"))
            {
                err += "\nMật khẩu không để trống";
            }

            if (err.Length == 0)
            {
                UserObject to = new UserObject(Int32.Parse(txtId.Text), txtName.Text, txtPass.Text, cbPer.GetItemText(cbPer.SelectedItem));
                if (UserBUS.createUser(to))
                {
                    MessageBox.Show("Thêm thành công");
                    txtId.Text = "";
                    txtName.Text = "";
                    txtPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại (Trùng id ???)");
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
