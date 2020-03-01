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
    public partial class ListOfStudents : Form
    {
        public ListOfStudents(string a,string b, string c, string d)
        {
            InitializeComponent();
            this.label4.Text = a;
            this.label6.Text = c;
            this.label49.Text = b;
            this.label7.Text = d;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       private void ListOfStudents_Load(object sender, EventArgs e)
        {
            label4.Hide();
            label49.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label7.Text == "RStudent")
            {
                ReturneeStudents RS = new ReturneeStudents(label4.Text, label49.Text, label6.Text);
                RS.Show();
                this.Hide();
            }
            else if (label7.Text == "OStudent")
            {
                OldStudents OS = new OldStudents(label4.Text, label49.Text, label6.Text);
                OS.Show();
                this.Hide();
            }
            else
            {
                RemainingBalance RB = new RemainingBalance(label4.Text, label49.Text, label6.Text,label7.Text);
                RB.Show();
                this.Hide();
            }
        }
    }
}
