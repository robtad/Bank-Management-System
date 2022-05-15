using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLRDbConnector;

namespace BankMS.managerChildForm
{//
    public partial class bankaTarihiForm : Form
    {
        DbConnector db = new DbConnector();
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        DateTime bankDate;

        public bankaTarihiForm()
        {
            InitializeComponent();
            //Console.WriteLine(ConnectionString);
        }
        private void bankaTarihiForm_Load(object sender, EventArgs e)
        {
            string dateTemp;
            db.getSingleValue("Select * From Date", out dateTemp, 0);
            bankDate = DateTime.Parse(dateTemp);
            labelDate.Text = bankDate.ToLongDateString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Banka Tarihi 1 Ay İlerlesin?", 
                                        "EMİN MİSİNİZ?!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bankDate = bankDate.AddMonths(1);
                labelDate.Text = bankDate.ToLongDateString();
                db.performCRUD("UPDATE Date SET BankDate = '"+bankDate+"'");
                updateGeneral();
            }
        }

        // maaşların ödenmesi, gelir-gider durumlarının
        // güncellenmesi ve müşterilerin bir sonraki aya ait borçlarının kendilerine
        // yansıtılması gerekmektedir.

        private void updateGeneral()
        {
            paySalary();
        }

        private void paySalary()
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TCKN FROM Teller", con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0, totalSalary;
            string TCKN, salaryID, salaryAmount, payrollLogID;
            db.getSingleValue("SELECT * From Salary", out salaryID, 0);
            db.getSingleValue("SELECT Amount From Salary WHERE id = '"+ salaryID +"'", out salaryAmount, 0);

            //create PayrollLog and get the ID
            db.getSingleValue("INSERT INTO PayrollLog(TotalAmount) VALUES(0); SELECT IDENT_CURRENT('PayrollLog') ", out payrollLogID, 0);

            while (reader.Read())
            {
                TCKN = reader.GetValue(0).ToString();
                string message = db.performCRUD("INSERT INTO Payroll(TCKN, SalaryID, PaymentDate, PayrollLogID)" +
                                "VALUES('"+TCKN+"','"+salaryID+"','"+bankDate+"', '"+ payrollLogID + "')");
                count++;
                //MessageBox.Show(message);
            }
            con.Close();
            
            //for bank monthly report total payroll for teller's salary

            totalSalary = (Convert.ToInt32(salaryAmount)) * count;
            db.performCRUD("UPDATE PayrollLog SET TotalAmount = '"+ totalSalary + "' WHERE id = '"+payrollLogID+"'");

            MessageBox.Show("TÜM TEMSİLCİLERİN MAAŞLARI ÖDENMİŞTİR",bankDate.ToString("ddd, dd/MMM/yyyy"), MessageBoxButtons.OK,MessageBoxIcon.Asterisk);            
        }
    }
}
