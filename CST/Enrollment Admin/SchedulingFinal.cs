﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Enrollment_Admin.PanelSched;


namespace CST.Enrollment_Admin
{
    public partial class SchedulingFinal : Form
    {
        public SchedulingFinal()
        {
            InitializeComponent();
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panelTimeTable p = new panelTimeTable();
            p.TopLevel = false;
            p.Visible = true;
            p.Dock = DockStyle.Fill;
            p.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(p);

        }

        private void SchedulingFinal_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnrollmentAdmin frm = new EnrollmentAdmin();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            PanelScheduling p = new PanelScheduling();
            p.TopLevel = false;
            p.Visible = true;
            p.Dock = DockStyle.Fill;
            p.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            PanelViewSchedules p = new PanelViewSchedules();
            p.TopLevel = false;
            p.Visible = true;
            p.Dock = DockStyle.Fill;
            p.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            PanelViewTeacherSched p = new PanelViewTeacherSched();
            p.TopLevel = false;
            p.Visible = true;
            p.Dock = DockStyle.Fill;
            p.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(p);
        }
    }
}
