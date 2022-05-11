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

namespace BankMS.customerChildForm
{
    public partial class bilgiGuncelleForm : Form
    {
        public bilgiGuncelleForm()
        {
            InitializeComponent();
            displayCustomerInfo();
            
            userIdlbl.Text = loginForm.userId;
            
            
            
        }
        public static string ID = loginForm.userId;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RobTad\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void openConnection()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        private void displayCustomerInfo()
        {
            openConnection();
           
            SqlCommand query = new SqlCommand(@"SELECT cp.*, ct.tellerId, ca.cAccountNo, ai.accCurrencyName,ai.accBalance,ai.accLoan 
                            FROM customerProfileTbl cp 
                            INNER JOIN customerTellerTbl ct ON cp.cId=ct.cId 
                            INNER JOIN customerAccountTbl ca ON ct.cId=ca.cId 
                            INNER JOIN accountInfoTbl ai ON ca.cAccountNo=ai.accNo
                            WHERE cp.cId = @ID", Con);

            query.Parameters.AddWithValue("@ID", ID);

            

            SqlDataAdapter sda = new SqlDataAdapter(query);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            customerDataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void reset()
        {

            newAccNameTB.Text = "";
            newAccGenderCB.SelectedIndex = -1;
            newAccPhoneTB.Text = "";
            newAccAddressTB.Text = "";
            newAccTellerIdTB.Text = "";
            customerPasswordTB.Text = "";          
            newAccDatePicker.Text = "";
            newAccCustomerIdTB.Text = "";
                    

        }
        
        int Key = 0, key2 = 0;
        int index;
        private void customerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            newAccCustomerIdTB.Text = row.Cells[0].Value.ToString();
            newAccNameTB.Text = row.Cells[1].Value.ToString();
            newAccGenderCB.SelectedItem = row.Cells[2].Value.ToString();
            newAccPhoneTB.Text = row.Cells[3].Value.ToString();
            newAccAddressTB.Text = row.Cells[4].Value.ToString();
            customerPasswordTB.Text = row.Cells[5].Value.ToString();
            newAccDatePicker.Text = row.Cells[6].Value.ToString();
            newAccTellerIdTB.Text = row.Cells[8].Value.ToString();
            

            if (newAccNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                key2 = Convert.ToInt32(row.Cells[9].Value.ToString());
            }

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (newAccNameTB.Text == "" || newAccGenderCB.SelectedIndex == -1 || newAccPhoneTB.Text == "" || newAccAddressTB.Text == "" || newAccTellerIdTB.Text == "" || customerPasswordTB.Text == "" || newAccDatePicker.Text == "" || newAccCustomerIdTB.Text == "" )
            {
                MessageBox.Show(" Select your account and \n Fill all the Cells before submitting to update");
            }
            else
            {
                try
                {
                    openConnection();
                    SqlCommand cmd1 = new SqlCommand(@"UPDATE customerProfileTbl SET cId = @CI,cName = @CN,cGender = @CG,cPhone = @CP,
                                                      cAddress = @CA,cPassword = @CPW,cDateUpdated = @CDU WHERE cId = @AccKey", Con);
                    cmd1.Parameters.AddWithValue("@CI", newAccCustomerIdTB.Text);
                    cmd1.Parameters.AddWithValue("@CN", newAccNameTB.Text);
                    cmd1.Parameters.AddWithValue("@CG", newAccGenderCB.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@CP", newAccPhoneTB.Text);
                    cmd1.Parameters.AddWithValue("@CA", newAccAddressTB.Text);
                    cmd1.Parameters.AddWithValue("@CPW", customerPasswordTB.Text);
                    cmd1.Parameters.AddWithValue("@CDU", newAccDatePicker.Value.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@AccKey", Key);
                    cmd1.ExecuteNonQuery();
                    Con.Close();                                                     

                    MessageBox.Show("Account Updated!");
                   
                    reset();
                    displayCustomerInfo();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }



    }
}
