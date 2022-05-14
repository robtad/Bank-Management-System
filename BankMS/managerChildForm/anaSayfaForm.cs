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
    public partial class anaSayfaForm : Form
    {
        DbConnector db = new DbConnector();

        public anaSayfaForm()
        {
            InitializeComponent();
        }

        private void anaSayfaForm_Load(object sender, EventArgs e)
        {
            string musteri, temsilci, hesap;

            db.getSingleValue("SELECT COUNT(TCKN) FROM Teller", out temsilci, 0);
            db.getSingleValue("SELECT COUNT(TCKN) FROM Customer", out musteri, 0);
            //db.getSingleValue("SELECT COUNT(AccountN0) FROM Account", out hesap, 0);
            hesap = "Hesap Bulunamadi";

            labelTemsilciSayisi.Text = temsilci;
            labelMusteriSayisi.Text = musteri;
            labelHesapSayisi.Text = hesap;

            // The old connection to DB
            /*
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LP6V62U;Initial Catalog=BankDB;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(id) FROM Teller", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                labelTemsilciSayisi.Text = dr.GetValue(0).ToString();
            }

            con.Close();
            */
        }
    }
}
