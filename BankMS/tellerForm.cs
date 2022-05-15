using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMS
{
    public partial class tellerForm : Form
    {
        public tellerForm()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.centerPanel.Controls.Count > 0)
                this.centerPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.centerPanel.Controls.Add(f);
            this.centerPanel.Tag = f;
            f.Show();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            loadForm(new tellerChildForm.hesaplarForm());           
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            loadForm(new tellerChildForm.taleplerForm());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            loadForm(new tellerChildForm.musteriIslemlerForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm obj = new loginForm();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new tellerChildForm.krediTalepleri());
        }
    }
}
