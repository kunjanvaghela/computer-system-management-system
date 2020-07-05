using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.IO;
using System.Drawing.Imaging;

namespace Test_GUI_for_Inventory_App
{


    public partial class Payroll : Form
    {
        string MyConnectionString;
        String emp_id, name, phone1, phone2, mob1, mob2, email1, email2, address1, address2, designation, remarks, basic_salary;
        Char gender;
        DateTime dob, hiredate;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        String flag;

        public string flagReport = "1";

        private static Payroll _instance;

        public Payroll()
        {
            InitializeComponent();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            reloadListBoxEmployeeList();
            empdetails_editable(false);
            dataGridViewAttendanceShow.Rows.Add();
        }

        public Payroll instance
        {
            get
            {
                if (Payroll._instance == null)
                {
                    Payroll._instance = new Payroll();
                }
                return Payroll._instance;
            }
        }

        private void Payroll_FormClosed(object sender, FormClosedEventArgs e)
        {
            Payroll._instance = null;
        }

        /*
         * 
         * Employee Details Tab Coding
         * 
         * 
         */

        private void listBoxEmployeeList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            empdetails_editable(false);
            if (listBoxEmployeeList.SelectedIndex > -1)
            {
                String selectedValue = listBoxEmployeeList.SelectedItem.ToString();
                connectingCsmsEmpDetails();
                try
                {
                    string stm = "SELECT * FROM employee_details where name='" + selectedValue + "'";
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

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            btnEmpDetailsSave.Enabled = true;
            clearAllFields();
            empdetails_editable(true);
            flag = "Add";

            btnEmpDetailsCancel.BringToFront();
            ctrls_enabled(true);
            suppIDGeneration();
        }

        private void suppIDGeneration()
        {
            String empID = "", finalEmpID = "";
            int empNo = 1;
            connectingCsmsEmpDetails();
            try
            {
                String stm = "SELECT emp_id from employee_details;";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    rdr.Close();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        empID = rdr.GetString(0);
                        string t = empID.Substring(2, 4);
                        empNo = int.Parse(t) + 1;
                    }
                    finalEmpID = "E" + "/" + empNo.ToString("D4");
                }
                else
                {
                    finalEmpID = "E" + "/0001";
                }
                txtEmpID.Text = finalEmpID;
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

        private void btnUpdateEmpDetails_Click(object sender, EventArgs e)
        {
            if (listBoxEmployeeList.SelectedIndex > -1 || listBoxEmpDetailsSearchResults.SelectedIndex > 0)
            {
                btnEmpDetailsSave.Enabled = true;
                empdetails_editable(true);
                flag = "Update";

                btnEmpDetailsCancel.BringToFront();
                ctrls_enabled(true);
            }
        }

        private void btnRemoveEmpDetails_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != null) //((listBoxCustomerList.SelectedIndex > -1 || listBoxCustDetailsSearchResults.SelectedIndex > 0) && (txtCustID!=null))
            {
                try
                {
                    connectingCsmsEmpDetails();
                    String stm = "SELECT emp_id,name FROM employee_Details where emp_id = '" + txtEmpID.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        if (MessageBox.Show("Do you want to delete Employee with name " + rdr.GetString(1) + "?", "Delete Employee?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText = "delete from employee_details where emp_id='" + rdr.GetString(0) + "';";
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
                    reloadListBoxEmployeeList();
                    clearAllFields();
                }
            }
        }

        private void btnEmpDetailsSave_Click(object sender, EventArgs e)
        {
            if (dateTimePickerEmpDOB.Value.Date >= dateTimePickerEmpDateOfJoining.Value.Date || dateTimePickerEmpDOB.Value.Date == dateTimePickerEmpDateOfJoining.Value.Date || dateTimePickerEmpDOB.Value.Date>=System.DateTime.Now || dateTimePickerEmpDateOfJoining.Value.Date>=System.DateTime.Now)
            {
                MessageBox.Show("Please verify the dates! Date of Birth cannot be after Date of Joining or System Date or Vice-Versa.", "Error");
            }
            else
            {
                //Extracting data from fields
                emp_id = txtEmpID.Text;
                name = txtEmpName.Text;
                if (comboBoxEmpGender.Text == "Male")
                    gender = 'M';
                else if (comboBoxEmpGender.Text == "Female")
                    gender = 'F';
                else
                    gender = ' ';
                phone1 = txtEmpPhone1.Text;
                phone2 = txtEmpPhone2.Text;
                mob1 = txtEmpMobile1.Text;
                mob2 = txtEmpMobile2.Text;
                email1 = txtEmpEmail1.Text;
                email2 = txtEmpEmail2.Text;
                address1 = txtEmpResidenceAddress.Text;
                address2 = txtEmpPermanentAddress.Text;
                dob = dateTimePickerEmpDOB.Value.Date;
                hiredate = dateTimePickerEmpDateOfJoining.Value.Date;
                designation = txtEmpDesignation.Text;
                remarks = txtEmpRemarks.Text;
                basic_salary = txtEmpBasicSalary.Text;

                //Inserting data
                connectingCsmsEmpDetails();
                try
                {
                    MemoryStream memoryStream = new MemoryStream();
                    byte[] imageBt;
                    if (pictureBoxEmpPhoto.Image != null)
                    {
                        Image image = pictureBoxEmpPhoto.Image;
                        image.Save(memoryStream, ImageFormat.Png);
                    }
                    imageBt = memoryStream.ToArray();

                    cmd = con.CreateCommand();
                    if (flag.Equals("Add"))
                    {
                        cmd.CommandText = "insert into employee_details values(@emp_id,@name,@gender,@add1,@add2,@ph1,@ph2,@mob1,@mob2,@dob,@hiredate,@designation,@remarks,@email1,@email2,@basic_salary,@image)";
                    }
                    else if (flag.Equals("Update"))
                    {
                        cmd.CommandText = "UPDATE employee_details SET name=@name,gender=@gender,address1=@add1,address2=@add2,phone1=@ph1,phone2=@ph2,mob1=@mob1,mob2=@mob2,dob=@dob,hiredate=@hiredate,designation=@designation,remarks=@remarks,email1=@email1,email2=@email2,basic_salary=@basic_salary, image=@image WHERE emp_id = @emp_id";
                    }
                    cmd.Parameters.AddWithValue("@emp_id", emp_id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@add1", address1);
                    cmd.Parameters.AddWithValue("@add2", address2);
                    cmd.Parameters.AddWithValue("@ph1", phone1);
                    cmd.Parameters.AddWithValue("@ph2", phone2);
                    cmd.Parameters.AddWithValue("@mob1", mob1);
                    cmd.Parameters.AddWithValue("@mob2", mob2);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@hiredate", hiredate);
                    cmd.Parameters.AddWithValue("@designation", designation);
                    cmd.Parameters.AddWithValue("@remarks", remarks);
                    cmd.Parameters.AddWithValue("@email1", email1);
                    cmd.Parameters.AddWithValue("@email2", email2);
                    cmd.Parameters.AddWithValue("@basic_salary", basic_salary);
                    cmd.Parameters.AddWithValue("@image", imageBt);
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
                    reloadListBoxEmployeeList();
                }

                empdetails_editable(false);

                ctrls_enabled(false);
                btnEmpDetailsCancel.SendToBack();
            }
        }

        private void btnEmpDetailsClear_Click_1(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void btnEmpDetailsCancel_Click(object sender, EventArgs e)
        {
            clearAllFields();
            empdetails_editable(false);
            ctrls_enabled(false);
            btnEmpDetailsCancel.SendToBack();
        }

        private void btnEmpDetailsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmpAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogEmpPhotoUpload.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";
            
            if (openFileDialogEmpPhotoUpload.ShowDialog() == DialogResult.OK)
            {                
                var img = new Bitmap(openFileDialogEmpPhotoUpload.FileName);
                System.IO.FileInfo file = new System.IO.FileInfo(openFileDialogEmpPhotoUpload.FileName);

                if (img.Width > 500 || img.Height > 500)
                {
                    MessageBox.Show("The image should not be more than 500x500 in resolution","Error");
                }
                else
                {
                    pictureBoxEmpPhoto.Image = new Bitmap(openFileDialogEmpPhotoUpload.FileName);
                    pictureBoxEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnEmpRemovePhoto_Click(object sender, EventArgs e)
        {
            pictureBoxEmpPhoto.Image = Test_GUI_for_Inventory_App.Properties.Resources._1__160_;
            pictureBoxEmpPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }        

        private void btnEmpDetailsSearch_Click(object sender, EventArgs e)
        {
            listBoxEmpDetailsSearchResults.Items.Clear();
            if (comboBoxEmpDetailsSearchBy.SelectedIndex > -1)
            {
                string stm;
                if (comboBoxEmpDetailsSearchBy.SelectedItem.ToString() == "ID")
                {
                    stm = "SELECT emp_id FROM employee_details where emp_id like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on ID:");
                }
                else if (comboBoxEmpDetailsSearchBy.SelectedItem.ToString() == "Name")
                {
                    stm = "SELECT name FROM employee_details where name like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on Name:");
                }
                else if (comboBoxEmpDetailsSearchBy.SelectedItem.ToString() == "Phone 1")
                {
                    stm = "SELECT phone1 FROM employee_details where phone1 like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on Phone 1:");
                }
                else if (comboBoxEmpDetailsSearchBy.SelectedItem.ToString() == "Phone 2")
                {
                    stm = "SELECT phone2 FROM employee_details where phone2 like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on Phone 2:");
                }
                else if (comboBoxEmpDetailsSearchBy.SelectedItem.ToString() == "Mobile 1")
                {
                    stm = "SELECT mob1 FROM employee_details where mob1 like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on Mobile 1:");
                }
                else if (comboBoxEmpDetailsSearchBy.SelectedItem.ToString() == "Mobile 2")
                {
                    stm = "SELECT mob2 FROM employee_details where mob2 like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on Mobile 2:");
                }
                else if (comboBoxEmpDetailsSearchBy.SelectedItem.ToString() == "Email 1")
                {
                    stm = "SELECT email1 FROM employee_details where email1 like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on Email 1:");
                }
                else // if (comboBoxCustDetailsSearchBy.SelectedItem == "Email 2")
                {
                    stm = "SELECT email2 FROM employee_details where email2 like '%" + txtEmpDetailsSearchKeywords.Text + "%'";
                    listBoxEmpDetailsSearchResults.Items.Add("Based on Email 2:");
                }
                try
                {
                    connectingCsmsEmpDetails();
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listBoxEmpDetailsSearchResults.Items.Add(rdr.GetString(0));
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

        private void listBoxEmpDetailsSearchResults_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            empdetails_editable(false);
            if (listBoxEmpDetailsSearchResults.SelectedIndex > 0)
            {
                String selectedValue = listBoxEmpDetailsSearchResults.SelectedItem.ToString();
                String stm;
                connectingCsmsEmpDetails();
                if (listBoxEmpDetailsSearchResults.Items[0].ToString() == "Based on ID:")
                {
                    stm = "SELECT * FROM employee_details where emp_id = '" + selectedValue + "'";
                }
                else if (listBoxEmpDetailsSearchResults.Items[0].ToString() == "Based on Name:")
                {
                    stm = "SELECT * FROM employee_details where name = '" + selectedValue + "'";
                }
                else if (listBoxEmpDetailsSearchResults.Items[0].ToString() == "Based on Phone 1:")
                {
                    stm = "SELECT * FROM employee_details where phone1 = '" + selectedValue + "'";
                }
                else if (listBoxEmpDetailsSearchResults.Items[0].ToString() == "Based on Phone 2:")
                {
                    stm = "SELECT * FROM employee_details where phone2 = '" + selectedValue + "'";
                }
                else if (listBoxEmpDetailsSearchResults.Items[0].ToString() == "Based on Mobile 1:")
                {
                    stm = "SELECT * FROM employee_details where mob1 = '" + selectedValue + "'";
                }
                else if (listBoxEmpDetailsSearchResults.Items[0].ToString() == "Based on Mobile 2:")
                {
                    stm = "SELECT * FROM employee_details where mob2 = '" + selectedValue + "'";
                }
                else if (listBoxEmpDetailsSearchResults.Items[0].ToString() == "Based on Email 1:")
                {
                    stm = "SELECT * FROM employee_details where email1 = '" + selectedValue + "'";
                }
                else //if (listBoxCustDetailsSearchResults.Items[0].ToString() == "Based on Email 2:")
                {
                    stm = "SELECT * FROM employee_details where email2 = '" + selectedValue + "'";
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

        public void reloadListBoxEmployeeList()
        {
            listBoxEmployeeList.Items.Clear();
            listBoxAttendanceEmp.Items.Clear();
            listBoxPayrollEmployeeList.Items.Clear();
            try
            {
                connectingCsmsEmpDetails();
                string stm = "SELECT name FROM employee_details";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    listBoxEmployeeList.Items.Add(rdr.GetString(0));
                    listBoxAttendanceEmp.Items.Add(rdr.GetString(0));
                    listBoxPayrollEmployeeList.Items.Add(rdr.GetString(0));
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
                txtEmpID.Text = rdr.GetString(0);
                txtEmpName.Text = rdr.GetString(1);
                if (rdr.GetChar(2) == 'M')
                    comboBoxEmpGender.Text = "Male";
                else if (rdr.GetChar(2) == 'F')
                    comboBoxEmpGender.Text = "Female";
                else
                    comboBoxEmpGender.Text = "";
                txtEmpResidenceAddress.Text = rdr.GetString(3);
                txtEmpPermanentAddress.Text = rdr.GetString(4);
                txtEmpPhone1.Text = rdr.GetString(5);
                txtEmpPhone2.Text = rdr.GetString(6);
                txtEmpMobile1.Text = rdr.GetString(7);
                txtEmpMobile2.Text = rdr.GetString(8);
                dateTimePickerEmpDOB.Value = rdr.GetDateTime(9);
                dateTimePickerEmpDateOfJoining.Value = rdr.GetDateTime(10);
                txtEmpDesignation.Text = rdr.GetString(11);
                txtEmpRemarks.Text = rdr.GetString(12);
                txtEmpEmail1.Text = rdr.GetString(13);
                txtEmpEmail2.Text = rdr.GetString(14);
                txtEmpBasicSalary.Text = rdr.GetString(15);
                byte[] blob = (byte[])rdr[16];
                if (blob.Length > 0)
                {
                    Bitmap bm = ByteToImage(blob);
                    pictureBoxEmpPhoto.Image = bm;
                }
                else
                {
                    pictureBoxEmpPhoto.Image = null;
                }
            }
        }
        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void empdetails_editable(bool choice)
        {
            choice = !choice;
            //txtEmpID.ReadOnly = choice;
            txtEmpName.ReadOnly = choice;
            comboBoxEmpGender.Enabled = !choice;
            txtEmpPhone1.ReadOnly = choice;
            txtEmpPhone2.ReadOnly = choice;
            txtEmpMobile1.ReadOnly = choice;
            txtEmpMobile2.ReadOnly = choice;
            txtEmpEmail1.ReadOnly = choice;
            txtEmpEmail2.ReadOnly = choice;
            txtEmpResidenceAddress.ReadOnly = choice;
            txtEmpPermanentAddress.ReadOnly = choice;
            dateTimePickerEmpDOB.Enabled = !choice;
            txtEmpBasicSalary.ReadOnly = choice;
            dateTimePickerEmpDateOfJoining.Enabled = !choice;
            txtEmpDesignation.ReadOnly = choice;
            txtEmpRemarks.ReadOnly = choice;
        }

        private void clearAllFields()
        {
            txtEmpID.Text = "";
            txtEmpName.Text = "";
            txtEmpResidenceAddress.Text = "";
            txtEmpPermanentAddress.Text = "";
            txtEmpPhone1.Text = "";
            txtEmpPhone2.Text = "";
            txtEmpMobile1.Text = "";
            txtEmpMobile2.Text = "";
            comboBoxEmpGender.SelectedIndex = 0;
            txtEmpEmail1.Text = "";
            txtEmpEmail2.Text = "";
            dateTimePickerEmpDOB.Value = DateTime.Now;
            dateTimePickerEmpDateOfJoining.Value = DateTime.Now;
            txtEmpDesignation.Text = "";
            txtEmpRemarks.Text = "";
            pictureBoxEmpPhoto.Image = Test_GUI_for_Inventory_App.Properties.Resources._1__160_;
        }
        
        private void ctrls_enabled(bool choice)
        {
            tableLayoutPanelEmpDisplay.Enabled = !choice;
            tableLayoutPanelEmpPhotoCtrls.Enabled = choice;
            tableLayoutPanelSearchCtrls.Enabled = !choice;
                        
            btnEmpDetailsCancel.Enabled = choice;
            btnEmpDetailsClose.Enabled = !choice;
            btnEmpDetailsClear.Enabled = choice;
            btnEmpDetailsSave.Enabled = choice;
        }

        private void txtEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyTextAllowed(e);
        }

        private void txtEmpPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtEmpPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtEmpMobile1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtEmpMobile2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtEmpEmail1_Leave(object sender, EventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.ValidateEmail(e, txtEmpEmail1);
        }

        private void txtEmpEmail2_Leave(object sender, EventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.ValidateEmail(e, txtEmpEmail2);
        }

        private void txtEmpBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }        
           
        public void connectingCsmsEmpDetails()
        {
            MyConnectionString = "Server=localhost;Database=csms;Uid=corpinfo;Pwd=kvvk;";
            con = new MySqlConnection(MyConnectionString);
            con.Open();
        }

        //Muster Codes

        private void listBoxAttendanceEmp_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAttendanceEmp.SelectedIndex > -1)
            {
                try
                {
                    connectingCsmsEmpDetails();
                    String stm = "SELECT emp_id from employee_details where name = '" + listBoxAttendanceEmp.SelectedItem.ToString() + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        txtAttendanceEmpID.Text = rdr.GetString(0);
                    }
                    rdr.Close();
                }
                catch(Exception)
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
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            if (dateTimePickerAttendanceDate.Value.Date >= System.DateTime.Now)
            {
                MessageBox.Show("Date ahead of System Date", "Error");
            }
            else
            {
                if (txtAttendanceEmpID.Text != "")
                {
                    try
                    {
                        String da = dateTimePickerAttendanceDate.Value.Date.ToString("yyyy-MM-dd");
                        connectingCsmsEmpDetails();
                        String stm = "SELECT emp_id,date,attendance_id from attendance where emp_id = '" + txtAttendanceEmpID.Text + "';";
                        MySqlCommand cmd = new MySqlCommand(stm, con);
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            if (da.Equals(rdr.GetString(1)))
                            {
                                String attId = rdr.GetString(2);
                                rdr.Close();
                                DialogResult dialogResult = MessageBox.Show("Attendance already marked. Do you want to update?", "Already Marked", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    cmd = con.CreateCommand();
                                    cmd.CommandText = "UPDATE attendance SET reporting_time=@reporting_time, present_absent=@present_absent,leaving_time=@leaving_time WHERE attendance_id=@attID;";
                                    cmd.Parameters.AddWithValue("@attID", attId);
                                    cmd.Parameters.AddWithValue("@reporting_time", txtAttendanceReportingTime.Text);
                                    cmd.Parameters.AddWithValue("@present_absent", comboBoxAttendance.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@leaving_time", txtAttendanceLeavingTime.Text);
                                    cmd.ExecuteNonQuery();
                                    return;
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    return;
                                }
                            }
                        }
                        rdr.Close();
                        cmd = con.CreateCommand();
                        cmd.CommandText = "INSERT into attendance(emp_id,date,reporting_time,present_absent,leaving_time) values(@emp_id,@date,@reporting_time,@present_absent,@leaving_time);";
                        cmd.Parameters.AddWithValue("@emp_id", txtAttendanceEmpID.Text);
                        cmd.Parameters.AddWithValue("@date", da);
                        cmd.Parameters.AddWithValue("@reporting_time", txtAttendanceReportingTime.Text);
                        cmd.Parameters.AddWithValue("@present_absent", comboBoxAttendance.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@leaving_time", txtAttendanceLeavingTime.Text);
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
                    }
                }
            }
        }

