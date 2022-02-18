﻿
namespace CuCo_POS
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.headerContainerMenu = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.parentContainer = new System.Windows.Forms.Panel();
            this.BodyContainerMenu = new System.Windows.Forms.Panel();
            this.reports = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.userList = new System.Windows.Forms.PictureBox();
            this.stockList = new System.Windows.Forms.PictureBox();
            this.supplierList = new System.Windows.Forms.PictureBox();
            this.MenuList = new System.Windows.Forms.PictureBox();
            this.salesRegister = new System.Windows.Forms.PictureBox();
            this.CashRegisterContainer = new System.Windows.Forms.Panel();
            this.bodyCashRegisterContainer = new System.Windows.Forms.Panel();
            this.headerCashRegisterContainer = new System.Windows.Forms.Panel();
            this.CashRegisterLabelDate = new System.Windows.Forms.Label();
            this.CashRegisterLabel = new System.Windows.Forms.Label();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuTypecomboBox = new System.Windows.Forms.ComboBox();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.headerContainerMenu.SuspendLayout();
            this.parentContainer.SuspendLayout();
            this.BodyContainerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegister)).BeginInit();
            this.CashRegisterContainer.SuspendLayout();
            this.bodyCashRegisterContainer.SuspendLayout();
            this.headerCashRegisterContainer.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerContainerMenu
            // 
            this.headerContainerMenu.BackColor = System.Drawing.Color.Transparent;
            this.headerContainerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerContainerMenu.Controls.Add(this.timeLabel);
            this.headerContainerMenu.Controls.Add(this.label1);
            this.headerContainerMenu.Controls.Add(this.label2);
            this.headerContainerMenu.Controls.Add(this.titleLabel);
            this.headerContainerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerContainerMenu.Location = new System.Drawing.Point(5, 5);
            this.headerContainerMenu.Name = "headerContainerMenu";
            this.headerContainerMenu.Size = new System.Drawing.Size(1278, 100);
            this.headerContainerMenu.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(799, 63);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(349, 23);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "SATURDAY, FEBRUARY 12, 2022, 11:30 AM";
            this.timeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(551, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 10);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(79, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 10);
            this.label2.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Gill Sans MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(73, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(213, 52);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "CuCo POS";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // parentContainer
            // 
            this.parentContainer.BackColor = System.Drawing.Color.Transparent;
            this.parentContainer.Controls.Add(this.BodyContainerMenu);
            this.parentContainer.Controls.Add(this.headerContainerMenu);
            this.parentContainer.Location = new System.Drawing.Point(23, 73);
            this.parentContainer.Name = "parentContainer";
            this.parentContainer.Padding = new System.Windows.Forms.Padding(5);
            this.parentContainer.Size = new System.Drawing.Size(1288, 581);
            this.parentContainer.TabIndex = 5;
            this.parentContainer.Visible = false;
            // 
            // BodyContainerMenu
            // 
            this.BodyContainerMenu.Controls.Add(this.reports);
            this.BodyContainerMenu.Controls.Add(this.logout);
            this.BodyContainerMenu.Controls.Add(this.userList);
            this.BodyContainerMenu.Controls.Add(this.stockList);
            this.BodyContainerMenu.Controls.Add(this.supplierList);
            this.BodyContainerMenu.Controls.Add(this.MenuList);
            this.BodyContainerMenu.Controls.Add(this.salesRegister);
            this.BodyContainerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyContainerMenu.Location = new System.Drawing.Point(5, 105);
            this.BodyContainerMenu.Name = "BodyContainerMenu";
            this.BodyContainerMenu.Size = new System.Drawing.Size(1278, 471);
            this.BodyContainerMenu.TabIndex = 1;
            // 
            // reports
            // 
            this.reports.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reports.BackgroundImage")));
            this.reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reports.Location = new System.Drawing.Point(495, 298);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(249, 161);
            this.reports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reports.TabIndex = 8;
            this.reports.TabStop = false;
            this.reports.MouseEnter += new System.EventHandler(this.reports_MouseEnter);
            this.reports.MouseLeave += new System.EventHandler(this.reports_MouseLeave);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout.BackgroundImage")));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.Location = new System.Drawing.Point(808, 298);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(249, 161);
            this.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logout.TabIndex = 8;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            this.logout.MouseEnter += new System.EventHandler(this.logout_MouseEnter);
            this.logout.MouseLeave += new System.EventHandler(this.logout_MouseLeave);
            // 
            // userList
            // 
            this.userList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userList.BackgroundImage")));
            this.userList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userList.Location = new System.Drawing.Point(175, 298);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(249, 161);
            this.userList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userList.TabIndex = 7;
            this.userList.TabStop = false;
            this.userList.MouseEnter += new System.EventHandler(this.userList_MouseEnter);
            this.userList.MouseLeave += new System.EventHandler(this.userList_MouseLeave);
            // 
            // stockList
            // 
            this.stockList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stockList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stockList.BackgroundImage")));
            this.stockList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stockList.Location = new System.Drawing.Point(629, 74);
            this.stockList.Name = "stockList";
            this.stockList.Size = new System.Drawing.Size(249, 161);
            this.stockList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stockList.TabIndex = 6;
            this.stockList.TabStop = false;
            this.stockList.MouseEnter += new System.EventHandler(this.stockList_MouseEnter);
            this.stockList.MouseLeave += new System.EventHandler(this.stockList_MouseLeave);
            // 
            // supplierList
            // 
            this.supplierList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supplierList.BackgroundImage")));
            this.supplierList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supplierList.Location = new System.Drawing.Point(889, 74);
            this.supplierList.Name = "supplierList";
            this.supplierList.Size = new System.Drawing.Size(249, 161);
            this.supplierList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supplierList.TabIndex = 5;
            this.supplierList.TabStop = false;
            this.supplierList.MouseEnter += new System.EventHandler(this.supplierList_MouseEnter);
            this.supplierList.MouseLeave += new System.EventHandler(this.supplierList_MouseLeave);
            // 
            // MenuList
            // 
            this.MenuList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MenuList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuList.BackgroundImage")));
            this.MenuList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuList.Location = new System.Drawing.Point(356, 74);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(249, 161);
            this.MenuList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuList.TabIndex = 4;
            this.MenuList.TabStop = false;
            this.MenuList.MouseEnter += new System.EventHandler(this.MenuList_MouseEnter);
            this.MenuList.MouseLeave += new System.EventHandler(this.MenuList_MouseLeave);
            // 
            // salesRegister
            // 
            this.salesRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesRegister.BackgroundImage")));
            this.salesRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salesRegister.Location = new System.Drawing.Point(94, 74);
            this.salesRegister.Name = "salesRegister";
            this.salesRegister.Size = new System.Drawing.Size(249, 161);
            this.salesRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salesRegister.TabIndex = 3;
            this.salesRegister.TabStop = false;
            this.salesRegister.MouseEnter += new System.EventHandler(this.salesRegister_MouseEnter);
            this.salesRegister.MouseLeave += new System.EventHandler(this.salesRegister_MouseLeave);
            // 
            // CashRegisterContainer
            // 
            this.CashRegisterContainer.BackColor = System.Drawing.Color.Transparent;
            this.CashRegisterContainer.BackgroundImage = global::CuCo_POS.Properties.Resources.background;
            this.CashRegisterContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CashRegisterContainer.Controls.Add(this.bodyCashRegisterContainer);
            this.CashRegisterContainer.Controls.Add(this.headerCashRegisterContainer);
            this.CashRegisterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashRegisterContainer.Location = new System.Drawing.Point(0, 0);
            this.CashRegisterContainer.Name = "CashRegisterContainer";
            this.CashRegisterContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CashRegisterContainer.Size = new System.Drawing.Size(1288, 581);
            this.CashRegisterContainer.TabIndex = 6;
            this.CashRegisterContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.menuListContainer_Paint);
            // 
            // bodyCashRegisterContainer
            // 
            this.bodyCashRegisterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(29)))), ((int)(((byte)(65)))));
            this.bodyCashRegisterContainer.Controls.Add(this.panel1);
            this.bodyCashRegisterContainer.Controls.Add(this.MenuContainer);
            this.bodyCashRegisterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyCashRegisterContainer.ForeColor = System.Drawing.Color.White;
            this.bodyCashRegisterContainer.Location = new System.Drawing.Point(5, 39);
            this.bodyCashRegisterContainer.Name = "bodyCashRegisterContainer";
            this.bodyCashRegisterContainer.Size = new System.Drawing.Size(1278, 537);
            this.bodyCashRegisterContainer.TabIndex = 1;
            this.bodyCashRegisterContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyCashRegisterContainer_Paint);
            // 
            // headerCashRegisterContainer
            // 
            this.headerCashRegisterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(48)))));
            this.headerCashRegisterContainer.Controls.Add(this.CashRegisterLabelDate);
            this.headerCashRegisterContainer.Controls.Add(this.CashRegisterLabel);
            this.headerCashRegisterContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerCashRegisterContainer.Location = new System.Drawing.Point(5, 5);
            this.headerCashRegisterContainer.Name = "headerCashRegisterContainer";
            this.headerCashRegisterContainer.Size = new System.Drawing.Size(1278, 34);
            this.headerCashRegisterContainer.TabIndex = 0;
            this.headerCashRegisterContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.headerCashRegisterContainer_Paint);
            // 
            // CashRegisterLabelDate
            // 
            this.CashRegisterLabelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CashRegisterLabelDate.AutoSize = true;
            this.CashRegisterLabelDate.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRegisterLabelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.CashRegisterLabelDate.Location = new System.Drawing.Point(929, 8);
            this.CashRegisterLabelDate.Name = "CashRegisterLabelDate";
            this.CashRegisterLabelDate.Size = new System.Drawing.Size(349, 23);
            this.CashRegisterLabelDate.TabIndex = 4;
            this.CashRegisterLabelDate.Text = "SATURDAY, FEBRUARY 12, 2022, 11:30 AM";
            this.CashRegisterLabelDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // CashRegisterLabel
            // 
            this.CashRegisterLabel.AutoSize = true;
            this.CashRegisterLabel.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRegisterLabel.ForeColor = System.Drawing.Color.White;
            this.CashRegisterLabel.Location = new System.Drawing.Point(1, -3);
            this.CashRegisterLabel.Name = "CashRegisterLabel";
            this.CashRegisterLabel.Size = new System.Drawing.Size(191, 38);
            this.CashRegisterLabel.TabIndex = 1;
            this.CashRegisterLabel.Text = "Cashier: Derick";
            // 
            // MenuContainer
            // 
            this.MenuContainer.Controls.Add(this.panel2);
            this.MenuContainer.Controls.Add(this.MenuflowLayoutPanel);
            this.MenuContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(646, 537);
            this.MenuContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(660, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 537);
            this.panel1.TabIndex = 1;
            // 
            // MenuflowLayoutPanel
            // 
            this.MenuflowLayoutPanel.AutoScroll = true;
            this.MenuflowLayoutPanel.Location = new System.Drawing.Point(3, 66);
            this.MenuflowLayoutPanel.Name = "MenuflowLayoutPanel";
            this.MenuflowLayoutPanel.Size = new System.Drawing.Size(640, 464);
            this.MenuflowLayoutPanel.TabIndex = 0;
            this.MenuflowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuflowLayoutPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.panel2.Controls.Add(this.SearchtextBox);
            this.panel2.Controls.Add(this.Searchlabel);
            this.panel2.Controls.Add(this.MenuTypecomboBox);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 47);
            this.panel2.TabIndex = 0;
            // 
            // MenuTypecomboBox
            // 
            this.MenuTypecomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.MenuTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MenuTypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTypecomboBox.FormattingEnabled = true;
            this.MenuTypecomboBox.Location = new System.Drawing.Point(8, 10);
            this.MenuTypecomboBox.Name = "MenuTypecomboBox";
            this.MenuTypecomboBox.Size = new System.Drawing.Size(176, 28);
            this.MenuTypecomboBox.TabIndex = 0;
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.Location = new System.Drawing.Point(275, 11);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(86, 25);
            this.Searchlabel.TabIndex = 1;
            this.Searchlabel.Text = "Search";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.SearchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(365, 7);
            this.SearchtextBox.Multiline = true;
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(253, 34);
            this.SearchtextBox.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 581);
            this.ControlBox = false;
            this.Controls.Add(this.CashRegisterContainer);
            this.Controls.Add(this.parentContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.headerContainerMenu.ResumeLayout(false);
            this.headerContainerMenu.PerformLayout();
            this.parentContainer.ResumeLayout(false);
            this.BodyContainerMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegister)).EndInit();
            this.CashRegisterContainer.ResumeLayout(false);
            this.bodyCashRegisterContainer.ResumeLayout(false);
            this.headerCashRegisterContainer.ResumeLayout(false);
            this.headerCashRegisterContainer.PerformLayout();
            this.MenuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerContainerMenu;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel parentContainer;
        private System.Windows.Forms.Panel BodyContainerMenu;
        private System.Windows.Forms.PictureBox supplierList;
        private System.Windows.Forms.PictureBox MenuList;
        private System.Windows.Forms.PictureBox salesRegister;
        private System.Windows.Forms.PictureBox stockList;
        private System.Windows.Forms.PictureBox reports;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox userList;
        private System.Windows.Forms.Panel CashRegisterContainer;
        private System.Windows.Forms.Panel bodyCashRegisterContainer;
        private System.Windows.Forms.Panel headerCashRegisterContainer;
        private System.Windows.Forms.Label CashRegisterLabel;
        private System.Windows.Forms.Label CashRegisterLabelDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.ComboBox MenuTypecomboBox;
        private System.Windows.Forms.FlowLayoutPanel MenuflowLayoutPanel;
    }
}

