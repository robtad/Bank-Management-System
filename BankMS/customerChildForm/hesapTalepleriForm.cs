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
    public partial class hesapTalepleriForm : Form
    {
        public hesapTalepleriForm()
        {
            InitializeComponent();
            displayCustomerInfo();
            db.FillCombobox("SELECT Name FROM Currency", CurrencyCB);

        }
        DbConnector db = new DbConnector();
        
        private void displayCustomerInfo()
        {

            db.fillDataGridView("SELECT * FROM CustomerAccounts  WHERE CustomerTCKN = '" + loginForm.userId + "'", customerDataGrid);
        }
        string message;

        private void btnConfirmNewAcc_Click(object sender, EventArgs e)
        {

            if (CurrencyCB.SelectedIndex == -1)
            {
                MessageBox.Show("Select Currency before submitting");
            }
            else
            {
                try
                {

                    message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)
                                            insert into CustomerRequestAccount(CustomerTCKN,Currency, RequestDate) 
                                            values('" + loginForm.userId + "','" + CurrencyCB.SelectedItem.ToString() + "', @date)") + "\n";

                    //MessageBox.Show(message);
                    MessageBox.Show("Request Has Been Sent To Your Teller Successfully!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }
        private void btnConfirmDeleteAcc_Click(object sender, EventArgs e)
        {
            if (AccNumberTB.Text == "")
            {
                MessageBox.Show("Select From Grid View The Account You Want to Delete!");
            }
            else
            {
                try
                {

                    message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)
                                            insert into CustomerDeleteAccount(CustomerTCKN,AccountNo,RequestDate) 
                                            values('" + loginForm.userId + "','" + AccNumberTB.Text + "',@date)") + "\n";

                    if (message.Contains("duplicate"))
                    {
                        message = "You Have Already Requested For The Selected Account To Be Deleted\nRequest Status: Pending...";
                    }

                   // MessageBox.Show(message);
                   MessageBox.Show("Account Delete Request Sent To Your Teller Successfully!");



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            if (btnCheckBalance.Text == "")
            {
                MessageBox.Show("To Check Balance Select Account From Grid View or" + "\n" + "Enter Your Account Number");
            }
            else
            {
                try
                {
                     
                    string[] accountDetails = db.getArray("select Balance, CurrencyName from Account where AccountNo = '"+ accountTB.Text +"'", 2);
                    balanceTB.Text = accountDetails[0];
                    lblCurrency.Text = accountDetails[1];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

             
        int index;
        
        private void customerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            AccNumberTB.Text = row.Cells[1].Value.ToString();
            accountTB.Text = row.Cells[1].Value.ToString();
        }

        //
    }
}
