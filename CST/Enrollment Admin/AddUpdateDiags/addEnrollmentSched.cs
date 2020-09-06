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

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class addEnrollmentSched : Form
    {

        YearController yearController = new YearController();
        EnrollScheduleController en = new EnrollScheduleController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        public addEnrollmentSched()
        {
            InitializeComponent();
            int currentYear = yearController.getSchoolYearId();
            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
         
        }

        public addEnrollmentSched(string ds,string de)
        {
            InitializeComponent();
            int currentYear = yearController.getSchoolYearId();
            dateTimePicker1.Value = DateTime.Parse(ds);
            dateTimePicker2.Value = DateTime.Parse(de);
         
            dateTimePicker1.MinDate = new DateTime(int.Parse(DateTime.Parse(ds).ToString().Split('/')[2].Split(' ')[0]), 1,1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            en.addEnrollmentSchedul(dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            auditTrail.addAudit(label3.Text, "Enrollment Schedule Starts On "+ dateTimePicker1.Value.ToString("dd/MM/yyyy") +" Ends On " + dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            MessageBox.Show("Succesfully Save Date");
            this.Hide();
        }

        private void addEnrollmentSched_Load(object sender, EventArgs e)
        {
            label3.Hide();
            timer1.Start();

            dateTimePicker2.MinDate = dateTimePicker2.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label3.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
