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
    public partial class dovizForm : Form
    {
        public dovizForm()
        {
            InitializeComponent();
        }

        DbConnector db = new DbConnector();

        private void getValue()
        {
            db.fillDataGridView("select * from Currency", dataGridView1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBoxPara.Text == "" || textBoxDeger.Text == "")
                MessageBox.Show("TÜM ALANLAR DOLDURULMALIDIR!!!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                db.performCRUD("insert into Currency(Name, ExchangeRate) values('" + textBoxPara.Text + "','" + textBoxDeger.Text + "')");
                getValue();
            }
        }

        private void dovizForm_Load(object sender, EventArgs e)
        {
            getValue();
            db.FillCombobox("select name from Currency", comboBox1);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPara.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxDeger.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.performCRUD("delete from Currency where name = '" + textBoxPara.Text + "'");
            getValue();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxPara.Text == "" || textBoxDeger.Text == "")
                MessageBox.Show("TÜM ALANLAR DOLDURULMALIDIR!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                db.performCRUD("update Currency set ExchangeRate = '" + textBoxDeger.Text + "' where name = '" + textBoxPara.Text + "'");
                getValue();
            }
        }
    }
}
