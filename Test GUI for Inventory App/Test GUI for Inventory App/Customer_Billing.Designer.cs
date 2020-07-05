namespace Test_GUI_for_Inventory_App
{
    partial class Customer_Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Billing));
            this.tableLayoutPanelBillingOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.listBoxBills = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBoxBillingOrderInventory = new System.Windows.Forms.ListBox();
            this.comboBoxBillingOrderBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxBillingOrderCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxBillingOrderType = new System.Windows.Forms.ComboBox();
            this.listBoxBillingCustList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelBillingDetails = new System.Windows.Forms.TableLayoutPanel();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblBillingCustName = new System.Windows.Forms.Label();
            this.txtBillingCustName = new System.Windows.Forms.TextBox();
            this.lblBillingShippingAddress = new System.Windows.Forms.Label();
            this.txtBillingShippingAddress = new System.Windows.Forms.TextBox();
            this.lblBillingDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblBillingCustPhone = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.lblBillingCustMobile = new System.Windows.Forms.Label();
            this.txtCustMobile = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.lblBillID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.listBoxPaymentsDone = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelCtrls = new System.Windows.Forms.TableLayoutPanel();
            this.lblBillSearchBy = new System.Windows.Forms.Label();
            this.lblBillSearchKeywords = new System.Windows.Forms.Label();
            this.comboBoxBillSearchBy = new System.Windows.Forms.ComboBox();
            this.txtBillSearchKeywords = new System.Windows.Forms.TextBox();
            this.btnBillSearch = new System.Windows.Forms.Button();
            this.listBoxBillSearchResults = new System.Windows.Forms.ListBox();
            this.lblBillingSubTotal = new System.Windows.Forms.Label();
            this.txtBillingSubTotal = new System.Windows.Forms.TextBox();
            this.lblBillingTax = new System.Windows.Forms.Label();
            this.txtBillingTax = new System.Windows.Forms.TextBox();
            this.lblBillingTotal = new System.Windows.Forms.Label();
            this.txtBillingTotal = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBillingQuantity = new System.Windows.Forms.Label();
            this.txtBillingQuantity = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.BillprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.BillprintDocument = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanelBillingOptions.SuspendLayout();
            this.tableLayoutPanelBillingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanelCtrls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBillingOptions
            // 
            this.tableLayoutPanelBillingOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelBillingOptions.ColumnCount = 1;
            this.tableLayoutPanelBillingOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBillingOptions.Controls.Add(this.btnDeleteBill, 0, 9);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.btnUpdateBill, 0, 8);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.btnAddBill, 0, 7);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.listBoxBills, 0, 6);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.monthCalendar1, 0, 5);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.listBoxBillingOrderInventory, 0, 4);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.comboBoxBillingOrderBrand, 0, 3);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.comboBoxBillingOrderCategory, 0, 2);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.comboBoxBillingOrderType, 0, 1);
            this.tableLayoutPanelBillingOptions.Controls.Add(this.listBoxBillingCustList, 0, 0);
            this.tableLayoutPanelBillingOptions.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanelBillingOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelBillingOptions.Name = "tableLayoutPanelBillingOptions";
            this.tableLayoutPanelBillingOptions.RowCount = 11;
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBillingOptions.Size = new System.Drawing.Size(243, 758);
            this.tableLayoutPanelBillingOptions.TabIndex = 0;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBill.Image")));
            this.btnDeleteBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteBill.Location = new System.Drawing.Point(3, 694);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(236, 40);
            this.btnDeleteBill.TabIndex = 5;
            this.btnDeleteBill.Text = "Delete Bill";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBill.Image")));
            this.btnUpdateBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateBill.Location = new System.Drawing.Point(3, 648);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(236, 40);
            this.btnUpdateBill.TabIndex = 4;
            this.btnUpdateBill.Text = "Update Bill";
            this.btnUpdateBill.UseVisualStyleBackColor = true;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBill.Image")));
            this.btnAddBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBill.Location = new System.Drawing.Point(3, 602);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(236, 40);
            this.btnAddBill.TabIndex = 1;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // listBoxBills
            // 
            this.listBoxBills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBills.FormattingEnabled = true;
            this.listBoxBills.ItemHeight = 20;
            this.listBoxBills.Location = new System.Drawing.Point(3, 489);
            this.listBoxBills.Name = "listBoxBills";
            this.listBoxBills.Size = new System.Drawing.Size(237, 104);
            this.listBoxBills.TabIndex = 1;
            this.listBoxBills.DoubleClick += new System.EventHandler(this.listBoxBills_DoubleClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 315);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // listBoxBillingOrderInventory
            // 
            this.listBoxBillingOrderInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBillingOrderInventory.FormattingEnabled = true;
            this.listBoxBillingOrderInventory.ItemHeight = 20;
            this.listBoxBillingOrderInventory.Location = new System.Drawing.Point(3, 196);
            this.listBoxBillingOrderInventory.Name = "listBoxBillingOrderInventory";
            this.listBoxBillingOrderInventory.Size = new System.Drawing.Size(237, 104);
            this.listBoxBillingOrderInventory.TabIndex = 1;
            this.listBoxBillingOrderInventory.DoubleClick += new System.EventHandler(this.listBoxBillingOrderInventory_DoubleClick);
            // 
            // comboBoxBillingOrderBrand
            // 
            this.comboBoxBillingOrderBrand.FormattingEnabled = true;
            this.comboBoxBillingOrderBrand.Items.AddRange(new object[] {
            "---Brand---"});
            this.comboBoxBillingOrderBrand.Location = new System.Drawing.Point(3, 169);
            this.comboBoxBillingOrderBrand.Name = "comboBoxBillingOrderBrand";
            this.comboBoxBillingOrderBrand.Size = new System.Drawing.Size(236, 28);
            this.comboBoxBillingOrderBrand.TabIndex = 3;
            this.comboBoxBillingOrderBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillingOrderBrand_SelectedIndexChanged);
            // 
            // comboBoxBillingOrderCategory
            // 
            this.comboBoxBillingOrderCategory.FormattingEnabled = true;
            this.comboBoxBillingOrderCategory.Items.AddRange(new object[] {
            "---Category---"});
            this.comboBoxBillingOrderCategory.Location = new System.Drawing.Point(3, 142);
            this.comboBoxBillingOrderCategory.Name = "comboBoxBillingOrderCategory";
            this.comboBoxBillingOrderCategory.Size = new System.Drawing.Size(236, 28);
            this.comboBoxBillingOrderCategory.TabIndex = 2;
            this.comboBoxBillingOrderCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillingOrderCategory_SelectedIndexChanged);
            // 
            // comboBoxBillingOrderType
            // 
            this.comboBoxBillingOrderType.Enabled = false;
            this.comboBoxBillingOrderType.FormattingEnabled = true;
            this.comboBoxBillingOrderType.Items.AddRange(new object[] {
            "---Type---"});
            this.comboBoxBillingOrderType.Location = new System.Drawing.Point(3, 115);
            this.comboBoxBillingOrderType.Name = "comboBoxBillingOrderType";
            this.comboBoxBillingOrderType.Size = new System.Drawing.Size(236, 28);
            this.comboBoxBillingOrderType.TabIndex = 1;
            this.comboBoxBillingOrderType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillingOrderType_SelectedIndexChanged);
            // 
            // listBoxBillingCustList
            // 
            this.listBoxBillingCustList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBillingCustList.FormattingEnabled = true;
            this.listBoxBillingCustList.ItemHeight = 20;
            this.listBoxBillingCustList.Location = new System.Drawing.Point(4, 5);
            this.listBoxBillingCustList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBillingCustList.Name = "listBoxBillingCustList";
            this.listBoxBillingCustList.Size = new System.Drawing.Size(235, 84);
            this.listBoxBillingCustList.TabIndex = 1;
            this.listBoxBillingCustList.DoubleClick += new System.EventHandler(this.listBoxBillingCustList_DoubleClick);
            // 
            // tableLayoutPanelBillingDetails
            // 
            this.tableLayoutPanelBillingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelBillingDetails.ColumnCount = 5;
            this.tableLayoutPanelBillingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBillingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBillingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBillingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBillingDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBillingDetails.Controls.Add(this.txtCustID, 1, 1);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblBillingCustName, 0, 2);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.txtBillingCustName, 1, 2);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblBillingShippingAddress, 0, 3);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.txtBillingShippingAddress, 1, 3);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblBillingDate, 2, 0);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.dateTimePicker1, 3, 0);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblBillingCustPhone, 2, 2);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.txtCustPhone, 3, 2);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblBillingCustMobile, 2, 3);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.txtCustMobile, 3, 3);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.dataGridView1, 0, 7);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.txtBillID, 3, 1);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblBillID, 2, 1);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblOrderID, 0, 0);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.txtOrderID, 1, 0);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.lblCustID, 0, 1);
            this.tableLayoutPanelBillingDetails.Controls.Add(this.listBoxPaymentsDone, 4, 7);
            this.tableLayoutPanelBillingDetails.Location = new System.Drawing.Point(265, 4);
            this.tableLayoutPanelBillingDetails.Name = "tableLayoutPanelBillingDetails";
            this.tableLayoutPanelBillingDetails.RowCount = 9;
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBillingDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanelBillingDetails.Size = new System.Drawing.Size(762, 597);
            this.tableLayoutPanelBillingDetails.TabIndex = 1;
            this.tableLayoutPanelBillingDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelBillingDetails_Paint);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(147, 35);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(194, 26);
            this.txtCustID.TabIndex = 27;
            // 
            // lblBillingCustName
            // 
            this.lblBillingCustName.AutoSize = true;
            this.lblBillingCustName.Location = new System.Drawing.Point(3, 64);
            this.lblBillingCustName.Name = "lblBillingCustName";
            this.lblBillingCustName.Size = new System.Drawing.Size(55, 20);
            this.lblBillingCustName.TabIndex = 2;
            this.lblBillingCustName.Text = "Name:";
            // 
            // txtBillingCustName
            // 
            this.txtBillingCustName.Location = new System.Drawing.Point(147, 67);
            this.txtBillingCustName.Name = "txtBillingCustName";
            this.txtBillingCustName.ReadOnly = true;
            this.txtBillingCustName.Size = new System.Drawing.Size(194, 26);
            this.txtBillingCustName.TabIndex = 3;
            // 
            // lblBillingShippingAddress
            // 
            this.lblBillingShippingAddress.AutoSize = true;
            this.lblBillingShippingAddress.Location = new System.Drawing.Point(3, 96);
            this.lblBillingShippingAddress.Name = "lblBillingShippingAddress";
            this.lblBillingShippingAddress.Size = new System.Drawing.Size(138, 20);
            this.lblBillingShippingAddress.TabIndex = 4;
            this.lblBillingShippingAddress.Text = "Shipping Address:";
            // 
            // txtBillingShippingAddress
            // 
            this.txtBillingShippingAddress.Location = new System.Drawing.Point(147, 99);
            this.txtBillingShippingAddress.Multiline = true;
            this.txtBillingShippingAddress.Name = "txtBillingShippingAddress";
            this.txtBillingShippingAddress.ReadOnly = true;
            this.txtBillingShippingAddress.Size = new System.Drawing.Size(194, 156);
            this.txtBillingShippingAddress.TabIndex = 5;
            // 
            // lblBillingDate
            // 
            this.lblBillingDate.AutoSize = true;
            this.lblBillingDate.Location = new System.Drawing.Point(347, 0);
            this.lblBillingDate.Name = "lblBillingDate";
            this.lblBillingDate.Size = new System.Drawing.Size(48, 20);
            this.lblBillingDate.TabIndex = 6;
            this.lblBillingDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(412, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblBillingCustPhone
            // 
            this.lblBillingCustPhone.AutoSize = true;
            this.lblBillingCustPhone.Location = new System.Drawing.Point(347, 64);
            this.lblBillingCustPhone.Name = "lblBillingCustPhone";
            this.lblBillingCustPhone.Size = new System.Drawing.Size(59, 20);
            this.lblBillingCustPhone.TabIndex = 8;
            this.lblBillingCustPhone.Text = "Phone:";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(412, 67);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.ReadOnly = true;
            this.txtCustPhone.Size = new System.Drawing.Size(194, 26);
            this.txtCustPhone.TabIndex = 9;
            // 
            // lblBillingCustMobile
            // 
            this.lblBillingCustMobile.AutoSize = true;
            this.lblBillingCustMobile.Location = new System.Drawing.Point(347, 96);
            this.lblBillingCustMobile.Name = "lblBillingCustMobile";
            this.lblBillingCustMobile.Size = new System.Drawing.Size(59, 20);
            this.lblBillingCustMobile.TabIndex = 10;
            this.lblBillingCustMobile.Text = "Mobile:";
            // 
            // txtCustMobile
            // 
            this.txtCustMobile.Location = new System.Drawing.Point(412, 99);
            this.txtCustMobile.Name = "txtCustMobile";
            this.txtCustMobile.ReadOnly = true;
            this.txtCustMobile.Size = new System.Drawing.Size(194, 26);
            this.txtCustMobile.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.Brand,
            this.Category,
            this.Price,
            this.Quantity,
            this.Total});
            this.tableLayoutPanelBillingDetails.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.Location = new System.Drawing.Point(3, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(603, 294);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(412, 35);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(194, 26);
            this.txtBillID.TabIndex = 1;
            this.txtBillID.TextChanged += new System.EventHandler(this.txtBillID_TextChanged);
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Location = new System.Drawing.Point(347, 32);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(54, 20);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "Bill ID:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(3, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(74, 20);
            this.lblOrderID.TabIndex = 13;
            this.lblOrderID.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(147, 3);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(194, 26);
            this.txtOrderID.TabIndex = 27;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(3, 32);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(103, 20);
            this.lblCustID.TabIndex = 28;
            this.lblCustID.Text = "Customer ID:";
            // 
            // listBoxPaymentsDone
            // 
            this.listBoxPaymentsDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPaymentsDone.FormattingEnabled = true;
            this.listBoxPaymentsDone.ItemHeight = 20;
            this.listBoxPaymentsDone.Location = new System.Drawing.Point(612, 289);
            this.listBoxPaymentsDone.Name = "listBoxPaymentsDone";
            this.listBoxPaymentsDone.Size = new System.Drawing.Size(147, 284);
            this.listBoxPaymentsDone.TabIndex = 29;
            // 
            // tableLayoutPanelCtrls
            // 
            this.tableLayoutPanelCtrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCtrls.ColumnCount = 2;
            this.tableLayoutPanelCtrls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCtrls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.82051F));
            this.tableLayoutPanelCtrls.Controls.Add(this.lblBillSearchBy, 0, 0);
            this.tableLayoutPanelCtrls.Controls.Add(this.lblBillSearchKeywords, 0, 1);
            this.tableLayoutPanelCtrls.Controls.Add(this.comboBoxBillSearchBy, 1, 0);
            this.tableLayoutPanelCtrls.Controls.Add(this.txtBillSearchKeywords, 1, 1);
            this.tableLayoutPanelCtrls.Controls.Add(this.btnBillSearch, 0, 2);
            this.tableLayoutPanelCtrls.Controls.Add(this.listBoxBillSearchResults, 0, 3);
            this.tableLayoutPanelCtrls.Location = new System.Drawing.Point(1030, 3);
            this.tableLayoutPanelCtrls.Name = "tableLayoutPanelCtrls";
            this.tableLayoutPanelCtrls.RowCount = 5;
            this.tableLayoutPanelCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelCtrls.Size = new System.Drawing.Size(195, 735);
            this.tableLayoutPanelCtrls.TabIndex = 2;
            // 
            // lblBillSearchBy
            // 
            this.lblBillSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillSearchBy.AutoSize = true;
            this.lblBillSearchBy.Location = new System.Drawing.Point(3, 7);
            this.lblBillSearchBy.Name = "lblBillSearchBy";
            this.lblBillSearchBy.Size = new System.Drawing.Size(84, 20);
            this.lblBillSearchBy.TabIndex = 27;
            this.lblBillSearchBy.Text = "Search by:";
            // 
            // lblBillSearchKeywords
            // 
            this.lblBillSearchKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillSearchKeywords.AutoSize = true;
            this.lblBillSearchKeywords.Location = new System.Drawing.Point(3, 40);
            this.lblBillSearchKeywords.Name = "lblBillSearchKeywords";
            this.lblBillSearchKeywords.Size = new System.Drawing.Size(84, 20);
            this.lblBillSearchKeywords.TabIndex = 29;
            this.lblBillSearchKeywords.Text = "Keywords:";
            // 
            // comboBoxBillSearchBy
            // 
            this.comboBoxBillSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBillSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBillSearchBy.FormattingEnabled = true;
            this.comboBoxBillSearchBy.Items.AddRange(new object[] {
            "Order ID",
            "Bill ID",
            "Customer ID",
            "Customer Name"});
            this.comboBoxBillSearchBy.Location = new System.Drawing.Point(93, 3);
            this.comboBoxBillSearchBy.Name = "comboBoxBillSearchBy";
            this.comboBoxBillSearchBy.Size = new System.Drawing.Size(99, 28);
            this.comboBoxBillSearchBy.TabIndex = 28;
            // 
            // txtBillSearchKeywords
            // 
            this.txtBillSearchKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBillSearchKeywords.Location = new System.Drawing.Point(93, 37);
            this.txtBillSearchKeywords.Name = "txtBillSearchKeywords";
            this.txtBillSearchKeywords.Size = new System.Drawing.Size(99, 26);
            this.txtBillSearchKeywords.TabIndex = 30;
            // 
            // btnBillSearch
            // 
            this.btnBillSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCtrls.SetColumnSpan(this.btnBillSearch, 2);
            this.btnBillSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnBillSearch.Image")));
            this.btnBillSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillSearch.Location = new System.Drawing.Point(3, 69);
            this.btnBillSearch.Name = "btnBillSearch";
            this.btnBillSearch.Size = new System.Drawing.Size(189, 40);
            this.btnBillSearch.TabIndex = 31;
            this.btnBillSearch.Text = "Search";
            this.btnBillSearch.UseVisualStyleBackColor = true;
            this.btnBillSearch.Click += new System.EventHandler(this.btnBillSearch_Click);
            // 
            // listBoxBillSearchResults
            // 
            this.listBoxBillSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCtrls.SetColumnSpan(this.listBoxBillSearchResults, 2);
            this.listBoxBillSearchResults.FormattingEnabled = true;
            this.listBoxBillSearchResults.ItemHeight = 20;
            this.listBoxBillSearchResults.Location = new System.Drawing.Point(3, 115);
            this.listBoxBillSearchResults.Name = "listBoxBillSearchResults";
            this.listBoxBillSearchResults.Size = new System.Drawing.Size(189, 604);
            this.listBoxBillSearchResults.TabIndex = 32;
            this.listBoxBillSearchResults.DoubleClick += new System.EventHandler(this.listBoxBillSearchResults_DoubleClick);
            // 
            // lblBillingSubTotal
            // 
            this.lblBillingSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBillingSubTotal.AutoSize = true;
            this.lblBillingSubTotal.Location = new System.Drawing.Point(824, 608);
            this.lblBillingSubTotal.Name = "lblBillingSubTotal";
            this.lblBillingSubTotal.Size = new System.Drawing.Size(81, 20);
            this.lblBillingSubTotal.TabIndex = 3;
            this.lblBillingSubTotal.Text = "Sub Total:";
            // 
            // txtBillingSubTotal
            // 
            this.txtBillingSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBillingSubTotal.Location = new System.Drawing.Point(911, 605);
            this.txtBillingSubTotal.Name = "txtBillingSubTotal";
            this.txtBillingSubTotal.ReadOnly = true;
            this.txtBillingSubTotal.Size = new System.Drawing.Size(100, 26);
            this.txtBillingSubTotal.TabIndex = 4;
            // 
            // lblBillingTax
            // 
            this.lblBillingTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBillingTax.AutoSize = true;
            this.lblBillingTax.Location = new System.Drawing.Point(867, 639);
            this.lblBillingTax.Name = "lblBillingTax";
            this.lblBillingTax.Size = new System.Drawing.Size(38, 20);
            this.lblBillingTax.TabIndex = 5;
            this.lblBillingTax.Text = "Tax:";
            // 
            // txtBillingTax
            // 
            this.txtBillingTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBillingTax.Location = new System.Drawing.Point(911, 636);
            this.txtBillingTax.Name = "txtBillingTax";
            this.txtBillingTax.Size = new System.Drawing.Size(100, 26);
            this.txtBillingTax.TabIndex = 6;
            this.txtBillingTax.TextChanged += new System.EventHandler(this.txtBillingTax_TextChanged);
            this.txtBillingTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillingTax_KeyPress);
            this.txtBillingTax.Leave += new System.EventHandler(this.txtBillingTax_Leave);
            // 
            // lblBillingTotal
            // 
            this.lblBillingTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBillingTotal.AutoSize = true;
            this.lblBillingTotal.Location = new System.Drawing.Point(857, 670);
            this.lblBillingTotal.Name = "lblBillingTotal";
            this.lblBillingTotal.Size = new System.Drawing.Size(48, 20);
            this.lblBillingTotal.TabIndex = 7;
            this.lblBillingTotal.Text = "Total:";
            // 
            // txtBillingTotal
            // 
            this.txtBillingTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBillingTotal.Location = new System.Drawing.Point(911, 667);
            this.txtBillingTotal.Name = "txtBillingTotal";
            this.txtBillingTotal.ReadOnly = true;
            this.txtBillingTotal.Size = new System.Drawing.Size(100, 26);
            this.txtBillingTotal.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(498, 699);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(741, 699);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 40);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(929, 698);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 40);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(841, 698);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBillingQuantity
            // 
            this.lblBillingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBillingQuantity.AutoSize = true;
            this.lblBillingQuantity.Location = new System.Drawing.Point(591, 670);
            this.lblBillingQuantity.Name = "lblBillingQuantity";
            this.lblBillingQuantity.Size = new System.Drawing.Size(111, 20);
            this.lblBillingQuantity.TabIndex = 27;
            this.lblBillingQuantity.Text = "Total Quantity:";
            // 
            // txtBillingQuantity
            // 
            this.txtBillingQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBillingQuantity.Location = new System.Drawing.Point(708, 667);
            this.txtBillingQuantity.Name = "txtBillingQuantity";
            this.txtBillingQuantity.ReadOnly = true;
            this.txtBillingQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtBillingQuantity.TabIndex = 28;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.Location = new System.Drawing.Point(594, 699);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 40);
            this.btnPay.TabIndex = 29;
            this.btnPay.Text = "Pay for this Bill";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // BillprintPreviewDialog
            // 
            this.BillprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.BillprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.BillprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.BillprintPreviewDialog.Enabled = true;
            this.BillprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("BillprintPreviewDialog.Icon")));
            this.BillprintPreviewDialog.Name = "BillprintPreviewDialog";
            this.BillprintPreviewDialog.Visible = false;
            // 
            // BillprintDocument
            // 
            this.BillprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.BillprintDocument_PrintPage);
            // 
            // Customer_Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 741);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtBillingQuantity);
            this.Controls.Add(this.lblBillingQuantity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBillingTotal);
            this.Controls.Add(this.lblBillingTotal);
            this.Controls.Add(this.txtBillingTax);
            this.Controls.Add(this.lblBillingTax);
            this.Controls.Add(this.txtBillingSubTotal);
            this.Controls.Add(this.lblBillingSubTotal);
            this.Controls.Add(this.tableLayoutPanelCtrls);
            this.Controls.Add(this.tableLayoutPanelBillingDetails);
            this.Controls.Add(this.tableLayoutPanelBillingOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Customer_Billing";
            this.Text = "Customer Billing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_Billing_FormClosed);
            this.Load += new System.EventHandler(this.Customer_Billing_Load);
            this.tableLayoutPanelBillingOptions.ResumeLayout(false);
            this.tableLayoutPanelBillingDetails.ResumeLayout(false);
            this.tableLayoutPanelBillingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanelCtrls.ResumeLayout(false);
            this.tableLayoutPanelCtrls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBillingOptions;
        private System.Windows.Forms.ListBox listBoxBillingCustList;
        private System.Windows.Forms.ComboBox comboBoxBillingOrderType;
        private System.Windows.Forms.ComboBox comboBoxBillingOrderCategory;
        private System.Windows.Forms.ComboBox comboBoxBillingOrderBrand;
        private System.Windows.Forms.ListBox listBoxBillingOrderInventory;
        private System.Windows.Forms.ListBox listBoxBills;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBillingDetails;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label lblBillingCustName;
        private System.Windows.Forms.TextBox txtBillingCustName;
        private System.Windows.Forms.Label lblBillingShippingAddress;
        private System.Windows.Forms.TextBox txtBillingShippingAddress;
        private System.Windows.Forms.Label lblBillingDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblBillingCustPhone;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label lblBillingCustMobile;
        private System.Windows.Forms.TextBox txtCustMobile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCtrls;
        private System.Windows.Forms.Label lblBillSearchBy;
        private System.Windows.Forms.Label lblBillSearchKeywords;
        private System.Windows.Forms.ComboBox comboBoxBillSearchBy;
        private System.Windows.Forms.TextBox txtBillSearchKeywords;
        private System.Windows.Forms.Button btnBillSearch;
        private System.Windows.Forms.ListBox listBoxBillSearchResults;
        private System.Windows.Forms.Label lblBillingSubTotal;
        private System.Windows.Forms.TextBox txtBillingSubTotal;
        private System.Windows.Forms.Label lblBillingTax;
        private System.Windows.Forms.TextBox txtBillingTax;
        private System.Windows.Forms.Label lblBillingTotal;
        private System.Windows.Forms.TextBox txtBillingTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblBillingQuantity;
        private System.Windows.Forms.TextBox txtBillingQuantity;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListBox listBoxPaymentsDone;
        private System.Windows.Forms.PrintPreviewDialog BillprintPreviewDialog;
        private System.Drawing.Printing.PrintDocument BillprintDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}