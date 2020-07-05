using MySql.Data.MySqlClient;
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
    public partial class PaymentCustomer : Form
    {
        String MyConnectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public PaymentCustomer()
        {
            InitializeComponent();
            formLoad();
        }

        private void formLoad()
        {
            txtBillID.Text = Test_GUI_for_Inventory_App.Customer_Billing.BillId;
            invoiceGeneration();
            totalRetrieval();
        }

        private void invoiceGeneration()
        {
            String invoice = "", finalInvoice = "";
            int ordNo = 1;
            if (txtBillID.Text != "")
            {
                connectingCust_Payment();
                try
                {
                    String stm = "SELECT cust_invoice_no from payment_cust where cust_bill_id = '" + txtBillID.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            invoice = rdr.GetString(0);
                            int initialIndex = txtBillID.Text.Length + 1;
                            string t = invoice.Substring(initialIndex, 4);
                            ordNo = int.Parse(t) + 1;
                        }
                        finalInvoice = txtBillID.Text + "/" + ordNo.ToString("D4");
                    }
                    else
                    {
                        finalInvoice = txtBillID.Text + "/0001";
                    }
                    txtCustInvoiceNo.Text = finalInvoice;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        rdr.Close();
                        con.Close();
                    }
                }
            }
        }

        private void totalRetrieval()
        {
            connectingCust_Payment();
            try
            {
                String stm = "SELECT total_amount,paid_amount from cust_bill where cust_bill_id = '" + txtBillID.Text + "';";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtTotalAmount.Text = rdr.GetString(0);
                    txtPaidAmount.Text = rdr.GetString(1);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    rdr.Close();
                    con.Close();
                }
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                connectingCust_Payment();
                String pay_type = comboPaymentType.SelectedItem.ToString();
                int paid_Amount = Int32.Parse(txtPaidAmount.Text);
                int pay_now = Int32.Parse(txtPayNow.Text);
                int total_amount = Int32.Parse(txtTotalAmount.Text);
                if ((paid_Amount + pay_now) <= total_amount)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT into payment_cust values(@c_i_n,@date,@c_b_i,@payment_type,@paid_amount);";
                    cmd.Parameters.AddWithValue("@c_i_n", txtCustInvoiceNo.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@c_b_i", txtBillID.Text);
                    cmd.Parameters.AddWithValue("@payment_type", pay_type);
                    cmd.Parameters.AddWithValue("@paid_amount", pay_now);
                    cmd.ExecuteNonQuery();

                    cmd = con.CreateCommand();
                    cmd.CommandText = "UPDATE cust_bill SET paid_amount=@pa where cust_bill_id = @c_b_i;";
                    cmd.Parameters.AddWithValue("@pa", (paid_Amount + pay_now));
                    cmd.Parameters.AddWithValue("@c_b_i", txtBillID.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Added");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pay less then total payment");
                    txtPayNow.Text = "";
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    rdr.Close();
                    con.Close();
                }
            }
        }

        public void connectingCust_Payment()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        private void txtPayNow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void PaymentCustomer_Load(object sender, EventArgs e)
        {

        }

    }
}
