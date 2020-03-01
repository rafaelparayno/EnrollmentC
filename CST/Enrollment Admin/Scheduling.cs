using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST
{
    public partial class Scheduling : Form
    {
        public Scheduling(string a, string b, string c)
        {
            InitializeComponent();
            label5.Text = a;
            label8.Text = b;
            label6.Text = c;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentSchedule fr3 = new EnrollmentSchedule(label5.Text,label8.Text,label6.Text);
            fr3.ShowDialog();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          StudentSchedule fr3 = new StudentSchedule(label5.Text, label8.Text, label6.Text);
            fr3.ShowDialog();
            return;

        }

        private void Scheduling_Load(object sender, EventArgs e)
        {
            label8.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnrollmentAdmin EA = new EnrollmentAdmin(label5.Text,label8.Text);
            EA.Show();
            this.Hide();
        }
    }
}
