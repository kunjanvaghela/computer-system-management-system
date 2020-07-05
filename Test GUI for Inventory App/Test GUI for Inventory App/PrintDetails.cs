using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace Test_GUI_for_Inventory_App
{
    public partial class PrintDetails : Form
    {
        private string payroll_emp_id;        

        public string pass_values_EmpID
        {        
            get { return payroll_emp_id; }
            set { payroll_emp_id = value; }
        }                

        private string customer_cust_id;
        
        public string pass_values_CustID
        {
            get { return customer_cust_id; }
            set { customer_cust_id = value; }
        }

        private string supplier_supp_id;

        public string pass_values_SuppID
        {
            get { return supplier_supp_id; }
            set { supplier_supp_id = value; }
        }

        private string bill_order_id;

        public string pass_values_OrderID
        {
            get { return bill_order_id; }
            set { bill_order_id = value; }
        }

        public PrintDetails()
        {
            InitializeComponent();
        }

        private void PrintDetails_Load(object sender, EventArgs e)
        {
            Payroll pr = new Payroll();
            Customer cr = new Customer();

            string MyConnectionString;
            MySqlConnection con;
            //MySqlDataReader rdr;

            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();


            if (Test_GUI_for_Inventory_App.Validations.flagReport=="Emp")
            {
                string stm = "SELECT * from employee_details where emp_id='" + payroll_emp_id + "'";
                MySqlCommand cmd = new MySqlCommand(stm, con);


                //csmsDataSet ds = new csmsDataSet();

                DataSet ds = new DataSet();

                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();

                myDataAdapter.SelectCommand = cmd;

                myDataAdapter.Fill(ds, "employee_details");


                //ds.Fill(ds, "Product");
                //MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
                //con.Close();



                EmpDetailsPrint objRpt = new EmpDetailsPrint();
                objRpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }

            else if (Test_GUI_for_Inventory_App.Validations.flagReport == "Cust")
            {
                string stm = "SELECT * from cust_details where cust_id='" + customer_cust_id + "'";
                MySqlCommand cmd = new MySqlCommand(stm, con);


                //csmsDataSet ds = new csmsDataSet();

                DataSet ds = new DataSet();

                MySqlDataAdapter myDataAdapterCust = new MySqlDataAdapter();

                myDataAdapterCust.SelectCommand = cmd;

                myDataAdapterCust.Fill(ds, "cust_details");


                //ds.Fill(ds, "Product");
                //MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
                //con.Close();



                CustDetailsPrint objRpt = new CustDetailsPrint();
                objRpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }

            else if (Test_GUI_for_Inventory_App.Validations.flagReport == "Supp")
            {
                string stm = "SELECT * from dealer_details where dealer_id='" + supplier_supp_id + "'";
                MySqlCommand cmd = new MySqlCommand(stm, con);


                //csmsDataSet ds = new csmsDataSet();

                DataSet ds = new DataSet();

                MySqlDataAdapter myDataAdapterCust = new MySqlDataAdapter();

                myDataAdapterCust.SelectCommand = cmd;

                myDataAdapterCust.Fill(ds, "dealer_details");


                //ds.Fill(ds, "Product");
                //MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
                //con.Close();



                SuppDetailsPrint objRpt = new SuppDetailsPrint();
                objRpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }

            else if (Test_GUI_for_Inventory_App.Validations.flagReport == "Bill")
            {
                //string stm = "SELECT a.model_id, a.amount, a.quantity, b.total_amount from sale_item a, cust_bill b where a.sale_order_id=b.sale_order_id and a.sale_order_id='" + bill_order_id + "'";
                string stm = "SELECT model_id, amount, quantity, sale_order_id from sale_item where sale_order_id='" + bill_order_id + "'";
                MySqlCommand cmd = new MySqlCommand(stm, con);


                //csmsDataSet ds = new csmsDataSet();

                DataSet ds = new DataSet();
                //DataSet ds1 = new DataSet();

                MySqlDataAdapter myDataAdapterCust = new MySqlDataAdapter();

                myDataAdapterCust.SelectCommand = cmd;

                myDataAdapterCust.Fill(ds, "sale_item");
                //myDataAdapterCust.Fill(ds1, "cust_bill");

                //ds.Fill(ds, "Product");
                //MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
                //con.Close();



                Invoice objRpt = new Invoice();
                objRpt.SetDataSource(ds);
                //objRpt.SetDataSource(ds1);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }

        }
    }
}
