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
using SLRDbConnector;

namespace BankMS.customerChildForm
{
    public partial class bilgiGuncelleForm : Form
    {
        public bilgiGuncelleForm()
        {
            InitializeComponent();
            displayCustomerInfo(loginForm.userId);
            
            userIdlbl.Text = loginForm.userId;
                                  
        }

        DbConnector db = new DbConnector();

        public static string ID = loginForm.userId;


        private void displayCustomerInfo(string userTC)
        {

            db.fillDataGridView(@"SELECT c.*, tc.TellerTCKN, ca.AccountNo, a.CurrencyName,a.Balance,a.Loan,cl.Password 
                            FROM customer c
                            INNER JOIN TellerCustomer tc ON c.TCKN=tc.CustomerTCKN 
                            INNER JOIN CustomerAccounts ca ON tc.CustomerTCKN=ca.CustomerTCKN 
                            INNER JOIN Account a ON ca.AccountNo=a.AccountNo
                            INNER JOIN CustomerLogin cl ON c.TCKN = cl.TCKN
                            where c.TCKN = '" +userTC+ "'", customerDataGrid);
        }
        private void reset()
        {
            CustomerIdTB.Text = "";
            FirstNameTB.Text = "";
            LastNameTB.Text = "";
            PhoneTB.Text = "";
            AddressTB.Text = "";
            GenderCB.SelectedIndex = -1;
            EmailTB.Text = "";
            PasswordTB.Text = "";
            
        }
        string message;
        


        int Key = 0;
        string tc;
        int index;
        
        private void customerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            CustomerIdTB.Text = row.Cells[0].Value.ToString();
            FirstNameTB.Text = row.Cells[1].Value.ToString();
            LastNameTB.Text = row.Cells[2].Value.ToString();
            PhoneTB.Text = row.Cells[3].Value.ToString();
            AddressTB.Text = row.Cells[4].Value.ToString();
            GenderCB.SelectedItem = row.Cells[5].Value.ToString();
            EmailTB.Text = row.Cells[6].Value.ToString();
            PasswordTB.Text = row.Cells[14].Value.ToString();


            if (FirstNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                tc = row.Cells[0].Value.ToString();


            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (FirstNameTB.Text == "" || LastNameTB.Text == "" || EmailTB.Text == "" || GenderCB.SelectedIndex == -1 || PhoneTB.Text == "" || AddressTB.Text == "" || PasswordTB.Text == "" || CustomerIdTB.Text == "")
            {
                MessageBox.Show(" Select the Account to be Updated and \n Fill all the Cells before Submitting");
            }
            else
            {
                try
                {

                    
                    message = db.performCRUD(@"update Customer set TCKN = '" + CustomerIdTB.Text + "',FirstName = '" + FirstNameTB.Text + "'," +
                                    "LastName = '" + LastNameTB.Text + "',Telephone = '" + PhoneTB.Text + "',Address = '" + AddressTB.Text + "'," +
                                    "Gender = '" + GenderCB.SelectedItem.ToString() + "'," +
                                    "Email = '" + EmailTB.Text + "',DateUpdated = getdate() " +
                                    "where TCKN = '" + tc + "'") + "\n";
                    message += db.performCRUD(@"update CustomerLogin set Password = '" + PasswordTB.Text + "'" +
                                                "where TCKN = '" + CustomerIdTB.Text + "'") + "\n";
                    

                    MessageBox.Show(message);
                  
                    displayCustomerInfo(CustomerIdTB.Text);
                    reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }





        }

       //
    }
}
