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

namespace BankMS.customerChildForm
{
    public partial class krediIslemleri : Form
    {
        DbConnector db = new DbConnector();

        public krediIslemleri()
        {
            InitializeComponent();
            displayCustomerInfo();
        }

        private void displayCustomerInfo()
        {

            
            db.fillDataGridView("SELECT * FROM CustomerAccounts  WHERE CustomerTCKN = '" + loginForm.userId + "'", customerDataGrid);
            db.fillDataGridView("SELECT * FROM Loan  WHERE CustomerTCKN = '" + loginForm.userId + "'", customerDataGrid2);


        }

        int index;
        
        private void customerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            creditAccountTB.Text = row.Cells[1].Value.ToString();
            loanAccountTB.Text = row.Cells[1].Value.ToString();
            accountTB.Text = row.Cells[1].Value.ToString();
        }
        int index2;
            
        decimal creditAmount, monthlyPayment, expiration,remainingPrincipal;
        int loanID;

        private void customerDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index2 = e.RowIndex;
            DataGridViewRow row = customerDataGrid2.Rows[index2];
            loanID = Int32.Parse(row.Cells[0].Value.ToString());
            creditAmount = decimal.Parse(row.Cells[3].Value.ToString());
            monthlyPayment = decimal.Parse(row.Cells[4].Value.ToString());
            remainingPrincipal = decimal.Parse(row.Cells[5].Value.ToString());
            expiration = decimal.Parse(row.Cells[6].Value.ToString());
            loanIdTB.Text = loanID.ToString();
        }
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {

            if (accountTB.Text == "")
            {
                MessageBox.Show("To Check Balance Select Account From Grid View or" + "\n" + "Enter Your Account Number");
            }
            else
            {
                try
                {

                    string[] accountDetails = db.getArray("select Balance, CurrencyName from Account where AccountNo = '" + accountTB.Text + "'", 2);
                    balanceTB.Text = accountDetails[0];
                    lblCurrency.Text = accountDetails[1];
                    lblCurrencyA.Text = accountDetails[1];
                    lblCurrencyB.Text = accountDetails[1];


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCreditRequest_Click(object sender, EventArgs e)
        {
            string msg;
            if (ExpirationCB.SelectedIndex == -1 || creditAmountTB.Text == "")
            {
                MessageBox.Show("Select Credit Amount and Currency before submitting");
            }
            else
            {
                try
                {

                    msg = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)
                                        insert into RequestLoan(CustomerTCKN,Amount,Expiration,RequestDate) 
                                    values('" + loginForm.userId + "','" + creditAmountTB.Text + "','" + ExpirationCB.SelectedItem.ToString() + "',@date)") + "\n";

                    MessageBox.Show(msg);
                    MessageBox.Show("Credit Request Has Been Sent To Your Teller Successfully!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnPayLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (loanAccountTB.Text == "" || loanIdTB.Text == "" || loanAmountTB.Text == "")
                {
                    MessageBox.Show("Please Credit Account To Be Paid and "+"\n"+"Fill All The Boxes!");
                }
                else
                {
                    string message;
                    int id = 1;
                    decimal LoanInterest, OverdueInterest;
                    //float creditAmount, monthlyPayment, expiration,remainingPrincipal;
                    string[] interestInfo = db.getArray("select LoanInterest, OverdueInterest from Interest where id = '" + id + "'", 2);
                    LoanInterest = decimal.Parse(interestInfo[0]);
                    OverdueInterest = decimal.Parse(interestInfo[1]);
                    LoanInterest /= 100;
                    OverdueInterest /= 100;

                    //string[] loanInfo = db.getArray("select TotalAmount, MonthlyPayment,Expiration,RemainingPrincipal from Loan where CustomerTCKN = '" + loginForm.userId + "'", 4);


                    decimal paidAmount, monthlyRemainingAmount, principal, interest;
                    paidAmount = decimal.Parse(loanAmountTB.Text);


                    monthlyRemainingAmount = monthlyPayment - paidAmount;//check this for early payment also

                    interest = remainingPrincipal * LoanInterest;
                    principal = monthlyPayment - interest;
                    remainingPrincipal = remainingPrincipal - principal;
                    //round off every float to 2dp
                    monthlyPayment= Math.Round(monthlyPayment, 2);
                    monthlyRemainingAmount = Math.Round(monthlyRemainingAmount, 2);
                    interest = Math.Round(interest, 2);
                    remainingPrincipal = Math.Round(remainingPrincipal, 2);
                 

                    //

                    // message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into LoanRepaymentLog(PaidAmount,MonthlyRemainingAmount,Principal,Interest,Date) values ('" +paidAmount + "','" + monthlyRemainingAmount + "','" + principal + "','" + interest + "',@date)") + "\n";
                    message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into LoanRepaymentLog(PaidAmount,MonthlyRemainingAmount,Principal,Interest,Date) values ('" + paidAmount + "','" + monthlyRemainingAmount + "','" + principal + "','" + interest + "',@date)") + "\n";

                    message += db.performCRUD(@"update Loan set MonthlyPayment = '" + monthlyPayment + "',RemainingPrincipal = '" + remainingPrincipal + "' where CustomerTCKN = '" + loginForm.userId + "' and  id = '" + loanID + "'") + "\n";

                    displayCustomerInfo();

                    //message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into Loan(CustomerTCKN,TotalAmount,MonthlyPayment,Expiration,DateStarted) values ('" + CustomerIdTB.Text + "','" + creditAmountTB.Text + "','" + mortgage + "','" + expirationTB.Text + "',@date)") + "\n";

                    MessageBox.Show(message);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }




        //
    }
}
