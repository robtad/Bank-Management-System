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

namespace BankMS.managerChildForm
{
    public partial class bankaTarihiForm : Form
    {
        DbConnector db = new DbConnector();
        DateTime bankDate;

        public bankaTarihiForm()
        {
            InitializeComponent();
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

            bankDate = bankDate.AddMonths(1);
            labelDate.Text = bankDate.ToLongDateString();
            db.performCRUD("UPDATE Date SET BankDate = '"+bankDate+"'");
            
        }

        private void paySalary()
        {

        }
    }
}
