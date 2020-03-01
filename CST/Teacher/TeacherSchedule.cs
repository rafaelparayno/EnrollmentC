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
    public partial class TeacherSchedule : Form
    {
        public TeacherSchedule(string a, string b, string c)
        {
            InitializeComponent();
            label5.Text = a;
            label3.Text = b;
            label6.Text = c; 
        }

        private void TeacherSchedule_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Teacher fr3 = new Teacher(label5.Text, label3.Text);
            fr3.ShowDialog();

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

