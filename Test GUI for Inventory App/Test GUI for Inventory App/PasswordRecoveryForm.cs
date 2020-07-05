using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace Test_GUI_for_Inventory_App
{
    public partial class PasswordRecoveryForm : Form
    {
        private string login_combo_username;

        public string pass_values
        {
            get { return login_combo_username; }
            set { login_combo_username = value; }
        }

        string MyConnectionString;
        public String uid="", email, pwd;
        MySqlConnection con;        
        MySqlDataReader rdr;    
    
        public PasswordRecoveryForm()
        {
            InitializeComponent();
        }

        private void PasswordRecoveryForm_Load(object sender, EventArgs e)
        {           
                        
        }

        public void connectingCsmsPasswordRecovery()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        private void btnSendPassword_Click(object sender, EventArgs e)
        {           
            connectingCsmsPasswordRecovery();

            string stm = "SELECT email from login where username='" + login_combo_username + "'";
            MySqlCommand cmd = new MySqlCommand(stm, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                try
                {
                    if(rdr.IsDBNull(0))
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        email = rdr.GetString(0);
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                    //throw;
                }
                
            }

            if(txtRecoveryEmail.Text==email)
            {   
                stm = "SELECT password from login where username='" + login_combo_username + "'";
                MySqlCommand cmd_pass = new MySqlCommand(stm, con);
                rdr.Close();
                rdr = cmd_pass.ExecuteReader();

                while (rdr.Read())
                {
                    pwd = rdr.GetString(0);
                }

                try
                {
                    MailMessage mail = new MailMessage("username@gmail.com", email);
                    SmtpClient client = new SmtpClient();
                    client.Port = 25;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("username@gmail.com", "password");
                    client.Host = "smtp.gmail.com";
                    mail.Subject = "Password Recovery";
                    mail.IsBodyHtml = true;
                    mail.Body = "Your Password is: <b>" + pwd + "</b> <br><br> NOTE: This is a system generated mail. Please do not 'Reply To' this mail.";
                    client.EnableSsl = true;
                    client.Send(mail);                   
                }

                catch(Exception)
                {  
                    MessageBox.Show("The mailbox you requested could not be reached.\nPlease check the id or try again later.","Sending Failure");                    
                }

                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("The recovery email id specified does not correspond to the one specified for the account.\nPlease check the id and try again");
            }
        }
    }
}
