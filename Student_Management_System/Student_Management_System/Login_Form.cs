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
    public partial class loginForm : Form
    {
        //Declear a Variable for SQL Connection
        SqlConnection conn = new SqlConnection();

        public loginForm()
        {
            //To Connect database
            conn.ConnectionString = @"Data Source=DESKTOP-QC2QNN5\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit Button Code
            DialogResult dialog = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Button Code
            txtUsername.Clear();
            txtPassword.Clear();
            
            //To Set Focus
            txtUsername.Focus();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Show Password Code
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Login Button Code
            string user = txtUsername.Text;
            string pw = txtPassword.Text;

            if (txtUsername.Text == "Admin" && txtPassword.Text == "Skills@123")
            {
                registrationForm second_form = new registrationForm();
                second_form.Show();
                this.Hide();
            }
            else
            {
                conn.Open();
                string query = "SELECT * from logins WHERE username = '" + user + "' AND Password = '" + pw + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sqlData = cmd.ExecuteReader();

                if (sqlData.HasRows)
                {
                    registrationForm second_form = new registrationForm();
                    second_form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials, Please check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
    }
}
