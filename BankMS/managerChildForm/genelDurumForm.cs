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
        string totalSalary;

        public genelDurumForm()
        {
            InitializeComponent();
            totalSalaryCount();
        }

        private void genelDurumForm_Load(object sender, EventArgs e)
        {
            showPayrollLogTab();
        }

        private void showPayrollLogTab()
        {
            string num = comboBox1.SelectedItem.ToString();
            if (!num.Contains("Hepsi"))
            {
                db.fillDataGridView("SELECT DISTINCT TOP "+num+ "  PaymentDate, TotalAmount " +
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

        private void totalSalaryCount()
        {
            db.getSingleValue("SELECT SUM(TotalAmount) FROM PayrollLog", out totalSalary, 0);
            
            labelTotalSalary.Text = Convert.ToInt32(totalSalary).ToString("N0"); //ToString("#,##0") for adding comma to number
        }
 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPayrollLogTab();
        }
    }
}
