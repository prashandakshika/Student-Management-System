using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class registrationForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        string gender_fm;

        public registrationForm()
        {
            //To Connect database
            conn.ConnectionString = @"Data Source=DESKTOP-QC2QNN5\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
            InitializeComponent();
        }

        private void lnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void btnRegExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check whether there have value in textboxes
            if (combStdID.Text == "")
            {
                MessageBox.Show("Haven't found data to delete!" , "Delete" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //check whether user wants to delete the record or not
                    DialogResult result = MessageBox.Show("Are you sure, Do you really want to delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //Delete a record according to Registration table
                        string del_Query = "DELETE FROM Registration WHERE studentID = '" + combStdID.Text + "'";
                        SqlCommand dcomm = new SqlCommand(del_Query, conn);
                        conn.Open();
                        dcomm.ExecuteNonQuery(); //Execute the code
                        MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) //When there is an error, this used to display that error
                {
                    MessageBox.Show("Error while deleting a recor." + ex);
                }
                finally
                {
                    conn.Close();
                    combStdID.Text = "- - - - -S E L E C T- - - - -";
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAddress.Clear();
                    txtCity.Text = "";
                    txtContactNO.Clear();
                    txtEmail.Clear();
                    txtHP.Clear();
                    txtMP.Clear();
                    txtNIC.Clear();
                    txtParentName.Clear();
                    txtProvince.Text = "";
                    rbtnFemale.Checked = false;
                    rbtnMale.Checked = false;
                    datetimepickerDOB.ResetText();

                    //set focus
                    txtFirstName.Focus();
                }
                try
                {
                    // Clear the dropdown list before loading new data
                    combStdID.Items.Clear();

                    // Open the connection
                    conn.Open();

                    // Get the ID's to combobox
                    string search = "SELECT studentID FROM Registration ORDER by studentID";
                    sqlda = new SqlDataAdapter(search, conn);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);

                    // Close the connection

                    combStdID.Items.Add("- - - - - S E L E C T - - - - -");
                    foreach (DataRow drow in dt.Rows)
                    {
                        combStdID.Items.Add(drow["studentID"]);
                    }
                    combStdID.SelectedIndex = 0;
                    combStdID.Focus();
                }
                catch (Exception exp) // When there is an error, this used to display that error
                {
                    MessageBox.Show("Error while searching data!" + exp);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void btnRegclear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            datetimepickerDOB.ResetText();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMP.Clear();
            txtHP.Clear();
            txtCity.Text = "";
            txtProvince.Text = "";
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNO.Clear();

            //set Focus
            txtFirstName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check whether there have value in textboxes
            if (combStdID.Text == "")
            {
                MessageBox.Show("Havent't found data to Update!" , "Update" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // Check whether radio button is checked or not
                    if (rbtnMale.Checked == true)
                    {
                        gender_fm = "Male";
                    }
                    else if (rbtnFemale.Checked == true)
                    {
                        gender_fm = "Female";
                    }
                    else
                    {
                        MessageBox.Show("Select gender..!" , "Select" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                    
                    // Take information to database
                    DialogResult result = MessageBox.Show("Do you want to update the record?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Update Registration table with previously Select record
                        string upd_query = "UPDATE Registration SET firstName = '" + txtFirstName.Text + "', lastName = '" + txtLastName.Text + "' , dateOfBirth = '" + datetimepickerDOB.Value.Date.ToString() + "' , address = '" + txtAddress.Text + "' , email = '" + txtEmail.Text + "',mobilePhone = '" + txtMP.Text + "',homePhone = '" + txtHP.Text + "',city = '" + txtCity.Text + "',province = '" + txtProvince.Text + "',parentName = '" + txtParentName.Text + "',nic = '" + txtNIC.Text + "',contactNumber = '" + txtContactNO.Text + "' WHERE studentID = '" + combStdID.Text + "'";
                        SqlCommand ucomm = new SqlCommand(upd_query, conn);
                        conn.Open();
                        ucomm.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Succesfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                
                }
                catch (Exception exp)// When there is an Error, this used to display that error
                {
                    MessageBox.Show("Error while Updating a record." + exp);
                }
                finally
                {
                    conn.Close();
                    combStdID.Text = " - - - - -S E L E C T- - - - - ";
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAddress.Clear();
                    txtCity.Text = "";
                    txtContactNO.Clear();
                    txtEmail.Clear();
                    txtHP.Clear();
                    txtMP.Clear();
                    txtNIC.Clear();
                    txtParentName.Clear();
                    txtProvince.Text = "";
                    rbtnFemale.Checked = false;
                    rbtnMale.Checked = false;
                    datetimepickerDOB.ResetText();

                    //set focus
                    txtFirstName.Focus();
                    try
                    {
                        // Clear the dropdown list before loading new data
                        combStdID.Items.Clear();

                        // Open the connection
                        conn.Open();

                        // Get the ID's to combobox
                        string search = "SELECT studentID FROM Registration ORDER by studentID";
                        sqlda = new SqlDataAdapter(search, conn);
                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);

                        // Close the connection

                        combStdID.Items.Add(" - - - - - S E L E C T - - - - - ");
                        foreach (DataRow drow in dt.Rows)
                        {
                            combStdID.Items.Add(drow["studentID"]);
                        }
                        combStdID.SelectedIndex = 0;
                        combStdID.Focus();
                    }
                    catch (Exception exp) // When there is an error, this used to display that error
                    {
                        MessageBox.Show("Error while searching data!"  + exp);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check whether that all the fields are filled
            if (combStdID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtMP.Text == "" || txtHP.Text == "" || txtCity.Text == "" || txtProvince.Text == "" || txtParentName.Text == "" || txtNIC.Text == "" || txtContactNO.Text == "")
            {
                MessageBox.Show("Fill all the details..!" , "Register" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (rbtnMale.Checked == true)
                    {
                        gender_fm = "Male";
                    }
                    else if (rbtnFemale.Checked == true)
                    {
                        gender_fm = "Female";
                    }
                    else
                    {
                        MessageBox.Show("Select gender!" , "Select" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                    conn.Open();
                    // Insert record into Registration table
                    string ins_query = "INSERT INTO Registration (StudentID, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, city, province, parentname, nic, contactNumber) VALUES ('" + combStdID.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + datetimepickerDOB.Value.Date.ToString() + "', '" + gender_fm + "','" + txtAddress.Text + "', '" + txtEmail.Text + "', '" + txtMP.Text + "', '" + txtHP.Text + "', '" + txtCity.Text + "', '" + txtProvince.Text + "', '" + txtParentName.Text + "', '" + txtNIC.Text + "', '" + txtContactNO.Text + "')";
                    SqlDataAdapter sql_DA = new SqlDataAdapter(ins_query, conn);
                    sql_DA.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exp)
                {
                    MessageBox.Show("Error while adding!" + exp);
                }
                finally
                {
                    conn.Close();
                    combStdID.Text = " - - - - - S E L E C T - - - - - ";
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAddress.Clear();
                    txtCity.Text = "";
                    txtContactNO.Clear();
                    txtEmail.Clear();
                    txtHP.Clear();
                    txtMP.Clear();
                    txtNIC.Clear();
                    txtParentName.Clear();
                    txtProvince.Text = "";
                    rbtnFemale.Checked = false;
                    rbtnMale.Checked = false;
                    datetimepickerDOB.ResetText();

                    //set focus
                    txtFirstName.Focus();

                    try
                    {
                        // Clear the dropdown list before loading new data
                        combStdID.Items.Clear();

                        // Open the connection
                        conn.Open();

                        // Get the ID's to combobox
                        string search = "SELECT studentID FROM Registration ORDER by studentID";
                        sqlda = new SqlDataAdapter(search, conn);
                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);

                        // Close the connection

                        combStdID.Items.Add(" - - - - - S E L E C T - - - - - ");
                        foreach (DataRow drow in dt.Rows)
                        {
                            combStdID.Items.Add(drow["studentID"]);
                        }
                        combStdID.SelectedIndex = 0;
                        combStdID.Focus();
                    }
                    catch (Exception exp) // When there is an error, this used to display that error
                    {
                        MessageBox.Show("Error while searching data!" + exp);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                
            }
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Clear the dropdown list before loading new data
                combStdID.Items.Clear();

                // Open the connection
                conn.Open();

                // Get the ID's to combobox
                string search = "SELECT studentID FROM Registration ORDER by studentID";
                sqlda = new SqlDataAdapter(search, conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                // Close the connection

                combStdID.Items.Add(" - - - - - S E L E C T - - - - - ");
                foreach(DataRow drow in dt.Rows)
                {
                    combStdID.Items.Add(drow["studentID"]);
                }
                combStdID.SelectedIndex = 0;
                combStdID.Focus();
            }
            catch(Exception exp) // When there is an error, this used to display that error
            {
                MessageBox.Show("Error while searching data!" + exp);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text.Contains("'"))
            {
                MessageBox.Show("Don't use single quotation (')", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void combStdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combStdID.SelectedIndex != 0)
            {
                try
                {
                    conn.Open();
                    string sel_query = "SELECT * FROM Registration WHERE studentID = '" + combStdID.SelectedItem.ToString() + "'";
                    SqlCommand scomm = new SqlCommand(sel_query, conn);
                    SqlDataReader sql_sr = scomm.ExecuteReader();
                    while (sql_sr.Read())
                    {
                        txtFirstName.Text = sql_sr["firstName"].ToString();
                        txtLastName.Text = sql_sr["lastName"].ToString();
                        datetimepickerDOB.Value = (DateTime)sql_sr["dateOfBirth"];
                        txtAddress.Text = sql_sr["address"].ToString();
                        txtEmail.Text = sql_sr["email"].ToString();
                        txtMP.Text = "0" + sql_sr["mobilePhone"].ToString();
                        txtHP.Text = "0" + sql_sr["homePhone"].ToString();
                        txtCity.Text = sql_sr["city"].ToString();
                        txtProvince.Text = sql_sr["province"].ToString();
                        txtParentName.Text = sql_sr["parentName"].ToString();
                        txtNIC.Text = sql_sr["nic"].ToString();
                        txtContactNO.Text = "0" + sql_sr["contactNumber"].ToString();
                        gender_fm = sql_sr["gender"].ToString();

                        if (gender_fm == "Male")
                        {
                            rbtnMale.Checked = true;
                        }
                        else if (gender_fm == "Female")
                        {
                            rbtnFemale.Checked = true;
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error while load data for selected items" + exp);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txtMP_TextChanged(object sender, EventArgs e)
        {
            if (txtMP.Text != "")
            {
                if (!txtMP.Text.StartsWith("0"))
                {
                    MessageBox.Show("Please Start with ('0').", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            if (txtHP.Text != "")
            {
                if (!txtHP.Text.StartsWith("0"))
                {
                    MessageBox.Show("Please start with ('0').", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtContactNO_TextChanged(object sender, EventArgs e)
        {
            if (txtContactNO.Text != "")
            {
                if (!txtContactNO.Text.StartsWith("0"))
                {
                    MessageBox.Show("Please start with ('0').", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
