using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuCo_POS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            timeLabel.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void salesRegister_MouseEnter(object sender, EventArgs e)
        {
            this.salesRegister.BackgroundImage = ((System.Drawing.Image)Properties.Resources.salesregister2);
        }

        private void salesRegister_MouseLeave(object sender, EventArgs e)
        {
            this.salesRegister.BackgroundImage = ((System.Drawing.Image)Properties.Resources.salesregister);
        }

        private void MenuList_MouseEnter(object sender, EventArgs e)
        {
            this.MenuList.BackgroundImage = ((Image)Properties.Resources.menulist2);
        }

        private void MenuList_MouseLeave(object sender, EventArgs e)
        {
            this.MenuList.BackgroundImage = ((Image)Properties.Resources.menulist);
        }

        private void stockList_MouseEnter(object sender, EventArgs e)
        {
            this.stockList.BackgroundImage = ((Image)Properties.Resources.stocklist2);
        }

        private void stockList_MouseLeave(object sender, EventArgs e)
        {
            this.stockList.BackgroundImage = ((Image)Properties.Resources.stocklist);
        }

        private void supplierList_MouseEnter(object sender, EventArgs e)
        {
            this.supplierList.BackgroundImage = ((Image)Properties.Resources.supplierlist2);
        }

        private void supplierList_MouseLeave(object sender, EventArgs e)
        {
            this.supplierList.BackgroundImage = ((Image)Properties.Resources.supplierlist);
        }

        private void userList_MouseEnter(object sender, EventArgs e)
        {
            this.userList.BackgroundImage = ((Image)Properties.Resources.userlist2);
        }

        private void userList_MouseLeave(object sender, EventArgs e)
        {
            this.userList.BackgroundImage = ((Image)Properties.Resources.userlist);
        }

        private void reports_MouseEnter(object sender, EventArgs e)
        {
            this.reports.BackgroundImage = ((Image)Properties.Resources.reports2);
        }

        private void reports_MouseLeave(object sender, EventArgs e)
        {
            this.reports.BackgroundImage = ((Image)Properties.Resources.reports);
        }

        private void logout_MouseEnter(object sender, EventArgs e)
        {
            this.logout.BackgroundImage = ((Image)Properties.Resources.log_out2);
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            this.logout.BackgroundImage = ((Image)Properties.Resources.log_out);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuListContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void headerCashRegisterContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bodyCashRegisterContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
