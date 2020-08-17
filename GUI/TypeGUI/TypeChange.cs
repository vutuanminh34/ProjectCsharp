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

namespace GUI.TypeGUI
{
    public partial class TypeChange : Form
    {
        public TypeChange()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Xóa ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                TypeObject to = new TypeObject(txtId.Text, txtName.Text);
                if (TypeBUS.deleteType(to))
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String err = "";
            if (!Regex.IsMatch(txtName.Text, @"[\w]+[\w ]+"))
            {
                err += "\nTên loại không để trống";
            }

            if (err.Length == 0)
            {
                TypeObject to = new TypeObject(txtId.Text, txtName.Text);
                if (TypeBUS.updateType(to))
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

        private void TypeChange_Load(object sender, EventArgs e)
        {

        }

        private void TypeChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
