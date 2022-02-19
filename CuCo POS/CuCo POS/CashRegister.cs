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
    public partial class CashRegister : Form
    {
        public CashRegister()
        {
            InitializeComponent();
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Sample";
            button.Name = "button1";
            button.Height = 200;
            button.BackColor = Color.Black;
            button.Width = 250;
            MenuflowLayoutPanel.Controls.Add(button);
        }

        private void MenuflowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
