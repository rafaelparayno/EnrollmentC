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
    public partial class StudentForm : Form
    {
        public StudentForm(string a, string b, string c, string d)
        {
            InitializeComponent();
            this.label5.Text = a;
            this.label6.Text = b;
            this.label7.Text = c;
            this.label12.Text = d;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label12.Hide();
            label44.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
            if (label12.Text == "RRecord")
            {
                label43.Text = "Edit Student Information";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label12.Text == "OStudent")
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
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
