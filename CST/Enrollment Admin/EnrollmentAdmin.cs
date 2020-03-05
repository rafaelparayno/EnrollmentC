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
using CST.Models.SchoolYear;
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class EnrollmentAdmin : Form
    {
        globalVariables gv = new globalVariables();
        public EnrollmentAdmin()
        {
            InitializeComponent();
            this.label5.Text = UserLog.getUserName();
            this.label1.Text = UserLog.getRole();
            this.label6.Text = SchoolYearModel.getSchoolYear();

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
            AddTuitionFee fr3 = new AddTuitionFee();
            fr3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scheduling fr3 = new Scheduling(label5.Text, label1.Text, label6.Text);
            fr3.ShowDialog();
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


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;

        }
    }
}
