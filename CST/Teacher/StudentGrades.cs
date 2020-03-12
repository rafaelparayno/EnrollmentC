using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using CST.Teacher;

namespace CST
{
    public partial class StudentGrades : Form
    {
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        string sno = "";
        string StudName = "";
        ListViewItem lvs = new ListViewItem();
        public StudentGrades()
        {
            InitializeComponent();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherFrm fr1 = new TeacherFrm();
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

        private void button4_Click(object sender, EventArgs e)
        {
            /*StudName = studentsDetailsController.searchName(textBox7.Text.Trim());
            textBox2.Text = StudName;

            if (StudName == "")
            {
                MessageBox.Show("Not Student Id Found");
            }
            else
            {
                sno = textBox7.Text.Trim();
            }*/

            
        }

     

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // ComputeAverage();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           // ComputeAverage();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
          //  ComputeAverage();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
           // ComputeAverage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addGradeStudent frm = new addGradeStudent();

            frm.ShowDialog();
        }
    }
}
