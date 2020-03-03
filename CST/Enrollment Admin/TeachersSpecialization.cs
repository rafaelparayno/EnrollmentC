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
    public partial class TeachersSpecialization : Form
    {
        public TeachersSpecialization(string a, string b, string c)
        {
            InitializeComponent();
            label8.Text = a;
            label6.Text = b;
            label9.Text = c;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateTeacherSpecialization fr3 = new UpdateTeacherSpecialization(label8.Text, label6.Text, label9.Text);
            fr3.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentAdmin fr3 = new EnrollmentAdmin ();
            fr3.ShowDialog();
            return;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeachersSpecialization_Load(object sender, EventArgs e)
        {
            label8.Hide();
            label6.Hide();
            label9.Hide();
            label7.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
