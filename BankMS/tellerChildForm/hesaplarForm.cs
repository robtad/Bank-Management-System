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
                    displayCustomerInfo();

                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
                
            }
       
        }


    }
}
