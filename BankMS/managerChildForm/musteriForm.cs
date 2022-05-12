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
    public partial class musteriForm : Form
    {
        public musteriForm()
        {
            InitializeComponent();
        }

        DbConnector db = new DbConnector();

        private void musteriForm_Load(object sender, EventArgs e)
        {
            tableShow();
            var test = assginTeller();
            Console.WriteLine(test);
        }

        private string assginTeller()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LP6V62U;Initial Catalog=BankDB;Integrated Security=True");
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
            string message;

            message = db.performCRUD("INSERT INTO Customer(TCKN, FirstName, LastName, Telephone, Address, Gender, Email) " +
                                    "values('" + textBoxTCKN.Text + "','" + textBoxAd.Text + "','" + textBoxSoyad.Text + "','" + textBoxTel.Text + "','" + richTextBoxAdres.Text + "','" + comboBoxCinsiyet.SelectedItem.ToString() + "','" + textBoxEmail.Text + "')");
            message += db.performCRUD("INSERT INTO CustomerLogin(TCKN, Password) " +
                                    "values('" + textBoxTCKN.Text + "','" + textBoxPassword.Text + "')");
            MessageBox.Show(message);

            string enAzMusteri = assginTeller();

            message = db.performCRUD("INSERT INTO TellerCustomer(CustomerTCKN, TellerTCKN) VALUES('"+ textBoxTCKN.Text +"', '"+enAzMusteri+"')");
            MessageBox.Show(message);
            tableShow();
            clearForm();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            //string message = db.fillDataGridView("SELECT C.id, TCKN, Name, Surname, Gender, Telephone, Address, Email, Password, CreateTime, TellerID FROM Customer C, CustomerProfile P WHERE C.id = P.CustomerID AND Surname = '" + textBoxSoyad.Text + "'", dataGridView1);
            //MessageBox.Show(message);
        }

        #endregion
    
    }
}
