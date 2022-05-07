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
    public partial class managerForm : Form
    {
        public managerForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelBankaSubmenu.Visible = false;
            panelTemsilciSubmenu.Visible = false;
            panelMusteriSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelBankaSubmenu.Visible == true)
                panelBankaSubmenu.Visible = false;
            if (panelTemsilciSubmenu.Visible == true)
                panelTemsilciSubmenu.Visible = false;
            if (panelMusteriSubmenu.Visible == true)
                panelMusteriSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm obj = new loginForm();
            obj.Show();
            this.Hide();
        }

        private void btnBankaIslemleri_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBankaSubmenu);
        }

       
        private void btnTemsilciler_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTemsilciSubmenu);
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMusteriSubmenu);
        }

    }
}
