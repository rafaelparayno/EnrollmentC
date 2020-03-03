using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class Facilities : Form
    {

        public Facilities()
        {
            InitializeComponent();
        
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            EnrollmentAdmin EA = new EnrollmentAdmin();
            EA.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Subject fr3 = new Subject(label3.Text, label2.Text, label4.Text);
            fr3.ShowDialog();
            return;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SchoolRequirements fr3 = new SchoolRequirements(label3.Text, label2.Text, label4.Text);
            fr3.ShowDialog();
            return;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Section fr3 = new Section(label3.Text, label2.Text, label4.Text);
            fr3.ShowDialog();
            return;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Classroom fr3 = new Classroom(label3.Text, label2.Text, label4.Text);
            fr3.ShowDialog();
            return;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GradeLevel fr3 = new GradeLevel();
            fr3.ShowDialog();
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
