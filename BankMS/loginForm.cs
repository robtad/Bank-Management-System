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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            userNameTB.Text = "";
            passwordTB.Text = "";
            roleCB.SelectedIndex = -1;
            roleCB.Text = "Role";
        }
    }
}
