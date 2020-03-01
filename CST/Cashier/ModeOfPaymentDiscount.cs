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
    public partial class ModeOfPaymentDiscount : Form
    {
        public ModeOfPaymentDiscount(string a, string b, string c, string d)
        {
            InitializeComponent();
            label8.Text = a;
            label7.Text = b;
            label9.Text = c;
            label10.Text = d;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment P = new Payment(label8.Text,label7.Text,label9.Text);
            P.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Form fr1 = new Payment_Form(label8.Text, label7.Text, label9.Text,label10.Text);
            fr1.ShowDialog();



        }

        private void ModeOfPaymentDiscount_Load(object sender, EventArgs e)
        {
            label10.Hide();
            label9.Hide();
            label7.Hide();
            label8.Hide();
        }
    }
}
