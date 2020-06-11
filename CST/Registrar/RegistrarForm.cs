using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CST.Registrar;
using CST.Models;

namespace  CST 
{
    public partial class RegistrarForm : Form
    {
        YearController yearController = new YearController();
        AuditTrailControl auditTrailControl = new AuditTrailControl();
        loginController controller = new loginController();
        EnrollScheduleController en = new EnrollScheduleController();
        int statusEn = 0;
        public RegistrarForm()
        {
            InitializeComponent();
            label5.Text = UserLog.getUserName();
            label1.Text = UserLog.getRole();
            timer1.Start();

            label6.Text = yearController.getSyActivated();
            statusEn = en.getStatusEnrollment();

            if(statusEn == 0)
            {
                btnEnroll.Enabled = false;
            }
            else
            {
                btnEnroll.Enabled = true;
            }
        }

        private void RegistrarForm_Load(object sender, EventArgs e)
        {
           

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            /*  Enrollment Enroll = new Enrollment();
              Enroll.Show();
              this.Hide();*/
            NewStudents frm = new NewStudents();
            frm.Show();
            this.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                               "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");
                controller.setOffline(UserLog.getUserId());
                Login frm = new Login();
                this.Hide();
                frm.Show();
         
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarRecord frm = new RegistrarRecord();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListRequirements frm = new ListRequirements();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfStudents frm = new ListOfStudents();
            frm.Show();
            this.Hide();
        }
    }
}
