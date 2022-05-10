using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMS.managerChildForm
{
    public partial class temsilciForm : Form
    {
        public temsilciForm()
        {
            InitializeComponent();
            
        }

        DbConnector db = new DbConnector();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (boxAmount.Text == "")
                MessageBox.Show("LÜTFEN MAAŞ MİKTARI GİRİNİZ!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                db.performCRUD("UPDATE Salary set Amount = '" + boxAmount.Text + "' where id = 1");
                MessageBox.Show("Successfully Updated!");
                updateSalaryForm();
            }
        }

        private void updateSalaryForm()
        {
            string salAmount;
            db.getSingleValue("SELECT Amount FROM Salary WHERE id = 1", out salAmount, 0);
            labelAmount.Text = salAmount;
        }

        private void tableShow()
        {
            db.fillDataGridView("SELECT T.id, TCKN, Name, Surname, Gender, Telephone, Address, Email, Password, CreateTime FROM Teller T, TellerProfile P WHERE T.id = P.TellerID", dataGridView1);
        }

        private void temsilciForm_Load(object sender, EventArgs e)
        {
            tableShow();
            updateSalaryForm();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string message;
            message = db.performCRUD("INSERT INTO Teller(Email, Password) values('" + textBoxEmail.Text + "','" + textBoxPass.Text + "')");
            
            string tellerID;
            db.getSingleValue("SELECT id FROM Teller WHERE Email = '" +textBoxEmail.Text +"'", out tellerID, 0);
            message += db.performCRUD("INSERT INTO TellerProfile(TCKN, Name, Surname, Gender, Telephone, Address, TellerID) " +
                "values('" + textBoxTC.Text + "','" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + comboBoxCinsiyet.SelectedItem.ToString() + "','" + textBoxTel.Text + "','" + richTextBoxAdres.Text + "', '"+tellerID+"')");

            MessageBox.Show(message);
            tableShow();
            clearForm();
        }

        private void clearForm()
        {
            textBoxID.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPass.Text = string.Empty;
            textBoxTC.Text = string.Empty;
            textBoxAd.Text = string.Empty;
            textBoxSoyad.Text = string.Empty;
            comboBoxCinsiyet.SelectedItem = string.Empty;
            textBoxTel.Text = string.Empty;
            richTextBoxAdres.Text = string.Empty;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string message = db.fillDataGridView("SELECT T.id, TCKN, Name, Surname, Gender, Telephone, Address, Email, Password FROM Teller T, TellerProfile P WHERE T.id = P.TellerID AND Surname = '" + textBoxSoyad.Text + "'", dataGridView1);
            MessageBox.Show(message);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxPass.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBoxTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxCinsiyet.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBoxAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearForm();
            tableShow();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string message;
            message = db.performCRUD("UPDATE Teller SET Email = '" + textBoxEmail.Text + "', Password = '" + textBoxPass.Text + "' WHERE id = '"+ textBoxID.Text +"'");

            message += db.performCRUD("UPDATE TellerProfile SET TCKN = '" + textBoxTC.Text + "', Name = '" + textBoxAd.Text + "', Surname = '" + textBoxSoyad.Text + "', Gender = '" + comboBoxCinsiyet.SelectedItem.ToString() + "', Telephone = '" + textBoxTel.Text + "', Address = '" + richTextBoxAdres.Text + "' WHERE TellerID = '"+textBoxID.Text+"'");

            MessageBox.Show(message);
            tableShow();
            clearForm();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string message;
            message = db.performCRUD("DELETE FROM TellerProfile WHERE TellerID = '" + textBoxID.Text + "'");
            message += db.performCRUD("DELETE FROM Teller WHERE id = '" + textBoxID.Text + "'");

            MessageBox.Show(message);
            tableShow();
        }
    }
}
