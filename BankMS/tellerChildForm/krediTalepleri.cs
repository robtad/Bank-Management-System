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

            db.fillDataGridView(@"SELECT rl.id, rl.CustomerTCKN, rl.Amount,rl.Expiration, rl.RequestDate 
                            FROM RequestLoan rl
                            INNER JOIN TellerCustomer tc ON rl.CustomerTCKN = tc.CustomerTCKN 
                            WHERE tc.TellerTCKN = '" + loginForm.userId + "'", customerDataGrid);
        }

        private void resetGrid()
        {
            CustomerIdTB.Text = "";
            creditAmountTB.Text = "";
            expirationTB.Text = "";
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
                    float LoanInterest, OverdueInterest;
                    string[] interestInfo = db.getArray("select LoanInterest, OverdueInterest from Interest where id = '" +id+ "'", 2);
                    LoanInterest = float.Parse(interestInfo[0]);
                    OverdueInterest = float.Parse(interestInfo[1]);
                    
                    float mortgage;
                    float totalAmount = float.Parse(creditAmountTB.Text);
                    int expiration = Int32.Parse(expirationTB.Text);
                    LoanInterest /= 100;
                    mortgage = (totalAmount * LoanInterest) / (1 - (float)Math.Pow((1 + LoanInterest), -expiration));

                    message = db.performCRUD(@"DECLARE @date DATE = (SELECT BankDate FROM Date)insert into Loan(CustomerTCKN,TotalAmount,MonthlyPayment,RemainingPrincipal,Expiration,DateStarted) values ('" + CustomerIdTB.Text + "','" + creditAmountTB.Text + "','" + mortgage + "','" + creditAmountTB.Text + "','" + expirationTB.Text + "',@date)") + "\n";

                    //MessageBox.Show(message);

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
            creditAmountTB.Text = row.Cells[2].Value.ToString();
            expirationTB.Text = row.Cells[3].Value.ToString();


            if (CustomerIdTB.Text == "" || creditAmountTB.Text == "" || expirationTB.Text == "")
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
