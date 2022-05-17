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
			hesaplarGoster();
			//List<string> list = new List<string>();
			//string[] array = new string[10];
		}
		DbConnector db = new DbConnector();
		string secilen;
		private void showTransactions()
		{
			paraGonder();
			borcOdeme();
			paraYatir();
			paraCek();
			//hesaplarGoster();
		}

		private void paraGonder()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo AS Kaynak, tr.TargetAccountNo AS Hedef, t.Balance AS Bakiye, p.Amount AS Tutar, Currency, t.Date
								FROM TransactionTbl t, Payment p, TransferTbl tr
								WHERE t.id = p.TransactionID AND tr.PaymentID = p.id
								AND AccountNo = '" + secilen + "'", dataGridViewParaGonder);
			db.fillDataGridView(@"SELECT AccountNo AS Gönderen, Amount AS Tutar, Date
								FROM TransactionTbl t, Payment p, TransferTbl tr
								WHERE t.id = p.TransactionID AND tr.PaymentID = p.id
								AND TargetAccountNo = '" + secilen + "'", dataGridViewGelen);
		}

		private void borcOdeme()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, LoanRepayment l
								WHERE t.id = p.TransactionID AND l.PaymentID = p.id
								AND AccountNo = '" + secilen + "'", dataGridViewBorc);
		}

		private void paraYatir()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, Deposit d
								WHERE t.id = p.TransactionID AND d.PaymentID = p.id
								AND AccountNo = '" + secilen + "'", dataGridViewYatir);
		}

		private void paraCek()
		{
			db.fillDataGridView(@"SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
								FROM TransactionTbl t, Payment p, Withdrawal w
								WHERE t.id = p.TransactionID AND w.PaymentID = p.id
								AND AccountNo = '" + secilen + "'", dataGridViewCek);


		}
		private void hesaplarGoster()
        {
			db.fillDataGridView(@"SELECT c.TCKN, FirstName, LastName, ca.AccountNo, Balance, CurrencyName
							FROM Customer c, TellerCustomer tc, CustomerAccounts ca, Account a
							WHERE c.TCKN = tc.CustomerTCKN AND tc.TellerTCKN = '"+loginForm.userId+"' AND ca.CustomerTCKN = c.TCKN AND a.AccountNo = ca.AccountNo", secim);
        }

        private void secim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			secilen = secim.CurrentRow.Cells[3].Value.ToString();
			showTransactions();

			string strGidenTransfer, strParaCikar, strBorc, strGelenTransfer, strYatanPara;
			decimal gidenTransfer, paraCikar, borc, gelenTransfer, yatanPara, totalGelir, totalGider;

			gidenTransfer = dataGridViewParaGonder.Rows.Cast<DataGridViewRow>()
					.Sum(t => Convert.ToDecimal(t.Cells[4].Value));
			paraCikar = dataGridViewCek.Rows.Cast<DataGridViewRow>()
					.Sum(t => Convert.ToDecimal(t.Cells[2].Value));
			borc = dataGridViewBorc.Rows.Cast<DataGridViewRow>()
					.Sum(t => Convert.ToDecimal(t.Cells[2].Value));
			gelenTransfer = dataGridViewGelen.Rows.Cast<DataGridViewRow>()
					.Sum(t => Convert.ToDecimal(t.Cells[1].Value));
			yatanPara = dataGridViewYatir.Rows.Cast<DataGridViewRow>()
					.Sum(t => Convert.ToDecimal(t.Cells[2].Value));

			totalGelir = gelenTransfer + yatanPara;
			totalGider = gidenTransfer + paraCikar + borc;

			gelir.Text = totalGelir.ToString("F2");
			gider.Text = totalGider.ToString("F2");
		}



 
    }
}
