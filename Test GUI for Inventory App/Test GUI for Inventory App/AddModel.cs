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
    public partial class AddModel : Form
    {
        String MyConnectionString;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader rdr;

        private static AddModel _instance;

        public AddModel()
        {
            InitializeComponent();
        }

        public AddModel instance
        {
            get
            {
                if (AddModel._instance == null)
                {
                    AddModel._instance = new AddModel();
                }
                return AddModel._instance;
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (txtModelName.Text != "")
            {
                String ModelName = txtModelName.Text;
                String Brand = txtModelBrand.Text;
                String Type = (String)comboModelType.SelectedItem;
                String Category = (String)comboModelCategory.SelectedItem;
                String Price = txtModelPrice.Text;
                String Warranty = txtModelWarranty.Text;
                String Remarks = txtModelRemarks.Text;

                try
                {
                    connectingCsmsCustDetails();
                    String stm = "SELECT model_id FROM stock where model_id = '" + ModelName + "'";
                    cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        MessageBox.Show("This Model already exists in database.");
                        rdr.Close();
                    }
                    else
                    {
                        rdr.Close();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "insert into stock values(@model_id,@brand,@type,@category,@warr,@price,@quantity,@remarks)";
                        cmd.Parameters.AddWithValue("@model_id", ModelName);
                        cmd.Parameters.AddWithValue("@brand", Brand);
                        cmd.Parameters.AddWithValue("@type", Type);
                        cmd.Parameters.AddWithValue("@category", Category);
                        cmd.Parameters.AddWithValue("@warr", Warranty);
                        cmd.Parameters.AddWithValue("@price", Price);
                        cmd.Parameters.AddWithValue("@quantity", '0');
                        cmd.Parameters.AddWithValue("@remarks", Remarks);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully!");
                        clearAll();
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
            else
            {
                MessageBox.Show("Add Model Name");
            }
        }

        public void connectingCsmsCustDetails()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        public void clearAll()
        {
            txtModelName.Text = "";
            txtModelBrand.Text = "";
            comboModelType.SelectedIndex = 0;
            comboModelCategory.SelectedIndex = 0;
            txtModelPrice.Text = "";
            txtModelWarranty.Text = "";
            txtModelRemarks.Text = "";
        }

        private void txtModelPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void AddModel_Load(object sender, EventArgs e)
        {

        }

    }
}
