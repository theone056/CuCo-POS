
namespace CuCo_POS
{
    partial class CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashRegister));
            this.CashRegisterContainer = new System.Windows.Forms.Panel();
            this.bodyCashRegisterContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.MenuTypecomboBox = new System.Windows.Forms.ComboBox();
            this.MenuflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.headerCashRegisterContainer = new System.Windows.Forms.Panel();
            this.CashRegisterLabelDate = new System.Windows.Forms.Label();
            this.CashRegisterLabel = new System.Windows.Forms.Label();
            this.CashRegisterContainer.SuspendLayout();
            this.bodyCashRegisterContainer.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.headerCashRegisterContainer.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(660, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 537);
            this.panel1.TabIndex = 1;
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
            // MenuflowLayoutPanel
            // 
            this.MenuflowLayoutPanel.AutoScroll = true;
            this.MenuflowLayoutPanel.Location = new System.Drawing.Point(3, 66);
            this.MenuflowLayoutPanel.Name = "MenuflowLayoutPanel";
            this.MenuflowLayoutPanel.Size = new System.Drawing.Size(640, 464);
            this.MenuflowLayoutPanel.TabIndex = 0;
            this.MenuflowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuflowLayoutPanel_Paint);
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
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 581);
            this.ControlBox = false;
            this.Controls.Add(this.CashRegisterContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.CashRegisterContainer.ResumeLayout(false);
            this.bodyCashRegisterContainer.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.headerCashRegisterContainer.ResumeLayout(false);
            this.headerCashRegisterContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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

