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
    public partial class LoginForm : Form
    {
                
        string MyConnectionString;        
        string pwd;
        public string privilege;
        MySqlConnection con;        
        MySqlDataReader rdr;
     
        public int flag = 0;
        public string access = "";
      
        public LoginForm()
        {
            InitializeComponent();            
        }

        public void connectingCsmsLoginDetails()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        public void reloadComboBoxUserList()
        {            
            try
            {
                connectingCsmsLoginDetails();
                string stm = "SELECT username FROM login";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    comboUserName.Items.Add(rdr.GetString(0));                    
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connectingCsmsLoginDetails();

                string stm = "SELECT password, privilege FROM login where username='" + comboUserName.Text + "'";                               

                MySqlCommand cmd = new MySqlCommand(stm, con);
                
                rdr = cmd.ExecuteReader();
                
                if (comboUserName.Text == "")
                {
                    MessageBox.Show("Select a username!");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter a password!");
                }
                else
                {
                    while (rdr.Read())
                    {
                        pwd = rdr.GetString(0);
                        access = rdr.GetString(1);
                        if (txtPassword.Text == pwd)
                        {
                            flag = 1;
                            privilege = access;
                            this.Close();
                        }
                        else
                        {
                            flag = 0;
                            MessageBox.Show("Invalid Username or Password", "Login Error");
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }                                                
                    }
                }
            }

            catch(Exception)
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            reloadComboBoxUserList();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              
        private void linkLblForgotPassword_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboUserName.Text == "")
            {
                MessageBox.Show("Select a username!");
            }
            else
            {
                PasswordRecoveryForm pass_recovery = new PasswordRecoveryForm();
                pass_recovery.pass_values = comboUserName.Text;
                pass_recovery.ShowDialog();
            }
        }

        private void txtPassword_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin.PerformClick();
            }            
        }
    }
}
