﻿using System;
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
    public partial class bankaTarihiForm : Form
    {
        public bankaTarihiForm()
        {
            InitializeComponent();
        }

        private void bankaTarihiForm_Load(object sender, EventArgs e)
        {
            //Change with date in database
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}