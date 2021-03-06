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
	public partial class aylikOzetForm : Form
	{
		public aylikOzetForm()
		{
			InitializeComponent();
		}

		DbConnector db = new DbConnector();
		private string accNo;

		private void aylikOzetForm_Load(object sender, EventArgs e)
		{
			showTransactions();
			db.FillCombobox("SELECT AccountNo FROM CustomerAccounts WHERE CustomerTCKN = '" + loginForm.userId + "'", comboBox1);
		}

		private void showTransactions()
		{
			paraGonder();
			borcOdeme();
			paraYatir();
			paraCek();
			faizAnapara();
			
		}

		private void faizAnapara()
		{
			db.fillDataGridView(@"SELECT ll.*
								FROM TransactionTbl t, Payment p, LoanRepayment l, LoanRepaymentLog ll
								WHERE t.id = p.TransactionID AND l.PaymentID = p.id AND ll.id = l.LoanRepaymentLogID AND t.AccountNo = '" + accNo + "'", dataGridView1);
		}

		private void paraGonder()
        {
			db.fillDataGridView(@"SELECT t.id, t.AccountNo AS Kaynak, tr.TargetAccountNo AS Hedef, t.Balance AS Bakiye, p.Amount AS Tutar, Currency, t.Date
								FROM TransactionTbl t, Payment p, TransferTbl tr
								WHERE t.id = p.TransactionID AND tr.PaymentID = p.id AND 
								AccountNo = '"+accNo+"'", dataGridViewParaGonder);
			db.fillDataGridView(@"SELECT AccountNo AS G?nderen, Amount AS Tutar, Date
								FROM TransactionTbl t, Payment p, TransferTbl tr
								WHERE t.id = p.TransactionID AND tr.PaymentID = p.id
								AND TargetAccountNo = '"+accNo+"'", dataGridViewGelenPara);
		}

		private void borcOdeme()
        {
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, LoanRepayment l
								WHERE t.id = p.TransactionID AND l.PaymentID = p.id
								AND AccountNo = '" + accNo + "'", dataGridViewBorc);
		}

		private void paraYatir()
        {
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, Deposit d
								WHERE t.id = p.TransactionID AND d.PaymentID = p.id
								AND AccountNo = '" + accNo + "'", dataGridViewYatir);
		}

		private void paraCek()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, Withdrawal w
								WHERE t.id = p.TransactionID AND w.PaymentID = p.id
								AND AccountNo = '" + accNo + "'", dataGridViewCek);
		}
		 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			accNo = comboBox1.SelectedItem.ToString();
			showTransactions();
		}
    }
}
