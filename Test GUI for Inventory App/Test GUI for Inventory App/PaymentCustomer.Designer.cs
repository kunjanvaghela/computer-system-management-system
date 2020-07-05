namespace Test_GUI_for_Inventory_App
{
    partial class PaymentCustomer
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
            this.lblBillID = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.lblCustInvoiceNo = new System.Windows.Forms.Label();
            this.txtCustInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboPaymentType = new System.Windows.Forms.ComboBox();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.txtPayNow = new System.Windows.Forms.TextBox();
            this.lblPayNow = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Location = new System.Drawing.Point(3, 0);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(37, 13);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "Bill ID:";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(216, 3);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(100, 20);
            this.txtBillID.TabIndex = 1;
            // 
            // lblCustInvoiceNo
            // 
            this.lblCustInvoiceNo.AutoSize = true;
            this.lblCustInvoiceNo.Location = new System.Drawing.Point(3, 35);
            this.lblCustInvoiceNo.Name = "lblCustInvoiceNo";
            this.lblCustInvoiceNo.Size = new System.Drawing.Size(62, 13);
            this.lblCustInvoiceNo.TabIndex = 2;
            this.lblCustInvoiceNo.Text = "Invoice No:";
            // 
            // txtCustInvoiceNo
            // 
            this.txtCustInvoiceNo.Location = new System.Drawing.Point(216, 38);
            this.txtCustInvoiceNo.Name = "txtCustInvoiceNo";
            this.txtCustInvoiceNo.ReadOnly = true;
            this.txtCustInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.txtCustInvoiceNo.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(3, 70);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(33, 13);
            this.txtDate.TabIndex = 4;
            this.txtDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(3, 105);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(78, 13);
            this.lblPaymentType.TabIndex = 6;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Location = new System.Drawing.Point(3, 175);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(73, 13);
            this.lblPaidAmount.TabIndex = 8;
            this.lblPaidAmount.Text = "Paid Amount: ";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(216, 178);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.Size = new System.Drawing.Size(100, 20);
            this.txtPaidAmount.TabIndex = 9;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(216, 213);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 10;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(3, 210);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(73, 13);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBillID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBillID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustInvoiceNo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustInvoiceNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboPaymentType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddPayment, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalAmount, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalAmount, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPaidAmount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPaidAmount, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPayNow, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPayNow, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 285);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // comboPaymentType
            // 
            this.comboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaymentType.FormattingEnabled = true;
            this.comboPaymentType.Items.AddRange(new object[] {
            "Cheque",
            "Cash"});
            this.comboPaymentType.Location = new System.Drawing.Point(216, 108);
            this.comboPaymentType.Name = "comboPaymentType";
            this.comboPaymentType.Size = new System.Drawing.Size(121, 21);
            this.comboPaymentType.TabIndex = 13;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(216, 248);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(131, 23);
            this.btnAddPayment.TabIndex = 12;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // txtPayNow
            // 
            this.txtPayNow.Location = new System.Drawing.Point(216, 143);
            this.txtPayNow.Name = "txtPayNow";
            this.txtPayNow.Size = new System.Drawing.Size(100, 20);
            this.txtPayNow.TabIndex = 14;
            this.txtPayNow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayNow_KeyPress);
            // 
            // lblPayNow
            // 
            this.lblPayNow.AutoSize = true;
            this.lblPayNow.Location = new System.Drawing.Point(3, 140);
            this.lblPayNow.Name = "lblPayNow";
            this.lblPayNow.Size = new System.Drawing.Size(53, 13);
            this.lblPayNow.TabIndex = 15;
            this.lblPayNow.Text = "Pay Now:";
            // 
            // PaymentCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaymentCustomer";
            this.Text = "PaymentCustomer";
            this.Load += new System.EventHandler(this.PaymentCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label lblCustInvoiceNo;
        private System.Windows.Forms.TextBox txtCustInvoiceNo;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.ComboBox comboPaymentType;
        private System.Windows.Forms.TextBox txtPayNow;
        private System.Windows.Forms.Label lblPayNow;
    }
}