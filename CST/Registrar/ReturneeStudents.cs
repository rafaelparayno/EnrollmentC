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
    public partial class ReturneeStudents : Form
    {
        public ReturneeStudents(string a, string b, string c)
        {
            InitializeComponent();
            this.label2.Text = a;
            this.label49.Text = b;
            this.label6.Text = c;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enrollment Enroll = new Enrollment();
            Enroll.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        

        private void ReturneeStudents_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label49.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentForm SF = new StudentForm();
            SF.Show();
            this.Hide();
        }
    }
}
