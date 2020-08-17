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
    public partial class TypeInsert : Form
    {
        public TypeInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String err = "";
            if (!Regex.IsMatch(txtId.Text, "L{1}[0-9]+"))
            {
                err += "Mã loại không để trống và đúng định dạng MLxxx";
            }
            if (!Regex.IsMatch(txtName.Text, @"[\w]+[\w ]+"))
            {
                err += "\nTên loại không để trống";
            }

            if (err.Length == 0)
            {
                TypeObject to = new TypeObject(txtId.Text, txtName.Text);
                if (TypeBUS.createType(to))
                {
                    MessageBox.Show("Thêm thành công");
                    txtId.Text = "";
                    txtName.Text = "";
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

        private void TypeInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
