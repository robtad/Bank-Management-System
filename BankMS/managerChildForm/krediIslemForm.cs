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
    public partial class krediIslemForm : Form
    {
        public krediIslemForm()
        {
            InitializeComponent();
        }

        DbConnector db = new DbConnector();

        private void interestShow()
        {
            string loanInt, overdueInt;
            db.getSingleValue("SELECT LoanInterest FROM Interest", out loanInt, 0);
            labelKrediFaizi.Text = loanInt;
            db.getSingleValue("SELECT OverdueInterest FROM Interest", out overdueInt, 0);
            labelGecikmeFaizi.Text = overdueInt;
        }

        private void krediIslemForm_Load(object sender, EventArgs e)
        {
            interestShow();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            db.performCRUD("UPDATE Interest SET LoanInterest = '"+textBoxKredi.Text+"', OverdueInterest = '"+textBoxGecikme.Text+"'");

            interestShow();
        }
    }
}
