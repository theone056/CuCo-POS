
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parentContainer = new System.Windows.Forms.Panel();
            this.BodyContainerMenu = new System.Windows.Forms.Panel();
            this.salesRegister = new System.Windows.Forms.PictureBox();
            this.MenuList = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.headerContainerMenu.SuspendLayout();
            this.parentContainer.SuspendLayout();
            this.BodyContainerMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.headerContainerMenu.Location = new System.Drawing.Point(0, 0);
            this.headerContainerMenu.Name = "headerContainerMenu";
            this.headerContainerMenu.Size = new System.Drawing.Size(1288, 100);
            this.headerContainerMenu.TabIndex = 0;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(79, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 10);
            this.label2.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(809, 63);
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
            this.label1.Location = new System.Drawing.Point(561, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 10);
            this.label1.TabIndex = 4;
            // 
            // parentContainer
            // 
            this.parentContainer.BackColor = System.Drawing.Color.Transparent;
            this.parentContainer.Controls.Add(this.BodyContainerMenu);
            this.parentContainer.Controls.Add(this.headerContainerMenu);
            this.parentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentContainer.Location = new System.Drawing.Point(0, 0);
            this.parentContainer.Name = "parentContainer";
            this.parentContainer.Size = new System.Drawing.Size(1288, 581);
            this.parentContainer.TabIndex = 5;
            // 
            // BodyContainerMenu
            // 
            this.BodyContainerMenu.Controls.Add(this.pictureBox5);
            this.BodyContainerMenu.Controls.Add(this.pictureBox4);
            this.BodyContainerMenu.Controls.Add(this.pictureBox2);
            this.BodyContainerMenu.Controls.Add(this.pictureBox1);
            this.BodyContainerMenu.Controls.Add(this.pictureBox3);
            this.BodyContainerMenu.Controls.Add(this.MenuList);
            this.BodyContainerMenu.Controls.Add(this.salesRegister);
            this.BodyContainerMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyContainerMenu.Location = new System.Drawing.Point(0, 100);
            this.BodyContainerMenu.Name = "BodyContainerMenu";
            this.BodyContainerMenu.Size = new System.Drawing.Size(1288, 481);
            this.BodyContainerMenu.TabIndex = 1;
            // 
            // salesRegister
            // 
            this.salesRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesRegister.BackgroundImage")));
            this.salesRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salesRegister.Location = new System.Drawing.Point(94, 74);
            this.salesRegister.Name = "salesRegister";
            this.salesRegister.Size = new System.Drawing.Size(249, 161);
            this.salesRegister.TabIndex = 3;
            this.salesRegister.TabStop = false;
            // 
            // MenuList
            // 
            this.MenuList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MenuList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuList.BackgroundImage")));
            this.MenuList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuList.Location = new System.Drawing.Point(361, 74);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(249, 161);
            this.MenuList.TabIndex = 4;
            this.MenuList.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(899, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 161);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(634, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 161);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(180, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 161);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(813, 298);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(249, 161);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(500, 298);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(249, 161);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
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
            this.headerContainerMenu.ResumeLayout(false);
            this.headerContainerMenu.PerformLayout();
            this.parentContainer.ResumeLayout(false);
            this.BodyContainerMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox MenuList;
        private System.Windows.Forms.PictureBox salesRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

