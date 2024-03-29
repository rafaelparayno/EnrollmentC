﻿using CST.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using CST.Cashier;

namespace CST
{
    public partial class Payment : Form
    {

        YearController yearController = new YearController();
        TuitionFeeController tuitionFeeController = new TuitionFeeController();
        MiscController miscController = new MiscController();
        EnrollScheduleController en = new EnrollScheduleController();
        int enStatus = 0;

        public Payment()
        {
            InitializeComponent();

            label2.Text = yearController.getSyActivated();
            label5.Text = UserLog.getUserName();
            foreach (string grade in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(grade);
            }

            enStatus = en.getStatusEnrollment();


            if(enStatus == 0)
            {
                button1.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            
            label9.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label4.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeOfPaymentDiscount fr1 = new ModeOfPaymentDiscount();
            fr1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemainingBalance fr6 = new RemainingBalance();
            fr6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashierDashboard fr3 = new CashierDashboard();
        //    cashi fr3 = new Cashier();
            fr3.ShowDialog();
            
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

         

            label4.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    tuitionFeeController.fillDataTuion2(ref dataGridView1, comboBox2.SelectedItem.ToString());

                }
                else
                {
                    miscController.fillDataGridMisc(ref dataGridView1, comboBox2.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please Select a Grade and Type of fees");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > -1)
            {
                if (comboBox1.SelectedIndex == 0)
                {

                    tuitionFeeController.fillAllTuition(ref dataGridView1);
                }
                else
                {
                    miscController.fillDataGridAllMisc(ref dataGridView1);
                }
            }
            else
            {
                MessageBox.Show("Please Select Type of fees");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            studentreserve frm = new studentreserve();
            frm.ShowDialog();
        }
    }
}
