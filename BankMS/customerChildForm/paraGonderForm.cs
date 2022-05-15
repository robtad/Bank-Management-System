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
{//
    public partial class paraGonderForm : Form
    {
        DbConnector db = new DbConnector();
  
        public paraGonderForm()
        {
            InitializeComponent();
            displayCustomerInfo();

        }
        private void displayCustomerInfo()
        {

            db.fillDataGridView("SELECT * FROM CustomerAccounts  WHERE CustomerTCKN = '" + loginForm.userId + "'", customerDataGrid);
        }
       
        int index;
        private void customerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            senderAccountTB.Text = row.Cells[1].Value.ToString();
            accountTB.Text = row.Cells[1].Value.ToString();
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            if (transferAmountTB.Text == "" || receiverAccountTB.Text == "" || senderAccountTB.Text == "")
            {
                MessageBox.Show("Please Fill Receiver's Account Number and Fill Transfer Amount");
            }
            else
            {

                string senderBalance,receiverBalance,msg;
                string TransactionID, PaymentID;
                string senderCurrency,receiverCurrency;
                string senderRate,receiverRate;
                float senderExchangeRate,receiverExchangeRate;
                db.getSingleValue("select CurrencyName from Account where AccountNo = '" + receiverAccountTB.Text + "'", out receiverCurrency, 0);
                senderCurrency = lblCurrencyA.Text;

                db.getSingleValue("select ExchangeRate from Currency where Name = '" + lblCurrencyA.Text + "'", out senderRate, 0);
                db.getSingleValue("select ExchangeRate from Currency where Name = '" + receiverCurrency + "'", out receiverRate, 0);
                senderExchangeRate = float.Parse(senderRate);
                receiverExchangeRate = float.Parse(receiverRate);
                float conversionRate;
                conversionRate = senderExchangeRate / receiverExchangeRate;


                db.getSingleValue("select Balance from Account where AccountNo = '" + senderAccountTB.Text + "'", out senderBalance, 0);
                db.getSingleValue("select Balance from Account where AccountNo = '" + receiverAccountTB.Text + "'", out receiverBalance, 0);

                float availableBalance,targetBalance, transferAmount, totalSender,totalReceiver;
                transferAmount = float.Parse(transferAmountTB.Text);
                availableBalance = float.Parse(senderBalance);
                targetBalance = float.Parse(receiverBalance);

                if(transferAmount <= 0)
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

                    totalReceiver = targetBalance + transferAmount;

                    msg = db.performCRUD(@"update Account set Balance = '" + totalSender + "'" +
                                                        "where AccountNo = '" + senderAccountTB.Text + "'") + "\n";
                    msg = db.performCRUD(@"update Account set Balance = '" + totalReceiver + "'" +
                                                        "where AccountNo = '" + receiverAccountTB.Text + "'") + "\n";
                    //MessageBox.Show(msg);
                    MessageBox.Show(@"Amount Transfered Successfully"+"\n"+"Amount Before Exchange: "+amountBeforeExchange+senderCurrency+"\n"+"" +
                                     "Target Account Currency: "+receiverCurrency+"\n"+"Amount After Exchange: "+amountAfterExchange+receiverCurrency);

                    //write info to transaction table,payment table and withdraw table

                    msg += db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)
                                            insert into TransactionTbl (AccountNo,Balance,Date) values ('" + senderAccountTB.Text + "','" + availableBalance + "',@date)") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('TransactionTbl')", out TransactionID, 0);


                    msg += db.performCRUD(@"insert into Payment (TransactionID,Amount,Currency) values ('" + TransactionID + "','" + transferAmount + "','" + lblCurrencyA.Text + "')") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('Payment')", out PaymentID, 0);


                    msg += db.performCRUD(@"insert into TransferTbl (PaymentID, TargetAccountNo) values ('" + PaymentID + "','" + receiverAccountTB.Text + "')") + "\n";

                    //MessageBox.Show(msg);
                    MessageBox.Show("Transaction, Payment and Transfer Tables Updated Successfully!");

                    //receiverAccountTB.Text = "";
                    transferAmountTB.Text = "";

                }


            }
        }

        

        ///
    }
}
