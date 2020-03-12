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
    public partial class StudentGrades : Form
    {
        public StudentGrades()
        {
            InitializeComponent();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher fr1 = new Teacher();
            fr1.ShowDialog();
        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            /*label10.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");*/

            timer1.Enabled = true;
        }
    }
}
