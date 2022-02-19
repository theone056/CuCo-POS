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
    public partial class ContainerPage : Form
    {
        static ContainerPage _obj;
        public ContainerPage()
        {
            InitializeComponent();
        }
        public static ContainerPage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ContainerPage();
                }
                return _obj;
            }
        }
        private void ContainerPage_Load(object sender, EventArgs e)
        {
            _obj = this;
            MainMenu mainMenu = new MainMenu();
            mainMenu.TopLevel = false;
            mainMenu.Dock = DockStyle.Fill;
            panelsContainer.Controls.Add(mainMenu);
            mainMenu.Show();
        }
    }
}
