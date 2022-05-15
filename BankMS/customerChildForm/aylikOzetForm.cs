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

namespace BankMS.customerChildForm
{
    public partial class aylikOzetForm : Form
    {
        DbConnector db = new DbConnector();
       

        public aylikOzetForm()
        {
            InitializeComponent();
        }
    }
}
