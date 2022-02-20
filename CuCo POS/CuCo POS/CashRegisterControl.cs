using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuCo_POS
{
    public partial class CashRegisterControl : UserControl
    {
        private Label _menuName, _menuPrice;
        public CashRegisterControl()
        {
            InitializeComponent();
            dataGridViewOrderDetails.Columns.Add("ItemName", "ITEMS NAME");
            dataGridViewOrderDetails.Columns.Add("QTYItem", "QTY");
            dataGridViewOrderDetails.Columns.Add("ItemPrice", "PRICE");
            dataGridViewOrderDetails.Columns[0].Width = 250;
            dataGridViewOrderDetails.Columns[1].Width = 50;
            dataGridViewOrderDetails.Columns[2].Width = 100;
            dataGridViewOrderDetails.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewOrderDetails.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewOrderDetails.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewImageColumn button = new DataGridViewImageColumn();
            button.HeaderText = "";
            button.Image = Properties.Resources.trash;
            button.Name = "Delete";
            button.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewOrderDetails.Columns.Add(button);
            dataGridViewOrderDetails.Columns[3].Width = 30;
        }

        private void CashRegisterControl_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                Panel menuItem = new Panel();
                Label menuName = new Label();
                Label menuPrice = new Label();
                PictureBox menuPicture = new PictureBox();


                menuPicture.BackgroundImage = Properties.Resources.salesregister;
                menuPicture.Width = 200;
                menuPicture.Height = 120;
                menuPicture.Name = "name" + x;
                menuPicture.BackgroundImageLayout = ImageLayout.Stretch;
                menuPicture.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);

                menuName.Text = "name" + x;
                menuName.Name = "name" + x;
                menuName.ForeColor = Color.Black;
                menuName.Width = 200;
                menuName.Height = 15;
                menuName.TextAlign = ContentAlignment.TopCenter;
                menuName.Location = new Point(0, 120);

                menuPrice.Text = "name" + x;
                menuPrice.Name = "name" + x;
                menuPrice.ForeColor = Color.Black;
                menuPrice.Width = 200;
                menuPrice.Height = 15;
                menuPrice.TextAlign = ContentAlignment.TopCenter;
                menuPrice.Location = new Point(0, 135);


                menuItem.Width = 200;
                menuItem.Height = 160;
                menuItem.Name = "name" + x;
                menuItem.BackColor = Color.White;
                menuItem.BorderStyle = BorderStyle.Fixed3D;

                menuItem.Controls.Add(menuPicture);
                menuItem.Controls.Add(menuName);
                menuItem.Controls.Add(menuPrice);
                MenuflowLayoutPanel.Name = "name" + x;
                menuItem.Click += new EventHandler(MenuFlowLayoutItemClick);
                menuPrice.Click += new EventHandler(MenuFlowLayoutItemClick);
                menuName.Click += new EventHandler(MenuFlowLayoutItemClick);
                menuPicture.Click += new EventHandler(MenuFlowLayoutItemClick);
                MenuflowLayoutPanel.Controls.Add(menuItem);

                _menuName = menuName;
                _menuPrice = menuPrice;
            }
        }

        private void MenuFlowLayoutItemClick(object sender, EventArgs a)
        {
            Control flowLayoutPanel = sender as Control;
            var row = dataGridViewOrderDetails.Rows.Cast<DataGridViewRow>().Where(c => c.Cells["ItemName"].Value.ToString().Equals(flowLayoutPanel.Name));
            int qty = 1;
            if (row.Count() == 0)
            {
                dataGridViewOrderDetails.Rows.Add(flowLayoutPanel.Name,qty, "100");
            }
            else
            {
                qty =Convert.ToInt32(row.First().Cells[1].Value);
                row.First().Cells[1].Value = ++qty;
                dataGridViewOrderDetails.Refresh();
            }
            dataGridViewOrderDetails.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.TopLevel = false;
            mainMenu.Dock = DockStyle.Fill;
            ContainerPage.Instance.panelsContainer.Controls.Add(mainMenu);
            mainMenu.Show();
            this.Dispose();
        }
    }
}
