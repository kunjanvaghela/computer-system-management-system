using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Test_GUI_for_Inventory_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
                
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());                    
        }
        
    }

    

    static class Validations
    {
        public static string flagReport = "";

        public static void OnlyTextAllowed(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
            }

            else
            {
                if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                {
                }

                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                    MessageBox.Show("Only text allowed!");
                }
            }
        }

        public static void OnlyNosAllowed(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }

            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                }

                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                    MessageBox.Show("Only numbers allowed!");
                }
            }
        }

        public static void ValidateEmail(EventArgs e, TextBox txtEmail)
        {
            Regex myRegularExpression = new Regex(@"^(?!\.)[\.\w!#$%&'*+\-/=?\^_`{|}~]{1,64}(?<!\.)@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");

            if (myRegularExpression.IsMatch(txtEmail.Text))
            {

            }

            else
            {
                if (txtEmail.Text != "")
                {
                    MessageBox.Show("Invalid email");
                    txtEmail.Focus();
                    txtEmail.Clear();
                }
            }
        }
    }
}
