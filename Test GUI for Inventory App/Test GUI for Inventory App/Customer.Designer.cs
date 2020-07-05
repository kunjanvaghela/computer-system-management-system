namespace Test_GUI_for_Inventory_App
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.tabPageCustomerDetails = new System.Windows.Forms.TabPage();
            this.splitContainerCustDetails = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelCustDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveCust = new System.Windows.Forms.Button();
            this.listBoxCustomerList = new System.Windows.Forms.ListBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnUpdateCustDetails = new System.Windows.Forms.Button();
            this.tableLayoutPanelCustSearchCtrls = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustDetailsSearchBy = new System.Windows.Forms.Label();
            this.comboBoxCustDetailsSearchBy = new System.Windows.Forms.ComboBox();
            this.listBoxCustDetailsSearchResults = new System.Windows.Forms.ListBox();
            this.btnCustDetailsSearch = new System.Windows.Forms.Button();
            this.lblCustDetailsSearchKeywords = new System.Windows.Forms.Label();
            this.txtCustDetailsSearchKeywords = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCustDetails = new System.Windows.Forms.TableLayoutPanel();
            this.panelActionButtons = new System.Windows.Forms.Panel();
            this.btnCustDetailsPrint = new System.Windows.Forms.Button();
            this.btnCustDetailsSave = new System.Windows.Forms.Button();
            this.btnCustDetailsCancel = new System.Windows.Forms.Button();
            this.btnCustDetailsClear = new System.Windows.Forms.Button();
            this.btnCustDetailsClose = new System.Windows.Forms.Button();
            this.dateTimePickerCustDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustGender = new System.Windows.Forms.ComboBox();
            this.txtCustRemarks = new System.Windows.Forms.TextBox();
            this.lblCustReamrks = new System.Windows.Forms.Label();
            this.txtCustShippingAddress = new System.Windows.Forms.TextBox();
            this.lblCustShippingAddress = new System.Windows.Forms.Label();
            this.lblCustGender = new System.Windows.Forms.Label();
            this.txtCustPhone1 = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustDOB = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustEmail1 = new System.Windows.Forms.Label();
            this.lblCustMobile2 = new System.Windows.Forms.Label();
            this.lblCustPhone1 = new System.Windows.Forms.Label();
            this.lblCustMobile1 = new System.Windows.Forms.Label();
            this.lblCustPhone2 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustEmail2 = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtCustPhone2 = new System.Windows.Forms.TextBox();
            this.txtCustMobile1 = new System.Windows.Forms.TextBox();
            this.txtCustMobile2 = new System.Windows.Forms.TextBox();
            this.txtCustEmail1 = new System.Windows.Forms.TextBox();
            this.txtCustEmail2 = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.tabCtrlCustomer = new System.Windows.Forms.TabControl();
            this.tabPageCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustDetails)).BeginInit();
            this.splitContainerCustDetails.Panel1.SuspendLayout();
            this.splitContainerCustDetails.Panel2.SuspendLayout();
            this.splitContainerCustDetails.SuspendLayout();
            this.tableLayoutPanelCustDisplay.SuspendLayout();
            this.tableLayoutPanelCustSearchCtrls.SuspendLayout();
            this.tableLayoutPanelCustDetails.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            this.tabCtrlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageCustomerDetails
            // 
            this.tabPageCustomerDetails.Controls.Add(this.splitContainerCustDetails);
            this.tabPageCustomerDetails.Location = new System.Drawing.Point(4, 29);
            this.tabPageCustomerDetails.Name = "tabPageCustomerDetails";
            this.tabPageCustomerDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomerDetails.Size = new System.Drawing.Size(1176, 708);
            this.tabPageCustomerDetails.TabIndex = 2;
            this.tabPageCustomerDetails.Text = "Customer Details";
            this.tabPageCustomerDetails.UseVisualStyleBackColor = true;
            // 
            // splitContainerCustDetails
            // 
            this.splitContainerCustDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerCustDetails.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerCustDetails.IsSplitterFixed = true;
            this.splitContainerCustDetails.Location = new System.Drawing.Point(3, 3);
            this.splitContainerCustDetails.Name = "splitContainerCustDetails";
            // 
            // splitContainerCustDetails.Panel1
            // 
            this.splitContainerCustDetails.Panel1.Controls.Add(this.tableLayoutPanelCustDisplay);
            // 
            // splitContainerCustDetails.Panel2
            // 
            this.splitContainerCustDetails.Panel2.AutoScroll = true;
            this.splitContainerCustDetails.Panel2.Controls.Add(this.tableLayoutPanelCustSearchCtrls);
            this.splitContainerCustDetails.Panel2.Controls.Add(this.tableLayoutPanelCustDetails);
            this.splitContainerCustDetails.Size = new System.Drawing.Size(1170, 702);
            this.splitContainerCustDetails.SplitterDistance = 235;
            this.splitContainerCustDetails.TabIndex = 17;
            // 
            // tableLayoutPanelCustDisplay
            // 
            this.tableLayoutPanelCustDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelCustDisplay.ColumnCount = 1;
            this.tableLayoutPanelCustDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCustDisplay.Controls.Add(this.btnRemoveCust, 0, 3);
            this.tableLayoutPanelCustDisplay.Controls.Add(this.listBoxCustomerList, 0, 0);
            this.tableLayoutPanelCustDisplay.Controls.Add(this.btnAddCust, 0, 1);
            this.tableLayoutPanelCustDisplay.Controls.Add(this.btnUpdateCustDetails, 0, 2);
            this.tableLayoutPanelCustDisplay.Location = new System.Drawing.Point(5, 6);
            this.tableLayoutPanelCustDisplay.Name = "tableLayoutPanelCustDisplay";
            this.tableLayoutPanelCustDisplay.RowCount = 5;
            this.tableLayoutPanelCustDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCustDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCustDisplay.Size = new System.Drawing.Size(227, 662);
            this.tableLayoutPanelCustDisplay.TabIndex = 0;
            // 
            // btnRemoveCust
            // 
            this.btnRemoveCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveCust.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCust.Image")));
            this.btnRemoveCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCust.Location = new System.Drawing.Point(3, 599);
            this.btnRemoveCust.Name = "btnRemoveCust";
            this.btnRemoveCust.Size = new System.Drawing.Size(221, 40);
            this.btnRemoveCust.TabIndex = 4;
            this.btnRemoveCust.Text = "Remove Customer";
            this.btnRemoveCust.UseVisualStyleBackColor = true;
            this.btnRemoveCust.Click += new System.EventHandler(this.btnRemoveCust_Click);
            // 
            // listBoxCustomerList
            // 
            this.listBoxCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCustomerList.FormattingEnabled = true;
            this.listBoxCustomerList.ItemHeight = 20;
            this.listBoxCustomerList.Location = new System.Drawing.Point(3, 3);
            this.listBoxCustomerList.Name = "listBoxCustomerList";
            this.listBoxCustomerList.Size = new System.Drawing.Size(221, 484);
            this.listBoxCustomerList.TabIndex = 1;
            this.listBoxCustomerList.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomerList_SelectedIndexChanged);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCust.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCust.Image")));
            this.btnAddCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCust.Location = new System.Drawing.Point(3, 507);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(221, 40);
            this.btnAddCust.TabIndex = 2;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnUpdateCustDetails
            // 
            this.btnUpdateCustDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateCustDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustDetails.Image")));
            this.btnUpdateCustDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCustDetails.Location = new System.Drawing.Point(3, 553);
            this.btnUpdateCustDetails.Name = "btnUpdateCustDetails";
            this.btnUpdateCustDetails.Size = new System.Drawing.Size(221, 40);
            this.btnUpdateCustDetails.TabIndex = 3;
            this.btnUpdateCustDetails.Text = "Update Details";
            this.btnUpdateCustDetails.UseVisualStyleBackColor = true;
            this.btnUpdateCustDetails.Click += new System.EventHandler(this.btnUpdateCustDetails_Click);
            // 
            // tableLayoutPanelCustSearchCtrls
            // 
            this.tableLayoutPanelCustSearchCtrls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCustSearchCtrls.ColumnCount = 2;
            this.tableLayoutPanelCustSearchCtrls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCustSearchCtrls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCustSearchCtrls.Controls.Add(this.lblCustDetailsSearchBy, 0, 0);
            this.tableLayoutPanelCustSearchCtrls.Controls.Add(this.comboBoxCustDetailsSearchBy, 1, 0);
            this.tableLayoutPanelCustSearchCtrls.Controls.Add(this.listBoxCustDetailsSearchResults, 1, 3);
            this.tableLayoutPanelCustSearchCtrls.Controls.Add(this.btnCustDetailsSearch, 1, 2);
            this.tableLayoutPanelCustSearchCtrls.Controls.Add(this.lblCustDetailsSearchKeywords, 0, 1);
            this.tableLayoutPanelCustSearchCtrls.Controls.Add(this.txtCustDetailsSearchKeywords, 1, 1);
            this.tableLayoutPanelCustSearchCtrls.Location = new System.Drawing.Point(666, 6);
            this.tableLayoutPanelCustSearchCtrls.Name = "tableLayoutPanelCustSearchCtrls";
            this.tableLayoutPanelCustSearchCtrls.RowCount = 3;
            this.tableLayoutPanelCustSearchCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustSearchCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustSearchCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustSearchCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustSearchCtrls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCustSearchCtrls.Size = new System.Drawing.Size(262, 649);
            this.tableLayoutPanelCustSearchCtrls.TabIndex = 31;
            // 
            // lblCustDetailsSearchBy
            // 
            this.lblCustDetailsSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustDetailsSearchBy.AutoSize = true;
            this.lblCustDetailsSearchBy.Location = new System.Drawing.Point(3, 7);
            this.lblCustDetailsSearchBy.Name = "lblCustDetailsSearchBy";
            this.lblCustDetailsSearchBy.Size = new System.Drawing.Size(84, 20);
            this.lblCustDetailsSearchBy.TabIndex = 22;
            this.lblCustDetailsSearchBy.Text = "Search by:";
            // 
            // comboBoxCustDetailsSearchBy
            // 
            this.comboBoxCustDetailsSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCustDetailsSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustDetailsSearchBy.FormattingEnabled = true;
            this.comboBoxCustDetailsSearchBy.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone 1",
            "Phone 2",
            "Mobile 1",
            "Mobile 2",
            "Email 1",
            "Email 2"});
            this.comboBoxCustDetailsSearchBy.Location = new System.Drawing.Point(93, 3);
            this.comboBoxCustDetailsSearchBy.Name = "comboBoxCustDetailsSearchBy";
            this.comboBoxCustDetailsSearchBy.Size = new System.Drawing.Size(166, 28);
            this.comboBoxCustDetailsSearchBy.TabIndex = 24;
            // 
            // listBoxCustDetailsSearchResults
            // 
            this.listBoxCustDetailsSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCustSearchCtrls.SetColumnSpan(this.listBoxCustDetailsSearchResults, 2);
            this.listBoxCustDetailsSearchResults.FormattingEnabled = true;
            this.listBoxCustDetailsSearchResults.ItemHeight = 20;
            this.listBoxCustDetailsSearchResults.Location = new System.Drawing.Point(3, 115);
            this.listBoxCustDetailsSearchResults.Name = "listBoxCustDetailsSearchResults";
            this.listBoxCustDetailsSearchResults.Size = new System.Drawing.Size(256, 524);
            this.listBoxCustDetailsSearchResults.TabIndex = 27;
            this.listBoxCustDetailsSearchResults.SelectedIndexChanged += new System.EventHandler(this.listBoxCustDetailsSearchResults_SelectedIndexChanged);
            // 
            // btnCustDetailsSearch
            // 
            this.btnCustDetailsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCustSearchCtrls.SetColumnSpan(this.btnCustDetailsSearch, 2);
            this.btnCustDetailsSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCustDetailsSearch.Image")));
            this.btnCustDetailsSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetailsSearch.Location = new System.Drawing.Point(3, 69);
            this.btnCustDetailsSearch.Name = "btnCustDetailsSearch";
            this.btnCustDetailsSearch.Size = new System.Drawing.Size(256, 40);
            this.btnCustDetailsSearch.TabIndex = 26;
            this.btnCustDetailsSearch.Text = "Search";
            this.btnCustDetailsSearch.UseVisualStyleBackColor = true;
            this.btnCustDetailsSearch.Click += new System.EventHandler(this.btnCustDetailsSearch_Click);
            // 
            // lblCustDetailsSearchKeywords
            // 
            this.lblCustDetailsSearchKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustDetailsSearchKeywords.AutoSize = true;
            this.lblCustDetailsSearchKeywords.Location = new System.Drawing.Point(3, 40);
            this.lblCustDetailsSearchKeywords.Name = "lblCustDetailsSearchKeywords";
            this.lblCustDetailsSearchKeywords.Size = new System.Drawing.Size(84, 20);
            this.lblCustDetailsSearchKeywords.TabIndex = 24;
            this.lblCustDetailsSearchKeywords.Text = "Keywords:";
            // 
            // txtCustDetailsSearchKeywords
            // 
            this.txtCustDetailsSearchKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustDetailsSearchKeywords.Location = new System.Drawing.Point(93, 37);
            this.txtCustDetailsSearchKeywords.Name = "txtCustDetailsSearchKeywords";
            this.txtCustDetailsSearchKeywords.Size = new System.Drawing.Size(166, 26);
            this.txtCustDetailsSearchKeywords.TabIndex = 25;
            // 
            // tableLayoutPanelCustDetails
            // 
            this.tableLayoutPanelCustDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelCustDetails.ColumnCount = 2;
            this.tableLayoutPanelCustDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanelCustDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCustDetails.Controls.Add(this.panelActionButtons, 0, 13);
            this.tableLayoutPanelCustDetails.Controls.Add(this.dateTimePickerCustDOB, 1, 11);
            this.tableLayoutPanelCustDetails.Controls.Add(this.comboBoxCustGender, 1, 2);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustRemarks, 1, 12);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustReamrks, 0, 12);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustShippingAddress, 1, 10);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustShippingAddress, 0, 10);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustGender, 0, 2);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustPhone1, 1, 3);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustName, 1, 1);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustDOB, 0, 11);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustID, 0, 0);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustEmail1, 0, 7);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustMobile2, 0, 6);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustPhone1, 0, 3);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustMobile1, 0, 5);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustPhone2, 0, 4);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustName, 0, 1);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustEmail2, 0, 8);
            this.tableLayoutPanelCustDetails.Controls.Add(this.lblCustAddress, 0, 9);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustID, 1, 0);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustPhone2, 1, 4);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustMobile1, 1, 5);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustMobile2, 1, 6);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustEmail1, 1, 7);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustEmail2, 1, 8);
            this.tableLayoutPanelCustDetails.Controls.Add(this.txtCustAddress, 1, 9);
            this.tableLayoutPanelCustDetails.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCustDetails.Name = "tableLayoutPanelCustDetails";
            this.tableLayoutPanelCustDetails.RowCount = 14;
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCustDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCustDetails.Size = new System.Drawing.Size(498, 652);
            this.tableLayoutPanelCustDetails.TabIndex = 0;
            // 
            // panelActionButtons
            // 
            this.panelActionButtons.AutoSize = true;
            this.tableLayoutPanelCustDetails.SetColumnSpan(this.panelActionButtons, 2);
            this.panelActionButtons.Controls.Add(this.btnCustDetailsPrint);
            this.panelActionButtons.Controls.Add(this.btnCustDetailsSave);
            this.panelActionButtons.Controls.Add(this.btnCustDetailsCancel);
            this.panelActionButtons.Controls.Add(this.btnCustDetailsClear);
            this.panelActionButtons.Controls.Add(this.btnCustDetailsClose);
            this.panelActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActionButtons.Location = new System.Drawing.Point(3, 601);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(492, 48);
            this.panelActionButtons.TabIndex = 50;
            // 
            // btnCustDetailsPrint
            // 
            this.btnCustDetailsPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnCustDetailsPrint.Image")));
            this.btnCustDetailsPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetailsPrint.Location = new System.Drawing.Point(124, 5);
            this.btnCustDetailsPrint.Name = "btnCustDetailsPrint";
            this.btnCustDetailsPrint.Size = new System.Drawing.Size(120, 40);
            this.btnCustDetailsPrint.TabIndex = 32;
            this.btnCustDetailsPrint.Text = "Print";
            this.btnCustDetailsPrint.UseVisualStyleBackColor = true;
            this.btnCustDetailsPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustDetailsSave
            // 
            this.btnCustDetailsSave.Enabled = false;
            this.btnCustDetailsSave.Image = ((System.Drawing.Image)(resources.GetObject("btnCustDetailsSave.Image")));
            this.btnCustDetailsSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetailsSave.Location = new System.Drawing.Point(372, 5);
            this.btnCustDetailsSave.Name = "btnCustDetailsSave";
            this.btnCustDetailsSave.Size = new System.Drawing.Size(120, 40);
            this.btnCustDetailsSave.TabIndex = 25;
            this.btnCustDetailsSave.Text = "Save";
            this.btnCustDetailsSave.UseVisualStyleBackColor = true;
            this.btnCustDetailsSave.Click += new System.EventHandler(this.btnCustDetailsSave_Click);
            // 
            // btnCustDetailsCancel
            // 
            this.btnCustDetailsCancel.Enabled = false;
            this.btnCustDetailsCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCustDetailsCancel.Image")));
            this.btnCustDetailsCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetailsCancel.Location = new System.Drawing.Point(124, 5);
            this.btnCustDetailsCancel.Name = "btnCustDetailsCancel";
            this.btnCustDetailsCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCustDetailsCancel.TabIndex = 23;
            this.btnCustDetailsCancel.Text = "Cancel";
            this.btnCustDetailsCancel.UseVisualStyleBackColor = true;
            this.btnCustDetailsCancel.Click += new System.EventHandler(this.btnCustDetailsCancel_Click);
            // 
            // btnCustDetailsClear
            // 
            this.btnCustDetailsClear.Enabled = false;
            this.btnCustDetailsClear.Image = ((System.Drawing.Image)(resources.GetObject("btnCustDetailsClear.Image")));
            this.btnCustDetailsClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetailsClear.Location = new System.Drawing.Point(248, 5);
            this.btnCustDetailsClear.Name = "btnCustDetailsClear";
            this.btnCustDetailsClear.Size = new System.Drawing.Size(120, 40);
            this.btnCustDetailsClear.TabIndex = 24;
            this.btnCustDetailsClear.Text = "Clear";
            this.btnCustDetailsClear.UseVisualStyleBackColor = true;
            this.btnCustDetailsClear.Click += new System.EventHandler(this.btnCustDetailsClear_Click);
            // 
            // btnCustDetailsClose
            // 
            this.btnCustDetailsClose.Image = ((System.Drawing.Image)(resources.GetObject("btnCustDetailsClose.Image")));
            this.btnCustDetailsClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustDetailsClose.Location = new System.Drawing.Point(0, 5);
            this.btnCustDetailsClose.Name = "btnCustDetailsClose";
            this.btnCustDetailsClose.Size = new System.Drawing.Size(120, 40);
            this.btnCustDetailsClose.TabIndex = 22;
            this.btnCustDetailsClose.Text = "Close";
            this.btnCustDetailsClose.UseVisualStyleBackColor = true;
            this.btnCustDetailsClose.Click += new System.EventHandler(this.btnCustDetailsClose_Click);
            // 
            // dateTimePickerCustDOB
            // 
            this.dateTimePickerCustDOB.Location = new System.Drawing.Point(129, 477);
            this.dateTimePickerCustDOB.Name = "dateTimePickerCustDOB";
            this.dateTimePickerCustDOB.Size = new System.Drawing.Size(205, 26);
            this.dateTimePickerCustDOB.TabIndex = 16;
            this.dateTimePickerCustDOB.Value = new System.DateTime(2016, 3, 4, 10, 35, 25, 0);
            // 
            // comboBoxCustGender
            // 
            this.comboBoxCustGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustGender.FormattingEnabled = true;
            this.comboBoxCustGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxCustGender.Location = new System.Drawing.Point(129, 67);
            this.comboBoxCustGender.Name = "comboBoxCustGender";
            this.comboBoxCustGender.Size = new System.Drawing.Size(124, 28);
            this.comboBoxCustGender.TabIndex = 7;
            // 
            // txtCustRemarks
            // 
            this.txtCustRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustRemarks.Location = new System.Drawing.Point(129, 509);
            this.txtCustRemarks.Multiline = true;
            this.txtCustRemarks.Name = "txtCustRemarks";
            this.txtCustRemarks.Size = new System.Drawing.Size(366, 86);
            this.txtCustRemarks.TabIndex = 17;
            // 
            // lblCustReamrks
            // 
            this.lblCustReamrks.AutoSize = true;
            this.lblCustReamrks.Location = new System.Drawing.Point(3, 506);
            this.lblCustReamrks.Name = "lblCustReamrks";
            this.lblCustReamrks.Size = new System.Drawing.Size(77, 20);
            this.lblCustReamrks.TabIndex = 46;
            this.lblCustReamrks.Text = "Remarks:";
            // 
            // txtCustShippingAddress
            // 
            this.txtCustShippingAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustShippingAddress.Location = new System.Drawing.Point(129, 385);
            this.txtCustShippingAddress.Multiline = true;
            this.txtCustShippingAddress.Name = "txtCustShippingAddress";
            this.txtCustShippingAddress.Size = new System.Drawing.Size(366, 86);
            this.txtCustShippingAddress.TabIndex = 15;
            // 
            // lblCustShippingAddress
            // 
            this.lblCustShippingAddress.AutoSize = true;
            this.lblCustShippingAddress.Location = new System.Drawing.Point(3, 382);
            this.lblCustShippingAddress.Name = "lblCustShippingAddress";
            this.lblCustShippingAddress.Size = new System.Drawing.Size(75, 40);
            this.lblCustShippingAddress.TabIndex = 44;
            this.lblCustShippingAddress.Text = "Shipping Address:";
            // 
            // lblCustGender
            // 
            this.lblCustGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustGender.AutoSize = true;
            this.lblCustGender.Location = new System.Drawing.Point(3, 71);
            this.lblCustGender.Name = "lblCustGender";
            this.lblCustGender.Size = new System.Drawing.Size(67, 20);
            this.lblCustGender.TabIndex = 38;
            this.lblCustGender.Text = "Gender:";
            // 
            // txtCustPhone1
            // 
            this.txtCustPhone1.Location = new System.Drawing.Point(129, 101);
            this.txtCustPhone1.Name = "txtCustPhone1";
            this.txtCustPhone1.Size = new System.Drawing.Size(205, 26);
            this.txtCustPhone1.TabIndex = 8;
            this.txtCustPhone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustPhone1_KeyPress);
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(129, 35);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(366, 26);
            this.txtCustName.TabIndex = 6;
            this.txtCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustName_KeyPress);
            // 
            // lblCustDOB
            // 
            this.lblCustDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustDOB.AutoSize = true;
            this.lblCustDOB.Location = new System.Drawing.Point(3, 480);
            this.lblCustDOB.Name = "lblCustDOB";
            this.lblCustDOB.Size = new System.Drawing.Size(103, 20);
            this.lblCustDOB.TabIndex = 27;
            this.lblCustDOB.Text = "Date of Birth:";
            // 
            // lblCustID
            // 
            this.lblCustID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(3, 6);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(30, 20);
            this.lblCustID.TabIndex = 18;
            this.lblCustID.Text = "ID:";
            // 
            // lblCustEmail1
            // 
            this.lblCustEmail1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustEmail1.AutoSize = true;
            this.lblCustEmail1.Location = new System.Drawing.Point(3, 232);
            this.lblCustEmail1.Name = "lblCustEmail1";
            this.lblCustEmail1.Size = new System.Drawing.Size(65, 20);
            this.lblCustEmail1.TabIndex = 24;
            this.lblCustEmail1.Text = "Email 1:";
            // 
            // lblCustMobile2
            // 
            this.lblCustMobile2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustMobile2.AutoSize = true;
            this.lblCustMobile2.Location = new System.Drawing.Point(3, 200);
            this.lblCustMobile2.Name = "lblCustMobile2";
            this.lblCustMobile2.Size = new System.Drawing.Size(72, 20);
            this.lblCustMobile2.TabIndex = 23;
            this.lblCustMobile2.Text = "Mobile 2:";
            // 
            // lblCustPhone1
            // 
            this.lblCustPhone1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustPhone1.AutoSize = true;
            this.lblCustPhone1.Location = new System.Drawing.Point(3, 104);
            this.lblCustPhone1.Name = "lblCustPhone1";
            this.lblCustPhone1.Size = new System.Drawing.Size(72, 20);
            this.lblCustPhone1.TabIndex = 20;
            this.lblCustPhone1.Text = "Phone 1:";
            // 
            // lblCustMobile1
            // 
            this.lblCustMobile1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustMobile1.AutoSize = true;
            this.lblCustMobile1.Location = new System.Drawing.Point(3, 168);
            this.lblCustMobile1.Name = "lblCustMobile1";
            this.lblCustMobile1.Size = new System.Drawing.Size(72, 20);
            this.lblCustMobile1.TabIndex = 22;
            this.lblCustMobile1.Text = "Mobile 1:";
            // 
            // lblCustPhone2
            // 
            this.lblCustPhone2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustPhone2.AutoSize = true;
            this.lblCustPhone2.Location = new System.Drawing.Point(3, 136);
            this.lblCustPhone2.Name = "lblCustPhone2";
            this.lblCustPhone2.Size = new System.Drawing.Size(72, 20);
            this.lblCustPhone2.TabIndex = 21;
            this.lblCustPhone2.Text = "Phone 2:";
            // 
            // lblCustName
            // 
            this.lblCustName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(3, 38);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(55, 20);
            this.lblCustName.TabIndex = 19;
            this.lblCustName.Text = "Name:";
            // 
            // lblCustEmail2
            // 
            this.lblCustEmail2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustEmail2.AutoSize = true;
            this.lblCustEmail2.Location = new System.Drawing.Point(3, 264);
            this.lblCustEmail2.Name = "lblCustEmail2";
            this.lblCustEmail2.Size = new System.Drawing.Size(65, 20);
            this.lblCustEmail2.TabIndex = 25;
            this.lblCustEmail2.Text = "Email 2:";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(3, 290);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(72, 20);
            this.lblCustAddress.TabIndex = 26;
            this.lblCustAddress.Text = "Address:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(129, 3);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(124, 26);
            this.txtCustID.TabIndex = 4;
            // 
            // txtCustPhone2
            // 
            this.txtCustPhone2.Location = new System.Drawing.Point(129, 133);
            this.txtCustPhone2.Name = "txtCustPhone2";
            this.txtCustPhone2.Size = new System.Drawing.Size(205, 26);
            this.txtCustPhone2.TabIndex = 9;
            this.txtCustPhone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustPhone2_KeyPress);
            // 
            // txtCustMobile1
            // 
            this.txtCustMobile1.Location = new System.Drawing.Point(129, 165);
            this.txtCustMobile1.Name = "txtCustMobile1";
            this.txtCustMobile1.Size = new System.Drawing.Size(205, 26);
            this.txtCustMobile1.TabIndex = 10;
            this.txtCustMobile1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustMobile1_KeyPress);
            // 
            // txtCustMobile2
            // 
            this.txtCustMobile2.Location = new System.Drawing.Point(129, 197);
            this.txtCustMobile2.Name = "txtCustMobile2";
            this.txtCustMobile2.Size = new System.Drawing.Size(205, 26);
            this.txtCustMobile2.TabIndex = 11;
            this.txtCustMobile2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustMobile2_KeyPress);
            // 
            // txtCustEmail1
            // 
            this.txtCustEmail1.Location = new System.Drawing.Point(129, 229);
            this.txtCustEmail1.Name = "txtCustEmail1";
            this.txtCustEmail1.Size = new System.Drawing.Size(366, 26);
            this.txtCustEmail1.TabIndex = 12;
            this.txtCustEmail1.Leave += new System.EventHandler(this.txtCustEmail1_Leave);
            // 
            // txtCustEmail2
            // 
            this.txtCustEmail2.Location = new System.Drawing.Point(129, 261);
            this.txtCustEmail2.Name = "txtCustEmail2";
            this.txtCustEmail2.Size = new System.Drawing.Size(366, 26);
            this.txtCustEmail2.TabIndex = 13;
            this.txtCustEmail2.Leave += new System.EventHandler(this.txtCustEmail2_Leave);
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustAddress.Location = new System.Drawing.Point(129, 293);
            this.txtCustAddress.Multiline = true;
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(366, 86);
            this.txtCustAddress.TabIndex = 14;
            // 
            // tabCtrlCustomer
            // 
            this.tabCtrlCustomer.Controls.Add(this.tabPageCustomerDetails);
            this.tabCtrlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlCustomer.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlCustomer.Name = "tabCtrlCustomer";
            this.tabCtrlCustomer.SelectedIndex = 0;
            this.tabCtrlCustomer.Size = new System.Drawing.Size(1184, 741);
            this.tabCtrlCustomer.TabIndex = 0;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.tabCtrlCustomer);
            this.DoubleBuffered = true;
            this.Name = "Customer";
            this.Text = "Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_FormClosed);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tabPageCustomerDetails.ResumeLayout(false);
            this.splitContainerCustDetails.Panel1.ResumeLayout(false);
            this.splitContainerCustDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustDetails)).EndInit();
            this.splitContainerCustDetails.ResumeLayout(false);
            this.tableLayoutPanelCustDisplay.ResumeLayout(false);
            this.tableLayoutPanelCustSearchCtrls.ResumeLayout(false);
            this.tableLayoutPanelCustSearchCtrls.PerformLayout();
            this.tableLayoutPanelCustDetails.ResumeLayout(false);
            this.tableLayoutPanelCustDetails.PerformLayout();
            this.panelActionButtons.ResumeLayout(false);
            this.tabCtrlCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageCustomerDetails;
        private System.Windows.Forms.SplitContainer splitContainerCustDetails;
        private System.Windows.Forms.Button btnRemoveCust;
        private System.Windows.Forms.Button btnUpdateCustDetails;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.ListBox listBoxCustomerList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustSearchCtrls;
        private System.Windows.Forms.Label lblCustDetailsSearchBy;
        private System.Windows.Forms.ComboBox comboBoxCustDetailsSearchBy;
        private System.Windows.Forms.ListBox listBoxCustDetailsSearchResults;
        private System.Windows.Forms.Button btnCustDetailsSearch;
        private System.Windows.Forms.Label lblCustDetailsSearchKeywords;
        private System.Windows.Forms.TextBox txtCustDetailsSearchKeywords;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustDetails;
        private System.Windows.Forms.TextBox txtCustRemarks;
        private System.Windows.Forms.Label lblCustReamrks;
        private System.Windows.Forms.TextBox txtCustShippingAddress;
        private System.Windows.Forms.Label lblCustShippingAddress;
        private System.Windows.Forms.Label lblCustGender;
        private System.Windows.Forms.TextBox txtCustPhone1;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustDOB;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustEmail1;
        private System.Windows.Forms.Label lblCustMobile2;
        private System.Windows.Forms.Label lblCustPhone1;
        private System.Windows.Forms.Label lblCustMobile1;
        private System.Windows.Forms.Label lblCustPhone2;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustEmail2;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtCustPhone2;
        private System.Windows.Forms.TextBox txtCustMobile1;
        private System.Windows.Forms.TextBox txtCustMobile2;
        private System.Windows.Forms.TextBox txtCustEmail1;
        private System.Windows.Forms.TextBox txtCustEmail2;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TabControl tabCtrlCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerCustDOB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustDisplay;
        private System.Windows.Forms.Panel panelActionButtons;
        private System.Windows.Forms.Button btnCustDetailsSave;
        private System.Windows.Forms.Button btnCustDetailsCancel;
        private System.Windows.Forms.Button btnCustDetailsClear;
        private System.Windows.Forms.Button btnCustDetailsClose;
        private System.Windows.Forms.Button btnCustDetailsPrint;

    }
}