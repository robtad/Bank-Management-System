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

        #region DropDown Menu

        private void customizeDesign()
        {
            panelBankaSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelBankaSubmenu.Visible == true)
                panelBankaSubmenu.Visible = false;
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

        private void btnBankaIslemleri_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBankaSubmenu);
        }

        #endregion

        #region Load Forms

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.anaSayfaForm());
        }

        //when first open manager dashboard from login
        private void managerForm_Load(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.anaSayfaForm());
        }

        #region Banka Islemleri Forms
        private void btnGenelDurum_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.genelDurumForm());
        }

        private void btnIslemKaydi_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.islemKaydiForm());
        }

        private void btnKrediIslem_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.krediIslemForm());
        }

        private void btnDoviz_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.dovizForm());
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.bankaTarihiForm());
        }
        #endregion

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.musteriForm());
        }

        private void btnTemsilciler_Click(object sender, EventArgs e)
        {
            loadForm(new managerChildForm.temsilciForm());
        }

        #endregion

        public void loadForm(object Form)
        {
            if (this.panelCenter.Controls.Count > 0)
                this.panelCenter.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelCenter.Controls.Add(f);
            this.panelCenter.Tag = f;
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm obj = new loginForm();
            obj.Show();
            this.Hide();
        }
    }
}
