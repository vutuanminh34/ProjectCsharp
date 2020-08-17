using GUI.ProductGUI;
using System;
using System.Windows.Forms;
using GUI;
using GUI.TypeGUI;
using GUI.ExportGUI;
using GUI.UserGUI;
using GUI.DistributorGUI;
using GUI.DailyReportGUI;
using GUI.MonthlyReportGUI;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox3.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            jpnExport.Visible = true;
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            jpnExport.Visible = false;
            this.showForm(new DailyReport());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            jpnExport.Visible = false;
            this.showForm(new MonthlyReport());
        }

        private void button14_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form f = new LoginForm();
            f.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.showForm(new ProductMain());
        }

        private void showForm(object formObject)
        {
            if (this.pnRoot.Controls.Count > 0)
            {
                this.pnRoot.Controls.RemoveAt(0);
            }
                Form fr = formObject as Form;
                fr.TopLevel = false;
                fr.Dock = DockStyle.Fill;
                this.pnRoot.Controls.Add(fr);
                this.pnRoot.Tag = fr;
                fr.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.showForm(new DegreeGUI());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.showForm(new StaffGUI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.showForm(new TypeMain());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.showForm(new CustomerGUI());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.showForm(new ImportGUI());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.showForm(new ExportMain());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.showForm(new UserMain());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.showForm(new DistributorMain());
        }

        private void pnRoot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
