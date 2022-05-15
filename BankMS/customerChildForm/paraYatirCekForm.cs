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
    public partial class paraYatirCekForm : Form
    {
        DbConnector db = new DbConnector();
        public paraYatirCekForm()
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
            depositAccountTB.Text = row.Cells[1].Value.ToString();
            withdrawAccountTB.Text = row.Cells[1].Value.ToString();
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
                    lblCurrencyB.Text = accountDetails[1];  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(depositAmountTB.Text == "" || depositAccountTB.Text == "")
            {
                MessageBox.Show("Please Select Account Number and Fill Deposit Amount");
            }
            else
            {
                
                string balance,msg;
                string TransactionID, PaymentID;
                db.getSingleValue("select Balance from Account where AccountNo = '" + depositAccountTB.Text + "'", out balance, 0);
              
                float availableBalance, depositAmount, total;
                depositAmount = float.Parse(depositAmountTB.Text);

                if (depositAmount <= 0)
                {
                    MessageBox.Show("Hey Come on Now >:( You Cannot Deposit Negative Amount or Zero!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {


                    availableBalance = float.Parse(balance);
                    total = availableBalance + depositAmount;


                    msg = db.performCRUD(@"update Account set Balance = '" + total + "'" +
                                                        "where AccountNo = '" + depositAccountTB.Text + "'") + "\n";
                    //MessageBox.Show(msg);
                    MessageBox.Show("Amount Deposited Successfully");
                    //write info to transaction table,payment table and deposit table

                    msg += db.performCRUD(@"insert into TransactionTbl (AccountNo,Balance) values ('" + depositAccountTB.Text + "','" + availableBalance + "')") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('TransactionTbl')", out TransactionID, 0);


                    msg += db.performCRUD(@"insert into Payment (TransactionID,Amount,Currency) values ('" + TransactionID + "','" + depositAmount + "','" + lblCurrencyA.Text + "')") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('Payment')", out PaymentID, 0);


                    msg += db.performCRUD(@"insert into Deposit (PaymentID) values ('" + PaymentID + "')") + "\n";

                    //MessageBox.Show(msg);
                    MessageBox.Show("Transaction, Payment and Deposit Tables Updated Successfully!");

                    depositAmountTB.Text = "";

                }
            }

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (withdrawAmountTB.Text == "" || withdrawAccountTB.Text == "")
            {
                MessageBox.Show("Please Select Account Number and Fill Withdraw Amount");
            }
            else
            {
                
                string balance,msg;
                string TransactionID, PaymentID;


                db.getSingleValue("select Balance from Account where AccountNo = '" + withdrawAccountTB.Text + "'", out balance, 0);

                float availableBalance, withdrawAmount, total;
                availableBalance = float.Parse(balance);
              
                withdrawAmount = float.Parse(withdrawAmountTB.Text);
                if (withdrawAmount <= 0)
                {
                    MessageBox.Show("Hey Come on Now >:( You Cannot Withdraw Negative Amount or Zero!");
                }
                else if (withdrawAmount > availableBalance)
                {
                    MessageBox.Show("Insufficient Balance"+"\n"+"Account Balance: "+availableBalance+"\n"+"Can't Withdraw:"+withdrawAmount);
                }
                else
                {
                    total = availableBalance - withdrawAmount;

                    msg = db.performCRUD(@"update Account set Balance = '" + total + "'" +
                                                        "where AccountNo = '" + depositAccountTB.Text + "'") + "\n";
                    //MessageBox.Show(msg);
                    MessageBox.Show("Amount Withdrawn Successfully");

                    //write info to transaction table,payment table and withdraw table

                    msg += db.performCRUD(@"insert into TransactionTbl (AccountNo,Balance) values ('" + withdrawAccountTB.Text + "','" + availableBalance + "')") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('TransactionTbl')", out TransactionID, 0);


                    msg += db.performCRUD(@"insert into Payment (TransactionID,Amount,Currency) values ('" + TransactionID + "','" + withdrawAmount + "','" + lblCurrencyB.Text + "')") + "\n";

                    db.getSingleValue("SELECT IDENT_CURRENT('Payment')", out PaymentID, 0);


                    msg += db.performCRUD(@"insert into Withdrawal (PaymentID) values ('" + PaymentID + "')") + "\n";

                    //MessageBox.Show(msg);
                    MessageBox.Show("Transaction, Payment and Withdrawal Tables Updated Successfully!");

                    withdrawAmountTB.Text = "";
                }
                

            }
        }

       //
    }
}
