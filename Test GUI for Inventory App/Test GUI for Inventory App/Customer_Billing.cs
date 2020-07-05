using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Test_GUI_for_Inventory_App
{
    public partial class Customer_Billing : Form
    {
        public static String BillId;
        String MyConnectionString, stm;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        String flag;
        int searchLevel;

        private static Customer_Billing _instance;

        public Customer_Billing()
        {
            InitializeComponent();
        }

        private void Customer_Billing_Load(object sender, EventArgs e)
        {
            reloadComboType();
            reloadListBoxCustList();
            reloadListBoxBills();
            flag = "";
            searchLevel = 0;
        }

        public Customer_Billing instance
        {
            get
            {
                if (Customer_Billing._instance == null)
                {
                    Customer_Billing._instance = new Customer_Billing();
                }
                return Customer_Billing._instance;
            }
        }

        private void Customer_Billing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Customer_Billing._instance = null;
        }

        private void tableLayoutPanelBillingDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reloadComboType()
        {
            comboBoxBillingOrderType.Items.Clear();
            connectingCust_Billing();
            String stm = "Select DISTINCT type from stock";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBoxBillingOrderType.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception)
            { }
            finally
            {
                comboBoxBillingOrderType.SelectedIndex = -1;
                comboBoxBillingOrderType.Text = "---Type---";
                comboBoxBillingOrderCategory.SelectedIndex = -1;
                comboBoxBillingOrderCategory.Text = "---Category---";
                comboBoxBillingOrderBrand.SelectedIndex = -1;
                comboBoxBillingOrderBrand.Text = "---Brand---";
                rdr.Close();
                con.Close();
            }
        }

        private void reloadListBoxCustList()
        {
            listBoxBillingCustList.Items.Clear();
            connectingCust_Billing();
            String stm = "SELECT cust_id from cust_details";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBoxBillingCustList.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception)
            { }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        public void connectingCust_Billing()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        private void comboBoxBillingOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectingCust_Billing();
            comboBoxBillingOrderCategory.Items.Clear();
            comboBoxBillingOrderBrand.Items.Clear();
            String stm = "Select DISTINCT category from stock where type = '" + (String)comboBoxBillingOrderType.SelectedItem + "';";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBoxBillingOrderCategory.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void comboBoxBillingOrderCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectingCust_Billing();
            String stm = "Select DISTINCT brand from stock where type = '" + (String)comboBoxBillingOrderType.SelectedItem + "' and category ='" + comboBoxBillingOrderCategory.SelectedItem + "';";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBoxBillingOrderBrand.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void comboBoxBillingOrderBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectingCust_Billing();
            listBoxBillingOrderInventory.Items.Clear();
            String stm = "Select model_id from stock where type = '" + (String)comboBoxBillingOrderType.SelectedItem + "' and category ='" + comboBoxBillingOrderCategory.SelectedItem + "' and brand = '" + comboBoxBillingOrderBrand.SelectedItem + "';";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBoxBillingOrderInventory.Items.Add(rdr.GetString(0));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                rdr.Close();
                con.Close();
            }
        }

        private void listBoxBillingOrderInventory_DoubleClick(object sender, EventArgs e)
        {
            for(int i=0; i<dataGridView1.RowCount;i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.Equals(listBoxBillingOrderInventory.SelectedItem.ToString()))
                    {
                        return;
                    }
                }
            }
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = listBoxBillingOrderInventory.SelectedItem.ToString();
            row.Cells[1].Value = comboBoxBillingOrderBrand.SelectedItem.ToString();
            row.Cells[2].Value = comboBoxBillingOrderCategory.SelectedItem;
            dataGridView1.Rows.Add(row);
        }

        private void listBoxBillingCustList_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxBillingCustList.SelectedIndex > -1 && flag.Equals("add"))
            {
                emptyAll();
                fillCustomerDetails();
                orderIDGeneration();
                //dataGridView1.ReadOnly = true;
            }
        }

        private void emptyAll()
        {
            txtBillingCustName.Text = "";
            txtBillingShippingAddress.Text = "";
            txtCustMobile.Text = "";
            txtCustPhone.Text = "";
            dataGridView1.Rows.Clear();
            txtBillingTax.Clear();
            txtBillingSubTotal.Clear();
            txtBillingTotal.Clear();
        }

        private void fillCustomerDetails()
        {
            try
            {
                connectingCust_Billing();
                stm = "SELECT * from cust_details where cust_id = '" + listBoxBillingCustList.SelectedItem.ToString() + "';";
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtCustID.Text = rdr.GetString(0);
                    txtBillingCustName.Text = rdr.GetString(1);
                    if (rdr.GetString(3) != null && rdr.GetString(3) != "")
                    {
                        txtBillingShippingAddress.Text = rdr.GetString(3);
                    }
                    else if (rdr.GetString(2) != null && rdr.GetString(2) != "")
                    {
                        txtBillingShippingAddress.Text = rdr.GetString(2);
                    }
                    else
                    {
                        MessageBox.Show("Shipping Address is empty.\nPlease first fill that in Add Customer form.");
                    }
                    if (rdr.GetString(4) != null && rdr.GetString(4) != "")
                    {
                        txtCustPhone.Text = rdr.GetString(4);
                    }
                    else if (rdr.GetString(5) != null && rdr.GetString(5) != "")
                    {
                        txtCustPhone.Text = rdr.GetString(5);
                    }
                    if (rdr.GetString(6) != null && rdr.GetString(6) != "")
                    {
                        txtCustMobile.Text = rdr.GetString(6);
                    }
                    else if (rdr.GetString(7) != null && rdr.GetString(7) != "")
                    {
                        txtCustMobile.Text = rdr.GetString(7);
                    }
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
                    con.Close();
                }
            }
        }

        private void populatingForm()
        {
            try
            {
                emptyAll();
                connectingCust_Billing();
                int sub_total = 0;
                int quantity = 0;

                String stm = "SELECT cust_bill_id from cust_bill where sale_order_id='" + txtOrderID.Text + "';";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtBillID.Text = rdr.GetString(0);
                }
                rdr.Close();
                stm = "SELECT a.amount,a.quantity,a.model_id,b.category,b.brand from sale_item a,stock b where a.model_id=b.model_id and a.sale_order_id ='" + txtOrderID.Text + "';";
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = rdr.GetString(2);
                    row.Cells[1].Value = rdr.GetString(4);
                    row.Cells[2].Value = rdr.GetString(3);
                    row.Cells[3].Value = rdr.GetString(0);
                    row.Cells[4].Value = rdr.GetString(1);
                    row.Cells[5].Value = Int32.Parse(rdr.GetString(0)) * Int32.Parse(rdr.GetString(1));
                    sub_total += Int32.Parse(rdr.GetString(0)) * Int32.Parse(rdr.GetString(1));
                    dataGridView1.Rows.Add(row);
                    quantity += Int32.Parse(rdr.GetString(1));
                }
                rdr.Close();
                txtBillingQuantity.Text = quantity.ToString();
                stm = "SELECT total_amount from cust_bill where cust_bill_id = '" + txtBillID.Text + "';";
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtBillingTotal.Text = rdr.GetString(0);
                }
                rdr.Close();
                stm = "SELECT cust_id,date from sale_order where sale_order_id = '" + txtOrderID.Text + "';";
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                txtBillingSubTotal.Text = sub_total.ToString();
                while (rdr.Read())
                {
                    if (listBoxBillingCustList.Items.Contains(rdr.GetString(0)))
                    {
                        listBoxBillingCustList.SelectedIndex = listBoxBillingCustList.Items.IndexOf(rdr.GetString(0));
                        dateTimePicker1.Value = rdr.GetDateTime(1);
                        fillCustomerDetails();
                        return;
                    }
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
                reloadListBoxPaymentsDone();
            }
        }

        private void orderIDGeneration()
        {
            String ordID = "", finalOrdID = "";
            int ordNo = 1;
            if (txtCustID.Text != "")
            {
                connectingCust_Billing();
                try
                {
                    String stm = "SELECT sale_order_id from sale_order where cust_id = '" + txtCustID.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            ordID = rdr.GetString(0);
                            int initialIndex = txtCustID.Text.Length + 1;
                            string t = ordID.Substring(initialIndex, 4);
                            ordNo = int.Parse(t) + 1;
                        }
                        finalOrdID = txtCustID.Text + "/" + ordNo.ToString("D4");
                    }
                    else
                    {
                        finalOrdID = txtCustID.Text + "/0001";
                    }
                    txtOrderID.Text = finalOrdID;
                    txtBillID.Text = finalOrdID;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            checkPriceQuantityTax();
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[rows].Cells[3] != null && dataGridView1.Rows[rows].Cells[4] != null && dataGridView1.Rows[rows].Cells[0] != null)
                {
                    if (dataGridView1.Rows[rows].Cells[0].Value == null)
                    {
                        if (dataGridView1.Rows[rows].Cells[3].Value != null)
                        {
                            dataGridView1.Rows[rows].Cells[3].Value = "";
                        }
                        if (dataGridView1.Rows[rows].Cells[4].Value != null)
                        {
                            dataGridView1.Rows[rows].Cells[4].Value = "";
                        }
                    }
                }
            }
            countAmountQuantity();
        }

        private void countAmountQuantity()
        {
            int quantity, price, total_amount = 0, total_quantity = 0;
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                if (dataGridView1.Rows[rows].Cells[3].Value != null && dataGridView1.Rows[rows].Cells[4].Value != null)
                {
                    if (Int32.TryParse(dataGridView1.Rows[rows].Cells[3].Value.ToString(), out price) && Int32.TryParse(dataGridView1.Rows[rows].Cells[4].Value.ToString(), out quantity))
                    {
                        total_quantity += quantity;
                        total_amount += price * quantity;
                        dataGridView1.Rows[rows].Cells[5].Value = price * quantity;
                    }
                }
            }
            txtBillingSubTotal.Text = total_amount.ToString();
            txtBillingQuantity.Text = total_quantity.ToString();
        }

        private void txtBillingTax_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBillingTax_Leave(object sender, EventArgs e)
        {
            int x, y;
            if (!txtBillingTax.Equals("") && !txtBillingSubTotal.Equals(""))
            {
                if ((Int32.TryParse(txtBillingSubTotal.Text, out x)) && (Int32.TryParse(txtBillingTax.Text, out y)))
                {
                    txtBillingTotal.Text = (Int32.Parse(txtBillingSubTotal.Text) + Int32.Parse(txtBillingTax.Text)).ToString();
                }
                else
                {
                    txtBillingTotal.Text = "";
                }
            }
            else
            {
                txtBillingTotal.Text = "";
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            flag = "add";
            dataGridView1.Rows.Clear();
            comboBoxBillingOrderType.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String modID;
            String orderID = txtOrderID.Text;
            String custID = txtCustID.Text;
            String custBillID = txtBillID.Text;
            int quantity = int.Parse(txtBillingQuantity.Text);
            String tax = txtBillingTax.Text;
            String totalAmount = txtBillingTotal.Text;
            int paidAmount = 0;
            DateTime orderDate = dateTimePicker1.Value.Date;

            connectingCust_Billing();

            //inserting into Purchase_Order table
            try
            {
                //for paid_amount calculation
                String stm = "SELECT paid_amount from payment_cust where cust_bill_id = '" + txtBillID.Text + "';";
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    paidAmount += rdr.GetInt32(0);
                }
                rdr.Close();
                stm = "select cust_id from cust_details where cust_id = '" + custID + "';";
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdr.Close();
                    stm = "select sale_order_id from sale_order where sale_order_id = '" + orderID + "';";
                    cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && flag.Equals("add"))
                    {
                        MessageBox.Show("OrderID is not unique. Please choose unique OrderId");
                        rdr.Close();
                    }
                    else
                    {
                        rdr.Close();
                        cmd = con.CreateCommand();
                        if (flag.Equals("add"))
                        {
                            cmd.CommandText = "insert into sale_order values(@sale_order_id,@cust_id,@quantity,@date);";
                            cmd.Parameters.AddWithValue("@sale_order_id", orderID);
                            cmd.Parameters.AddWithValue("@cust_id", custID);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@date", orderDate);
                            cmd.ExecuteNonQuery();
                            cmd = con.CreateCommand();
                            cmd.CommandText = "insert into cust_bill values(@cust_bill_id,@sale_order_id,@total_amount,@paid_amount);";
                            cmd.Parameters.AddWithValue("@cust_bill_id", custBillID);
                            cmd.Parameters.AddWithValue("@sale_order_id", orderID);
                            cmd.Parameters.AddWithValue("@total_amount", totalAmount);
                            cmd.Parameters.AddWithValue("@paid_amount", "0");
                            cmd.ExecuteNonQuery();
                        }
                        else if (flag.Equals("update"))
                        {
                            cmd.CommandText = "UPDATE sale_order SET quantity=@quantity,date=@date WHERE sale_order_id=@sale_order_id;";
                            cmd.Parameters.AddWithValue("@sale_order_id", orderID);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@date", orderDate);
                            cmd.ExecuteNonQuery();
                            cmd = con.CreateCommand();
                            cmd.CommandText = "UPDATE cust_bill SET total_amount=@total_amount, paid_amount=@paid_amount WHERE cust_bill_id=@cust_bill_id;";
                            cmd.Parameters.AddWithValue("@cust_bill_id", custBillID);
                            cmd.Parameters.AddWithValue("@sale_order_id", orderID);
                            cmd.Parameters.AddWithValue("@total_amount", totalAmount);
                            cmd.Parameters.AddWithValue("@paid_amount", paidAmount);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Inserted into sale_order");

                        int r = dataGridView1.RowCount;

                        //if (flag.Equals("update"))    //Decrementing stock previously order
                        //{
                        //    for (int i = 1; i < r; i++)
                        //    {
                        //        if (dataGridView1.Rows[i - 1].Cells[0].Value != null)
                        //        {
                        //            int t;
                        //            t = int.Parse(dataGridView1.Rows[i - 1].Cells[4].Value.ToString());
                        //            cmd = con.CreateCommand();
                        //            cmd.CommandText = "UPDATE stock SET quantity=quantity-@quantity where model_id=@model_id";
                        //            cmd.Parameters.AddWithValue("@model_id", dataGridView1.Rows[i - 1].Cells[0].Value.ToString());
                        //            quantity = Int32.Parse(dataGridView1.Rows[i - 1].Cells[4].Value.ToString());
                        //            cmd.Parameters.AddWithValue("@quantity", quantity);
                        //            cmd.ExecuteNonQuery();
                        //            //Removing from purchase_item
                        //            cmd = con.CreateCommand();
                        //            cmd.CommandText = "DELETE from sale_item where sale_order_id=@sale_order_id";
                        //            cmd.Parameters.AddWithValue("@sale_order_id", txtOrderID.Text);
                        //            cmd.ExecuteNonQuery();
                        //        }
                        //    }
                        //}

                        for (int i = 1; i < r; i++)
                        {
                            //MessageBox.Show("i = " + i);
                            if (dataGridView1.Rows[i - 1].Cells[0].Value != null)
                            {
                                //MessageBox.Show("Model ID is not null");
                                stm = "select model_id,quantity from stock where model_id = '" + dataGridView1.Rows[i - 1].Cells[0].Value.ToString() + "';";
                                cmd = new MySqlCommand(stm, con);
                                rdr = cmd.ExecuteReader();
                                if (rdr.Read())
                                {
                                    modID = rdr.GetString(0);
                                    rdr.Close();
                                    //MessageBox.Show("Model ID present!");
                                    cmd = con.CreateCommand();
                                    cmd.CommandText = "INSERT into sale_item (sale_order_id,amount,model_id,quantity) values(@sale_order_id,@amount,@model_id,@quantity)";
                                    cmd.Parameters.AddWithValue("@sale_order_id", txtOrderID.Text);
                                    MessageBox.Show("Amount : " + dataGridView1.Rows[i - 1].Cells[3].Value.ToString());
                                    cmd.Parameters.AddWithValue("@amount", dataGridView1.Rows[i - 1].Cells[3].Value.ToString());
                                    cmd.Parameters.AddWithValue("@model_id", dataGridView1.Rows[i - 1].Cells[0].Value.ToString());
                                    quantity = Int32.Parse(dataGridView1.Rows[i - 1].Cells[4].Value.ToString());
                                    cmd.Parameters.AddWithValue("@quantity", quantity);
                                    cmd.ExecuteNonQuery();
                                    for (int j = 0; j < quantity; j++)
                                    {
                                        cmd = con.CreateCommand();
                                        cmd.CommandText = "UPDATE stock set quantity=quantity-1 where model_id=@model_id";
                                        cmd.Parameters.AddWithValue("@model_id", modID);
                                        cmd.ExecuteNonQuery();
                                        cmd.CommandText = "";
                                        MessageBox.Show("Updated "+j);
                                    }
                                    MessageBox.Show("Updated Stock");
                                }
                                //MessageBox.Show("Exited 1st if");
                            }
                            //MessageBox.Show("Exited 2nd if");
                        }
                        //MessageBox.Show("Exited for");
                    }
                }
                else
                {
                    MessageBox.Show("Error: Customer not present!!");
                    rdr.Close();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
                flag = "";
            }
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            flag = "update";
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (!txtOrderID.Text.Equals(""))
            {
                try
                {
                    connectingCust_Billing();
                    int r = dataGridView1.RowCount;
                    for (int i = 1; i < r; i++)
                    {
                        if (dataGridView1.Rows[i - 1].Cells[0].Value.ToString() != null)
                        {
                            int t;
                            t = int.Parse(dataGridView1.Rows[i - 1].Cells[4].Value.ToString());
                            cmd = con.CreateCommand();
                            cmd.CommandText = "UPDATE stock SET quantity=quantity-@quantity where model_id=@model_id";
                            cmd.Parameters.AddWithValue("@model_id", dataGridView1.Rows[i - 1].Cells[0].Value.ToString());
                            int quantity = Int32.Parse(dataGridView1.Rows[i - 1].Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.ExecuteNonQuery();
                            //Removing from sale_item
                            cmd = con.CreateCommand();
                            cmd.CommandText = "DELETE from sale_item where sale_order_id=@sale_order_id";
                            cmd.Parameters.AddWithValue("@sale_order_id", txtOrderID.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE from cust_bill where sale_order_id=@s_o_i";
                    cmd.Parameters.AddWithValue("@s_o_i", txtOrderID.Text);
                    cmd.ExecuteNonQuery();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE from sale_order where sale_order_id=@s_o_i";
                    cmd.Parameters.AddWithValue("@s_o_i", txtOrderID.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        emptyAll();
                        reloadListBoxBills();
                        reloadListBoxCustList();
                    }
                }
            }
        }

        private void reloadListBoxBills()
        {
            listBoxBills.Items.Clear();
            try
            {
                connectingCust_Billing();
                stm = "SELECT sale_order_id from sale_order";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBoxBills.Items.Add(rdr.GetString(0));
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
                    con.Close();
                }
            }
        }

        private void listBoxBills_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxBills.SelectedIndex > -1)
            {
                flag = "";
                emptyAll();
                txtOrderID.Text = listBoxBills.SelectedItem.ToString();
                populatingForm();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!txtOrderID.Equals(""))
            {
                try
                {
                    connectingCust_Billing();
                    stm = "SELECT cust_bill_id from cust_bill where cust_bill_id='" + txtBillID.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        BillId = rdr.GetString(0);
                    }
                    rdr.Close();
                    PaymentCustomer pc = new PaymentCustomer();
                    pc.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void txtBillID_TextChanged(object sender, EventArgs e)
        {
            //reloadListBoxPaymentsDone();
        }

        private void reloadListBoxPaymentsDone()
        {
            listBoxPaymentsDone.Items.Clear();
            try
            {
                connectingCust_Billing();
                String stm2 = "SELECT cust_invoice_no from payment_cust where cust_bill_id='" + txtBillID.Text + "';";
                MySqlCommand cmd = new MySqlCommand(stm2, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBoxPaymentsDone.Items.Add(rdr.GetString(0));
                }
                rdr.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            listBoxBillSearchResults.Items.Clear();
            searchLevel = 0;
            if (comboBoxBillSearchBy.SelectedIndex > -1)
            {
                string stm = "";
                if (comboBoxBillSearchBy.SelectedItem.ToString() == "Order ID")
                {
                    stm = "SELECT sale_order_id FROM sale_order where sale_order_id like '%" + txtBillSearchKeywords.Text + "%'";
                    listBoxBillSearchResults.Items.Add("Order ID's:");
                }
                else if (comboBoxBillSearchBy.SelectedItem.ToString() == "Bill ID")
                {
                    stm = "SELECT cust_bill_id FROM cust_bill where cust_bill_id like '%" + txtBillSearchKeywords.Text + "%'";
                    listBoxBillSearchResults.Items.Add("Bill ID's:");
                }
                else if (comboBoxBillSearchBy.SelectedItem.ToString() == "Customer ID")
                {
                    stm = "SELECT cust_id FROM sale_order where cust_id like '%" + txtBillSearchKeywords.Text + "%'";
                    listBoxBillSearchResults.Items.Add("Based on Customer ID:");
                }
                else if (comboBoxBillSearchBy.SelectedItem.ToString() == "Customer Name")
                {
                    stm = "SELECT a.name FROM cust_details a, sale_order b where a.cust_id=b.cust_id and a.name like '%" + txtBillSearchKeywords.Text + "%'";
                    listBoxBillSearchResults.Items.Add("Based on Customer Name:");
                }
                else
                {
                    MessageBox.Show("Select something valid from the drop down list");
                }
                try
                {
                    connectingCust_Billing();
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listBoxBillSearchResults.Items.Add(rdr.GetString(0));
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
                        con.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBillingTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            BillprintPreviewDialog.Document = BillprintDocument;

            BillprintPreviewDialog.ShowDialog();

        }

        private void BillprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources._1__160_;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString("Bill ID :" + txtBillID.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Customer ID :" + txtCustID.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Name :"+txtBillingCustName.Text,new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Date :" + dateTimePicker1.Value.ToString("dd-MM-yyyy"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Shipping Address :" + txtBillingShippingAddress.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            //e.Graphics.DrawString("Ref By :"+billrefid.Text,new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            //e.Graphics.DrawString("Age :" + billpage.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            //e.Graphics.DrawString("Sex :" + billpsex.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Model"].Value);
                e.Graphics.DrawString("Test Name :" + a, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));
                Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                e.Graphics.DrawLine(pen, 20, 10, 300, 100);
            }
            int r = dataGridView1.RowCount;
            for (int i = 1; i < r; i++)
            {
                if (dataGridView1.Rows[i - 1].Cells[0].Value.ToString() != null)
                {
                    int quantity = int.Parse(dataGridView1.Rows[i - 1].Cells[4].Value.ToString());
                    int Price = int.Parse(dataGridView1.Rows[i - 1].Cells[3].Value.ToString());
                }
            }
        }

        private void checkPriceQuantityTax()
        {
            int check;
            if(txtBillingTax.Text!="")
            {
                if(!Int32.TryParse(txtBillingTax.Text,out check))
                {
                    MessageBox.Show("Tax must be integer");
                    txtBillingTax.Text = "";
                }
            }
            int r = dataGridView1.RowCount;
            for (int i = 1; i < r; i++)
            {
                if (dataGridView1.Rows[i - 1].Cells[0].Value != null)
                {
                    if (dataGridView1.Rows[i - 1].Cells[3].Value != null && dataGridView1.Rows[i - 1].Cells[4].Value != null)
                    {
                        if (!Int32.TryParse(dataGridView1.Rows[i - 1].Cells[3].Value.ToString(), out check))
                        {
                            MessageBox.Show("Price must be integer");
                            dataGridView1.Rows[i - 1].Cells[3].Value = "";
                        }
                        if (!Int32.TryParse(dataGridView1.Rows[i - 1].Cells[4].Value.ToString(), out check))
                        {
                            MessageBox.Show("Quantity must be integer");
                            dataGridView1.Rows[i - 1].Cells[4].Value = "";
                        }
                    }
                }
            }
        }

        private void listBoxBillSearchResults_DoubleClick(object sender, EventArgs e)
        {
            if (searchLevel == 0)
            {
                if (listBoxBillSearchResults.SelectedIndex > 0)
                {
                    string stm = "";
                    if (comboBoxBillSearchBy.SelectedItem.ToString() == "Order ID")
                    {
                        txtOrderID.Text = listBoxBillSearchResults.SelectedItem.ToString();
                        populatingForm();
                    }
                    else if (comboBoxBillSearchBy.SelectedItem.ToString() == "Bill ID")
                    {
                        stm = "SELECT sale_order_id FROM cust_bill where cust_bill_id = '" + listBoxBillSearchResults.SelectedItem.ToString() + "'";
                        try
                        {
                            connectingCust_Billing();
                            MySqlCommand cmd = new MySqlCommand(stm, con);
                            rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {
                                txtOrderID.Text = rdr.GetString(0);
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        populatingForm();
                    }
                    else if (comboBoxBillSearchBy.SelectedItem.ToString() == "Customer ID")
                    {
                        stm = "SELECT sale_order_id, cust_id FROM sale_order where cust_id = '" + listBoxBillSearchResults.SelectedItem.ToString() + "'";
                        try
                        {
                            connectingCust_Billing();
                            MySqlCommand cmd = new MySqlCommand(stm, con);
                            listBoxBillSearchResults.Items.Clear();
                            listBoxBillSearchResults.Items.Add("Based on Customer ID:");
                            rdr = cmd.ExecuteReader();
                            if (rdr.Read())
                            {
                                listBoxBillSearchResults.Items.Add("Orders from " + rdr.GetString(1) + ":");
                                rdr.Close();
                                rdr = cmd.ExecuteReader();
                                while (rdr.Read())
                                {
                                    listBoxBillSearchResults.Items.Add(rdr.GetString(0));
                                }
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        searchLevel = 1;
                    }
                    else if (comboBoxBillSearchBy.SelectedItem.ToString() == "Customer Name")
                    {
                        stm = "SELECT a.sale_order_id, b.name FROM sale_order a, cust_details b where a.cust_id=b.cust_id and b.name = '" + listBoxBillSearchResults.SelectedItem.ToString() + "'";
                        try
                        {
                            connectingCust_Billing();
                            MySqlCommand cmd = new MySqlCommand(stm, con);
                            listBoxBillSearchResults.Items.Clear();
                            listBoxBillSearchResults.Items.Add("Based on Customer Name:");
                            rdr = cmd.ExecuteReader();
                            if (rdr.Read())
                            {
                                listBoxBillSearchResults.Items.Add("Orders from " + rdr.GetString(1) + ":");
                                rdr.Close();
                                rdr = cmd.ExecuteReader();
                                while (rdr.Read())
                                {
                                    listBoxBillSearchResults.Items.Add(rdr.GetString(0));
                                }
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        searchLevel = 1;
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                if (comboBoxBillSearchBy.SelectedItem.ToString() == "Customer ID")
                {
                    if (listBoxBillSearchResults.SelectedIndex > 1)
                    {
                        txtOrderID.Text = listBoxBillSearchResults.SelectedItem.ToString();
                        populatingForm();
                    }
                }
                else if (comboBoxBillSearchBy.SelectedItem.ToString() == "Customer Name")
                {
                    if (listBoxBillSearchResults.SelectedIndex > 1)
                    {
                        txtOrderID.Text = listBoxBillSearchResults.SelectedItem.ToString();
                        populatingForm();
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDetails pd = new PrintDetails();
            Test_GUI_for_Inventory_App.Validations.flagReport = "Bill";
            pd.pass_values_OrderID = txtOrderID.Text;
            pd.Show();
        }        
    }
}
