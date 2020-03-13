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
        SpecializationController specializationController = new SpecializationController();
        SubjectController subjectController = new SubjectController();
        StudentGradesController gradesController = new StudentGradesController();
        string sno = "";
        string StudName = "";
        int [] subjectids = { };
        int[] sectids = { };
        int teacherId = 0;
        int selectedSectionId = 0;
        int selectedSubId = 0;
      
        SectionController sectionController = new SectionController();
        public StudentGrades()
        {
            InitializeComponent();
            teacherId = specializationController.findTeacherId(UserLog.getUserId());
            sectids = sectionController.fillComboSect4(ref comboBox2, teacherId);
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



            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            
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
       
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            if(selectedSubId>0 && selectedSectionId > 0)
            {
                addGradeStudent frm = new addGradeStudent(selectedSectionId, selectedSubId, teacherId);
                frm.ShowDialog();
                refreshGrid();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Enabled = true;
            
            selectedSectionId = sectids[comboBox2.SelectedIndex];
            subjectids = subjectController.fillComboSubjectsAssignTeacher(ref comboBox1, teacherId, selectedSectionId); 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubId = subjectids[comboBox1.SelectedIndex];
            button3.Enabled = true;
            button7.Enabled = true; 
            refreshGrid();

        }

        private void refreshGrid()
        {
            gradesController.fillDataGridGrades(ref dataGridView1, selectedSectionId, selectedSubId, teacherId);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                addGradeStudent frm = new addGradeStudent(selectedSectionId, selectedSubId, teacherId,
                                                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                     double.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()),
                                                      double.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                                                       double.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
                                                        double.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                                                         double.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()));
                frm.ShowDialog();
                refreshGrid();
            }
            else
            {
                MessageBox.Show("Please Click the row you wanted to edit");
            }
        }
    }
}
