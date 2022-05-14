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
    public partial class taleplerForm : Form
    {
        public taleplerForm()
        {
            InitializeComponent();
            displayNewAccInfo();
            displayDeleteAccInfo();
        }
        DbConnector db = new DbConnector();

        private void displayNewAccInfo()
        {

            db.fillDataGridView(@"SELECT cra.id, cra.CustomerTCKN, cra.Currency,cra.RequestDate 
                            FROM CustomerRequestAccount cra
                            INNER JOIN TellerCustomer tc ON cra.CustomerTCKN = tc.CustomerTCKN 
                            WHERE tc.TellerTCKN = '" + loginForm.userId + "'", customerDataGrid);
        }

        private void displayDeleteAccInfo()
        {

            db.fillDataGridView(@"SELECT cda.id, cda.CustomerTCKN, cda.AccountNo,cda.RequestDate 
                            FROM CustomerDeleteAccount cda
                            INNER JOIN TellerCustomer tc ON cda.CustomerTCKN = tc.CustomerTCKN 
                            WHERE tc.TellerTCKN = '" + loginForm.userId + "'", customerDataGrid2);

        }

        private void resetGrid1()
        {
            CustomerIdNewTB.Text = "";
            CurrencyTB.Text = "";
        }
        private void resetGrid2()
        {
            CustomerIdDeleteTB.Text = "";
            AccountNoTB.Text = "";
        }

        int index;
        int key1;
        int key2;
        private void customerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid.Rows[index];
            CustomerIdNewTB.Text = row.Cells[1].Value.ToString();
            CurrencyTB.Text = row.Cells[2].Value.ToString();

            //if (CustomerIdNewTB.Text == "" || CurrencyTB.Text == "" || DateNewAccTB.Text == "")
            if (CustomerIdNewTB.Text == "")
            {
                key1 = 0;

            }
            else
            {
                key1 = Convert.ToInt32(row.Cells[0].Value.ToString());

            }

        }


        private void customerDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = customerDataGrid2.Rows[index];
            CustomerIdDeleteTB.Text = row.Cells[1].Value.ToString();
            AccountNoTB.Text = row.Cells[2].Value.ToString();

            if (CustomerIdDeleteTB.Text == "")
            {
                key2 = 0;

            }
            else
            {
                key2 = Convert.ToInt32(row.Cells[0].Value.ToString());

            }
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

                    string msg = db.performCRUD(@"delete from CustomerRequestAccount where CustomerTCKN = '" + CustomerIdNewTB.Text + "' and " +
                                                "id = '" + key1 + "'");
                    //MessageBox.Show(msg);

                    //MessageBox.Show("Request Deleted!");

                    resetGrid1();
                    displayNewAccInfo();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteFromAccDeleteTable()
        {
            if (key2 == 0)
            {
                MessageBox.Show("Select the Request to be Deleted");
            }
            else
            {
                try
                {

                    string msg = db.performCRUD(@"delete from CustomerDeleteAccount where CustomerTCKN = '" + CustomerIdDeleteTB.Text + "' and id = '" + key2 + "'");
                    //MessageBox.Show(msg);
                    //MessageBox.Show("Request Deleted!");
                    resetGrid2();
                    displayDeleteAccInfo();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnCancelNewAcc_Click(object sender, EventArgs e)
        {
            if (key1 == 0 || CustomerIdNewTB.Text == "")
            {
                MessageBox.Show("Select the Request to be Deleted");
            }
            else
            {
                try
                {

                    string msg = db.performCRUD(@"delete from CustomerRequestAccount where CustomerTCKN = '" + CustomerIdNewTB.Text + "' and " +
                                                "id = '" + key1 + "'");
                    //MessageBox.Show(msg);

                    MessageBox.Show("Request Deleted!");

                    resetGrid1();
                    displayNewAccInfo();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnConfirmNewAcc_Click(object sender, EventArgs e)
        {
            string message;
            string AccNum;
            if (key1 == 0 || CustomerIdNewTB.Text == "" || CurrencyTB.Text == "")
            {
                MessageBox.Show("Select The Request to Approve It!");
            }
            else
            {
                try
                {
                    message = db.performCRUD(@"insert into Account(CurrencyName) values ('" + CurrencyTB.Text + "')") + "\n";

                    db.getSingleValue("select AccountNo from Account; select scope_identity();", out AccNum, 0);

                    message += db.performCRUD(@"insert into CustomerAccounts(CustomerTCKN,AccountNo) values ('" + CustomerIdNewTB.Text + "','" + AccNum + "')") + "\n";

                    //MessageBox.Show(message);

                    if (message.Contains("success"))
                    {
                        deleteFromAccRequestTable();
                    }
                    MessageBox.Show("Account Created Successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }
        }

        private int checkBalance()
        {
            string balance;
            db.getSingleValue("select Balance from Account where AccountNo = '" + AccountNoTB.Text + "'", out balance, 0);
            //MessageBox.Show(balance);
            int balanceInt;
            balanceInt = Convert.ToInt32(balance);
           
            return balanceInt;
        }

        private void btnConfirmDeleteAcc_Click(object sender, EventArgs e)
        {

            if (checkBalance() != 0)
            {
                MessageBox.Show("Account Balance Has To Be Zero To Be Deleted!");
            }
            else 
            { 

                if (key2 == 0)
                {
                    MessageBox.Show("Select the Account to be Deleted");
                }
                else
                {
                    try
                    {

                        string msg = db.performCRUD("delete from Account where AccountNo = '" + AccountNoTB.Text + "'");
                        //MessageBox.Show(msg);

                        deleteFromAccDeleteTable();

                        MessageBox.Show("Account Deleted Successfully!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                }

            }


        }
   
    
    
    
    }
}
