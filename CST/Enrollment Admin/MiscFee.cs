﻿using CST.Data;
using CST.Enrollment_Admin.AddUpdateDiags;
using CST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Enrollment_Admin
{
    public partial class MiscFee : Form
    {
        MiscController miscController = new MiscController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        public MiscFee()
        {
            InitializeComponent();
            foreach (string item in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(item);
            }

            loadGrid();
            comboBox2.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SchoolFees frm = new SchoolFees();
            this.Hide();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            diagMisc frm = new diagMisc();

            frm.ShowDialog();
            loadGrid();
        }

        private void loadGrid()
        {
            miscController.fillDataGridAllMisc(ref dataGridView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "ALL")
            {
                loadGrid();
            }
            else
            {
                miscController.fillDataGridMisc(ref dataGridView2, comboBox2.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
                return;
            // miscfee_id,grade_level,details,price FROM misc_f
            diagMisc frm = new diagMisc(dataGridView2.SelectedRows[0].Cells[1].Value.ToString(),
                                       dataGridView2.SelectedRows[0].Cells[2].Value.ToString(),
                                      dataGridView2.SelectedRows[0].Cells[3].Value.ToString(),
                                      int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
            frm.ShowDialog();
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
                return;
            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                    "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                miscController.RemoveMisc(int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
                auditTrail.addAudit(label7.Text, "Remove Miscelleneous Fee");
                MessageBox.Show("Succesfully Remove Data");
                loadGrid();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MiscFee_Load(object sender, EventArgs e)
        {
            label7.Hide();
            timer1.Start();

        }
    }
}
