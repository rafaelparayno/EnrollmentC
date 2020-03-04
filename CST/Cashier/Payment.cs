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
    public partial class Payment : Form
    {
        public Payment(string a, string b, string c)
        {
            InitializeComponent();
            label5.Text = a;
            label2.Text = b;
            label6.Text = c;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label9.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label4.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeOfPaymentDiscount fr1 = new ModeOfPaymentDiscount(label5.Text,label2.Text,label6.Text,label9.Text);
            fr1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemainingBalance fr6 = new RemainingBalance(label5.Text, label2.Text, label6.Text, "RBalance");
            fr6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier fr3 = new Cashier(label5.Text,label2.Text);
            fr3.ShowDialog();
            
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

         

            label4.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
