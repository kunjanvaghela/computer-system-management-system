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
    public partial class Billing : Form
    {
        private static Billing _instance;
        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        public Billing instance
        {
            get
            {
                if (Billing._instance == null)
                {
                    Billing._instance = new Billing();
                }
                return Billing._instance;
            }
        }

        private void Billing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Billing._instance = null;
        }
    }
}
