using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class Cashier : Form
    {
        globalVariables gv = new globalVariables();
        public Cashier()
        {
            InitializeComponent();
          
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment fr1 = new Payment();
            fr1.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                                "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                this.Hide();
                Login frm = new Login();
                frm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records fr1 = new Records(label5.Text, label1.Text,label6.Text);
            fr1.ShowDialog();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
