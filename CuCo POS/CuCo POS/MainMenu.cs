﻿using System;
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
    }
}
