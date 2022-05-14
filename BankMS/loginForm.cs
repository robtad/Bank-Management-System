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
        public static string userPassword = "";
        
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
                        userPassword = passwordTB.Text;
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
                string query = "SELECT COUNT(*) FROM ClerkTbl WHERE tId = @username AND tPassword = @password ";
                tellerForm obj = new tellerForm();
                login_check(query, obj);
            }
            else //for customer
            {
                string query = "SELECT COUNT(*) FROM CustomerLogin WHERE TCKN = @username AND Password = @password ";
                customerForm obj = new customerForm();
                login_check(query, obj);
            }



        }
       
       
    }
}
