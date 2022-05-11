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
    public partial class customerForm : Form
    {
        public customerForm()
        {
            InitializeComponent();
            //welcomelbl.Text = loginForm.userId;
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

        private void btnGonder_Click(object sender, EventArgs e)
        {
            loadForm(new customerChildForm.paraGonderForm());

        }


        private void btnYatirCek_Click(object sender, EventArgs e)
        {
            loadForm(new customerChildForm.paraYatirCekForm());

        }
       
        private void btnHesapTalepleri_Click(object sender, EventArgs e)
        {
            loadForm(new customerChildForm.hesapTalepleriForm());

        }

        private void btnKrediIslemleri_Click(object sender, EventArgs e)
        {
            loadForm(new customerChildForm.krediIslemleri());
        }

        private void btnAylikOzet_Click(object sender, EventArgs e)
        {
            loadForm(new customerChildForm.aylikOzetForm());

        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            loadForm(new customerChildForm.bilgiGuncelleForm());

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm obj = new loginForm();
            obj.Show();
            this.Hide();
        }

       
    }
}
