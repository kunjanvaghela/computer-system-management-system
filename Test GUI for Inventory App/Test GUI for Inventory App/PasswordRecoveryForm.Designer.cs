namespace Test_GUI_for_Inventory_App
{
    partial class PasswordRecoveryForm
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
            this.lblRecoveryEmail = new System.Windows.Forms.Label();
            this.txtRecoveryEmail = new System.Windows.Forms.TextBox();
            this.lblRecoveryInstructions = new System.Windows.Forms.Label();
            this.btnSendPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecoveryEmail
            // 
            this.lblRecoveryEmail.AutoSize = true;
            this.lblRecoveryEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoveryEmail.Location = new System.Drawing.Point(12, 105);
            this.lblRecoveryEmail.Name = "lblRecoveryEmail";
            this.lblRecoveryEmail.Size = new System.Drawing.Size(122, 20);
            this.lblRecoveryEmail.TabIndex = 0;
            this.lblRecoveryEmail.Text = "Recovery Email:";
            // 
            // txtRecoveryEmail
            // 
            this.txtRecoveryEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecoveryEmail.Location = new System.Drawing.Point(140, 102);
            this.txtRecoveryEmail.Name = "txtRecoveryEmail";
            this.txtRecoveryEmail.Size = new System.Drawing.Size(352, 26);
            this.txtRecoveryEmail.TabIndex = 1;
            // 
            // lblRecoveryInstructions
            // 
            this.lblRecoveryInstructions.AutoSize = true;
            this.lblRecoveryInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoveryInstructions.Location = new System.Drawing.Point(12, 18);
            this.lblRecoveryInstructions.Name = "lblRecoveryInstructions";
            this.lblRecoveryInstructions.Size = new System.Drawing.Size(491, 40);
            this.lblRecoveryInstructions.TabIndex = 2;
            this.lblRecoveryInstructions.Text = "Please specify the email id corresponding to the username in the box\r\nbelow on wh" +
    "ich the password will be sent.";
            // 
            // btnSendPassword
            // 
            this.btnSendPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPassword.Location = new System.Drawing.Point(395, 134);
            this.btnSendPassword.Name = "btnSendPassword";
            this.btnSendPassword.Size = new System.Drawing.Size(97, 31);
            this.btnSendPassword.TabIndex = 3;
            this.btnSendPassword.Text = "Send";
            this.btnSendPassword.UseVisualStyleBackColor = true;
            this.btnSendPassword.Click += new System.EventHandler(this.btnSendPassword_Click);
            // 
            // PasswordRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 183);
            this.Controls.Add(this.btnSendPassword);
            this.Controls.Add(this.lblRecoveryInstructions);
            this.Controls.Add(this.txtRecoveryEmail);
            this.Controls.Add(this.lblRecoveryEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordRecoveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.Load += new System.EventHandler(this.PasswordRecoveryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecoveryEmail;
        private System.Windows.Forms.TextBox txtRecoveryEmail;
        private System.Windows.Forms.Label lblRecoveryInstructions;
        private System.Windows.Forms.Button btnSendPassword;
    }
}