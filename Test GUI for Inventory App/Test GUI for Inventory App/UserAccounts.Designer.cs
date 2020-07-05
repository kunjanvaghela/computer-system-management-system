namespace Test_GUI_for_Inventory_App
{
    partial class UserAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccounts));
            this.tableLayoutPanelUserAccDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnUpdateUserDetails = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.listBoxUserAccList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRecoveryEmail = new System.Windows.Forms.TextBox();
            this.lblRecoveryEmail = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panelActionButtons = new System.Windows.Forms.Panel();
            this.btnUserAccSave = new System.Windows.Forms.Button();
            this.btnUserAccCancel = new System.Windows.Forms.Button();
            this.btnUserAccClear = new System.Windows.Forms.Button();
            this.btnUserAccClose = new System.Windows.Forms.Button();
            this.checkBoxUserPrivilegeLtd = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelUserAccDisplay.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUserAccDisplay
            // 
            this.tableLayoutPanelUserAccDisplay.ColumnCount = 1;
            this.tableLayoutPanelUserAccDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserAccDisplay.Controls.Add(this.btnRemoveUser, 0, 3);
            this.tableLayoutPanelUserAccDisplay.Controls.Add(this.btnUpdateUserDetails, 0, 2);
            this.tableLayoutPanelUserAccDisplay.Controls.Add(this.btnAddUser, 0, 1);
            this.tableLayoutPanelUserAccDisplay.Controls.Add(this.listBoxUserAccList, 0, 0);
            this.tableLayoutPanelUserAccDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelUserAccDisplay.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelUserAccDisplay.Name = "tableLayoutPanelUserAccDisplay";
            this.tableLayoutPanelUserAccDisplay.RowCount = 5;
            this.tableLayoutPanelUserAccDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserAccDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelUserAccDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelUserAccDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelUserAccDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelUserAccDisplay.Size = new System.Drawing.Size(228, 414);
            this.tableLayoutPanelUserAccDisplay.TabIndex = 0;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveUser.Image")));
            this.btnRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUser.Location = new System.Drawing.Point(3, 356);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(221, 40);
            this.btnRemoveUser.TabIndex = 3;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnUpdateUserDetails
            // 
            this.btnUpdateUserDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUserDetails.Image")));
            this.btnUpdateUserDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUserDetails.Location = new System.Drawing.Point(3, 310);
            this.btnUpdateUserDetails.Name = "btnUpdateUserDetails";
            this.btnUpdateUserDetails.Size = new System.Drawing.Size(221, 40);
            this.btnUpdateUserDetails.TabIndex = 2;
            this.btnUpdateUserDetails.Text = "Update Details";
            this.btnUpdateUserDetails.UseVisualStyleBackColor = true;
            this.btnUpdateUserDetails.Click += new System.EventHandler(this.btnUpdateUserDetails_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(3, 264);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(221, 40);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // listBoxUserAccList
            // 
            this.listBoxUserAccList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUserAccList.FormattingEnabled = true;
            this.listBoxUserAccList.ItemHeight = 20;
            this.listBoxUserAccList.Location = new System.Drawing.Point(3, 3);
            this.listBoxUserAccList.Name = "listBoxUserAccList";
            this.listBoxUserAccList.Size = new System.Drawing.Size(222, 244);
            this.listBoxUserAccList.TabIndex = 0;
            this.listBoxUserAccList.SelectedIndexChanged += new System.EventHandler(this.listBoxUserAccList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.06186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.93814F));
            this.tableLayoutPanel1.Controls.Add(this.txtRecoveryEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRecoveryEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUserPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelActionButtons, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUserPrivilegeLtd, 1, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(246, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 411);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtRecoveryEmail
            // 
            this.txtRecoveryEmail.Location = new System.Drawing.Point(138, 67);
            this.txtRecoveryEmail.Name = "txtRecoveryEmail";
            this.txtRecoveryEmail.Size = new System.Drawing.Size(358, 26);
            this.txtRecoveryEmail.TabIndex = 5;
            this.txtRecoveryEmail.Leave += new System.EventHandler(this.txtRecoveryEmail_Leave);
            // 
            // lblRecoveryEmail
            // 
            this.lblRecoveryEmail.AutoSize = true;
            this.lblRecoveryEmail.Location = new System.Drawing.Point(3, 64);
            this.lblRecoveryEmail.Name = "lblRecoveryEmail";
            this.lblRecoveryEmail.Size = new System.Drawing.Size(122, 20);
            this.lblRecoveryEmail.TabIndex = 4;
            this.lblRecoveryEmail.Text = "Recovery Email:";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(138, 35);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(358, 26);
            this.txtUserPassword.TabIndex = 3;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(3, 32);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(82, 20);
            this.lblUserPassword.TabIndex = 2;
            this.lblUserPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(3, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(138, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(358, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // panelActionButtons
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelActionButtons, 2);
            this.panelActionButtons.Controls.Add(this.btnUserAccSave);
            this.panelActionButtons.Controls.Add(this.btnUserAccCancel);
            this.panelActionButtons.Controls.Add(this.btnUserAccClear);
            this.panelActionButtons.Controls.Add(this.btnUserAccClose);
            this.panelActionButtons.Location = new System.Drawing.Point(3, 129);
            this.panelActionButtons.Name = "panelActionButtons";
            this.panelActionButtons.Size = new System.Drawing.Size(495, 48);
            this.panelActionButtons.TabIndex = 6;
            // 
            // btnUserAccSave
            // 
            this.btnUserAccSave.Enabled = false;
            this.btnUserAccSave.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccSave.Image")));
            this.btnUserAccSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAccSave.Location = new System.Drawing.Point(373, 3);
            this.btnUserAccSave.Name = "btnUserAccSave";
            this.btnUserAccSave.Size = new System.Drawing.Size(120, 40);
            this.btnUserAccSave.TabIndex = 29;
            this.btnUserAccSave.Text = "Save";
            this.btnUserAccSave.UseVisualStyleBackColor = true;
            this.btnUserAccSave.Click += new System.EventHandler(this.btnUserAccSave_Click);
            // 
            // btnUserAccCancel
            // 
            this.btnUserAccCancel.Enabled = false;
            this.btnUserAccCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccCancel.Image")));
            this.btnUserAccCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAccCancel.Location = new System.Drawing.Point(125, 3);
            this.btnUserAccCancel.Name = "btnUserAccCancel";
            this.btnUserAccCancel.Size = new System.Drawing.Size(120, 40);
            this.btnUserAccCancel.TabIndex = 27;
            this.btnUserAccCancel.Text = "Cancel";
            this.btnUserAccCancel.UseVisualStyleBackColor = true;
            this.btnUserAccCancel.Click += new System.EventHandler(this.btnUserAccCancel_Click);
            // 
            // btnUserAccClear
            // 
            this.btnUserAccClear.Enabled = false;
            this.btnUserAccClear.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccClear.Image")));
            this.btnUserAccClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAccClear.Location = new System.Drawing.Point(249, 3);
            this.btnUserAccClear.Name = "btnUserAccClear";
            this.btnUserAccClear.Size = new System.Drawing.Size(120, 40);
            this.btnUserAccClear.TabIndex = 28;
            this.btnUserAccClear.Text = "Clear";
            this.btnUserAccClear.UseVisualStyleBackColor = true;
            this.btnUserAccClear.Click += new System.EventHandler(this.btnUserAccClear_Click);
            // 
            // btnUserAccClose
            // 
            this.btnUserAccClose.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccClose.Image")));
            this.btnUserAccClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserAccClose.Location = new System.Drawing.Point(1, 3);
            this.btnUserAccClose.Name = "btnUserAccClose";
            this.btnUserAccClose.Size = new System.Drawing.Size(120, 40);
            this.btnUserAccClose.TabIndex = 26;
            this.btnUserAccClose.Text = "Close";
            this.btnUserAccClose.UseVisualStyleBackColor = true;
            this.btnUserAccClose.Click += new System.EventHandler(this.btnUserAccClose_Click);
            // 
            // checkBoxUserPrivilegeLtd
            // 
            this.checkBoxUserPrivilegeLtd.AutoSize = true;
            this.checkBoxUserPrivilegeLtd.Enabled = false;
            this.checkBoxUserPrivilegeLtd.Location = new System.Drawing.Point(138, 99);
            this.checkBoxUserPrivilegeLtd.Name = "checkBoxUserPrivilegeLtd";
            this.checkBoxUserPrivilegeLtd.Size = new System.Drawing.Size(236, 24);
            this.checkBoxUserPrivilegeLtd.TabIndex = 7;
            this.checkBoxUserPrivilegeLtd.Text = "Limit Access to Inventory only";
            this.checkBoxUserPrivilegeLtd.UseVisualStyleBackColor = true;
            // 
            // UserAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelUserAccDisplay);
            this.Name = "UserAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Accounts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserAccounts_FormClosed);
            this.Load += new System.EventHandler(this.UserAccounts_Load);
            this.tableLayoutPanelUserAccDisplay.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserAccDisplay;
        private System.Windows.Forms.ListBox listBoxUserAccList;
        private System.Windows.Forms.Button btnUpdateUserDetails;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblRecoveryEmail;
        private System.Windows.Forms.TextBox txtRecoveryEmail;
        private System.Windows.Forms.Panel panelActionButtons;
        private System.Windows.Forms.Button btnUserAccSave;
        private System.Windows.Forms.Button btnUserAccCancel;
        private System.Windows.Forms.Button btnUserAccClear;
        private System.Windows.Forms.Button btnUserAccClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox checkBoxUserPrivilegeLtd;
    }
}