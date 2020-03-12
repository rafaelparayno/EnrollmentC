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

namespace CST
{
    public partial class Teacher : Form
    {
    
        public Teacher()
        {
            InitializeComponent();
           

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
          
                this.Hide();
                TeacherSchedule fr1 = new TeacherSchedule();
                fr1.ShowDialog();
                return;


            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
      ListofSection fr1 = new ListofSection ();
            fr1.ShowDialog();
            return;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentGrades fr1 = new StudentGrades();
            fr1.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                               "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                this.Hide();
                Login log = new Login();
                log.Show();
              
            }
        }

        private void Teacher_Load(object sender, EventArgs e)
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
    

