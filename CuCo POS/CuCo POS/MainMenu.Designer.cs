
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
            this.parentContainer = new System.Windows.Forms.Panel();
            this.BodyContainerMenu = new System.Windows.Forms.Panel();
            this.reports = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.PictureBox();
            this.userList = new System.Windows.Forms.PictureBox();
            this.stockList = new System.Windows.Forms.PictureBox();
            this.supplierList = new System.Windows.Forms.PictureBox();
            this.MenuList = new System.Windows.Forms.PictureBox();
            this.salesRegister = new System.Windows.Forms.PictureBox();
            this.headerContainerMenu = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.parentContainer.SuspendLayout();
            this.BodyContainerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegister)).BeginInit();
            this.headerContainerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentContainer
            // 
            this.parentContainer.BackColor = System.Drawing.Color.Transparent;
            this.parentContainer.Controls.Add(this.BodyContainerMenu);
            this.parentContainer.Controls.Add(this.headerContainerMenu);
            this.parentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentContainer.Location = new System.Drawing.Point(0, 0);
            this.parentContainer.Name = "parentContainer";
            this.parentContainer.Padding = new System.Windows.Forms.Padding(5);
            this.parentContainer.Size = new System.Drawing.Size(1288, 581);
            this.parentContainer.TabIndex = 5;
            // 
            // BodyContainerMenu
            // 
            this.BodyContainerMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyContainerMenu.Controls.Add(this.reports);
            this.BodyContainerMenu.Controls.Add(this.logout);
            this.BodyContainerMenu.Controls.Add(this.userList);
            this.BodyContainerMenu.Controls.Add(this.stockList);
            this.BodyContainerMenu.Controls.Add(this.supplierList);
            this.BodyContainerMenu.Controls.Add(this.MenuList);
            this.BodyContainerMenu.Controls.Add(this.salesRegister);
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
            this.salesRegister.Click += new System.EventHandler(this.salesRegister_Click);
            this.salesRegister.MouseEnter += new System.EventHandler(this.salesRegister_MouseEnter);
            this.salesRegister.MouseLeave += new System.EventHandler(this.salesRegister_MouseLeave);
            // 
            // headerContainerMenu
            // 
            this.headerContainerMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerContainerMenu.BackColor = System.Drawing.Color.Transparent;
            this.headerContainerMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerContainerMenu.Controls.Add(this.timeLabel);
            this.headerContainerMenu.Controls.Add(this.label1);
            this.headerContainerMenu.Controls.Add(this.label2);
            this.headerContainerMenu.Controls.Add(this.titleLabel);
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
            this.parentContainer.ResumeLayout(false);
            this.BodyContainerMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegister)).EndInit();
            this.headerContainerMenu.ResumeLayout(false);
            this.headerContainerMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel parentContainer;
        private System.Windows.Forms.Panel BodyContainerMenu;
        private System.Windows.Forms.PictureBox reports;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.PictureBox userList;
        private System.Windows.Forms.PictureBox stockList;
        private System.Windows.Forms.PictureBox supplierList;
        private System.Windows.Forms.PictureBox MenuList;
        private System.Windows.Forms.PictureBox salesRegister;
        private System.Windows.Forms.Panel headerContainerMenu;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
    }
}

