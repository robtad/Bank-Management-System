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

namespace BankMS.tellerChildForm
{
    public partial class hesaplarForm : Form
    {
        public hesaplarForm()
        {
            InitializeComponent();
            displayCustomerInfo();
            
            db.FillCombobox("SELECT Name FROM Currency", CurrencyCB);
        }
        
        DbConnector db = new DbConnector();

      
        private void displayCustomerInfo()
        {

            db.fillDataGridView(@"SELECT c.*, tc.TellerTCKN, ca.AccountNo, a.CurrencyName,a.Balance,cl.Password 
                            FROM customer c
                            INNER JOIN TellerCustomer tc ON c.TCKN=tc.CustomerTCKN 
                            INNER JOIN CustomerAccounts ca ON tc.CustomerTCKN=ca.CustomerTCKN 
                            INNER JOIN Account a ON ca.AccountNo=a.AccountNo
                            INNER JOIN CustomerLogin cl ON c.TCKN = cl.TCKN
                            ", customerDataGrid);
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
            CurrencyCB.SelectedIndex = -1;           
        }
        string message;
        string AccNum;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
                if (FirstNameTB.Text == "" || LastNameTB.Text == "" || GenderCB.SelectedIndex == -1 || EmailTB.Text == "" || PhoneTB.Text == "" || AddressTB.Text == "" || PasswordTB.Text == "" || CurrencyCB.SelectedIndex == -1 || CustomerIdTB.Text == "")
                {
                    MessageBox.Show("Fill all the Cells before Submitting");
                }
                else
                {
                    try
                    {
                    
                    message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date) insert into Customer(TCKN,FirstName,LastName,Telephone,Address,Gender,Email,DateCreated) 
                                    values('" + CustomerIdTB.Text + "','" + FirstNameTB.Text + "','" + LastNameTB.Text + "', " +
                                    "'" + PhoneTB.Text + "','" + AddressTB.Text + "','" + GenderCB.SelectedItem.ToString() + "'," +
                                    "'" + EmailTB.Text + "',@date)") + "\n";
                    if (message.Contains("success"))
                    {
                        message += db.performCRUD(@"insert into Account(CurrencyName) values ('" + CurrencyCB.SelectedItem.ToString() + "')") + "\n";

                    }

                    db.getSingleValue("SELECT IDENT_CURRENT('Account')", out AccNum, 0);

                    //db.getSingleValue("select AccountNo from Account; select scope_identity();", out AccNum, 0);


                    message += db.performCRUD(@"insert into CustomerAccounts(CustomerTCKN,AccountNo) values ('" + CustomerIdTB.Text + "','" + AccNum + "')") + "\n";

                    if (message.Contains("success"))
                    {
                        message += db.performCRUD(@"insert into TellerCustomer(CustomerTCKN,TellerTCKN) values ('" + CustomerIdTB.Text + "'," +
                                    "'" + loginForm.userId + "')") + "\n";
                    }
                    
                    message += db.performCRUD(@"insert into CustomerLogin(TCKN,Password) values ('" + CustomerIdTB.Text + "'," +
                                    "'" +PasswordTB.Text+ "')") + "\n";

                    
                    MessageBox.Show(message);
                    
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


                    string msg = db.performCRUD("delete from Account where AccountNo = '" + AccNum + "'");
                    //MessageBox.Show(msg);

                    db.performCRUD("delete from Customer where TCKN = '" +CustomerIdTB.Text+ "'");
                    

                    MessageBox.Show("Account Deleted!");

                   
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
        int acc;
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
            CurrencyCB.SelectedItem = row.Cells[11].Value.ToString();




            if (FirstNameTB.Text == "")
            {
                Key = 0;

            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                acc = Convert.ToInt32(row.Cells[10].Value.ToString());
                tc = row.Cells[0].Value.ToString();

            }

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            
            if (FirstNameTB.Text == "" || LastNameTB.Text == "" || EmailTB.Text == "" || GenderCB.SelectedIndex == -1 || PhoneTB.Text == "" || AddressTB.Text == "" ||  PasswordTB.Text == "" || CustomerIdTB.Text == "" )
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
                    //teller cannot change currency!thats why the next line is commented out.
                    //message += db.performCRUD(@"update Account set CurrencyName = '" + CurrencyCB.SelectedItem.ToString() + "' " +
                                                    //"where AccountNo = '" + acc + "'") + "\n";
                    message += db.performCRUD(@"update CustomerLogin set Password = '" + PasswordTB.Text + "'" +
                                                "where TCKN = '" + CustomerIdTB.Text + "'") + "\n";
                   


                    MessageBox.Show(message);
                   
                    reset();
                    displayCustomerInfo();

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
