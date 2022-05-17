using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        private void musteriForm_Load(object sender, EventArgs e)
        {
            tableShow();
            var test = assginTeller();
            //Console.WriteLine(test);
        }

        private string assginTeller()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TellerCustomer", con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            List<string> list = new List<string>();

            while (reader.Read())
            {
                list.Add(reader.GetValue(1).ToString());
            }

            var result = list.GroupBy(i => i).OrderBy(g => g.Count()).Select(g => g.Key).ToList();

            //var mostCommon = result.Last();
            var leastCommon = result.First();
            //Console.WriteLine(leastCommon);
            //Console.WriteLine(mostCommon);
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Teller", con);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            List<string> list2 = new List<string>();

            while (reader2.Read())
            {
                list2.Add(reader2.GetValue(0).ToString());
            }

            con.Close();
            //Console.WriteLine(leastCommon);
            foreach (var e in list2)
            {
                if (!list.Contains(e))
                {
                    //Console.WriteLine(e);
                    leastCommon = e;
                    break;
                }
            }


            return leastCommon;
        }

        private void tableShow()
        {
            db.fillDataGridView("SELECT C.TCKN, C.FirstName, C.LastName, C.Telephone, C.Gender, C.Address, C.Email, L.Password, C.DateCreated, C.DateUpdated, T.FirstName, T.LastName " +
                                "FROM Customer C, CustomerLogin L , TellerCustomer TC, Teller T " +
                                "WHERE C.TCKN = L.TCKN AND C.TCKN = TC.CustomerTCKN AND T.TCKN = TC.TellerTCKN ", dataGridView1);
        }

        private void clearForm()
        {
            textBoxTCKN.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxAd.Text = string.Empty;
            textBoxSoyad.Text = string.Empty;
            comboBoxCinsiyet.SelectedItem = string.Empty;
            textBoxTel.Text = string.Empty;
            richTextBoxAdres.Text = string.Empty;
            textBoxTemsilci.Text = string.Empty;
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
            textBoxPassword.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxTemsilci.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString() +" "+ dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        #region Buttons

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string message, message2;

            if (textBoxTCKN.Text == "" || textBoxAd.Text == "" || textBoxSoyad.Text == "" ||
                textBoxTel.Text == "" || richTextBoxAdres.Text == "" || textBoxEmail.Text == "" ||
                textBoxPassword.Text == "")
            {
                MessageBox.Show("TÜM ALANLAR DOLDURULMALIDIR!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                message = db.performCRUD("INSERT INTO Customer(TCKN, FirstName, LastName, Telephone, Address, Gender, Email) " +
                                        "values('" + textBoxTCKN.Text + "','" + textBoxAd.Text + "','" + textBoxSoyad.Text + "'," +
                                        "'" + textBoxTel.Text + "','" + richTextBoxAdres.Text + "','" + comboBoxCinsiyet.SelectedItem.ToString() + "','" + textBoxEmail.Text + "')"
                                        );
                message += db.performCRUD("INSERT INTO CustomerLogin(TCKN, Password) " +
                                        "values('" + textBoxTCKN.Text + "','" + textBoxPassword.Text + "')"
                                        );
                //MessageBox.Show(message);

                string enAzMusteri = assginTeller();

                message2 = db.performCRUD("INSERT INTO TellerCustomer(CustomerTCKN, TellerTCKN) VALUES('" + textBoxTCKN.Text + "', '" + enAzMusteri + "')");
                addCustomerAccount();
                if (!message.Contains("failed"))
                {
                    MessageBox.Show("MÜŞTERİ EKLENMİŞTİR","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (!message2.Contains("failed"))
                    {
                        MessageBox.Show("\"" + textBoxTCKN.Text + "\" TCKN'Lİ MÜŞTERİ, \n\""+enAzMusteri+"\" TCKN'Lİ TEMSİLCİYE ATANMIŞTIR", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("MÜŞTERİ EKLENMEMİŞTİR","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show(message);
                tableShow();
                clearForm();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            string message;
            var result = MessageBox.Show("\""+ textBoxTCKN.Text +"\" TCKN'Lİ MÜŞTERİ SİLİNECEKTİR!!!",
                                        "EMİN MİSİNİZ?!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
                                        );
            if (result == DialogResult.OK)
            {
                message = db.performCRUD("DELETE FROM Customer WHERE TCKN = '" + textBoxTCKN.Text + "'");
                //MessageBox.Show(message);
                MessageBox.Show("\"" + textBoxTCKN.Text + "\" TCKN'Lİ MÜŞTERİ SİLİNMİŞTİR!!!","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                tableShow();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string message;
            message = db.performCRUD(@"UPDATE Customer SET Email = '"+textBoxEmail.Text+"', TCKN = '" + textBoxTCKN.Text + "', FirstName = '" + textBoxAd.Text +
                                    "', LastName = '" + textBoxSoyad.Text + "', Gender = '" + comboBoxCinsiyet.SelectedItem.ToString() +
                                    "', Telephone = '" + textBoxTel.Text + "', Address = '" + richTextBoxAdres.Text + "', DateUpdated = GETDATE() " +
                                    "WHERE TCKN = '" + textBoxTCKN.Text + "'"
                                    );

            message += db.performCRUD("UPDATE CustomerLogin SET Password = '" + textBoxPassword.Text + "' WHERE TCKN = '" + textBoxTCKN.Text + "'");
            //MessageBox.Show(message);
            MessageBox.Show("Updated Successfully!");
            tableShow();
            clearForm();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string message = db.fillDataGridView("SELECT C.TCKN, C.FirstName, C.LastName, " +
                                                "C.Telephone, C.Gender, C.Address, C.Email, L.Password, " +
                                                "C.DateCreated, C.DateUpdated, T.FirstName, T.LastName " +
                                                "FROM Customer C, CustomerLogin L , TellerCustomer TC, Teller T " +
                                                "WHERE C.TCKN = L.TCKN AND C.TCKN = TC.CustomerTCKN " +
                                                "AND T.TCKN = TC.TellerTCKN AND C.LastName = '"+textBoxSoyad.Text+"'", 
                                                dataGridView1
                                                );
            //MessageBox.Show(message);
        }

        private void addCustomerAccount()
        {
            string AccNum;
            db.performCRUD(@"insert into Account(CurrencyName) values ('Lira')");
            db.getSingleValue("SELECT IDENT_CURRENT('Account')", out AccNum, 0);
            db.performCRUD(@"insert into CustomerAccounts(CustomerTCKN,AccountNo) values ('" + textBoxTCKN.Text + "','" + AccNum + "')");
        }
        #endregion

    }
}
