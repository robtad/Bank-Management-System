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
{//
    public partial class temsilciForm : Form
    {
        public temsilciForm()
        {
            InitializeComponent();
        }

        DbConnector db = new DbConnector();

        private void temsilciForm_Load(object sender, EventArgs e)
        {
            tableShow();
            updateSalaryForm();
        }

        private void tableShow()
        {
            //the old query without MusteriSayisi
            //SELECT T.TCKN, FirstName, LastName, Telephone, Gender, Address, Email, Password, DateCreated, DateUpdated FROM Teller T, TellerLogin L WHERE T.TCKN = L.TCKN
            db.fillDataGridView(@"SELECT T.TCKN, FirstName, LastName, Telephone, Gender, Address, Email, Password, DateCreated, DateUpdated,
                                        (SELECT COUNT(CustomerTCKN)
                                        FROM TellerCustomer TL
                                        WHERE TL.TellerTCKN = T.TCKN
                                        GROUP BY TellerTCKN) AS 'MüşteriSayısı'
                                FROM Teller T, TellerLogin L
                                WHERE T.TCKN = L.TCKN", dataGridView1);
        }

        private void clearForm()
        {
            textBoxTCKN.Text = string.Empty;
            textBoxPass.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxAd.Text = string.Empty;
            textBoxSoyad.Text = string.Empty;
            comboBoxCinsiyet.SelectedItem = string.Empty;
            textBoxTel.Text = string.Empty;
            richTextBoxAdres.Text = string.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTCKN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxCinsiyet.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            richTextBoxAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxPass.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearForm();
            tableShow();
        }

        #region Teller

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string message;
            if (textBoxTCKN.Text == "" || textBoxAd.Text == "" || textBoxSoyad.Text == "" ||
                textBoxTel.Text == "" || richTextBoxAdres.Text == "" || textBoxEmail.Text == "" ||
                textBoxPass.Text == "")
            {
                MessageBox.Show("TÜM ALANLAR DOLDURULMALIDIR!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                message = db.performCRUD("INSERT INTO Teller(TCKN, FirstName, LastName, Telephone, Address, Gender, Email) " +
                                        "values('" + textBoxTCKN.Text + "','" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + textBoxTel.Text + "','" + richTextBoxAdres.Text + "','" + comboBoxCinsiyet.SelectedItem.ToString() + "','" + textBoxEmail.Text + "')");

                message += db.performCRUD("INSERT INTO TellerLogin(TCKN, Password) " +
                                        "values('" + textBoxTCKN.Text + "','" + textBoxPass.Text + "')");

                //MessageBox.Show(message);
                if (!message.Contains("failed"))
                {
                    MessageBox.Show("TEMSİLCİ EKLENMİŞTİR", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("TEMSİLCİ EKLENMEMİŞTİR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tableShow();
                clearForm();
            }
        }      
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string message;
            message = db.performCRUD(@"UPDATE Teller SET Email = '"+textBoxEmail.Text+"', TCKN = '" + textBoxTCKN.Text + "', FirstName = '" + textBoxAd.Text + 
                                    "', LastName = '" + textBoxSoyad.Text + "', Gender = '" + comboBoxCinsiyet.SelectedItem.ToString() + 
                                    "', Telephone = '" + textBoxTel.Text + "', Address = '" + richTextBoxAdres.Text + "', DateUpdated = GETDATE() " +
                                    "WHERE TCKN = '" + textBoxTCKN.Text + "'");

            message += db.performCRUD("UPDATE TellerLogin SET Password = '" + textBoxPass.Text + "' WHERE TCKN = '" + textBoxTCKN.Text + "'");

            MessageBox.Show(message);
            MessageBox.Show("Updated Successfully!");
            tableShow();
            clearForm();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            string message;
            var result = MessageBox.Show("\"" + textBoxTCKN.Text + "\" TCKN'Lİ TEMSİLCİ SİLİNECEKTİR!!!",
                                        "EMİN MİSİNİZ?!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
                                        );
            if (result == DialogResult.OK)
            {
                message = db.performCRUD("DELETE FROM Teller WHERE TCKN = '" + textBoxTCKN.Text + "'");
                //MessageBox.Show(message);
                MessageBox.Show("\"" + textBoxTCKN.Text + "\" TCKN'Lİ TEMSİLCİ SİLİNMİŞTİR!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tableShow();
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string message = db.fillDataGridView("SELECT T.TCKN, FirstName, LastName, Telephone, Gender, Address, Email, Password, DateCreated, DateUpdated FROM Teller T, TellerLogin L WHERE T.TCKN = L.TCKN AND LastName = '" + textBoxSoyad.Text + "'", dataGridView1);
            //MessageBox.Show(message);
        }

        #endregion

        #region Salary

        private void updateSalaryForm()
        {
            string salAmount;
            db.getSingleValue("SELECT Amount FROM Salary", out salAmount, 0);
            labelAmount.Text = salAmount;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (boxAmount.Text == "")
                MessageBox.Show("LÜTFEN MAAŞ MİKTARI GİRİNİZ!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                db.performCRUD("INSERT INTO Salary(Amount) VALUES('" + boxAmount.Text + "')");
                MessageBox.Show("Successfully Updated!");
                updateSalaryForm();
            }
        }
        #endregion
    }
}
