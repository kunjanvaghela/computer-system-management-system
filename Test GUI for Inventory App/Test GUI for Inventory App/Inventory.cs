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
    public partial class Inventory : Form
    {
        private static Inventory _instance;
        MySqlConnection con;
        //MySqlCommand cmd;
        MySqlDataReader rdr;
        String MyConnectionString;

        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            loadInventory();
        }

        public Inventory instance
        {
            get
            {
                if (Inventory._instance == null)
                {
                    Inventory._instance = new Inventory();
                }
                return Inventory._instance;
            }
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inventory._instance = null;
        }

        private void loadInventory()
        {
            try
            {
                dataGridViewInventory.Rows.Clear();
                connectingCsmsInventory();
                String stm = "SELECT * from stock;";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewInventory.Rows[0].Clone();
                    row.Cells[0].Value = rdr.GetString(0);
                    row.Cells[1].Value = rdr.GetString(1);
                    row.Cells[2].Value = rdr.GetString(2);
                    row.Cells[3].Value = rdr.GetString(3);
                    row.Cells[4].Value = rdr.GetString(5);
                    row.Cells[5].Value = rdr.GetString(6);
                    row.Cells[6].Value = rdr.GetString(4);
                    dataGridViewInventory.Rows.Add(row);
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
        public void connectingCsmsInventory()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        private void dataGridViewInventory_DoubleClick(object sender, EventArgs e)
        {
            loadInventory();
        }
    }
}
