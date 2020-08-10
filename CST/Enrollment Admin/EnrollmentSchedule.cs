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
using CST.Enrollment_Admin.AddUpdateDiags;
using System.Globalization;

namespace CST
{
    public partial class EnrollmentSchedule : Form
    {

        EnrollScheduleController en = new EnrollScheduleController();
        string OpenEnrollemnt = "";
        string[] dataEn = { };
        CultureInfo provider = CultureInfo.InvariantCulture;
        public EnrollmentSchedule()
        {
            InitializeComponent();
            refreshData();
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnrollmentAdmin frm = new EnrollmentAdmin();
            frm.Show();
            this.Hide();
        }

        private void EnrollmentSchedule_Load(object sender, EventArgs e)
        {
            //refreshGrid();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

         

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEnrollmentSched frm = new addEnrollmentSched();
            frm.ShowDialog();
            refreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshData()
        {
            dataEn = en.getEnrollSched();
        
            string syname = dataEn[0] == "" || dataEn[0] == null ? "No Date Yet" : dataEn[0];
            string startdate = dataEn[1] == "" || dataEn[1] == null ? "No Date Yet" : dataEn[1];
            string endDate = dataEn[2] == "" || dataEn[2] == null ? "No Date Yet" : dataEn[2];
            OpenEnrollemnt = dataEn[3] == "" || dataEn[3] == null ? "No Data" :
                int.Parse(dataEn[3]) == 0 ? "Closed" : "Open";
            DateTime _;

            bool isdateStart = DateTime.TryParse(startdate, out _);

           
            if (isdateStart)
            {
                //  DateTime dateStart = DateTime.Parse(startdate);

                DateTime dateStart = DateTime.ParseExact(startdate, "dd/MM/yyyy", provider);
                DateTime dateEnd = DateTime.ParseExact(endDate, "dd/MM/yyyy", provider);
            
                label3.Text = "Start Date :  " + dateStart.ToString("MMMM dd, yyyy");
                label4.Text = "End Date :" + dateEnd.ToString("MMMM dd, yyyy");
            }
            else
            {
                label3.Text =  "Start Date :  " + startdate;
                label4.Text =  "End Date : " + endDate;
            }

            label5.Text = "School Year :" + " " + syname;
          
            
            label2.Text = "Open Enrollment : " + OpenEnrollemnt;

            if (OpenEnrollemnt == "Closed")
            {
                button4.Text = "Open Enrollment";
                button4.Enabled = true;
            }
            else if (OpenEnrollemnt == "Open")
            {
                button4.Text = "Close Enrollment";
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(OpenEnrollemnt == "Closed")
            {
                en.updateOpenEn();
                MessageBox.Show("Open Enrollment");
            }
            else if(OpenEnrollemnt == "Open")
            {
                en.updateCloseEn();
                MessageBox.Show("Closed Enrollment");
            }
            refreshData();
        }
    }
}
