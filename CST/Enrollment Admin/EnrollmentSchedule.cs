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

namespace CST
{
    public partial class EnrollmentSchedule : Form
    {

        EnrollScheduleController en = new EnrollScheduleController();
        public EnrollmentSchedule()
        {
            InitializeComponent();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnrollmentAdmin frm = new EnrollmentAdmin();
            frm.Show();
            this.Hide();
        }

        private void EnrollmentSchedule_Load(object sender, EventArgs e)
        {
            refreshGrid();
           
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addEnrollmentSched frm = new addEnrollmentSched(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            frm.ShowDialog();
        }

        private void refreshGrid()
        {
            en.fillDataEnrolSched(ref dataGridView1);
        }
    }
}
