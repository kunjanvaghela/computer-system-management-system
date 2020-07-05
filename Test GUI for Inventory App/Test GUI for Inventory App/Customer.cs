using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test_GUI_for_Inventory_App
{
    public partial class Customer : Form
    {
        String MyConnectionString;
        String cust_id, name, phone1, phone2, mob1, mob2, email1, email2, address1, address2, remarks;
        Char gender;
        DateTime dob;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        String flag;

        public string flagReport = "2";

        private static Customer _instance;

        Payroll P_Roll = new Payroll();

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            reloadListBoxCustomerList();
            custdetails_editable(false);
        }

        public Customer instance
        {
            get
            {
                if (Customer._instance == null)
                {
                    Customer._instance = new Customer();
                }
                return Customer._instance;
            }
        }

        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Customer._instance = null;
        }

        /*
        * 
        * Customer Details Tab Coding
        * 
        * 
        */

        private void listBoxCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            custdetails_editable(false);
            if (listBoxCustomerList.SelectedIndex > -1)
            {
                String selectedValue = listBoxCustomerList.SelectedItem.ToString();
                connectingCsmsCustDetails();
                try
                {
                    string stm = "SELECT * FROM cust_Details where name='" + selectedValue + "'";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    populatingForm();
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

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            btnCustDetailsSave.Enabled = true;
            clearAllFields();
            custdetails_editable(true);
            flag = "Add";

            btnCustDetailsCancel.BringToFront();
            ctrls_enabled(true);
            custIDGeneration();
        }

        private void custIDGeneration()
        {
            String custID = "", finalCustID = "";
            int CustNo = 1;
            connectingCsmsCustDetails();
            try
            {
                String stm = "SELECT cust_id from cust_details;";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdr.Close();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        custID = rdr.GetString(0);
                        string t = custID.Substring(2, 4);
                        CustNo = int.Parse(t) + 1;
                    }
                    finalCustID = "C" + "/" + CustNo.ToString("D4");
                }
                else
                {
                    finalCustID = "C" + "/0001";
                }
                txtCustID.Text = finalCustID;
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

        private void btnUpdateCustDetails_Click(object sender, EventArgs e)
        {
            if (listBoxCustomerList.SelectedIndex > -1 || listBoxCustDetailsSearchResults.SelectedIndex > 0)
            {
                btnCustDetailsSave.Enabled = true;
                custdetails_editable(true);
                flag = "Update";

                btnCustDetailsCancel.BringToFront();
                ctrls_enabled(true);
            }
        }

        private void btnRemoveCust_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text != null) //((listBoxCustomerList.SelectedIndex > -1 || listBoxCustDetailsSearchResults.SelectedIndex > 0) && (txtCustID!=null))
            {
                try
                {
                    connectingCsmsCustDetails();
                    String stm = "SELECT cust_id,name FROM cust_Details where cust_id = '" + txtCustID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (MessageBox.Show("Do you want to delete Customer with name " + rdr.GetString(1) + "?", "Delete Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText = "delete from cust_details where cust_id=" + rdr.GetString(0) + ";";
                            rdr.Close();
                            cmd.ExecuteNonQuery();
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
                    reloadListBoxCustomerList();
                    clearAllFields();
                }
            }
        }

        private void btnCustDetailsSave_Click(object sender, EventArgs e)
        {
            //Extracting data from fields
            cust_id = txtCustID.Text;
            name = txtCustName.Text;
            if (comboBoxCustGender.Text == "Male")
                gender = 'M';
            else if (comboBoxCustGender.Text == "Female")
                gender = 'F';
            else
                gender = ' ';
            phone1 = txtCustPhone1.Text;
            phone2 = txtCustPhone2.Text;
            mob1 = txtCustMobile1.Text;
            mob2 = txtCustMobile2.Text;
            email1 = txtCustEmail1.Text;
            email2 = txtCustEmail2.Text;
            address1 = txtCustAddress.Text;
            address2 = txtCustShippingAddress.Text;
            dob = dateTimePickerCustDOB.Value.Date;
            remarks = txtCustRemarks.Text;

            //Inserting data
            connectingCsmsCustDetails();
            try
            {
                cmd = con.CreateCommand();
                if (flag.Equals("Add"))
                {
                    cmd.CommandText = "insert into cust_details values(@cust_id,@name,@add1,@add2,@ph1,@ph2,@mob1,@mob2,@gender,@email1,@email2,@dob,@remarks)";
                }
                else if (flag.Equals("Update"))
                {
                    cmd.CommandText = "UPDATE cust_Details SET name=@name,address1=@add1,address2=@add2,phone1=@ph1,phone2=@ph2,mob1=@mob1,mob2=@mob2,gender=@gender,email1=@email1,email2=@email2,dob=@dob,remarks=@remarks WHERE cust_id = @cust_id";
                }
                cmd.Parameters.AddWithValue("@cust_id", cust_id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@add1", address1);
                cmd.Parameters.AddWithValue("@add2", address2);
                cmd.Parameters.AddWithValue("@ph1", phone1);
                cmd.Parameters.AddWithValue("@ph2", phone2);
                cmd.Parameters.AddWithValue("@mob1", mob1);
                cmd.Parameters.AddWithValue("@mob2", mob2);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email1", email1);
                cmd.Parameters.AddWithValue("@email2", email2);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@remarks", remarks);
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
                }
                reloadListBoxCustomerList();
            }
            custdetails_editable(false);
            btnCustDetailsSave.Enabled = false;

            ctrls_enabled(false);
            btnCustDetailsCancel.SendToBack();
        }

        private void btnCustDetailsClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }
        
        private void btnCustDetailsCancel_Click(object sender, EventArgs e)
        {
            clearAllFields();
            custdetails_editable(false);
            ctrls_enabled(false);
            btnCustDetailsCancel.SendToBack();
        } 

        private void btnCustDetailsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustDetailsSearch_Click(object sender, EventArgs e)
        {
            listBoxCustDetailsSearchResults.Items.Clear();
            if (comboBoxCustDetailsSearchBy.SelectedIndex > -1)
            {
                string stm;
                if (comboBoxCustDetailsSearchBy.SelectedItem.ToString() == "ID")
                {
                    stm = "SELECT cust_id FROM cust_Details where cust_id like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on ID:");
                }
                else if (comboBoxCustDetailsSearchBy.SelectedItem.ToString() == "Name")
                {
                    stm = "SELECT name FROM cust_Details where name like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on Name:");
                }
                else if (comboBoxCustDetailsSearchBy.SelectedItem.ToString() == "Phone 1")
                {
                    stm = "SELECT phone1 FROM cust_Details where phone1 like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on Phone 1:");
                }
                else if (comboBoxCustDetailsSearchBy.SelectedItem.ToString() == "Phone 2")
                {
                    stm = "SELECT phone2 FROM cust_Details where phone2 like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on Phone 2:");
                }
                else if (comboBoxCustDetailsSearchBy.SelectedItem.ToString() == "Mobile 1")
                {
                    stm = "SELECT mob1 FROM cust_Details where mob1 like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on Mobile 1:");
                }
                else if (comboBoxCustDetailsSearchBy.SelectedItem.ToString() == "Mobile 2")
                {
                    stm = "SELECT mob2 FROM cust_Details where mob2 like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on Mobile 2:");
                }
                else if (comboBoxCustDetailsSearchBy.SelectedItem.ToString() == "Email 1")
                {
                    stm = "SELECT email1 FROM cust_Details where email1 like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on Email 1:");
                }
                else // if (comboBoxCustDetailsSearchBy.SelectedItem == "Email 2")
                {
                    stm = "SELECT email2 FROM cust_Details where email2 like '%" + txtCustDetailsSearchKeywords.Text + "%'";
                    listBoxCustDetailsSearchResults.Items.Add("Based on Email 2:");
                }
                try
                {
                    connectingCsmsCustDetails();
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listBoxCustDetailsSearchResults.Items.Add(rdr.GetString(0));
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

        private void listBoxCustDetailsSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            custdetails_editable(false);
            if (listBoxCustDetailsSearchResults.SelectedIndex > 0)
            {
                String selectedValue = listBoxCustDetailsSearchResults.SelectedItem.ToString();
                String stm;
                connectingCsmsCustDetails();
                if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on ID:")
                {
                    stm = "SELECT * FROM cust_Details where cust_id = '" + selectedValue + "'";
                }
                else if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Name:")
                {
                    stm = "SELECT * FROM cust_Details where name = '" + selectedValue + "'";
                }
                else if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Phone 1:")
                {
                    stm = "SELECT * FROM cust_Details where phone1 = '" + selectedValue + "'";
                }
                else if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Phone 2:")
                {
                    stm = "SELECT * FROM cust_Details where phone2 = '" + selectedValue + "'";
                }
                else if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Mobile 1:")
                {
                    stm = "SELECT * FROM cust_Details where mob1 = '" + selectedValue + "'";
                }
                else if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Mobile 2:")
                {
                    stm = "SELECT * FROM cust_Details where mob2 = '" + selectedValue + "'";
                }
                else if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Email 1:")
                {
                    stm = "SELECT * FROM cust_Details where email1 = '" + selectedValue + "'";
                }
                else //if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Email 2:")
                {
                    stm = "SELECT * FROM cust_Details where email2 = '" + selectedValue + "'";
                }
                try
                {
                    cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    populatingForm();
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

        public void reloadListBoxCustomerList()
        {
            listBoxCustomerList.Items.Clear();
            try
            {
                connectingCsmsCustDetails();
                string stm = "SELECT name FROM cust_Details";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxCustomerList.Items.Add(rdr.GetString(0));
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
            while (rdr.Read())
            {
                txtCustID.Text = rdr.GetString(0);
                txtCustName.Text = rdr.GetString(1);
                txtCustAddress.Text = rdr.GetString(2);
                txtCustShippingAddress.Text = rdr.GetString(3);
                txtCustPhone1.Text = rdr.GetString(4);
                txtCustPhone2.Text = rdr.GetString(5);
                txtCustMobile1.Text = rdr.GetString(6);
                txtCustMobile2.Text = rdr.GetString(7);
                if (rdr.GetChar(8) == 'M')
                    comboBoxCustGender.Text = "Male";
                else if (rdr.GetChar(8) == 'F')
                    comboBoxCustGender.Text = "Female";
                else
                    comboBoxCustGender.Text = "";
                txtCustEmail1.Text = rdr.GetString(9);
                txtCustEmail2.Text = rdr.GetString(10);
                dateTimePickerCustDOB.Value = rdr.GetDateTime(11);
                txtCustRemarks.Text = rdr.GetString(12);
            }
        }
        private void custdetails_editable(bool choice)
        {
            choice = !choice;
            //txtCustID.ReadOnly = choice;
            txtCustName.ReadOnly = choice;
            comboBoxCustGender.Enabled = !choice;
            txtCustPhone1.ReadOnly = choice;
            txtCustPhone2.ReadOnly = choice;
            txtCustMobile1.ReadOnly = choice;
            txtCustMobile2.ReadOnly = choice;
            txtCustEmail1.ReadOnly = choice;
            txtCustEmail2.ReadOnly = choice;
            txtCustAddress.ReadOnly = choice;
            txtCustShippingAddress.ReadOnly = choice;
            dateTimePickerCustDOB.Enabled = !choice;
            txtCustRemarks.ReadOnly = choice;
        }

        private void clearAllFields()
        {
            txtCustID.Text = "";
            txtCustName.Text = "";
            txtCustAddress.Text = "";
            txtCustShippingAddress.Text = "";
            txtCustPhone1.Text = "";
            txtCustPhone2.Text = "";
            txtCustMobile1.Text = "";
            txtCustMobile2.Text = "";
            comboBoxCustGender.SelectedIndex = 0;
            txtCustEmail1.Text = "";
            txtCustEmail2.Text = "";
            dateTimePickerCustDOB.Value = DateTime.Now;
            txtCustRemarks.Text = "";
        }

        private void ctrls_enabled(bool choice)
        {
            tableLayoutPanelCustDisplay.Enabled = !choice;
            tableLayoutPanelCustSearchCtrls.Enabled = !choice;

            btnCustDetailsCancel.Enabled = choice;
            btnCustDetailsClose.Enabled = !choice;
            btnCustDetailsClear.Enabled = choice;
            btnCustDetailsSave.Enabled = choice;
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyTextAllowed(e);
        }

        private void txtCustPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtCustPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtCustMobile1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtCustMobile2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtCustEmail1_Leave(object sender, EventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.ValidateEmail(e, txtCustEmail1);
        }

        private void txtCustEmail2_Leave(object sender, EventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.ValidateEmail(e, txtCustEmail2);
        }
        
        public void connectingCsmsCustDetails()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDetails pd = new PrintDetails();
            Test_GUI_for_Inventory_App.Validations.flagReport = "Cust";
            pd.pass_values_CustID = txtCustID.Text;
            pd.Show();
        }       
    }
}
