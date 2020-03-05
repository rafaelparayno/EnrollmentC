using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CST
{
    public partial class StudentForm : Form
    {
        public StudentForm(/*string a, string b, string c, string d*/)
        {
            InitializeComponent();
            /*this.label5.Text = a;
            this.label6.Text = b;
            this.label7.Text = c;
            this.label12.Text = d;*/
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            rbNew.Checked = true;
          /*  label5.Hide();
            label6.Hide();
            label7.Hide();
            label12.Hide();
            label44.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

       

            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
            if (label12.Text == "RRecord")
            {
                label43.Text = "Edit Student Information";
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* if (label12.Text == "OStudent")
            {
                OldStudents OS = new OldStudents(label5.Text,label6.Text,label7.Text);
                OS.Show();
                this.Hide();
            }
            else if (label12.Text == "RStudent")
            {
                ReturneeStudents RS = new ReturneeStudents(label5.Text, label6.Text, label7.Text);
                RS.Show();
                this.Hide();
            }
            else if (label12.Text == "TStudent")
            {
                TransfereeStudents TS = new TransfereeStudents(label5.Text, label6.Text, label7.Text);
                TS.Show();
                this.Hide();
            }
            else if (label12.Text == "RRecord")
            {
                RegistrarRecord RR = new RegistrarRecord(label5.Text, label6.Text, label7.Text);
                RR.Show();
                this.Hide();
            }
            else
            {
                NewStudents NS = new NewStudents(label5.Text, label6.Text, label7.Text);
                NS.Show();
                this.Hide();
            }*/


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                btnSearch.Visible = false;
            }
            else
            {
                btnSearch.Visible = true;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            /*if (rbOld.Checked)
            {
                btnSearch.Visible = true;
            }
            else
            {

            }*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Enrollment frm = new Enrollment();
            frm.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Succesfully Added Student Details");
            Enrollment frm = new Enrollment();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save!!
            //executes query 

            backgroundWorker1.RunWorkerAsync();
            progressBar1.Show();
            tabControl1.Enabled = false;
        }
    }
}
