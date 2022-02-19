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
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
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

                menuName.Text = "Menu Name";
                menuName.Name = "name" + x;
                menuName.ForeColor = Color.White;
                menuName.Width = 200;
                menuName.Height = 15;
                menuName.TextAlign = ContentAlignment.TopCenter;
                menuName.Location = new Point(0, 120);

                menuPrice.Text = "Menu Price";
                menuPrice.Name = "name" + x;
                menuPrice.ForeColor = Color.White;
                menuPrice.Width = 200;
                menuPrice.Height = 15;
                menuPrice.TextAlign = ContentAlignment.TopCenter;
                menuPrice.Location = new Point(0, 135);


                menuItem.Width = 200;
                menuItem.Height = 160;
                menuItem.Name = "name" + x;
                menuItem.BackColor = Color.FromArgb(183, 29, 65);
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

            }
        }

        private void MenuFlowLayoutItemClick(object sender, EventArgs a)
        {
            Control flowLayoutPanel = sender as Control;
            MessageBox.Show(flowLayoutPanel.Name);
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
