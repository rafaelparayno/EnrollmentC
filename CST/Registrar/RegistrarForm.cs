using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CST.Registrar;

namespace  CST 
{
    public partial class RegistrarForm : Form
    {
        globalVariables gv = new globalVariables();
        public RegistrarForm()
        {
            InitializeComponent();
         

        }

        private void RegistrarForm_Load(object sender, EventArgs e)
        {
           

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            /*  Enrollment Enroll = new Enrollment();
              Enroll.Show();
              this.Hide();*/
            NewStudents frm = new NewStudents();
            frm.Show();
            this.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                               "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                Login frm = new Login();
                this.Hide();
                frm.Show();
         
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarRecord frm = new RegistrarRecord();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListRequirements frm = new ListRequirements();
            frm.Show();
            this.Hide();
        }
    }
}
