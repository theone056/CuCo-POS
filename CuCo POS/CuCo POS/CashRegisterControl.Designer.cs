
namespace CuCo_POS
{
    partial class CashRegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CashRegisterContainer = new System.Windows.Forms.Panel();
            this.bodyCashRegisterContainer = new System.Windows.Forms.Panel();
            this.invoiceContainer = new System.Windows.Forms.Panel();
            this.dataGridContainer = new System.Windows.Forms.Panel();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.totalDetailsContainer = new System.Windows.Forms.Panel();
            this.buttonsContainer = new System.Windows.Forms.Panel();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonPrintSlip = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.totalContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backButtonContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxServiceMode = new System.Windows.Forms.ComboBox();
            this.tableDetailsContainer = new System.Windows.Forms.Panel();
            this.comboBoxOrderNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxTableNumber = new System.Windows.Forms.ComboBox();
            this.labelOrderNum = new System.Windows.Forms.Label();
            this.labelTablenum = new System.Windows.Forms.Label();
            this.CustomerNameContainer = new System.Windows.Forms.Panel();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.LabelCustomer = new System.Windows.Forms.Label();
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
            this.invoiceContainer.SuspendLayout();
            this.dataGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.totalDetailsContainer.SuspendLayout();
            this.buttonsContainer.SuspendLayout();
            this.totalContainer.SuspendLayout();
            this.backButtonContainer.SuspendLayout();
            this.tableDetailsContainer.SuspendLayout();
            this.CustomerNameContainer.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.headerCashRegisterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashRegisterContainer
            // 
            this.CashRegisterContainer.BackColor = System.Drawing.Color.Transparent;
            this.CashRegisterContainer.BackgroundImage = global::CuCo_POS.Properties.Resources.background;
            this.CashRegisterContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CashRegisterContainer.Controls.Add(this.bodyCashRegisterContainer);
            this.CashRegisterContainer.Controls.Add(this.headerCashRegisterContainer);
            this.CashRegisterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashRegisterContainer.Location = new System.Drawing.Point(0, 0);
            this.CashRegisterContainer.Name = "CashRegisterContainer";
            this.CashRegisterContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CashRegisterContainer.Size = new System.Drawing.Size(1300, 589);
            this.CashRegisterContainer.TabIndex = 7;
            // 
            // bodyCashRegisterContainer
            // 
            this.bodyCashRegisterContainer.BackColor = System.Drawing.Color.White;
            this.bodyCashRegisterContainer.Controls.Add(this.invoiceContainer);
            this.bodyCashRegisterContainer.Controls.Add(this.MenuContainer);
            this.bodyCashRegisterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyCashRegisterContainer.ForeColor = System.Drawing.Color.White;
            this.bodyCashRegisterContainer.Location = new System.Drawing.Point(5, 39);
            this.bodyCashRegisterContainer.Name = "bodyCashRegisterContainer";
            this.bodyCashRegisterContainer.Size = new System.Drawing.Size(1290, 545);
            this.bodyCashRegisterContainer.TabIndex = 1;
            // 
            // invoiceContainer
            // 
            this.invoiceContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceContainer.Controls.Add(this.dataGridContainer);
            this.invoiceContainer.Controls.Add(this.totalDetailsContainer);
            this.invoiceContainer.Controls.Add(this.backButtonContainer);
            this.invoiceContainer.Controls.Add(this.tableDetailsContainer);
            this.invoiceContainer.Controls.Add(this.CustomerNameContainer);
            this.invoiceContainer.Location = new System.Drawing.Point(660, 0);
            this.invoiceContainer.Name = "invoiceContainer";
            this.invoiceContainer.Size = new System.Drawing.Size(630, 537);
            this.invoiceContainer.TabIndex = 1;
            // 
            // dataGridContainer
            // 
            this.dataGridContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridContainer.Controls.Add(this.dataGridViewOrderDetails);
            this.dataGridContainer.Location = new System.Drawing.Point(3, 88);
            this.dataGridContainer.Name = "dataGridContainer";
            this.dataGridContainer.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridContainer.Size = new System.Drawing.Size(624, 232);
            this.dataGridContainer.TabIndex = 5;
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AllowUserToAddRows = false;
            this.dataGridViewOrderDetails.AllowUserToDeleteRows = false;
            this.dataGridViewOrderDetails.AllowUserToResizeColumns = false;
            this.dataGridViewOrderDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOrderDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewOrderDetails.GridColor = System.Drawing.Color.White;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewOrderDetails.MultiSelect = false;
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.ReadOnly = true;
            this.dataGridViewOrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrderDetails.RowHeadersVisible = false;
            this.dataGridViewOrderDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrderDetails.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.dataGridViewOrderDetails.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrderDetails.RowTemplate.DividerHeight = 5;
            this.dataGridViewOrderDetails.RowTemplate.Height = 50;
            this.dataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(614, 222);
            this.dataGridViewOrderDetails.TabIndex = 0;
            // 
            // totalDetailsContainer
            // 
            this.totalDetailsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDetailsContainer.Controls.Add(this.buttonsContainer);
            this.totalDetailsContainer.Controls.Add(this.totalContainer);
            this.totalDetailsContainer.Location = new System.Drawing.Point(3, 326);
            this.totalDetailsContainer.Name = "totalDetailsContainer";
            this.totalDetailsContainer.Size = new System.Drawing.Size(624, 204);
            this.totalDetailsContainer.TabIndex = 4;
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsContainer.Controls.Add(this.buttonCancelOrder);
            this.buttonsContainer.Controls.Add(this.buttonSave);
            this.buttonsContainer.Controls.Add(this.buttonNewOrder);
            this.buttonsContainer.Controls.Add(this.buttonPrintSlip);
            this.buttonsContainer.Controls.Add(this.buttonCheckOut);
            this.buttonsContainer.Location = new System.Drawing.Point(355, 3);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Size = new System.Drawing.Size(269, 198);
            this.buttonsContainer.TabIndex = 1;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(48)))));
            this.buttonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelOrder.Location = new System.Drawing.Point(137, 135);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(127, 60);
            this.buttonCancelOrder.TabIndex = 7;
            this.buttonCancelOrder.Text = "CANCEL ORDER";
            this.buttonCancelOrder.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(48)))));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(137, 69);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 60);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(48)))));
            this.buttonNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewOrder.Location = new System.Drawing.Point(4, 69);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(127, 60);
            this.buttonNewOrder.TabIndex = 5;
            this.buttonNewOrder.Text = "NEW ORDER";
            this.buttonNewOrder.UseVisualStyleBackColor = false;
            // 
            // buttonPrintSlip
            // 
            this.buttonPrintSlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrintSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(48)))));
            this.buttonPrintSlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintSlip.Location = new System.Drawing.Point(4, 135);
            this.buttonPrintSlip.Name = "buttonPrintSlip";
            this.buttonPrintSlip.Size = new System.Drawing.Size(127, 60);
            this.buttonPrintSlip.TabIndex = 4;
            this.buttonPrintSlip.Text = "PRINT ORDER SLIP";
            this.buttonPrintSlip.UseVisualStyleBackColor = false;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(48)))));
            this.buttonCheckOut.Location = new System.Drawing.Point(4, 3);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(260, 60);
            this.buttonCheckOut.TabIndex = 0;
            this.buttonCheckOut.Text = "CHECK OUT";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // totalContainer
            // 
            this.totalContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalContainer.Controls.Add(this.label1);
            this.totalContainer.Controls.Add(this.label6);
            this.totalContainer.Location = new System.Drawing.Point(0, 0);
            this.totalContainer.Name = "totalContainer";
            this.totalContainer.Size = new System.Drawing.Size(349, 204);
            this.totalContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(46)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(0, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 138);
            this.label1.TabIndex = 6;
            this.label1.Text = "100,000.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 66);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL AMOUNT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // backButtonContainer
            // 
            this.backButtonContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backButtonContainer.Controls.Add(this.button1);
            this.backButtonContainer.Controls.Add(this.comboBoxServiceMode);
            this.backButtonContainer.Location = new System.Drawing.Point(429, 6);
            this.backButtonContainer.Name = "backButtonContainer";
            this.backButtonContainer.Size = new System.Drawing.Size(193, 76);
            this.backButtonContainer.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CuCo_POS.Properties.Resources.return3;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(125, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 55);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxServiceMode
            // 
            this.comboBoxServiceMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxServiceMode.AutoCompleteCustomSource.AddRange(new string[] {
            "test1",
            "test2",
            "test3"});
            this.comboBoxServiceMode.BackColor = System.Drawing.Color.White;
            this.comboBoxServiceMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxServiceMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServiceMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxServiceMode.FormattingEnabled = true;
            this.comboBoxServiceMode.Items.AddRange(new object[] {
            "DINE IN",
            "TAKE OUT"});
            this.comboBoxServiceMode.Location = new System.Drawing.Point(3, 14);
            this.comboBoxServiceMode.Name = "comboBoxServiceMode";
            this.comboBoxServiceMode.Size = new System.Drawing.Size(116, 45);
            this.comboBoxServiceMode.TabIndex = 7;
            // 
            // tableDetailsContainer
            // 
            this.tableDetailsContainer.Controls.Add(this.comboBoxOrderNumber);
            this.tableDetailsContainer.Controls.Add(this.comboBoxTableNumber);
            this.tableDetailsContainer.Controls.Add(this.labelOrderNum);
            this.tableDetailsContainer.Controls.Add(this.labelTablenum);
            this.tableDetailsContainer.Location = new System.Drawing.Point(3, 44);
            this.tableDetailsContainer.Name = "tableDetailsContainer";
            this.tableDetailsContainer.Size = new System.Drawing.Size(423, 38);
            this.tableDetailsContainer.TabIndex = 1;
            // 
            // comboBoxOrderNumber
            // 
            this.comboBoxOrderNumber.AutoCompleteCustomSource.AddRange(new string[] {
            "test1",
            "test2",
            "test3"});
            this.comboBoxOrderNumber.BackColor = System.Drawing.Color.White;
            this.comboBoxOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrderNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxOrderNumber.FormattingEnabled = true;
            this.comboBoxOrderNumber.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3"});
            this.comboBoxOrderNumber.Location = new System.Drawing.Point(262, 5);
            this.comboBoxOrderNumber.Name = "comboBoxOrderNumber";
            this.comboBoxOrderNumber.Size = new System.Drawing.Size(158, 28);
            this.comboBoxOrderNumber.TabIndex = 7;
            // 
            // comboBoxTableNumber
            // 
            this.comboBoxTableNumber.AutoCompleteCustomSource.AddRange(new string[] {
            "test1",
            "test2",
            "test3"});
            this.comboBoxTableNumber.BackColor = System.Drawing.Color.White;
            this.comboBoxTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTableNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxTableNumber.FormattingEnabled = true;
            this.comboBoxTableNumber.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3"});
            this.comboBoxTableNumber.Location = new System.Drawing.Point(89, 5);
            this.comboBoxTableNumber.Name = "comboBoxTableNumber";
            this.comboBoxTableNumber.Size = new System.Drawing.Size(75, 28);
            this.comboBoxTableNumber.TabIndex = 6;
            // 
            // labelOrderNum
            // 
            this.labelOrderNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderNum.AutoSize = true;
            this.labelOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNum.ForeColor = System.Drawing.Color.Black;
            this.labelOrderNum.Location = new System.Drawing.Point(170, 9);
            this.labelOrderNum.Name = "labelOrderNum";
            this.labelOrderNum.Size = new System.Drawing.Size(88, 20);
            this.labelOrderNum.TabIndex = 5;
            this.labelOrderNum.Text = "ORDER #";
            // 
            // labelTablenum
            // 
            this.labelTablenum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTablenum.AutoSize = true;
            this.labelTablenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTablenum.ForeColor = System.Drawing.Color.Black;
            this.labelTablenum.Location = new System.Drawing.Point(3, 9);
            this.labelTablenum.Name = "labelTablenum";
            this.labelTablenum.Size = new System.Drawing.Size(80, 20);
            this.labelTablenum.TabIndex = 4;
            this.labelTablenum.Text = "TABLE #";
            // 
            // CustomerNameContainer
            // 
            this.CustomerNameContainer.Controls.Add(this.CustomerTextBox);
            this.CustomerNameContainer.Controls.Add(this.LabelCustomer);
            this.CustomerNameContainer.Location = new System.Drawing.Point(3, 3);
            this.CustomerNameContainer.Name = "CustomerNameContainer";
            this.CustomerNameContainer.Size = new System.Drawing.Size(423, 38);
            this.CustomerNameContainer.TabIndex = 0;
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerTextBox.BackColor = System.Drawing.Color.White;
            this.CustomerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTextBox.Location = new System.Drawing.Point(123, 4);
            this.CustomerTextBox.Multiline = true;
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(297, 31);
            this.CustomerTextBox.TabIndex = 3;
            this.CustomerTextBox.Text = "Guest";
            // 
            // LabelCustomer
            // 
            this.LabelCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCustomer.AutoSize = true;
            this.LabelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomer.ForeColor = System.Drawing.Color.Black;
            this.LabelCustomer.Location = new System.Drawing.Point(5, 7);
            this.LabelCustomer.Name = "LabelCustomer";
            this.LabelCustomer.Size = new System.Drawing.Size(112, 25);
            this.LabelCustomer.TabIndex = 2;
            this.LabelCustomer.Text = "Customer";
            // 
            // MenuContainer
            // 
            this.MenuContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(29)))), ((int)(((byte)(65)))));
            this.MenuContainer.Controls.Add(this.panel2);
            this.MenuContainer.Controls.Add(this.MenuflowLayoutPanel);
            this.MenuContainer.Location = new System.Drawing.Point(0, 0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(658, 545);
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
            this.panel2.Size = new System.Drawing.Size(641, 47);
            this.panel2.TabIndex = 0;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.SearchtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(368, 9);
            this.SearchtextBox.Multiline = true;
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(253, 31);
            this.SearchtextBox.TabIndex = 2;
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.Location = new System.Drawing.Point(278, 11);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(86, 25);
            this.Searchlabel.TabIndex = 1;
            this.Searchlabel.Text = "Search";
            // 
            // MenuTypecomboBox
            // 
            this.MenuTypecomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "test1",
            "test2",
            "test3"});
            this.MenuTypecomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(76)))), ((int)(((byte)(112)))));
            this.MenuTypecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuTypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTypecomboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuTypecomboBox.FormattingEnabled = true;
            this.MenuTypecomboBox.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3"});
            this.MenuTypecomboBox.Location = new System.Drawing.Point(8, 10);
            this.MenuTypecomboBox.Name = "MenuTypecomboBox";
            this.MenuTypecomboBox.Size = new System.Drawing.Size(162, 28);
            this.MenuTypecomboBox.TabIndex = 0;
            // 
            // MenuflowLayoutPanel
            // 
            this.MenuflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuflowLayoutPanel.AutoScroll = true;
            this.MenuflowLayoutPanel.Location = new System.Drawing.Point(3, 92);
            this.MenuflowLayoutPanel.Name = "MenuflowLayoutPanel";
            this.MenuflowLayoutPanel.Size = new System.Drawing.Size(640, 446);
            this.MenuflowLayoutPanel.TabIndex = 0;
            // 
            // headerCashRegisterContainer
            // 
            this.headerCashRegisterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(21)))), ((int)(((byte)(48)))));
            this.headerCashRegisterContainer.Controls.Add(this.CashRegisterLabelDate);
            this.headerCashRegisterContainer.Controls.Add(this.CashRegisterLabel);
            this.headerCashRegisterContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerCashRegisterContainer.Location = new System.Drawing.Point(5, 5);
            this.headerCashRegisterContainer.Name = "headerCashRegisterContainer";
            this.headerCashRegisterContainer.Size = new System.Drawing.Size(1290, 34);
            this.headerCashRegisterContainer.TabIndex = 0;
            // 
            // CashRegisterLabelDate
            // 
            this.CashRegisterLabelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CashRegisterLabelDate.AutoSize = true;
            this.CashRegisterLabelDate.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRegisterLabelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.CashRegisterLabelDate.Location = new System.Drawing.Point(941, 8);
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
            // CashRegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CashRegisterContainer);
            this.Name = "CashRegisterControl";
            this.Size = new System.Drawing.Size(1300, 589);
            this.Load += new System.EventHandler(this.CashRegisterControl_Load);
            this.CashRegisterContainer.ResumeLayout(false);
            this.bodyCashRegisterContainer.ResumeLayout(false);
            this.invoiceContainer.ResumeLayout(false);
            this.dataGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.totalDetailsContainer.ResumeLayout(false);
            this.buttonsContainer.ResumeLayout(false);
            this.totalContainer.ResumeLayout(false);
            this.backButtonContainer.ResumeLayout(false);
            this.tableDetailsContainer.ResumeLayout(false);
            this.tableDetailsContainer.PerformLayout();
            this.CustomerNameContainer.ResumeLayout(false);
            this.CustomerNameContainer.PerformLayout();
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
        private System.Windows.Forms.Panel MenuContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.ComboBox MenuTypecomboBox;
        private System.Windows.Forms.FlowLayoutPanel MenuflowLayoutPanel;
        private System.Windows.Forms.Panel headerCashRegisterContainer;
        private System.Windows.Forms.Label CashRegisterLabelDate;
        private System.Windows.Forms.Label CashRegisterLabel;
        private System.Windows.Forms.Panel invoiceContainer;
        private System.Windows.Forms.Panel dataGridContainer;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Panel totalDetailsContainer;
        private System.Windows.Forms.Panel backButtonContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxServiceMode;
        private System.Windows.Forms.Panel tableDetailsContainer;
        private System.Windows.Forms.ComboBox comboBoxOrderNumber;
        private System.Windows.Forms.ComboBox comboBoxTableNumber;
        private System.Windows.Forms.Label labelOrderNum;
        private System.Windows.Forms.Label labelTablenum;
        private System.Windows.Forms.Panel CustomerNameContainer;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Label LabelCustomer;
        private System.Windows.Forms.Panel buttonsContainer;
        private System.Windows.Forms.Button buttonPrintSlip;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Panel totalContainer;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}
