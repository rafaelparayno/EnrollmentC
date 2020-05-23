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
using CST.Models;
using CST.Models.SchoolYear;

namespace CST {  
    public partial class Admin : Form

    {

        AuditTrailControl auditTrailControl = new AuditTrailControl();
        loginController control = new loginController();
        public Admin()

        {
            InitializeComponent();

            this.label5.Text = UserLog.getUserName();
            this.label1.Text = UserLog.getRole();
            this.label6.Text = SchoolYearModel.getSchoolYear();

        }


        private void btnRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuditTrail fr2 = new AuditTrail(label5.Text, label1.Text);
            fr2.ShowDialog();

        }        

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccount fr2 = new UserAccount(label5.Text,label1.Text);
            fr2.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                                 "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");
                control.setOffline(UserLog.getUserId());
                Login f = new Login();
                f.Show();
                this.Hide();
                
            }
        }








        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackupAndRestore fr2 = new BackupAndRestore();
            fr2.ShowDialog();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoolYear fr3 = new SchoolYear();
            fr3.ShowDialog();
            
        }

        public void label5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            timer1.Start();
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }


}
