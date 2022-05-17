using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLRDbConnector;

namespace BankMS.tellerChildForm
{
    public partial class krediTalepleri : Form
    {
        DbConnector db = new DbConnector();

        public krediTalepleri()
        {
            InitializeComponent();
            displayNewAccInfo();
        }

        private void displayNewAccInfo()
        {

            db.fillDataGridView(@"SELECT rl.* 
                            FROM RequestLoan rl
                            INNER JOIN TellerCustomer tc ON rl.CustomerTCKN = tc.CustomerTCKN 
                            WHERE tc.TellerTCKN = '" + loginForm.userId + "'", customerDataGrid);
        }

        private void resetGrid()
        {
            CustomerIdTB.Text = "";
            creditAmountTB.Text = "";
            expirationTB.Text = "";
            creditAccountTB.Text = "";
        }
        private void deleteFromAccRequestTable()
        {
            if (key1 == 0)
            {
                MessageBox.Show("Select the Request to be Deleted");
            }
            else
            {
                try
                {

                    string msg = db.performCRUD(@"delete from RequestLoan where CustomerTCKN = '" + CustomerIdTB.Text + "' and " +
                                                "id = '" + key1 + "'");
                    //MessageBox.Show(msg);

                    //MessageBox.Show("Request Deleted!");

                    resetGrid();
                    displayNewAccInfo();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnConfirmCredit_Click(object sender, EventArgs e)
        {
            string message;
            
            if (key1 == 0 )
            {
                MessageBox.Show("Select The Request to Approve It!");
            }
            else
            {
                try
                {

                    int id = 1;
                    decimal LoanInterest, OverdueInterest;
                    string[] interestInfo = db.getArray("select LoanInterest, OverdueInterest from Interest where id = '" +id+ "'", 2);
                    LoanInterest = decimal.Parse(interestInfo[0]);
                    OverdueInterest = decimal.Parse(interestInfo[1]);
                    
                    decimal mortgage;
                    decimal totalAmount = decimal.Parse(creditAmountTB.Text);
                    int expiration = Int32.Parse(expirationTB.Text);
                    LoanInterest /= 100;
                    double denominator = 1 - Math.Pow(1+ decimal.ToDouble(LoanInterest), -expiration);

                    mortgage = (totalAmount * LoanInterest) / (decimal)(denominator);


                    //MessageBox.Show();
                    message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into Loan(CustomerTCKN,TotalAmount,MonthlyPayment,RemainingPrincipal,Expiration,DateStarted) values ('" + CustomerIdTB.Text + "','" + creditAmountTB.Text + "','" + Math.Round(mortgage,2) + "','" + creditAmountTB.Text + "','" + expirationTB.Text + "',@date)") + "\n";

                    //MessageBox.Show(message);

                    //Deposit The Credit To The Customer's Account
                    string receiverCurrency;
                    string receiverRate;
                    float receiverExchangeRate,conversionRate;
                    db.getSingleValue("select CurrencyName from Account where AccountNo = '" + creditAccountTB.Text + "'", out receiverCurrency, 0);
                    
                    db.getSingleValue("select ExchangeRate from Currency where Name = '" + receiverCurrency + "'", out receiverRate, 0);
                    receiverExchangeRate = float.Parse(receiverRate);
                    conversionRate = 1/ receiverExchangeRate; //Banks currency is always lira

                    string balance, msg;
                    string TransactionID, PaymentID;
                    db.getSingleValue("select Balance from Account where AccountNo = '" + creditAccountTB.Text + "'", out balance, 0);

                    float availableBalance, creditAmount, total;
                    creditAmount = float.Parse(creditAmountTB.Text);
                    creditAmount *= conversionRate; //converting lira to target currency.

                    availableBalance = float.Parse(balance);
                    total = availableBalance + creditAmount;


                    msg = db.performCRUD(@"update Account set Balance = '" + total + "'" +
                                                        "where AccountNo = '" + creditAccountTB.Text + "'") + "\n";
                    //MessageBox.Show(msg);
                    MessageBox.Show(" Credit Amount Deposited Successfully");
                    //write info to transaction table,payment table and deposit table

                    msg += db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)
                                        insert into TransactionTbl (AccountNo,Balance,Date) values ('" + creditAccountTB.Text + "','" + availableBalance + "',@date)") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('TransactionTbl')", out TransactionID, 0);


                    msg += db.performCRUD(@"insert into Payment (TransactionID,Amount,Currency) values ('" + TransactionID + "','" + creditAmount + "','" + "lira" + "')") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('Payment')", out PaymentID, 0);


                    msg += db.performCRUD(@"insert into Deposit (PaymentID) values ('" + PaymentID + "')") + "\n";

                    //MessageBox.Show(msg);
                    //MessageBox.Show("Transaction, Payment and Deposit Tables Updated Successfully!");



                    if (message.Contains("success"))
                    {
                        deleteFromAccRequestTable();
                    }
                    MessageBox.Show("Credit Account Created Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }



            }
        }
        private void btnCancelCredit_Click(object sender, EventArgs e)
        {
            if (key1 == 0)
            {
                MessageBox.Show("Select the Request to be Deleted");
            }
            else
            {
                deleteFromAccRequestTable();
                MessageBox.Show("The Credit Request Deleted Successfully!");

            }
        }
        int index;
        int key1;
        private void customerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            CustomerIdTB.Text = row.Cells[1].Value.ToString();
            creditAccountTB.Text = row.Cells[2].Value.ToString();
            creditAmountTB.Text = row.Cells[3].Value.ToString();
            expirationTB.Text = row.Cells[4].Value.ToString();

            if (CustomerIdTB.Text == "" || creditAmountTB.Text == "" || expirationTB.Text == ""||creditAccountTB.Text=="")
            {
                key1 = 0;

            }
            else
            {
                key1 = Convert.ToInt32(row.Cells[0].Value.ToString());

            }


            
        }

       

       



        //
    }
}
