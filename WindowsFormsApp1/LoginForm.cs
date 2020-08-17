using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = this.button1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Equals("") || txtUserPass.Text.Equals(""))
            {
                MessageBox.Show("Không để trống tài khoản và mật khẩu");
            } else
            {
                List<UserObject> listU = UserBUS.getUsers(txtUserName.Text, txtUserPass.Text);
                if(listU.Count == 0)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                } else
                {
                    MessageBox.Show("Welcome Mr.Stark");
                    this.Hide();
                    MainForm f = new MainForm();
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
