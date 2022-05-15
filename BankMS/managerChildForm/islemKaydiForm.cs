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

namespace BankMS.managerChildForm
{
    public partial class islemKaydiForm : Form
    {
        DbConnector db = new DbConnector();

        public islemKaydiForm()
        {
            InitializeComponent();
            
        }

        private void islemKaydiForm_Load(object sender, EventArgs e)
        {
            showTransactions();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			showTransactions();
        }

        private void showTransactions()
        {
			string num = "TOP " + comboBox1.SelectedItem.ToString() + " *";
			if (num.Contains("Hepsi"))
            {
				num = "*";
            } 
			
			string query = "SELECT "+num+" FROM" + @" 
								(
									(
									SELECT  t.id AS IşlemNo, CONVERT(varchar(10), t.AccountNo) AS Kaynak, CONVERT(varchar(10), tr.TargetAccountNO) AS Hedef, 'Para Gönderme' AS İşlem, p.Amount AS Tutar, t.Balance AS 'Kaynak Bakiye', (SELECT Balance FROM Account WHERE AccountNo = tr.TargetAccountNo) AS 'Hedef Bakiye', Date
									FROM TransactionTbl t, Payment p, TransferTbl tr
									WHERE t.id = p.TransactionID AND tr.PaymentID = p.id
									)			
										UNION ALL
									(
									SELECT t.id, CONVERT(varchar(10), t.AccountNo), 'Banka', 'Borç Ödeme', p.Amount, t.Balance, null, Date
									FROM TransactionTbl t, Payment p, LoanRepayment l
									WHERE t.id = p.TransactionID AND l.PaymentID = p.id
									)
										UNION ALL
									(
									SELECT t.id, 'Customer' + CONVERT(varchar(10), t.AccountNo), CONVERT(varchar(10), t.AccountNo), 'Para Yatırma', p.Amount, null, t.Balance, Date
									  FROM TransactionTbl t, Payment p, Deposit d
									WHERE t.id = p.TransactionID AND d.PaymentID = p.id
									)
										UNION ALL
									(
									SELECT t.id, CONVERT(varchar(10), t.AccountNo), 'Customer' + CONVERT(varchar(10), t.AccountNo), 'Para Çekme', p.Amount, t.Balance, null, Date
									  FROM TransactionTbl t, Payment p, Withdrawal w
									WHERE t.id = p.TransactionID AND w.PaymentID = p.id
									)
								)t ORDER BY t.IşlemNo;";
			
			db.fillDataGridView(query, dataGridView1);
        }

    }
}
