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
            string temp;
            db.getSingleValue("SELECT COUNT(id) FROM Teller", out temp, 0);
            labelTemsilciSayisi.Text = temp;
            //Normal connection to DB
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
