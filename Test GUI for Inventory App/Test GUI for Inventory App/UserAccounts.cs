using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test_GUI_for_Inventory_App
{
    public partial class UserAccounts : Form
    {        
        String MyConnectionString;
        String username, password, email;
        char privilege;
        String flag;
        int f;
        MySqlConnection con;
        //MySqlCommand cmd;
        MySqlDataReader rdr;        

        private static UserAccounts _instance;
        
        public UserAccounts()
        {
            InitializeComponent();
        }

        private void UserAccounts_Load(object sender, EventArgs e)
        {
            reloadListBoxUserAcc();            
            useraccdetails_editable(false);            
            flag = "";
            f = 0;
        }

        public UserAccounts instance
        {
            get
            {
                if (UserAccounts._instance == null)
                {
                    UserAccounts._instance = new UserAccounts();
                }
                return UserAccounts._instance;
            }
        }

        private void UserAccounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserAccounts._instance = null;
        }

        private void listBoxUserAccList_SelectedIndexChanged(object sender, EventArgs e)
        {
            useraccdetails_editable(false);
            if (listBoxUserAccList.SelectedIndex > -1)
            {
                String selectedValue = listBoxUserAccList.SelectedItem.ToString();
                connectingCsmsUserAccDetails();
                try
                {
                    string stm = "SELECT * FROM login where username='" + selectedValue + "'";
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btnUserAccSave.Enabled = true;
            clearAllFieldsUserAccDetails();
            useraccdetails_editable(true);
            flag = "Add";

            ctrls_enabled(true);
        }

        private void btnUpdateUserDetails_Click(object sender, EventArgs e)
        {
            if (listBoxUserAccList.SelectedIndex > -1)
            {
                btnUserAccSave.Enabled = true;
                useraccdetails_editable(true);
                flag = "Update";

                ctrls_enabled(true);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != null) //((listBoxCustomerList.SelectedIndex > -1 || listBoxCustDetailsSearchResults.SelectedIndex > 0) && (txtCustID!=null))
            {
                try
                {
                    connectingCsmsUserAccDetails();
                    String stm = "SELECT privilege FROM login where username != '" + txtUserName.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetString(0).Equals("Y"))
                        {
                            f++;
                        }
                    }
                    if (f == 0)
                    {
                        MessageBox.Show("No other account with all the privilege. Please allow atleast one account with all the privilege");
                        checkBoxUserPrivilegeLtd.Checked = false;
                        reloadListBoxUserAcc();
                        useraccdetails_editable(false);
                        btnUserAccSave.Enabled = false;
                        ctrls_enabled(false);
                        return;
                    }
                    rdr.Close();

                    stm = "SELECT username FROM login where username = '" + txtUserName.Text + "'";
                    cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (MessageBox.Show("Do you want to delete User with name " + rdr.GetString(0) + "?", "Delete User?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {                            
                            if (listBoxUserAccList.Items.Count == 1)
                            {
                                MessageBox.Show("Cannot delete the only account present!", "Error");
                            }
                            else
                            {
                                cmd = con.CreateCommand();
                                cmd.CommandText = "delete from login where username='" + rdr.GetString(0) + "';";
                                rdr.Close();
                                cmd.ExecuteNonQuery();
                            }
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
                    reloadListBoxUserAcc();
                    clearAllFieldsUserAccDetails();
                }            
            }
        
        }

        private void btnUserAccSave_Click(object sender, EventArgs e)
        {
            //Extracting data from fields
            
            username = txtUserName.Text;
            password = txtUserPassword.Text;
            email = txtRecoveryEmail.Text;

            if (checkBoxUserPrivilegeLtd.Checked == true)
                privilege = 'N';
            else
                privilege = 'Y';

            //Inserting data
            connectingCsmsUserAccDetails();
            try
            {
                String stm = "SELECT privilege FROM login where username != '"+ txtUserName.Text +"';";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    if(rdr.GetString(0).Equals("Y"))
                    {
                        f++;
                    }
                }
                if(f==0 && checkBoxUserPrivilegeLtd.Checked==true)
                {
                    MessageBox.Show("No other account with all the privilege. Please allow atleast one account with all the privilege");
                    checkBoxUserPrivilegeLtd.Checked = false;
                    reloadListBoxUserAcc();
                    useraccdetails_editable(false);
                    btnUserAccSave.Enabled = false;
                    ctrls_enabled(false);
                    return;
                }
                rdr.Close();
                cmd = con.CreateCommand();
                if (flag.Equals("Add"))
                {
                    cmd.CommandText = "insert into login values(@username, @password, @email,@privilege)";
                }
                else if (flag.Equals("Update"))
                {
                    cmd.CommandText = "UPDATE login SET username=@username, password=@password, email=@email, privilege=@privilege WHERE username = @username";
                }
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@privilege", privilege);   
                cmd.ExecuteNonQuery();
                f = 0;
                MessageBox.Show("User updated!");
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
                reloadListBoxUserAcc();
            }
            useraccdetails_editable(false);
            btnUserAccSave.Enabled = false;

            ctrls_enabled(false);
        }

        private void btnUserAccClear_Click(object sender, EventArgs e)
        {
            clearAllFieldsUserAccDetails();
        }

        private void btnUserAccCancel_Click(object sender, EventArgs e)
        {
            clearAllFieldsUserAccDetails();
            useraccdetails_editable(false);
            ctrls_enabled(false);
        }

        private void btnUserAccClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void reloadListBoxUserAcc()
        {
            listBoxUserAccList.Items.Clear();            
            try
            {
                connectingCsmsUserAccDetails();
                string stm = "SELECT username FROM login";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxUserAccList.Items.Add(rdr.GetString(0));                    
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
                txtUserName.Text = rdr.GetString(0);
                txtUserPassword.Text = rdr.GetString(1);
                txtRecoveryEmail.Text = rdr.GetString(2);
                if (rdr.GetChar(3) == 'N')
                    checkBoxUserPrivilegeLtd.Checked = true;
                else
                    checkBoxUserPrivilegeLtd.Checked = false;
            }
        }

        private void useraccdetails_editable(bool choice)
        {            
            txtUserName.ReadOnly = !choice;            
            txtUserPassword.ReadOnly = !choice;
            txtRecoveryEmail.ReadOnly = !choice;
            checkBoxUserPrivilegeLtd.Enabled = choice;
        }

        private void clearAllFieldsUserAccDetails()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtRecoveryEmail.Text = "";            
        }

        private void ctrls_enabled(bool choice)
        {
            tableLayoutPanelUserAccDisplay.Enabled = !choice;            

            btnUserAccCancel.Enabled = choice;
            btnUserAccClose.Enabled = !choice;
            btnUserAccClear.Enabled = choice;
            btnUserAccSave.Enabled = choice;
        }

        private void txtRecoveryEmail_Leave(object sender, EventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.ValidateEmail(e, txtRecoveryEmail);
        }        

        public void connectingCsmsUserAccDetails()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }        
    }
}
