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
    public partial class Payment_Form : Form
    {
        public Payment_Form(string a,string b,string c, string d)
        {
            InitializeComponent();
            label6.Text = d;
            label5.Text = a;
            label4.Text = b;
            label7.Text = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label6.Text == "VSummary")
            {
                RemainingBalance RB = new RemainingBalance(label5.Text, label4.Text, label7.Text, label6.Text);
                RB.Show();
                this.Hide();
            }
            else if(label6.Text == "RBalance")
            {
                RemainingBalance RB = new RemainingBalance(label5.Text, label4.Text, label7.Text, label6.Text);
                RB.Show();
                this.Hide();
            }
            else
            {
                ModeOfPaymentDiscount MP = new ModeOfPaymentDiscount(label5.Text, label4.Text, label7.Text, label6.Text);
                MP.Show();
                this.Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
               
}

        private void Payment_Form_Load(object sender, EventArgs e)
        {

          
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
