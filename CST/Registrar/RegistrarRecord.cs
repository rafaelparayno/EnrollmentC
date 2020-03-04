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
    public partial class RegistrarRecord : Form
    {
        public RegistrarRecord(string a, string b, string c)
        {
            InitializeComponent();
            this.label5.Text = a;
            this.label6.Text = c;
            this.label49.Text = b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            button1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox1.Show();
            button1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void RegistrarRecord_Load(object sender, EventArgs e)
        {
            label49.Hide();
            label8.Hide();
            button1.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

        

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm SF = new StudentForm();
            SF.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
