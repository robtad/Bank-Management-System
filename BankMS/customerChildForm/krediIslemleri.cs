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

                    msg = db.performCRUD(@"insert into RequestLoan(CustomerTCKN,Amount,Expiration) 
                                    values('" + loginForm.userId + "','" + creditAmountTB.Text + "','" + ExpirationCB.SelectedItem.ToString() + "')") + "\n";

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

        }


        //
    }
}
