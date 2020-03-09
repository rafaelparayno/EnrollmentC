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
    public partial class RemainingBalance : Form
    {
        public RemainingBalance(string a, string b,string c, string d)
        {
            InitializeComponent();
            label9.Text = d;
            label5.Text = a;
            label4.Text = b;
            label7.Text = c;
        }

        private void RemainingBalance_Load(object sender, EventArgs e)
        {
            label9.Hide();
            label5.Hide();
            label4.Hide();
            label7.Hide();
            if (label9.Text == "VSummary")
            {
                label6.Text = "Summary";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label9.Text == "VSummary")
            {
                Records R = new Records(label5.Text, label4.Text, label7.Text);
                R.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
                Payment fr6 = new Payment();
                fr6.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label9.Text == "VSummary")
            {
                Payment_Form PF = new Payment_Form(label5.Text, label4.Text, label7.Text, label9.Text);
                PF.Show();
                this.Hide();
            }
            else
            {
                Payment_Form PF = new Payment_Form(label5.Text, label4.Text, label7.Text, label9.Text);
                PF.Show();
                this.Hide();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListOfStudents LS = new ListOfStudents(label5.Text,label4.Text,label7.Text,label9.Text);
            LS.Show();
            this.Hide();
        }
    }
}
