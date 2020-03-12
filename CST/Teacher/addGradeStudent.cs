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

namespace CST.Teacher
{
    public partial class addGradeStudent : Form
    {

        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        public string sno = "";
        public string StudName = "";
        public double g1 = 0;
        public double g2 = 0;
        public double g3 = 0;
        public double g4 = 0;
        public double avg = 0;
        public addGradeStudent()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ComputeAverage();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ComputeAverage();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            ComputeAverage();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            ComputeAverage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            avg = double.Parse(textBox6.Text);
            g1 = double.Parse(numericUpDown1.Value.ToString());
            g2 = double.Parse(numericUpDown2.Value.ToString());
            g3 = double.Parse(numericUpDown3.Value.ToString());
            g4 = double.Parse(numericUpDown4.Value.ToString());
        }

        private void ComputeAverage()
        {
            double avg = 0;
            double g1 = double.Parse(numericUpDown1.Value.ToString());
            double g2 = double.Parse(numericUpDown2.Value.ToString());
            double g3 = double.Parse(numericUpDown3.Value.ToString());
            double g4 = double.Parse(numericUpDown4.Value.ToString());

            avg = (g1 + g2 + g3 + g4) / 4;
            avg = Math.Round((Double)avg, 2);
            textBox6.Text = avg + "";
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

        /* public*/
    }
}

