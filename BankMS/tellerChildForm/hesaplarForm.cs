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
        private void displayCustomerInfo()
        {
            Con.Open();
            string query = "SELECT * FROM AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder =  new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            customerDataGrid.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void reset()
        {
            newAccTellerIdTB.Text = "";
            newAccPhoneTB.Text = "";
            newAccAddressTB.Text = "";
            newAccCurrencyCB.SelectedIndex = -1;
            newAccDatePicker.Text = "";
            newAccGenderCB.SelectedIndex = -1;
            newAccNameTB.Text = "";
            customerPasswordTB.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            
                if (newAccNameTB.Text == "" || newAccGenderCB.SelectedIndex == -1 || newAccPhoneTB.Text == "" || newAccAddressTB.Text == "" || newAccTellerIdTB.Text == "" || customerPasswordTB.Text == "" || newAccCurrencyCB.SelectedIndex == -1 || newAccDatePicker.Text == "")
                {
                    MessageBox.Show("Fill all the Cells before Submitting");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into AccountTbl(AccName,AccGender,AccPhone,AccBalance,AccType,AccTeller,AccAddress,AccPassword,AccDate)values(@AN,@AG,@AT,@AB,@ATP,@AR,@AA,@AP,@AD)", Con);
                        cmd.Parameters.AddWithValue("@AN", newAccNameTB.Text);
                        cmd.Parameters.AddWithValue("@AG", newAccGenderCB.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@AT", newAccPhoneTB.Text);
                        cmd.Parameters.AddWithValue("@AB", 0);
                        cmd.Parameters.AddWithValue("@ATP", newAccCurrencyCB.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@AR", newAccTellerIdTB.Text);
                        cmd.Parameters.AddWithValue("@AA", newAccAddressTB.Text);
                        cmd.Parameters.AddWithValue("@AP", customerPasswordTB.Text);
                        cmd.Parameters.AddWithValue("@AD", newAccDatePicker.Value.ToShortDateString());
                        cmd.ExecuteNonQuery();

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
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AccountTbl WHERE AccNum = @AccKey", Con);
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
        
        int Key = 0;
        int index;
        private void customerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            newAccTellerIdTB.Text = row.Cells[1].Value.ToString();
            newAccNameTB.Text = row.Cells[2].Value.ToString();
            newAccGenderCB.SelectedItem = row.Cells[3].Value.ToString();
            newAccPhoneTB.Text = row.Cells[4].Value.ToString();
            newAccAddressTB.Text = row.Cells[5].Value.ToString();
            newAccCurrencyCB.SelectedItem = row.Cells[7].Value.ToString();
            customerPasswordTB.Text = row.Cells[8].Value.ToString();
            newAccDatePicker.Text = row.Cells[9].Value.ToString();

            if(newAccNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key =  Convert.ToInt32(row.Cells[0].Value.ToString());
            }



        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (newAccNameTB.Text == "" || newAccGenderCB.SelectedIndex == -1 || newAccPhoneTB.Text == "" || newAccAddressTB.Text == "" || newAccTellerIdTB.Text == "" || customerPasswordTB.Text == "" || newAccCurrencyCB.SelectedIndex == -1 || newAccDatePicker.Text == "")
            {
                MessageBox.Show(" Select the Account to be Updated and \n Fill all the Cells before Submitting");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AccName = @AN,AccGender = @AG,AccPhone = @AT,AccType = @ATP,AccTeller = @AR,AccAddress = @AA,AccPassword = @AP,AccDate = @AD WHERE AccNum = @AccKey", Con);
                    cmd.Parameters.AddWithValue("@AN", newAccNameTB.Text);
                    cmd.Parameters.AddWithValue("@AG", newAccGenderCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AT", newAccPhoneTB.Text);
                    cmd.Parameters.AddWithValue("@AccKey", Key);
                    cmd.Parameters.AddWithValue("@ATP", newAccCurrencyCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AR", newAccTellerIdTB.Text);
                    cmd.Parameters.AddWithValue("@AA", newAccAddressTB.Text);
                    cmd.Parameters.AddWithValue("@AP", customerPasswordTB.Text);
                    cmd.Parameters.AddWithValue("@AD", newAccDatePicker.Value.ToShortDateString());
                    cmd.ExecuteNonQuery();

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
