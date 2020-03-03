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
    public partial class SchoolFees : Form
    {
        public SchoolFees(string a, string b, string c)
        {
            InitializeComponent();
            label5.Text = a;
            label3.Text = b;
            label6.Text = c;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           EnrollmentAdmin  fr3 = new EnrollmentAdmin();
            fr3.ShowDialog();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddTuitionFee fr3 = new AddTuitionFee(label5.Text,label3.Text,label6.Text);
            fr3.ShowDialog();
            return;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddMiscellaneousFee fr3 = new AddMiscellaneousFee(label5.Text, label3.Text, label6.Text);
            fr3.ShowDialog();
            return;


        }

        private void SchoolFees_Load(object sender, EventArgs e)
        {
            label3.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label4.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label4.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
