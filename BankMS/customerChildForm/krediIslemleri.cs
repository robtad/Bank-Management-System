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
            else if (creditAmountTB.Text.Contains("-"))
            {
                MessageBox.Show("You Cannot Request Negative Amount or Zero!"+"\n"+"Please Enter Valid Numerical Values!");
            }
            else
            {
                try
                {

                    msg = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)
                                        insert into RequestLoan(CustomerTCKN,Amount,Expiration,AccountNo,RequestDate) 
                                    values('" + loginForm.userId + "','" + creditAmountTB.Text + "','" + ExpirationCB.SelectedItem.ToString() + "','" + creditAccountTB.Text + "',@date)") + "\n";

                    //MessageBox.Show(msg);
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
                    string[] interestInfo = db.getArray("select LoanInterest, OverdueInterest from Interest where id = '" + id + "'", 2);
                    LoanInterest = decimal.Parse(interestInfo[0]);
                    OverdueInterest = decimal.Parse(interestInfo[1]);
                    LoanInterest /= 100;
                    OverdueInterest /= 100;

                    //
                    string senderCurrency1;
                    string senderRate1;
                    decimal senderExchangeRate1, conversionRate1;
                    db.getSingleValue("select CurrencyName from Account where AccountNo = '" + loanAccountTB.Text + "'", out senderCurrency1, 0);

                    db.getSingleValue("select ExchangeRate from Currency where Name = '" + senderCurrency1 + "'", out senderRate1, 0);
                    senderExchangeRate1 = decimal.Parse(senderRate1);
                    conversionRate1 = senderExchangeRate1 / 1;

                    decimal paidAmount, principal, interest;

                    paidAmount = decimal.Parse(loanAmountTB.Text);
                    paidAmount *= conversionRate1;


                    if (paidAmount < 0)
                    {
                        MessageBox.Show("Can't Pay Negative Amount or Zero");
                    }
                    else if(paidAmount > 0)
                    {
                        if (remainingPrincipal > 0)
                        {

                            if (paidAmount >= monthlyPayment)
                            {
                                decimal extraPayment = paidAmount - monthlyPayment;
                                remainingPrincipal -= extraPayment;


                                interest = remainingPrincipal * LoanInterest;
                                //principal = paidAmount - interest;
                                principal = monthlyPayment - interest;
                                remainingPrincipal = remainingPrincipal - principal;
                            }
                            else
                            {
                                decimal remainedPayment = monthlyPayment - paidAmount;
                                remainedPayment += remainedPayment * OverdueInterest;
                                remainingPrincipal += remainedPayment;


                                interest = remainingPrincipal * LoanInterest;
                                //principal = paidAmount - interest;
                                principal = monthlyPayment - interest;
                                remainingPrincipal = remainingPrincipal - principal;

                            }

                            //round off every float to 2dp
                            interest = Math.Round(interest, 2);
                            remainingPrincipal = Math.Round(remainingPrincipal, 2);

                            //

                            // message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into LoanRepaymentLog(PaidAmount,MonthlyRemainingAmount,Principal,Interest,Date) values ('" +paidAmount + "','" + monthlyRemainingAmount + "','" + principal + "','" + interest + "',@date)") + "\n";
                            message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into LoanRepaymentLog(PaidAmount,Principal,Interest,Date) values ('" + paidAmount + "','" + principal + "','" + interest + "',@date)") + "\n";

                            message += db.performCRUD(@"update Loan set RemainingPrincipal = '" + remainingPrincipal + "' where CustomerTCKN = '" + loginForm.userId + "' and  id = '" + loanID + "'") + "\n";

                            displayCustomerInfo();
                            //MessageBox.Show(message);

                            //message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into Loan(CustomerTCKN,TotalAmount,MonthlyPayment,Expiration,DateStarted) values ('" + CustomerIdTB.Text + "','" + creditAmountTB.Text + "','" + mortgage + "','" + expirationTB.Text + "',@date)") + "\n";


                            //transfer the money from selected account




                            string senderBalance, TransactionID, senderCurrency, senderRate, msg;
                            string PaymentID, LoanID, LoanRepaymentLogID;
                            float senderExchangeRate;
                            senderCurrency = lblCurrencyA.Text;

                            db.getSingleValue("select ExchangeRate from Currency where Name = '" + lblCurrencyA.Text + "'", out senderRate, 0);
                            senderExchangeRate = float.Parse(senderRate);

                            float conversionRate;
                            conversionRate = senderExchangeRate / 1;//coz bank's currency is only lira


                            db.getSingleValue("select Balance from Account where AccountNo = '" + loanAccountTB.Text + "'", out senderBalance, 0);

                            float availableBalance, transferAmount, totalSender;
                            transferAmount = float.Parse(loanAmountTB.Text);
                            availableBalance = float.Parse(senderBalance);


                            if (transferAmount <= 0)
                            {
                                MessageBox.Show("Hey Come on Now >:( You Cannot Transfer Negative Amount or Zero!");
                            }
                            else if (transferAmount > availableBalance)
                            {
                                MessageBox.Show("Insufficient Balance" + "\n" + "Account Balance: " + availableBalance + "\n" + "Can't Transfer:" + transferAmount);
                            }
                            else
                            {
                                totalSender = availableBalance - transferAmount;
                                float amountBeforeExchange = transferAmount;

                                transferAmount = transferAmount * conversionRate;//convert from sender currency to receiver currency
                                float amountAfterExchange = transferAmount;



                                msg = db.performCRUD(@"update Account set Balance = '" + totalSender + "'" +
                                                                    "where AccountNo = '" + loanAccountTB.Text + "'") + "\n";

                                //MessageBox.Show(msg);
                                MessageBox.Show(@"Amount Transfered Successfully" + "\n" + "Amount Before Exchange: " + amountBeforeExchange + senderCurrency + "\n" + "" +
                                                 "Target Account Currency: lira " + "\n" + "Amount After Exchange: " + amountAfterExchange + "lira");

                                //write info to transaction table,payment table and withdraw table

                                msg += db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)
                                            insert into TransactionTbl (AccountNo,Balance,Date) values ('" + loanAccountTB.Text + "','" + availableBalance + "',@date)") + "\n";

                                db.getSingleValue("SELECT IDENT_CURRENT('TransactionTbl')", out TransactionID, 0);


                                msg += db.performCRUD(@"insert into Payment (TransactionID,Amount,Currency) values ('" + TransactionID + "','" + transferAmount + "','" + lblCurrencyA.Text + "')") + "\n";

                                db.getSingleValue("SELECT IDENT_CURRENT('Payment')", out PaymentID, 0);
                                db.getSingleValue("SELECT IDENT_CURRENT('Loan')", out LoanID, 0);
                                db.getSingleValue("SELECT IDENT_CURRENT('LoanRepaymentLog')", out LoanRepaymentLogID, 0);



                                msg += db.performCRUD(@"insert into LoanRepayment (LoanID, PaymentID,LoanRepaymentLogID) values ('" + LoanID + "','" + PaymentID + "','" + LoanRepaymentLogID + "')") + "\n";

                                //MessageBox.Show(msg);
                                //MessageBox.Show("Transaction, Payment and Transfer Tables Updated Successfully!");
                                MessageBox.Show("Mortgage Paid Successfully!");
                                loanAmountTB.Text = "";

                            }
                        }                    
                        else
                        {
                            MessageBox.Show("You Have Completed Your Credit Payment");
                        }




                        }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }




        //
    }
}
