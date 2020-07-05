namespace Test_GUI_for_Inventory_App
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCurrTime = new System.Windows.Forms.Label();
            this.timerCurrTime = new System.Windows.Forms.Timer(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.InventorytoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrDate = new System.Windows.Forms.Label();
            this.mainMenubtnLogin = new System.Windows.Forms.Button();
            this.mainMenubtnLogout = new System.Windows.Forms.Button();
            this.mainMenubtnExit = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrTime
            // 
            this.lblCurrTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrTime.AutoSize = true;
            this.lblCurrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrTime.Location = new System.Drawing.Point(1160, 9);
            this.lblCurrTime.Name = "lblCurrTime";
            this.lblCurrTime.Size = new System.Drawing.Size(113, 20);
            this.lblCurrTime.TabIndex = 1;
            this.lblCurrTime.Text = "Time: 10:00:00";
            // 
            // timerCurrTime
            // 
            this.timerCurrTime.Enabled = true;
            this.timerCurrTime.Interval = 1000;
            this.timerCurrTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InventorytoolStripMenuItem1,
            this.suppliersToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.accountsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1276, 40);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // InventorytoolStripMenuItem1
            // 
            this.InventorytoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("InventorytoolStripMenuItem1.Image")));
            this.InventorytoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InventorytoolStripMenuItem1.Name = "InventorytoolStripMenuItem1";
            this.InventorytoolStripMenuItem1.Size = new System.Drawing.Size(101, 36);
            this.InventorytoolStripMenuItem1.Text = "Inventory";
            this.InventorytoolStripMenuItem1.Click += new System.EventHandler(this.InventorytoolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliersToolStripMenuItem.Image")));
            this.suppliersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("billingToolStripMenuItem.Image")));
            this.billingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customersToolStripMenuItem.Image")));
            this.customersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(108, 36);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("payrollToolStripMenuItem.Image")));
            this.payrollToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(87, 36);
            this.payrollToolStripMenuItem.Text = "Payroll";
            this.payrollToolStripMenuItem.Click += new System.EventHandler(this.payrollToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountsToolStripMenuItem.Image")));
            this.accountsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.accountsToolStripMenuItem.Text = "Accounts";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // lblCurrDate
            // 
            this.lblCurrDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrDate.AutoSize = true;
            this.lblCurrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrDate.Location = new System.Drawing.Point(1028, 9);
            this.lblCurrDate.Name = "lblCurrDate";
            this.lblCurrDate.Size = new System.Drawing.Size(132, 20);
            this.lblCurrDate.TabIndex = 3;
            this.lblCurrDate.Text = "Date: 11/12/2015";
            // 
            // mainMenubtnLogin
            // 
            this.mainMenubtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenubtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenubtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("mainMenubtnLogin.Image")));
            this.mainMenubtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainMenubtnLogin.Location = new System.Drawing.Point(869, 2);
            this.mainMenubtnLogin.Name = "mainMenubtnLogin";
            this.mainMenubtnLogin.Size = new System.Drawing.Size(86, 36);
            this.mainMenubtnLogin.TabIndex = 5;
            this.mainMenubtnLogin.Text = "Login";
            this.mainMenubtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainMenubtnLogin.UseVisualStyleBackColor = true;
            this.mainMenubtnLogin.Click += new System.EventHandler(this.mainMenubtnLogin_Click);
            // 
            // mainMenubtnLogout
            // 
            this.mainMenubtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenubtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenubtnLogout.Location = new System.Drawing.Point(869, 2);
            this.mainMenubtnLogout.Name = "mainMenubtnLogout";
            this.mainMenubtnLogout.Size = new System.Drawing.Size(86, 36);
            this.mainMenubtnLogout.TabIndex = 6;
            this.mainMenubtnLogout.Text = "Logout";
            this.mainMenubtnLogout.UseVisualStyleBackColor = true;
            this.mainMenubtnLogout.Click += new System.EventHandler(this.mainMenubtnLogout_Click);
            // 
            // mainMenubtnExit
            // 
            this.mainMenubtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenubtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenubtnExit.Image = ((System.Drawing.Image)(resources.GetObject("mainMenubtnExit.Image")));
            this.mainMenubtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainMenubtnExit.Location = new System.Drawing.Point(961, 2);
            this.mainMenubtnExit.Name = "mainMenubtnExit";
            this.mainMenubtnExit.Size = new System.Drawing.Size(64, 36);
            this.mainMenubtnExit.TabIndex = 7;
            this.mainMenubtnExit.Text = "Exit";
            this.mainMenubtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainMenubtnExit.UseVisualStyleBackColor = true;
            this.mainMenubtnExit.Click += new System.EventHandler(this.mainMenubtnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 496);
            this.Controls.Add(this.mainMenubtnExit);
            this.Controls.Add(this.mainMenubtnLogin);
            this.Controls.Add(this.lblCurrDate);
            this.Controls.Add(this.lblCurrTime);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainMenubtnLogout);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Corporate Infosystems (India) Pvt. Ltd.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrTime;
        private System.Windows.Forms.Timer timerCurrTime;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InventorytoolStripMenuItem1;
        public System.Windows.Forms.Label lblCurrDate;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.Button mainMenubtnLogin;
        private System.Windows.Forms.Button mainMenubtnLogout;
        private System.Windows.Forms.Button mainMenubtnExit;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
    }
}

