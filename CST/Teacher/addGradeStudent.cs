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
        StudentGradesController gradesController = new StudentGradesController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        public string sno = "";
        public string StudName = "";
        public double g1 = 65;
        public double g2 = 65;
        public double g3 = 65;
        public double g4 = 65;
        public double avg = 65;
    
        int sect = 0;
        int subj = 0;
        int teacher = 0;
        public addGradeStudent(int section_id,int subject_id,int teacher_id)
        {
            InitializeComponent();
            subj = subject_id;
            sect = section_id;
            teacher = teacher_id;
        }
        public addGradeStudent(int section_id, int subject_id, int teacher_id,string sno,string name,
                              double g1,double g2,double g3,double g4, double avg)
        {
            InitializeComponent();
            subj = subject_id;
            sect = section_id;
            teacher = teacher_id;
            this.sno = sno;
            StudName = name;
            textBox2.Text = StudName;
            button4.Visible = false;
            textBox7.Text = sno;
            textBox7.Enabled = false;
            numericUpDown1.Value = decimal.Parse(g1.ToString()) > 0 ? decimal.Parse(g1.ToString()) : 65;
            numericUpDown2.Value = decimal.Parse(g2.ToString()) > 0 ? decimal.Parse(g2.ToString()) : 65; 
            numericUpDown3.Value = decimal.Parse(g3.ToString()) >0 ? decimal.Parse(g3.ToString()) : 65; 
            numericUpDown4.Value = decimal.Parse(g4.ToString()) >0 ? decimal.Parse(g4.ToString()) : 65; 
         

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
            if (isValid())
            {

                avg = double.Parse(textBox6.Text);
                g1 = double.Parse(numericUpDown1.Value.ToString());
                g2 = double.Parse(numericUpDown2.Value.ToString());
                g3 = double.Parse(numericUpDown3.Value.ToString());
                g4 = double.Parse(numericUpDown4.Value.ToString());

              
                
               gradesController.addStudentGrade(sno, g1, g2, g3, g4, avg, subj, sect, teacher);

                auditTrail.addAudit(label11.Text, "Input " + textBox2.Text.Trim()+ "Grades");
                MessageBox.Show("Succesfully Save Grade");

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please FIll Data");
            }
         
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
            StudName = studentsDetailsController.searchStudInSection("STUD-" +textBox7.Text.Trim(), sect);
            textBox2.Text = StudName;

            if (StudName.Trim() == "")
            {
                MessageBox.Show("No Student Id Found in section ");
                sno = "";
            }
            else
            {
                sno = "STUD-" +textBox7.Text.Trim();
            }
        }


        private bool isValid()
        {

            bool isValid = true;

            isValid = !(sno == "") && isValid;

            isValid = !(textBox6.Text.Trim() == "") && isValid;


            return isValid;
        }

        private void addGradeStudent_Load(object sender, EventArgs e)
        {
            label11.Hide();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;
        }
    }
}

