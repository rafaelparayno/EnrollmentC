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
    public partial class OldStudents : Form
    {
        public OldStudents(string a, string b, string c)
        {
            InitializeComponent();
            this.label3.Text = a;
            this.label49.Text = b;
            this.label6.Text = c;
        }

        private void OldStudents_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label49.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfStudents LOS = new ListOfStudents(label3.Text,label49.Text,label6.Text,label7.Text);
            LOS.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enrollment Enroll = new Enrollment(label3.Text, label49.Text,label6.Text);
            Enroll.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentForm SF = new StudentForm(label3.Text, label49.Text, label6.Text, label7.Text);
            SF.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
