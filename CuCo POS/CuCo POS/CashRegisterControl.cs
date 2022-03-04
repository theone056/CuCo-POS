using CuCo_POS.Entities;
using CuCoPOSLib.FACADE;
using CuCoPOSLib.FACADE.Interface;
using Newtonsoft.Json;
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
            ICuCoPOSFacade GetItem = new CuCoPOSFacade();
            var allItem = JsonConvert.DeserializeObject<List<MenuList>>(JsonConvert.SerializeObject(GetItem.GetAllMenuItem().Result));
            for (int x = 0; x < allItem.Count; x++)
            {
                Panel menuItem = new Panel();
                Label menuName = new Label();
                Label menuPrice = new Label();
                PictureBox menuPicture = new PictureBox();

                menuPicture.BackgroundImage = Properties.Resources.salesregister;
                menuPicture.Width = 200;
                menuPicture.Height = 120;
                menuPicture.Name = allItem[x].MenuName;
                menuPicture.BackgroundImageLayout = ImageLayout.Stretch;
                menuPicture.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                menuPicture.Tag = allItem[x].MenuPrice;

                menuName.Text = allItem[x].MenuName;
                menuName.Name = allItem[x].MenuName;
                menuName.ForeColor = Color.Black;
                menuName.Width = 200;
                menuName.Height = 15;
                menuName.TextAlign = ContentAlignment.TopCenter;
                menuName.Location = new Point(0, 120);
                menuName.Tag = allItem[x].MenuPrice;

                menuPrice.Text = allItem[x].MenuPrice.ToString();
                menuPrice.Name = allItem[x].MenuName;
                menuPrice.ForeColor = Color.Black;
                menuPrice.Width = 200;
                menuPrice.Height = 15;
                menuPrice.TextAlign = ContentAlignment.TopCenter;
                menuPrice.Location = new Point(0, 135);
                menuPrice.Tag = allItem[x].MenuPrice;

                menuItem.Width = 200;
                menuItem.Height = 160;
                menuItem.Name = allItem[x].MenuName;
                menuItem.BackColor = Color.White;
                menuItem.BorderStyle = BorderStyle.Fixed3D;
                menuItem.Tag = allItem[x].MenuPrice;

                menuItem.Controls.Add(menuPicture);
                menuItem.Controls.Add(menuName);
                menuItem.Controls.Add(menuPrice);
                MenuflowLayoutPanel.Name = allItem[x].MenuName;
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
            var flowLayout = sender as Control;
            double price = Convert.ToDouble(flowLayout.Tag);
            var row = dataGridViewOrderDetails.Rows.Cast<DataGridViewRow>().Where(c => c.Cells["ItemName"].Value.ToString().Equals(flowLayout.Name));
            int qty = 1;
            if (row.Count() == 0)
            {
                dataGridViewOrderDetails.Rows.Add(flowLayout.Name, qty, price);
            }
            else
            {
                qty = Convert.ToInt32(row.First().Cells[1].Value);
                row.First().Cells[1].Value = ++qty;
                row.First().Cells[2].Value = qty * price;
               
            }
            double total = dataGridViewOrderDetails.Rows.Cast<DataGridViewRow>().Sum(c => Convert.ToDouble(c.Cells[2].Value));
            labelTotal.Text = total.ToString()+".00";
            dataGridViewOrderDetails.Refresh();
            dataGridViewOrderDetails.ClearSelection();
        }


        private void AddDataGridView(string Name, string text)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                int qty =  Convert.ToInt32(dataGridViewOrderDetails.Rows[e.RowIndex].Cells[1].Value);
                double price = Convert.ToDouble(dataGridViewOrderDetails.Rows[e.RowIndex].Cells[2].Value);
                dataGridViewOrderDetails.Rows[e.RowIndex].Cells[1].Value = --qty;
               // dataGridViewOrderDetails.Rows[e.RowIndex].Cells[2].Value = price * qty;
                if (qty == 0)
                {
                    dataGridViewOrderDetails.Rows.RemoveAt(e.RowIndex);
                }
            }
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
