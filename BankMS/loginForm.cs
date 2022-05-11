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


namespace BankMS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        public static string userId = "";
        //Sql connection string
        //string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RobTad\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30";
        
        //initializing sql connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RobTad\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void resetLabel_Click(object sender, EventArgs e)
        {
            userNameTB.Text = "";
            passwordTB.Text = "";
            roleCB.SelectedIndex = -1;
            roleCB.Text = "Role";
        }

        //method to check credentials of users from the database and redirect to destination form
        public void login_check(string query, Form destinationForm)
        {
            if (userNameTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Enter Both Username and Password");
            }
            else
            {
                Con.Open();
                //string query = "SELECT COUNT(*) FROM ManagerTbl WHERE mName = @username AND mPassword = @password ";
                //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM ManagerTbl WHERE mName = '"+userNameTB.Text+"' AND mPassword = '"+passwordTB.Text+"' ", Con);
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("username", userNameTB.Text);
                cmd.Parameters.AddWithValue("password", passwordTB.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        //destinationForm obj = new destinationForm();
                        userId = userNameTB.Text;
                        destinationForm.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                        userNameTB.Text = "";
                        passwordTB.Text = "";
                    }
                }
                catch (Exception)
                {               
                    string msg = "Please enter only integer values for Username!\nYour User name is your TCK!";
                    MessageBox.Show(msg);
                }
               
                Con.Close();

            }
        }
        
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (roleCB.SelectedIndex == -1)//if role not seleceted
            {
                MessageBox.Show("Please Select Your Role");
            }
            else if (roleCB.SelectedIndex == 0)//for manager
            {
                string query = "SELECT COUNT(*) FROM ManagerTbl WHERE mName = @username AND mPassword = @password ";
                managerForm obj = new managerForm();
                login_check(query, obj);

            }
            else if (roleCB.SelectedIndex == 1)//for teller (bank clerk)
            {
                string query = "SELECT COUNT(*) FROM ClerkTbl WHERE tName = @username AND tPassword = @password ";
                tellerForm obj = new tellerForm();
                login_check(query, obj);
            }
            else //for customer
            {
                string query = "SELECT COUNT(*) FROM customerProfileTbl WHERE cId = @username AND cPassword = @password ";
                customerForm obj = new customerForm();
                login_check(query, obj);
            }



        }



        //place holders for username and password
        /*
        private void userNameTB_Enter(object sender, EventArgs e)
        {
            if(userNameTB.Text == "Username")
            {
                userNameTB.Text = "";
                userNameTB.ForeColor = Color.Black;          }
        }

        private void userNameTB_Leave(object sender, EventArgs e)
        {
            if( userNameTB.Text == "")
            {
                userNameTB.Text = "Username";
                userNameTB.ForeColor= Color.LightGray; 

            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordTB.Text == "Password")
            {
                passwordTB.Text = "";
                passwordTB.ForeColor = Color.Black;
            }

        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordTB.Text == "")
            {
                passwordTB.Text = "Password";
                passwordTB.ForeColor = Color.LightGray;

            }
        }
        
        private void userNameTB_TextChanged(object sender, EventArgs e)
        {

        }
        */
       
    }
}
