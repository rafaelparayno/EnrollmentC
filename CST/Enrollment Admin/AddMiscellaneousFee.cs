﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST
{
    public partial class AddMiscellaneousFee : Form
    {
        public AddMiscellaneousFee(string a, string b , string c)
        {
            InitializeComponent();
            label6.Text = a;
            label8.Text = b;
            label9.Text = c;
        }

        private void AddMiscellaneousFee_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label8.Hide();
            label9.Hide();
            label7.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

          

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoolFees fr3 = new SchoolFees(label6.Text,label8.Text,label9.Text);
            fr3.ShowDialog();
            return;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

         

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
