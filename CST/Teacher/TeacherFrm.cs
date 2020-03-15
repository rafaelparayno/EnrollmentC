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

namespace CST.Teacher
{
    public partial class TeacherFrm : Form
    {
        YearController yearController = new YearController();

        public TeacherFrm()
        {
            InitializeComponent();
            label1.Text = UserLog.getRole();
            label5.Text = UserLog.getUserName();
            label6.Text = yearController.getSyActivated();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherSchedule frm = new TeacherSchedule();
            frm.Show();
            this.Hide();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentGrades frm = new StudentGrades();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListofSection frm = new ListofSection();
            frm.Show();
            this.Hide();
        }

        private void TeacherFrm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                                 "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

              /*  auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");*/

                Login f = new Login();
                f.Show();
                this.Hide();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
