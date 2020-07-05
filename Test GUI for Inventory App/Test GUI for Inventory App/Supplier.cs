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
    public partial class Supplier : Form
    {
        public static String modID;
        String MyConnectionString;
        String dealer_id, name, phone1, phone2, mob1, mob2, email1, email2, address1, remarks;
        Char gender;        
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        String flag, flag2;

        private static Supplier _instance;
                

        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            reloadListBoxSuppliers();
            reloadlistBoxPurchaseOrderOrderList();
            suppdetails_editable(false);
            reloadComboType();
            flag = "";
            flag2 = "";
        }

        public Supplier instance
        {
            get
            {
                if (Supplier._instance == null)
                {
                    Supplier._instance = new Supplier();
                }
                return Supplier._instance;
            }
        }

        private void Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Supplier._instance = null;
        }


        /*
         * 
         * Supplier Details Tab Coding
         * 
         * 
         */

        private void listBoxSupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppdetails_editable(false);
            if (listBoxSupplierList.SelectedIndex > -1)
            {
                String selectedValue = listBoxSupplierList.SelectedItem.ToString();
                connectingCsmsSuppDetails();
                try
                {
                    string stm = "SELECT * FROM dealer_details where name='" + selectedValue + "'";
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

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            btnSuppDetailsSave.Enabled = true;
            clearAllFieldsSupplierDetails();
            suppdetails_editable(true);
            flag = "Add";

            btnSuppDetailsCancel.BringToFront();
            ctrls_enabled(true);
            suppIDGeneration();
        }

        private void suppIDGeneration()
        {
            String suppID = "", finalSuppID = "";
            int suppNo = 1;
            connectingCsmsSuppDetails();
            try
            {
                String stm = "SELECT dealer_id from dealer_details;";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdr.Close();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        suppID = rdr.GetString(0);
                        string t = suppID.Substring(2, 4);
                        suppNo = int.Parse(t) + 1;
                    }
                    finalSuppID = "S" + "/" + suppNo.ToString("D4");
                }
                else
                {
                    finalSuppID = "S" + "/0001";
                }
                txtSuppID.Text = finalSuppID;
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

        private void btnUpdateSuppDetails_Click(object sender, EventArgs e)
        {
            if (listBoxSupplierList.SelectedIndex > -1 || listBoxSuppDetailsSearchResults.SelectedIndex > 0)
            {
                btnSuppDetailsSave.Enabled = true;
                suppdetails_editable(true);
                flag = "Update";

                btnSuppDetailsCancel.BringToFront();
                ctrls_enabled(true);
            }
        }

        private void btnRemoveSupp_Click(object sender, EventArgs e)
        {
            if (txtSuppID.Text != null) //((listBoxCustomerList.SelectedIndex > -1 || listBoxCustDetailsSearchResults.SelectedIndex > 0) && (txtCustID!=null))
            {
                try
                {
                    connectingCsmsSuppDetails();
                    String stm = "SELECT dealer_id,name FROM dealer_details where dealer_id = '" + txtSuppID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (MessageBox.Show("Do you want to delete Supplier with name " + rdr.GetString(1) + "?", "Delete Supplier?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText = "delete from dealer_details where dealer_id='" + rdr.GetString(0) + "';";
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
                    reloadListBoxSuppliers();
                    clearAllFieldsSupplierDetails();
                }
            }
        }

        private void btnSuppDetailsSave_Click(object sender, EventArgs e)
        {
            //Extracting data from fields
            dealer_id = txtSuppID.Text;
            name = txtSuppName.Text;
            if (comboBoxSuppGender.Text == "Male")
                gender = 'M';
            else if (comboBoxSuppGender.Text == "Female")
                gender = 'F';
            else
                gender = ' ';
            phone1 = txtSuppPhone1.Text;
            phone2 = txtSuppPhone2.Text;
            mob1 = txtSuppMobile1.Text;
            mob2 = txtSuppMobile2.Text;
            email1 = txtSuppEmail1.Text;
            email2 = txtSuppEmail2.Text;
            address1 = txtSuppAddress.Text;
            remarks = txtSuppRemarks.Text;

            //Inserting data
            connectingCsmsSuppDetails();
            try
            {
                cmd = con.CreateCommand();
                if (flag.Equals("Add"))
                {
                    cmd.CommandText = "insert into dealer_details values(@dealer_id,@name,@add1,@ph1,@ph2,@mob1,@mob2,@gender,@email1,@email2,@remarks)";
                }
                else if (flag.Equals("Update"))
                {
                    cmd.CommandText = "UPDATE dealer_details SET name=@name,address1=@add1,phone1=@ph1,phone2=@ph2,mob1=@mob1,mob2=@mob2,gender=@gender,email1=@email1,email2=@email2,remarks=@remarks WHERE dealer_id = @dealer_id";
                }
                cmd.Parameters.AddWithValue("@dealer_id", dealer_id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@add1", address1);
                cmd.Parameters.AddWithValue("@ph1", phone1);
                cmd.Parameters.AddWithValue("@ph2", phone2);
                cmd.Parameters.AddWithValue("@mob1", mob1);
                cmd.Parameters.AddWithValue("@mob2", mob2);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email1", email1);
                cmd.Parameters.AddWithValue("@email2", email2);
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
                reloadListBoxSuppliers();
            }
            suppdetails_editable(false);
            btnSuppDetailsSave.Enabled = false;

            ctrls_enabled(false);
            btnSuppDetailsCancel.SendToBack();
        }

        private void btnSuppDetailsClear_Click(object sender, EventArgs e)
        {
            clearAllFieldsSupplierDetails();
        }

        private void btnSuppDetailsCancel_Click(object sender, EventArgs e)
        {
            clearAllFieldsSupplierDetails();
            suppdetails_editable(false);
            ctrls_enabled(false);
            btnSuppDetailsCancel.SendToBack();
        }  

        private void btnSuppDetailsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuppDetailsSearch_Click(object sender, EventArgs e)
        {
            listBoxSuppDetailsSearchResults.Items.Clear();
            if (comboBoxSuppDetailsSearchBy.SelectedIndex > -1)
            {
                string stm;
                if (comboBoxSuppDetailsSearchBy.SelectedItem.ToString() == "ID")
                {
                    stm = "SELECT dealer_id FROM dealer_details where dealer_id like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on ID:");
                }
                else if (comboBoxSuppDetailsSearchBy.SelectedItem.ToString() == "Name")
                {
                    stm = "SELECT name FROM dealer_details where name like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on Name:");
                }
                else if (comboBoxSuppDetailsSearchBy.SelectedItem.ToString() == "Phone 1")
                {
                    stm = "SELECT phone1 FROM dealer_details where phone1 like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on Phone 1:");
                }
                else if (comboBoxSuppDetailsSearchBy.SelectedItem.ToString() == "Phone 2")
                {
                    stm = "SELECT phone2 FROM dealer_details where phone2 like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on Phone 2:");
                }
                else if (comboBoxSuppDetailsSearchBy.SelectedItem.ToString() == "Mobile 1")
                {
                    stm = "SELECT mob1 FROM dealer_details where mob1 like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on Mobile 1:");
                }
                else if (comboBoxSuppDetailsSearchBy.SelectedItem.ToString() == "Mobile 2")
                {
                    stm = "SELECT mob2 FROM dealer_details where mob2 like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on Mobile 2:");
                }
                else if (comboBoxSuppDetailsSearchBy.SelectedItem.ToString() == "Email 1")
                {
                    stm = "SELECT email1 FROM dealer_details where email1 like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on Email 1:");
                }
                else // if (comboBoxCustDetailsSearchBy.SelectedItem == "Email 2")
                {
                    stm = "SELECT email2 FROM dealer_details where email2 like '%" + txtSuppDetailsSearchKeywords.Text + "%'";
                    listBoxSuppDetailsSearchResults.Items.Add("Based on Email 2:");
                }
                try
                {
                    connectingCsmsSuppDetails();
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listBoxSuppDetailsSearchResults.Items.Add(rdr.GetString(0));
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

        private void listBoxSuppDetailsSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            suppdetails_editable(false);
            if (listBoxSuppDetailsSearchResults.SelectedIndex > 0)
            {
                String selectedValue = listBoxSuppDetailsSearchResults.SelectedItem.ToString();
                String stm;
                connectingCsmsSuppDetails();
                if (listBoxSuppDetailsSearchResults.Items[0].ToString() == "Based on ID:")
                {
                    stm = "SELECT * FROM dealer_details where dealer_id = '" + selectedValue + "'";
                }
                else if (listBoxSuppDetailsSearchResults.Items[0].ToString() == "Based on Name:")
                {
                    stm = "SELECT * FROM dealer_details where name = '" + selectedValue + "'";
                }
                else if (listBoxSuppDetailsSearchResults.Items[0].ToString() == "Based on Phone 1:")
                {
                    stm = "SELECT * FROM dealer_details where phone1 = '" + selectedValue + "'";
                }
                else if (listBoxSuppDetailsSearchResults.Items[0].ToString() == "Based on Phone 2:")
                {
                    stm = "SELECT * FROM dealer_details where phone2 = '" + selectedValue + "'";
                }
                else if (listBoxSuppDetailsSearchResults.Items[0].ToString() == "Based on Mobile 1:")
                {
                    stm = "SELECT * FROM dealer_details where mob1 = '" + selectedValue + "'";
                }
                else if (listBoxSuppDetailsSearchResults.Items[0].ToString() == "Based on Mobile 2:")
                {
                    stm = "SELECT * FROM dealer_details where mob2 = '" + selectedValue + "'";
                }
                else if (listBoxSuppDetailsSearchResults.Items[0].ToString() == "Based on Email 1:")
                {
                    stm = "SELECT * FROM dealer_details where email1 = '" + selectedValue + "'";
                }
                else //if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Email 2:")
                {
                    stm = "SELECT * FROM dealer_details where email2 = '" + selectedValue + "'";
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

        public void reloadListBoxSuppliers()
        {
            listBoxSupplierList.Items.Clear();
            listBoxPurchaseOrderSupplierList.Items.Clear();
            try
            {
                connectingCsmsSuppDetails();
                string stm = "SELECT name FROM dealer_details";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxSupplierList.Items.Add(rdr.GetString(0));
                    listBoxPurchaseOrderSupplierList.Items.Add(rdr.GetString(0));
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

        private void populatingForm()                //of Supplier Details form
        {
            while (rdr.Read())
            {
                txtSuppID.Text = rdr.GetString(0);
                txtSuppName.Text = rdr.GetString(1);
                txtSuppAddress.Text = rdr.GetString(2);
                txtSuppPhone1.Text = rdr.GetString(3);
                txtSuppPhone2.Text = rdr.GetString(4);
                txtSuppMobile1.Text = rdr.GetString(5);
                txtSuppMobile2.Text = rdr.GetString(6);
                if (rdr.GetChar(7) == 'M')
                    comboBoxSuppGender.Text = "Male";
                else if (rdr.GetChar(7) == 'F')
                    comboBoxSuppGender.Text = "Female";
                else
                    comboBoxSuppGender.Text = "";
                txtSuppEmail1.Text = rdr.GetString(8);
                txtSuppEmail2.Text = rdr.GetString(9);
                txtSuppRemarks.Text = rdr.GetString(10);
            }
        }
        private void suppdetails_editable(bool choice)
        {
            choice = !choice;
            //txtSuppID.ReadOnly = choice;
            txtSuppName.ReadOnly = choice;
            comboBoxSuppGender.Enabled = !choice;
            txtSuppPhone1.ReadOnly = choice;
            txtSuppPhone2.ReadOnly = choice;
            txtSuppMobile1.ReadOnly = choice;
            txtSuppMobile2.ReadOnly = choice;
            txtSuppEmail1.ReadOnly = choice;
            txtSuppEmail2.ReadOnly = choice;
            txtSuppAddress.ReadOnly = choice;
            txtSuppRemarks.ReadOnly = choice;
        }

        private void clearAllFieldsSupplierDetails()
        {
            txtSuppID.Text = "";
            txtSuppName.Text = "";
            txtSuppAddress.Text = "";
            txtSuppPhone1.Text = "";
            txtSuppPhone2.Text = "";
            txtSuppMobile1.Text = "";
            txtSuppMobile2.Text = "";
            comboBoxSuppGender.SelectedIndex = 0;
            txtSuppEmail1.Text = "";
            txtSuppEmail2.Text = "";
            txtSuppRemarks.Text = "";
        }

        private void ctrls_enabled(bool choice)
        {
            tableLayoutPanelSuppDisplay.Enabled = !choice;
            tableLayoutPanelSuppSearchCtrls.Enabled = !choice;

            btnSuppDetailsCancel.Enabled = choice;
            btnSuppDetailsClose.Enabled = !choice;
            btnSuppDetailsClear.Enabled = choice;
            btnSuppDetailsSave.Enabled = choice;
        }
                
        private void txtSuppName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyTextAllowed(e);
        }

        private void txtSuppPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtSuppPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtSuppMobile1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtSuppMobile2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtSuppEmail1_Leave(object sender, EventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.ValidateEmail(e, txtSuppEmail1);
        }

        private void txtSuppEmail2_Leave(object sender, EventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.ValidateEmail(e, txtSuppEmail2);
        }


        /*
         * 
         * Supplier Purchase Order Tab Coding
         * 
         * 
         */

        private void listBoxPurchaseOrderSupplierList_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPurchaseOrderSupplierList.SelectedIndex > -1)
            {
                if (flag2.Equals("update"))
                {
                    purchase_order_editable(false);
                    clearAllFieldsPurchaseOrder();
                }
                if (flag2.Equals("add"))
                {
                    String selectedValue = listBoxPurchaseOrderSupplierList.SelectedItem.ToString();
                    connectingCsmsSuppDetails();
                    try
                    {
                        string stm = "SELECT dealer_id,name FROM dealer_details where name='" + selectedValue + "'";
                        MySqlCommand cmd = new MySqlCommand(stm, con);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            txtDealerID.Text = rdr.GetString(0);
                            txtDealerName.Text = rdr.GetString(1);
                        }
                        rdr.Close();
                        orderIDGeneration();
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
        }

        private void btnShowDealerOrder_Click(object sender, EventArgs e)
        {
            String stm, dealerNameHere, dealerIdHere = "";
            if (listBoxPurchaseOrderSupplierList.SelectedIndex > -1)
            {
                listBoxPurchaseOrderOrderList.Items.Clear();
                dealerNameHere = listBoxPurchaseOrderSupplierList.SelectedItem.ToString();
                connectingCsmsSuppDetails();
                try
                {
                    stm = "SELECT dealer_id from dealer_details where name='" + dealerNameHere + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        dealerIdHere = rdr.GetString(0);
                    }
                    rdr.Close();
                    stm = "SELECT purchase_order_id from purchase_order where dealer_id = '" + dealerIdHere + "';";
                    cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listBoxPurchaseOrderOrderList.Items.Add(rdr.GetString(0));
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

        private void listBoxPurchaseOrderOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPurchaseOrderOrderList.SelectedIndex > -1)
            {
                purchase_order_editable(false);
                String selectedValue = listBoxPurchaseOrderOrderList.SelectedItem.ToString();
                try
                {
                    connectingCsmsSuppDetails();
                    clearDataGridViewProductOrdering();
                    String stm = "SELECT * from purchase_order where purchase_order_id = '" + selectedValue + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        txtOrderID.Text = rdr.GetString(0);
                        txtDealerID.Text = rdr.GetString(1);
                        dateTimePickerOrderDate.Value = rdr.GetDateTime(4);
                    }
                    rdr.Close();
                    stm = "SELECT a.amount,a.quantity,a.model_id,b.category,b.brand from purchase_item a,stock b where a.model_id=b.model_id and a.purchase_order_id ='" + txtOrderID.Text + "';";
                    cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewProductOrdering.Rows[0].Clone();
                        row.Cells[0].Value = rdr.GetString(2);
                        row.Cells[1].Value = rdr.GetString(4);
                        row.Cells[2].Value = rdr.GetString(3);
                        row.Cells[3].Value = rdr.GetString(0);
                        row.Cells[4].Value = rdr.GetString(1);
                        dataGridViewProductOrdering.Rows.Add(row);
                    }
                    countAmountQuantity();
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
            purchase_order_editable(true);
            clearAllFieldsPurchaseOrder();
            flag2 = "add";
        }

        private void btnUpdateOrderDetails_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text != "")
            {
                purchase_order_editable(true);
                flag2 = "update";
            }
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            if (listBoxPurchaseOrderOrderList.SelectedIndex > -1 && txtOrderID.Text == listBoxPurchaseOrderOrderList.SelectedItem.ToString())
            {
                MessageBox.Show(listBoxPurchaseOrderOrderList.SelectedItem.ToString());
                try
                {
                    connectingCsmsSuppDetails();
                    int r = dataGridViewProductOrdering.RowCount;
                    for (int i = 1; i < r; i++)
                    {
                        if (dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value.ToString() != null)
                        {
                            int t;
                            t = int.Parse(dataGridViewProductOrdering.Rows[i - 1].Cells[4].Value.ToString());
                            cmd = con.CreateCommand();
                            cmd.CommandText = "UPDATE stock SET quantity=quantity-@quantity where model_id=@model_id";
                            cmd.Parameters.AddWithValue("@model_id", dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value.ToString());
                            int quantity = Int32.Parse(dataGridViewProductOrdering.Rows[i - 1].Cells[4].Value.ToString());
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.ExecuteNonQuery();
                            //Removing from purchase_item
                            cmd = con.CreateCommand();
                            cmd.CommandText = "DELETE from purchase_item where purchase_order_id=@purchase_order_id";
                            cmd.Parameters.AddWithValue("@purchase_order_id", txtOrderID.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE from purchase_order where purchase_order_id=@p_o_i";
                    cmd.Parameters.AddWithValue("@p_o_i", txtOrderID.Text);
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
                        clearAllFieldsPurchaseOrder();
                        clearDataGridViewProductOrdering();
                        reloadListBoxSuppliers();
                        reloadlistBoxPurchaseOrderOrderList();
                    }
                }
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectingCsmsSuppDetails();
            comboCategory.Items.Clear();
            comboBrand.Items.Clear();
            comboModel.Items.Clear();
            String stm = "Select DISTINCT category from stock where type = '" + (String)comboType.SelectedItem + "';";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboCategory.Items.Add(rdr.GetString(0));
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

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectingCsmsSuppDetails();
            String stm = "Select DISTINCT brand from stock where type = '" + (String)comboType.SelectedItem + "' and category ='" + comboCategory.SelectedItem + "';";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboBrand.Items.Add(rdr.GetString(0));
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

        private void comboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectingCsmsSuppDetails();
            String stm = "Select model_id from stock where type = '" + (String)comboType.SelectedItem + "' and category ='" + comboCategory.SelectedItem + "' and brand = '" + comboBrand.SelectedItem + "';";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboModel.Items.Add(rdr.GetString(0));
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

        private void btnAddToDataGrid_Click(object sender, EventArgs e)
        {
            if (comboModel.SelectedIndex > -1)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewProductOrdering.Rows[0].Clone();
                row.Cells[0].Value = comboModel.SelectedItem;
                row.Cells[1].Value = comboBrand.SelectedItem;
                row.Cells[2].Value = comboCategory.SelectedItem;
                dataGridViewProductOrdering.Rows.Add(row);
            }
        }

        private void btnNewModel_Click(object sender, EventArgs e)
        {
            AddModel addModel = new AddModel();
            addModel.ShowDialog(this);
            reloadComboType();
        }

        private void dataGridViewProductOrdering_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int rows = 0; rows < dataGridViewProductOrdering.Rows.Count; rows++)
            {
                if (dataGridViewProductOrdering.Rows.Count > 0 && dataGridViewProductOrdering.Rows[rows].Cells[3] != null && dataGridViewProductOrdering.Rows[rows].Cells[4] != null && dataGridViewProductOrdering.Rows[rows].Cells[0] != null)
                {
                    if (dataGridViewProductOrdering.Rows[rows].Cells[0].Value == null)
                    {
                        if (dataGridViewProductOrdering.Rows[rows].Cells[3].Value != null)
                        {
                            dataGridViewProductOrdering.Rows[rows].Cells[3].Value = "";
                        }
                        if (dataGridViewProductOrdering.Rows[rows].Cells[4].Value != null)
                        {
                            dataGridViewProductOrdering.Rows[rows].Cells[4].Value = "";
                        }
                    }
                }
            }
            if (flag2.Equals("update"))
            {
                int inStock, inPurchaseItem;
                try
                {
                    connectingCsmsSuppDetails();

                    int r = dataGridViewProductOrdering.RowCount;
                    for (int i = 1; i < r; i++)
                    {
                        if (dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value.ToString() != null)
                        {
                            String stm = "SELECT a.quantity,b.quantity from stock a, purchase_item b where a.model_id=b.model_id and b.purchase_order_id='" + txtOrderID.Text + "' and b.model_id='" + dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value + "' and b.amount='" + dataGridViewProductOrdering.Rows[i - 1].Cells[3].Value + "';";
                            MySqlCommand cmd = new MySqlCommand(stm, con);
                            rdr = cmd.ExecuteReader();
                            while (rdr.Read())
                            {
                                inStock = int.Parse(rdr.GetString(0));
                                inPurchaseItem = int.Parse(rdr.GetString(1));
                                int t1 = inPurchaseItem - int.Parse(dataGridViewProductOrdering.Rows[i - 1].Cells[4].Value.ToString());
                                int t = inStock - t1;
                                if (t < 0)
                                {
                                    //MessageBox.Show("In if");
                                    dataGridViewProductOrdering.Rows[i - 1].Cells[4].Value = inStock;
                                }
                            }
                            rdr.Close();
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
            countAmountQuantity();
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            String orderID = txtOrderID.Text;
            String dealerID = txtDealerID.Text;
            String dealerBillID = txtDealerBillID.Text;
            int quantity = int.Parse(txtQuantity.Text);
            String totalAmount = txtAmount.Text;
            DateTime orderDate = dateTimePickerOrderDate.Value.Date;

            connectingCsmsSuppDetails();

            if (txtOrderID.Text != "")
            {
                //inserting into Purchase_Order table
                try
                {
                    String stm = "select dealer_id from dealer_details where dealer_id = '" + dealerID + "';";
                    cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        stm = "select purchase_order_id from purchase_order where purchase_order_id = '" + orderID + "';";
                        cmd = new MySqlCommand(stm, con);
                        rdr = cmd.ExecuteReader();
                        if (rdr.Read() && flag2.Equals("add"))
                        {
                            MessageBox.Show("OrderID is not unique. Please choose unique OrderId");
                            rdr.Close();
                        }
                        else
                        {
                            rdr.Close();
                            cmd = con.CreateCommand();
                            if (flag2.Equals("add"))
                            {
                                cmd.CommandText = "insert into purchase_order values(@purchase_order_id,@dealer_id,@quantity,@total_amount,@date);";
                                cmd.Parameters.AddWithValue("@purchase_order_id", orderID);
                                cmd.Parameters.AddWithValue("@dealer_id", dealerID);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@total_amount", totalAmount);
                                cmd.Parameters.AddWithValue("@date", orderDate);
                                cmd.ExecuteNonQuery();
                            }
                            else if (flag2.Equals("update"))
                            {
                                cmd.CommandText = "UPDATE purchase_order SET quantity=@quantity,total_amount=@quantity,date=@date WHERE purchase_order_id=@purchase_order_id;";
                                cmd.Parameters.AddWithValue("@purchase_order_id", orderID);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@total_amount", totalAmount);
                                cmd.Parameters.AddWithValue("@date", orderDate);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Inserted into purchase_order");

                            int r = dataGridViewProductOrdering.RowCount;

                            if (flag2.Equals("update"))    //Decrementing stock previously order
                            {
                                for (int i = 1; i < r; i++)
                                {
                                    if (dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value.ToString() != null)
                                    {
                                        int t;
                                        t = int.Parse(dataGridViewProductOrdering.Rows[i - 1].Cells[4].Value.ToString());
                                        cmd = con.CreateCommand();
                                        cmd.CommandText = "UPDATE stock SET quantity=quantity-@quantity where model_id=@model_id";
                                        cmd.Parameters.AddWithValue("@model_id", dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value.ToString());
                                        quantity = Int32.Parse(dataGridViewProductOrdering.Rows[i - 1].Cells[4].Value.ToString());
                                        cmd.Parameters.AddWithValue("@quantity", quantity);
                                        cmd.ExecuteNonQuery();
                                        //Removing from purchase_item
                                        cmd = con.CreateCommand();
                                        cmd.CommandText = "DELETE from purchase_item where purchase_order_id=@purchase_order_id";
                                        cmd.Parameters.AddWithValue("@purchase_order_id", txtOrderID.Text);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            for (int i = 1; i < r; i++)
                            {
                                //MessageBox.Show("i = " + i);
                                if (dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value != null)
                                {
                                    //MessageBox.Show("Model ID is not null");
                                    stm = "select model_id,quantity from stock where model_id = '" + dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value.ToString() + "';";
                                    cmd = new MySqlCommand(stm, con);
                                    rdr = cmd.ExecuteReader();
                                    if (rdr.Read())
                                    {
                                        modID = rdr.GetString(0);
                                        rdr.Close();
                                        //MessageBox.Show("Model ID present!");
                                        cmd = con.CreateCommand();
                                        cmd.CommandText = "INSERT into purchase_item (purchase_order_id,amount,model_id,quantity) values(@purchase_order_id,@amount,@model_id,@quantity)";
                                        cmd.Parameters.AddWithValue("@purchase_order_id", txtOrderID.Text);
                                        //MessageBox.Show("Amount : " + dataGridViewProductOrdering.Rows[i - 1].Cells[3].Value.ToString());
                                        cmd.Parameters.AddWithValue("@amount", dataGridViewProductOrdering.Rows[i - 1].Cells[3].Value.ToString());
                                        cmd.Parameters.AddWithValue("@model_id", dataGridViewProductOrdering.Rows[i - 1].Cells[0].Value.ToString());
                                        quantity = Int32.Parse(dataGridViewProductOrdering.Rows[i - 1].Cells[4].Value.ToString());
                                        cmd.Parameters.AddWithValue("@quantity", quantity);
                                        cmd.ExecuteNonQuery();
                                        for (int j = 0; j < quantity; j++)
                                        {
                                            cmd = con.CreateCommand();
                                            cmd.CommandText = "update stock set quantity=quantity+1 where model_id=@model_id";
                                            cmd.Parameters.AddWithValue("@model_id", Test_GUI_for_Inventory_App.Supplier.modID);
                                            cmd.ExecuteNonQuery();
                                            cmd.CommandText = "";
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
                        MessageBox.Show("Error: Dealer not present!!");
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
                }
            }
            else
            {
                MessageBox.Show("Please add a new order or choose an existing order!");
            }
        }

        private void countAmountQuantity()
        {
            int quantity, price, total_amount = 0, total_quantity = 0;
            for (int rows = 0; rows < dataGridViewProductOrdering.Rows.Count; rows++)
            {
                if (dataGridViewProductOrdering.Rows[rows].Cells[3].Value != null && dataGridViewProductOrdering.Rows[rows].Cells[4].Value != null)
                {
                    if (Int32.TryParse(dataGridViewProductOrdering.Rows[rows].Cells[3].Value.ToString(), out price) && Int32.TryParse(dataGridViewProductOrdering.Rows[rows].Cells[4].Value.ToString(), out quantity))
                    {
                        total_quantity += quantity;
                        total_amount += price * quantity;
                    }
                }
            }
            txtAmount.Text = total_amount.ToString();
            txtQuantity.Text = total_quantity.ToString();
        }
        
        public void reloadlistBoxPurchaseOrderOrderList()
        {
            listBoxPurchaseOrderOrderList.Items.Clear();
            try
            {
                connectingCsmsSuppDetails();
                string stm = "SELECT purchase_order_id FROM purchase_order";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxPurchaseOrderOrderList.Items.Add(rdr.GetString(0));
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
        
        private void reloadComboType()
        {
            comboType.Items.Clear();
            connectingCsmsSuppDetails();
            String stm = "Select DISTINCT type from stock";
            try
            {
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    comboType.Items.Add(rdr.GetString(0));
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
        
        private void purchase_order_editable(bool choice)
        {
            comboType.Enabled = choice;
            comboCategory.Enabled = choice;
            comboBrand.Enabled = choice;
            comboModel.Enabled = choice;
            dateTimePickerOrderDate.Enabled = choice;
            dataGridViewProductOrdering.Enabled = choice;
        }

        private void clearDataGridViewProductOrdering()
        {
            dataGridViewProductOrdering.Rows.Clear();
        }

        private void clearAllFieldsPurchaseOrder()
        {
            txtOrderID.Text = "";
            txtDealerID.Text = "";
            txtDealerName.Text = "";
            txtDealerBillID.Text = "";
            dateTimePickerOrderDate.Value = DateTime.Today;
            comboType.SelectedIndex = -1;
            comboCategory.SelectedIndex = -1;
            comboBrand.SelectedIndex = -1;
            comboModel.SelectedIndex = -1;
            txtQuantity.Text = "";
            txtAmount.Text = "";
            txtPurchaseOrderPaidAmount.Text = "";
            txtPurchaseOrderPendingAmount.Text = "";
            clearDataGridViewProductOrdering();
        }        

        private void orderIDGeneration()
        {
            String ordID = "", finalOrdID = "";
            int ordNo = 1;
            if (txtDealerID.Text != "")
            {
                connectingCsmsSuppDetails();
                try
                {
                    String stm = "SELECT purchase_order_id from purchase_order where dealer_id = '" + txtDealerID.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        rdr.Close();
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            //MessageBox.Show("Passed while");
                            ordID = rdr.GetString(0);
                            int initialIndex = txtDealerID.Text.Length + 1;
                            //MessageBox.Show("ordId = "+ordID);
                            //MessageBox.Show("initialIndex = " + initialIndex);
                            string t = ordID.Substring(initialIndex, 4);
                            //MessageBox.Show("t = " + t);
                            ordNo = int.Parse(t) + 1;
                            //MessageBox.Show("ordNo = " + ordNo);
                        }
                        finalOrdID = txtDealerID.Text + "/" + ordNo.ToString("D4");
                    }
                    else
                    {
                        finalOrdID = txtDealerID.Text + "/0001";
                    }
                    txtOrderID.Text = finalOrdID;
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

        public void connectingCsmsSuppDetails()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        private void btnSuppDetailsPrint_Click(object sender, EventArgs e)
        {
            PrintDetails pd = new PrintDetails();
            Test_GUI_for_Inventory_App.Validations.flagReport = "Supp";
            pd.pass_values_SuppID = txtSuppID.Text;
            pd.Show();
        }

        private void txtPurchaseOrderPaidAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtPurchaseOrderPendingAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }                
    }
}
