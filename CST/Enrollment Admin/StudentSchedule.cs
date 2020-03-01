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
    public partial class StudentSchedule : Form
    {
        public StudentSchedule(string a, string b, string c)
        {
            InitializeComponent();
            label13.Text = a;
            label12.Text = b;
            label14.Text = c;
        }

        private void StudentSchedule_Load(object sender, EventArgs e)
        {
            label11.Hide();
            label13.Hide();
            label12.Hide();
            label14.Hide();

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentAdmin fr3 = new EnrollmentAdmin("", "");
            fr3.ShowDialog();
            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you want Add this Schedule?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                MessageBox.Show("Add Schedule Success");
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you want Remove this Schedule?",
                  "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                MessageBox.Show("Remove Schedule Success");
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Scheduling fr3 = new Scheduling(label13.Text, label12.Text, label14.Text);
            fr3.ShowDialog();
            return;
        }
    }
}
