using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_GUI_for_Inventory_App
{
    public partial class MainForm : Form
    {
        LoginForm lf = new LoginForm();
        public MainForm()
        {
            InitializeComponent();            
        }      

        private void Form1_Load(object sender, EventArgs e)
        {            
            lblCurrDate.Text = "Date: " + DateTime.Now.ToShortDateString();
                            
            lf.Show();
            mainMenuStrip.Enabled = false;
            lf.MdiParent = this;
            mainMenubtnLogout.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCurrTime.Start();
            this.lblCurrTime.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            //string lbl = lf.access;

            if (lf.Visible == false && lf.flag == 1)
            {
                if (lf.privilege == "Y")
                {
                    mainMenuStrip.Enabled = true;
                    mainMenubtnLogin.Visible = false;
                    mainMenubtnLogout.Visible = true;
                    mainMenubtnLogout.BringToFront();
                }

                else
                {
                    mainMenuStrip.Enabled = true;
                    InventorytoolStripMenuItem1.Enabled = true;
                    accountsToolStripMenuItem.Enabled = false;
                    payrollToolStripMenuItem.Enabled = false;
                    billingToolStripMenuItem.Enabled = false;
                    //reportToolStripMenuItem.Enabled = false;
                    customersToolStripMenuItem.Enabled = false;
                    suppliersToolStripMenuItem.Enabled = false;

                    mainMenubtnLogin.Visible = false;
                    mainMenubtnLogout.Visible = true;
                    mainMenubtnLogout.BringToFront();
                }               
            }
            else
            {
                mainMenuStrip.Enabled = false;
            }
        }

        private void mainMenubtnLogin_Click(object sender, EventArgs e)
        {
            Application.Restart();         
        }

        private void mainMenubtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Confirm Action", MessageBoxButtons.YesNo);

            if(result==DialogResult.Yes)
            {
                Application.Restart();
            }           
        }

        private void mainMenubtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Quit?", "Confirm Action", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void InventorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.instance.MdiParent = this;
            inventory.instance.Show();
            inventory.instance.WindowState = FormWindowState.Maximized;
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.instance.MdiParent = this;
            supplier.instance.Show();
            supplier.instance.WindowState = FormWindowState.Maximized;
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Billing bill = new Customer_Billing();
            bill.instance.MdiParent = this;
            bill.instance.Show();
            bill.instance.WindowState = FormWindowState.Maximized;                        
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.instance.MdiParent = this;
            customer.instance.Show();
            customer.instance.WindowState = FormWindowState.Maximized;
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.instance.MdiParent = this;
            payroll.instance.Show();
            payroll.instance.WindowState = FormWindowState.Maximized;
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccounts useraccount = new UserAccounts();
            useraccount.instance.MdiParent = this;
            useraccount.instance.Show();
            useraccount.instance.WindowState = FormWindowState.Maximized;
        }      
    }
}
