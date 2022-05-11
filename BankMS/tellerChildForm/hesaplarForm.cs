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


namespace BankMS.tellerChildForm
{
    public partial class hesaplarForm : Form
    {
        public hesaplarForm()
        {
            InitializeComponent();
            displayCustomerInfo();
        }
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

            string query = @"SELECT cp.*, ct.tellerId, ca.cAccountNo, ai.accCurrencyName,ai.accBalance,ai.accLoan 
                            FROM customerProfileTbl cp 
                            INNER JOIN customerTellerTbl ct ON cp.cId=ct.cId 
                            INNER JOIN customerAccountTbl ca ON ct.cId=ca.cId 
                            INNER JOIN accountInfoTbl ai ON ca.cAccountNo=ai.accNo";

            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder =  new SqlCommandBuilder(sda);
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
            newAccCurrencyCB.SelectedIndex = -1;
            newAccDatePicker.Text = "";
            newAccCustomerIdTB.Text = "";
            newAccAccountNoTB.Text = "";
            newAccBalanceTB.Text = "";
            newAccLoanTB.Text = "";

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            
                if (newAccNameTB.Text == "" || newAccGenderCB.SelectedIndex == -1 || newAccPhoneTB.Text == "" || newAccAddressTB.Text == "" || newAccTellerIdTB.Text == "" || customerPasswordTB.Text == "" || newAccCurrencyCB.SelectedIndex == -1 || newAccDatePicker.Text == ""||newAccCustomerIdTB.Text == ""||newAccAccountNoTB.Text =="" || newAccBalanceTB.Text == "" || newAccLoanTB.Text == "")
                {
                    MessageBox.Show("Fill all the Cells before Submitting");
                }
                else
                {
                    try
                    {
                    openConnection();
                    
                    SqlCommand cmd1 = new SqlCommand("insert into customerProfileTbl(cId,cName,cGender,cPhone,cAddress,cPassword,cDateCreated)values(@CI,@CN,@CG,@CP,@CA,@CPW,@CDC)", Con);
                    cmd1.Parameters.AddWithValue("@CI", newAccCustomerIdTB.Text);
                    cmd1.Parameters.AddWithValue("@CN", newAccNameTB.Text);
                    cmd1.Parameters.AddWithValue("@CG", newAccGenderCB.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@CP", newAccPhoneTB.Text);
                    cmd1.Parameters.AddWithValue("@CA", newAccAddressTB.Text);
                    cmd1.Parameters.AddWithValue("@CPW", customerPasswordTB.Text);
                    cmd1.Parameters.AddWithValue("@CDC", newAccDatePicker.Value.ToShortDateString());
                    //cmd1.Parameters.AddWithValue("@CDU", null);
                    cmd1.ExecuteNonQuery();
                    cmd1.Parameters.Clear();

                    Con.Close();

                    openConnection();

                    SqlCommand cmd4 = new SqlCommand("insert into customerTellerTbl(cId,tellerId)values(@CI,@TI)", Con);
                    cmd4.Parameters.AddWithValue("@CI", newAccCustomerIdTB.Text);
                    cmd4.Parameters.AddWithValue("@TI", newAccTellerIdTB.Text);
                    cmd4.ExecuteNonQuery();
                    cmd4.Parameters.Clear();

                    Con.Close();

                    openConnection();

                    SqlCommand cmd3 = new SqlCommand("insert into customerAccountTbl(cId,cAccountNo)values(@CI,@CA)", Con);
                    cmd3.Parameters.AddWithValue("@CI", newAccCustomerIdTB.Text);
                    cmd3.Parameters.AddWithValue("@CA", newAccAccountNoTB.Text);
                    cmd3.ExecuteNonQuery();
                    cmd3.Parameters.Clear();

                    Con.Close();

                    openConnection();

                    SqlCommand cmd2 = new SqlCommand("insert into accountInfoTbl(accNo,accCurrencyName,accBalance,accLoan)values(@AN,@AC,@AB,@AL)", Con);
                    cmd2.Parameters.AddWithValue("@AN", newAccAccountNoTB.Text);
                    cmd2.Parameters.AddWithValue("@AC", newAccCurrencyCB.SelectedItem.ToString());
                    cmd2.Parameters.AddWithValue("@AB", newAccBalanceTB.Text);
                    cmd2.Parameters.AddWithValue("@AL", newAccLoanTB.Text);
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();

                    MessageBox.Show("Account Created!");

                     Con.Close();
                     reset();
                     displayCustomerInfo();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Account to be Deleted");
            }
            else
            {
                try
                {
                    openConnection();

                    SqlCommand cmd = new SqlCommand("DELETE FROM customerProfileTbl WHERE cId = @AccKey", Con);

                    cmd.Parameters.AddWithValue("@AccKey", Key);
           
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Deleted!");

                    Con.Close();
                    reset();
                    displayCustomerInfo();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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
            newAccAccountNoTB.Text = row.Cells[9].Value.ToString();
            newAccCurrencyCB.SelectedItem = row.Cells[10].Value.ToString();
            newAccBalanceTB.Text = row.Cells[11].Value.ToString();
            newAccLoanTB.Text = row.Cells[12].Value.ToString();

            if (newAccNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key =  Convert.ToInt32(row.Cells[0].Value.ToString());
                key2 = Convert.ToInt32(row.Cells[9].Value.ToString());
            }



        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (newAccNameTB.Text == "" || newAccGenderCB.SelectedIndex == -1 || newAccPhoneTB.Text == "" || newAccAddressTB.Text == "" || newAccTellerIdTB.Text == "" || customerPasswordTB.Text == "" || newAccCurrencyCB.SelectedIndex == -1 || newAccDatePicker.Text == ""||newAccCustomerIdTB.Text == ""||newAccAccountNoTB.Text =="" || newAccBalanceTB.Text == "" || newAccLoanTB.Text == "")
            {
                    MessageBox.Show(" Select the Account to be Updated and \n Fill all the Cells before Submitting");
            }
            else
            {
                try
                {
                    openConnection();                                     
                    SqlCommand cmd1 = new SqlCommand(@"UPDATE customerProfileTbl SET cId = @CI,cName = @CN,cGender = @CG,cPhone = @CP,
                                                      cAddress = @CA,cPassword = @CPW,cDateCreated = @CDC WHERE cId = @AccKey", Con);
                    cmd1.Parameters.AddWithValue("@CI", newAccCustomerIdTB.Text);
                    cmd1.Parameters.AddWithValue("@CN", newAccNameTB.Text);
                    cmd1.Parameters.AddWithValue("@CG", newAccGenderCB.SelectedItem.ToString());
                    cmd1.Parameters.AddWithValue("@CP", newAccPhoneTB.Text);
                    cmd1.Parameters.AddWithValue("@CA", newAccAddressTB.Text);
                    cmd1.Parameters.AddWithValue("@CPW", customerPasswordTB.Text);
                    cmd1.Parameters.AddWithValue("@CDC", newAccDatePicker.Value.ToShortDateString());
                    cmd1.Parameters.AddWithValue("@AccKey", Key);
                    cmd1.ExecuteNonQuery();
                    Con.Close();
                    
                    openConnection();
                    SqlCommand cmd2 = new SqlCommand(@"UPDATE accountInfoTbl SET accCurrencyName = @AC,
                                                       accBalance = @AB,accLoan = @AL WHERE accNo = @AccKey2", Con);

                    //cmd2.Parameters.AddWithValue("@AN", newAccAccountNoTB.Text);//can only be updated in parent table (i.e, customerAccountTbl) (since it is a foreign key)
                    cmd2.Parameters.AddWithValue("@AC", newAccCurrencyCB.SelectedItem.ToString());
                    cmd2.Parameters.AddWithValue("@AB", newAccBalanceTB.Text);
                    cmd2.Parameters.AddWithValue("@AL", newAccLoanTB.Text);
                    cmd2.Parameters.AddWithValue("@AccKey2", key2);
                    cmd2.ExecuteNonQuery();
                    Con.Close();
                                       
                    openConnection();
                    SqlCommand cmd3 = new SqlCommand(@"UPDATE customerAccountTbl SET cAccountNo = @CA
                                                       WHERE cId = @AccKey", Con);
                    //cmd3.Parameters.AddWithValue("@CI", newAccCustomerIdTB.Text);//can only be updated in parent table(i.e, customerProfileTbl)(since it is a foreign key)
                    cmd3.Parameters.AddWithValue("@CA", newAccAccountNoTB.Text); 
                    cmd3.Parameters.AddWithValue("@AccKey", Key);
                    cmd3.ExecuteNonQuery();
                    Con.Close();
                    
                    openConnection();
                    SqlCommand cmd4 = new SqlCommand(@"UPDATE customerTellerTbl SET tellerId = @TI
                                                       WHERE cId = @AccKey", Con);
                    //cmd4.Parameters.AddWithValue("@CI", newAccCustomerIdTB.Text);//can only be updated in parent table(i.e, customerProfileTbl)(since it is a foreign key)
                    cmd4.Parameters.AddWithValue("@TI", newAccTellerIdTB.Text);
                    cmd4.Parameters.AddWithValue("@AccKey", Key);
                    cmd4.ExecuteNonQuery();
                 
                    MessageBox.Show("Account Updated!");

                    Con.Close();
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
