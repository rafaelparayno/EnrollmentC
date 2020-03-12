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

namespace CST
{
    public partial class StudentGrades : Form
    {
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        string sno = "";
        string StudName = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            StudName = studentsDetailsController.searchName(textBox7.Text.Trim());
            textBox2.Text = StudName;

            if (StudName == "")
            {
                MessageBox.Show("Not Student Id Found");
            }
            else
            {
                sno = textBox7.Text.Trim();
            }

            
        }

        private void ComputeAverage()
        {
            double avg = 0;
            double g1 = double.Parse( numericUpDown1.Value.ToString());
            double g2 = double.Parse(numericUpDown2.Value.ToString());
            double g3 = double.Parse(numericUpDown3.Value.ToString());
            double g4 = double.Parse(numericUpDown4.Value.ToString());

            avg = (g1 + g2 + g3 + g4) / 4;
            avg = Math.Round((Double)avg, 2);
            textBox6.Text = avg + "";
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
            ComputeAverage();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ComputeAverage();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            ComputeAverage();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            ComputeAverage();
        }
    }
}
