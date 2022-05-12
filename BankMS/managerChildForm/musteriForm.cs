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
            db.fillDataGridView("SELECT C.id, TCKN, Name, Surname, Gender, Telephone, Address, Email, Password, CreateTime, TellerID FROM Customer C, CustomerProfile P WHERE C.id = P.CustomerID", dataGridView1);
        }
        private void musteriForm_Load(object sender, EventArgs e)
        {
            tableShow();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxPassword.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBoxTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxCinsiyet.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBoxAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxTemsilciID.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string message = db.fillDataGridView("SELECT C.id, TCKN, Name, Surname, Gender, Telephone, Address, Email, Password, CreateTime, TellerID FROM Customer C, CustomerProfile P WHERE C.id = P.CustomerID AND Surname = '" + textBoxSoyad.Text + "'", dataGridView1);
            MessageBox.Show(message);
        }
    }
}
