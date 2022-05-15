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
			deadlock += ")";
			labelDeadLock.Text = deadlock;
			//Console.WriteLine(deadlock);
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
			sameValue(dataGridView1);
			//FindSameValueInCellsOfDataGridView(dataGridView1);
			//detectDeadlock();

		}

		string deadlock = "(";
		DataGridViewRow lastRow = null;
		private Random rnd = new Random();

		private void detectDeadlock(DataGridViewRow row1, DataGridViewRow row2)
        {
			string targetAcc1 = row1.Cells[2].Value.ToString();
			string sourceAcc1 = row2.Cells[1].Value.ToString();
			string targetAcc2 = row1.Cells[1].Value.ToString();
			string sourceAcc2 = row2.Cells[2].Value.ToString();

			if (lastRow != null)
			{
				if (lastRow.Cells[7].Value != null && row1.Cells[7].Value != null)
				{
					if (lastRow.Cells[7].Value.ToString() != row1.Cells[7].Value.ToString())
					{
						Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
						row1.Cells[7].Style.BackColor = color;
						row2.Cells[7].Style.BackColor = color;
					}
				}
			}

			if (targetAcc1 == sourceAcc1 || targetAcc2 == sourceAcc2)
            {
				if (lastRow != null)
				{
					if (lastRow.Cells[7].Value != null && row1.Cells[7].Value != null)
					{
						if (lastRow.Cells[7].Value.ToString() != row1.Cells[7].Value.ToString())
						{
							deadlock += ") + (";
							Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
							row1.Cells[7].Style.BackColor = color;
							row2.Cells[7].Style.BackColor = color;
						}
					}
				}

				var result = row1.Cells[0].Value.ToString() + " ile " + row2.Cells[0].Value.ToString();
				Console.WriteLine(result);
				
				if (!deadlock.Contains(row1.Cells[0].Value.ToString()))
                {
					deadlock += row1.Cells[0].Value.ToString() + " ";
					
					lastRow = row1;
                }
				if (!deadlock.Contains(row2.Cells[0].Value.ToString()))
				{
					deadlock += row2.Cells[0].Value.ToString()+" ";
					
					lastRow = row2;
				}
				//Console.WriteLine(deadlock);
				
			}
			


			// make datagrid to array
			/*
			string[,] myGridData = new string[dataGridView1.Rows.Count, dataGridView1.Columns.Count];

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				foreach (DataGridViewColumn col in dataGridView1.Columns)
				{
					if (dataGridView1.Rows[row.Index].Cells[col.Index].Value != null)
					{
						myGridData[row.Index, col.Index] = dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString();
					}
				}
			}

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
                if (row.Cells[7].Value != null)
                {
					Console.WriteLine(row.Cells[7].Value.ToString());

                }
			}

			HashSet<string> unique = new HashSet<string>();

			foreach (var item in myGridData)
				if (!unique.Add(item))
					Console.WriteLine(item);
			*/

		}

		private void sameValue(DataGridView dgv)
		{
			deadlock = "(";
			int rowCount = dgv.Rows.Count;
			
			for (int i = 0; i < rowCount; i++)
			{
				if (dgv.Rows[i].Cells[7].Value != null)
				{
                    for (int j = i + 1; j < rowCount; j++) //rowCount-i bir kere doner
					{
						if (dgv.Rows[j].Cells[7].Value != null)
						{
							if (dgv.Rows[i].Cells[7].Value.ToString() == dgv.Rows[j].Cells[7].Value.ToString())
							{

								dgv.Rows[i].Cells[7].Style.BackColor = Color.Red;
								dgv.Rows[j].Cells[7].Style.BackColor = Color.Red;
								//Console.WriteLine(dgv.Rows[i].Cells[0].Value.ToString());
								//Console.WriteLine(dgv.Rows[j].Cells[0].Value.ToString());
								detectDeadlock(dgv.Rows[i], dgv.Rows[j]);
							}
						}
                    }
				}
			}
			
		}

		/*
		private void FindSameValueInCellsOfDataGridView(DataGridView dgv)
		{
			int rowCount = dgv.Rows.Count;
			int colCount = dgv.Columns.Count;
			for (int i = 0; i < rowCount; i++)
			{
				for (int j = 0; j < colCount; j++)
				{
					if (dgv.Rows[i].Cells[j].Value != null)
					{
						for (int k = i + 1; k < rowCount; k++)
						{
							for (int l = 0; l < colCount; l++)
							{
								if (dgv.Rows[k].Cells[l].Value != null)
								{
									if (dgv.Rows[i].Cells[j].Value.ToString() == dgv.Rows[k].Cells[l].Value.ToString())
									{
										dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
										dgv.Rows[k].Cells[l].Style.BackColor = Color.Red;
									}
								}
							}
						}
					}
				}
			}
		}
		*/
	}
}
