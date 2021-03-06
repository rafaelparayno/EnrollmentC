﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using CST.Models.SchoolYear;
using MySql.Data.MySqlClient;
using CST.Enrollment_Admin;

namespace CST
{
    public partial class EnrollmentAdmin : Form
    {
        globalVariables gv = new globalVariables();
        AuditTrailControl auditTrailControl = new AuditTrailControl();
        loginController controller = new loginController();
        EnrollScheduleController en = new EnrollScheduleController();
        int statusEnrollment = 0;
        public EnrollmentAdmin()
        {
            InitializeComponent();
            this.label5.Text = UserLog.getUserName();
            this.label1.Text = UserLog.getRole();
            this.label6.Text = SchoolYearModel.getSchoolYear();

            statusEnrollment = en.getStatusEnrollment();
            if (statusEnrollment == 0)
            {
                btnEnroll.Enabled = true;
                btnRecord.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnEnroll.Enabled = false;
                btnRecord.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
            }

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facilities fr3 = new Facilities();
            fr3.ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoolFees fr3 = new SchoolFees();
            fr3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SchedulingFinal frm = new SchedulingFinal();
            frm.Show();
            this.Hide();
            /*this.Hide;();
            Scheduling fr3 = new Scheduling(label5.Text, label1.Text, label6.Text);
            fr3.ShowDialog();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersSpecialization fr3 = new TeachersSpecialization();
            fr3.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                                "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");
                controller.setOffline(UserLog.getUserId());
                this.Hide();
                Login log = new Login();
                log.Show();
            
            }
        }

        private void EnrollmentAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            //DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnrollmentSchedule frm = new EnrollmentSchedule();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bookeeping frm = new Bookeeping();
            frm.Show();
            this.Hide();
        }
    }
}
