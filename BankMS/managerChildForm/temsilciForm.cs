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

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LP6V62U;Initial Catalog=BankDB;Integrated Security=True");
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Salary SET Amount=@Amount WHERE id=1", con);
            cmd.Parameters.AddWithValue("@Amount", int.Parse(boxAmount.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated!");

            updateSalaryForm();
        }

        private void updateSalaryForm()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Amount FROM Salary WHERE id=1", con);
            
            SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //textBoxAmount.Text = dr.GetValue(0).ToString();
            
            while (dr.Read())
            {
                labelAmount.Text = dr.GetValue(0).ToString()+" TL";
            }
            
            con.Close();
        }

        private void temsilciForm_Load(object sender, EventArgs e)
        {
            updateSalaryForm();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
