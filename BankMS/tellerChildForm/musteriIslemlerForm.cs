using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMS.tellerChildForm
{
    public partial class musteriIslemlerForm : Form
    {
        public musteriIslemlerForm()
        {
            InitializeComponent();
			showTransactions();

		}
		DbConnector db = new DbConnector();

		private void showTransactions()
		{
			paraGonder();
			borcOdeme();
			paraYatir();
			paraCek();
		}

		private void paraGonder()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo AS Kaynak, tr.TargetAccountNo AS Hedef, t.Balance AS Bakiye, p.Amount AS Tutar, Currency, t.Date
								FROM TransactionTbl t, Payment p, TransferTbl tr
								WHERE t.id = p.TransactionID AND tr.PaymentID = p.id", dataGridViewParaGonder);
		}

		private void borcOdeme()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, LoanRepayment l
								WHERE t.id = p.TransactionID AND l.PaymentID = p.id", dataGridViewBorc);
		}

		private void paraYatir()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, Deposit d
								WHERE t.id = p.TransactionID AND d.PaymentID = p.id", dataGridViewYatir);
		}

		private void paraCek()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, Withdrawal w
								WHERE t.id = p.TransactionID AND w.PaymentID = p.id", dataGridViewCek);
		}
	}
}
