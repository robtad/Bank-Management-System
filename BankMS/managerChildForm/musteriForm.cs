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
    public partial class musteriForm : Form
    {
        public musteriForm()
        {
            InitializeComponent();
        }

        DbConnector db = new DbConnector();

        private void tableShow()
        {
            db.fillDataGridView("SELECT * FROM Customer", dataGridView1);
        }
        private void musteriForm_Load(object sender, EventArgs e)
        {
            tableShow();
        }
    }
}
