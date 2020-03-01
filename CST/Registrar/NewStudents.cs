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
    public partial class NewStudents : Form
    {
       
        public NewStudents(string a, string b, string c)
        {
            InitializeComponent();

            this.label3.Text = a;
            this.label6.Text = c;
            this.label49.Text = b;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enrollment Enroll = new Enrollment(label3.Text, label49.Text, label6.Text);
            Enroll.Show();
            this.Hide();
        }

            private void NewStudents_Load(object sender, EventArgs e)
        {
           label3.Hide();
           label6.Hide(); 
           label49.Hide();
            label7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm SF = new StudentForm(label3.Text, label49.Text, label6.Text, label7.Text);
            SF.Show();
            this.Hide();
        }
    }
}
