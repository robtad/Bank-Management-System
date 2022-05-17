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
    public partial class genelDurumForm : Form
    {
        DbConnector db = new DbConnector();
        string totalSalary, totalKredi, totalGelir, totalBakiye;
        int totalSalaryNum, totalKrediNum, totalGelirNum, totalBakiyeNum;

        public genelDurumForm()
        {
            InitializeComponent();
            bankDate();
        }

        private void genelDurumForm_Load(object sender, EventArgs e)
        {
            showPayrollLogTab();
            tumIslemler();
        }

        private void showPayrollLogTab()
        {
            string num = comboBox1.SelectedItem.ToString();
            if (!num.Contains("Hepsi"))
            {
                db.fillDataGridView("SELECT DISTINCT TOP " + num + "  PaymentDate, TotalAmount " +
                                    "FROM PayrollLog PL, Payroll P " +
                                    "WHERE PL.id = P.PayrollLogID " +
                                    "ORDER BY PaymentDate DESC", dataGridPayroll
                                    );
            }
            else
            {
                db.fillDataGridView("SELECT DISTINCT PaymentDate, TotalAmount " +
                                    "FROM PayrollLog PL, Payroll P " +
                                    "WHERE PL.id = P.PayrollLogID " +
                                    "ORDER BY PaymentDate DESC", dataGridPayroll
                                    );
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPayrollLogTab();
        }
 
        private void bankDate()
        {
            string dateTemp;
            db.getSingleValue("Select * From Date", out dateTemp, 0);
            DateTime bankDate = DateTime.Parse(dateTemp);
            labelBankaaTarihi.Text = bankDate.ToString("ddd, dd/MMM/yyyy");
        }

        //Banka Hesaplamalari

        private void totalSalaryCount()
        {
            db.getSingleValue("SELECT SUM(TotalAmount) FROM PayrollLog", out totalSalary, 0);
            if (totalSalary != "")
            {
                totalSalaryNum = Convert.ToInt32(totalSalary); //ToString("#,##0") for adding comma to number
            }
            labelTotalSalary.Text = totalSalaryNum.ToString("N0") + " (Maaş)";
        }

        private void totalCreditCount()
        {
            db.getSingleValue("SELECT SUM(TotalAmount) FROM Loan", out totalKredi, 0);
            if (totalKredi != "")
            {
                totalKrediNum = Convert.ToInt32(totalKredi);
            }
            labelTotalKredi.Text = totalKrediNum.ToString("N0") + " (Kredi)";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM Loan", dataGridViewKredi);
            db.fillDataGridView("SELECT LoanID, Amount FROM Payment p, LoanRepayment l WHERE p.id = l.PaymentID; ", dataGridRepayment);
        }

        private void totalGelirCount()
        {
            db.getSingleValue("SELECT SUM(Amount) FROM Payment p, LoanRepayment l WHERE p.id = l.PaymentID;", out totalGelir, 0);
            if (totalGelir != "")
            {
                totalGelirNum = Convert.ToInt32(totalGelir);
            }
            labelGelir.Text = "TLY " + totalGelirNum.ToString("N0") + " \n(Kredi Ödeme)";
        }

        private void totalBakiyeCount()
        {
            db.getSingleValue("SELECT Balance FROM Bank", out totalBakiye, 0);
            if (totalBakiye != "")
            {
                totalBakiyeNum = Convert.ToInt32(totalBakiye);
            }
        }

        private void tumIslemler()
        {
            totalSalaryCount();
            totalCreditCount();
            int totalGiderTemp = totalKrediNum + totalSalaryNum;
            totalGider.Text = "TLY " + totalGiderTemp.ToString("N0");

            totalGelirCount();

            int totalKar = totalGelirNum - totalGiderTemp;
            labelKar.Text = totalKar.ToString("N0");

            totalBakiyeCount();

            int bankBalance = totalBakiyeNum + totalKar;
            labelBakiye.Text = "TLY " + bankBalance.ToString("N0");
        }


    }
}