        private void btnAnalyzeAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewAttendanceShow.Rows.Clear();
                dataGridViewAttendanceShow.Rows.Add();
                connectingCsmsEmpDetails();
                String stm = "SELECT * from attendance where date = '" + dateTimePickerAttendanceDate.Value.Date.ToString("yyyy-MM-dd") + "';";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                cmd = new MySqlCommand(stm, con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewAttendanceShow.Rows[0].Clone();
                    row.Cells[0].Value = rdr.GetString(1);
                    row.Cells[1].Value = rdr.GetString(2);
                    row.Cells[2].Value = rdr.GetString(3);
                    row.Cells[3].Value = rdr.GetString(5);
                    row.Cells[4].Value = rdr.GetString(4);
                    dataGridViewAttendanceShow.Rows.Add(row);
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

        //Payroll

        private void listBoxPayrollEmployeeList_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPayrollEmployeeList.SelectedIndex > -1)
            {
                emptyPayrollFields(); 
                try
                {
                    comboBoxPayrollYear.Items.Clear();
                    DateTime payrollHireDate;
                    connectingCsmsEmpDetails();
                    String stm = "SELECT emp_id, name, gender, mob1, designation, basic_salary, hiredate from employee_details where name = '" + listBoxPayrollEmployeeList.SelectedItem.ToString() + "';";
                    MySqlCommand cmd = new MySqlCommand(stm, con);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        txtPayrollEmpID.Text = rdr.GetString(0);
                        txtPayrollEmpName.Text = rdr.GetString(1);
                        txtPayrollGender.Text = rdr.GetString(2);
                        txtPayrollMob.Text = rdr.GetString(3);
                        txtPayrollDesignation.Text = rdr.GetString(4);
                        txtPayrollBasicSalary.Text = rdr.GetString(5);
                        payrollHireDate = rdr.GetDateTime(6);
                        int f = payrollHireDate.Year;
                        while(f<=DateTime.Today.Year)
                        {
                            comboBoxPayrollYear.Items.Add(f);
                            f++;
                        }
                    }
                    rdr.Close();
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

        private void btnPayrollCalculate_Click(object sender, EventArgs e)
        {
            if(txtPayrollBasicSalary.Text!="")
            {
                txtPayrollTotalSalary.Text=txtPayrollBasicSalary.Text;
                if(txtPayrollDeduction.Text!="")
                {
                    txtPayrollTotalSalary.Text = Convert.ToString(Int32.Parse(txtPayrollTotalSalary.Text) - Int32.Parse(txtPayrollDeduction.Text));
                }
                if (txtPayrollCommission.Text != "")
                {
                    txtPayrollTotalSalary.Text = Convert.ToString(Int32.Parse(txtPayrollTotalSalary.Text) + Int32.Parse(txtPayrollCommission.Text));
                }
            }
        }

        private void btnPayrollSave_Click(object sender, EventArgs e)
        {
            if(txtPayrollEmpID.Text!="")
            {
                connectingCsmsEmpDetails();
                try
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT into payroll(emp_id,year,month,leaves_taken,leaves_allowed,commission,deduction,total_salary,payment_Status) values(@emp_id,@year,@month,@leaves_taken,@leaves_allowed,@commission,@deduction,@total_salary,@payment_Status)";
                    cmd.Parameters.AddWithValue("@emp_id", txtPayrollEmpID.Text);
                    cmd.Parameters.AddWithValue("@year", comboBoxPayrollYear.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@month", comboBoxPayrollMonth.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@leaves_taken", txtPayrollLeavesTaken.Text);
                    cmd.Parameters.AddWithValue("@leaves_allowed", comboBoxPayrollLeavesAllowed.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@commission", txtPayrollCommission.Text);
                    cmd.Parameters.AddWithValue("@deduction", txtPayrollDeduction.Text);
                    cmd.Parameters.AddWithValue("@total_salary", txtPayrollTotalSalary.Text);
                    cmd.Parameters.AddWithValue("@payment_Status", comboBoxPaymentStatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    emptyPayrollFields();
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

        private void emptyPayrollFields()
        {
            txtPayrollEmpID.Text = "";
            txtPayrollEmpName.Text = "";
            txtPayrollGender.Text = "";
            txtPayrollMob.Text = "";
            txtPayrollDesignation.Text = "";
            comboBoxPayrollYear.SelectedIndex = -1;
            comboBoxPayrollMonth.SelectedIndex = -1;
            txtPayrollLeavesTaken.Text = "";
            comboBoxPayrollLeavesAllowed.SelectedIndex = 0;
            txtPayrollCommission.Text = "";
            txtPayrollDeduction.Text = "";
            txtPayrollTotalSalary.Text = "";
            comboBoxPaymentStatus.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDetails pd = new PrintDetails();
            Test_GUI_for_Inventory_App.Validations.flagReport = "Emp";
            pd.pass_values_EmpID = txtEmpID.Text;           
            pd.Show();           

        }

        private void txtPayrollCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }

        private void txtPayrollDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            Test_GUI_for_Inventory_App.Validations.OnlyNosAllowed(e);
        }
    }
}
