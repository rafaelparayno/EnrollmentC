using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using CST.Teacher;
using CST.Reports;
using CST.Data;

namespace CST
{
    public partial class StudentGrades : Form
    {
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        SpecializationController specializationController = new SpecializationController();
        SubjectController subjectController = new SubjectController();
        StudentGradesController gradesController = new StudentGradesController();
        SectionController sectionController = new SectionController();

        int [] subjectids = { };
        int[] sectids = { };
        int teacherId = 0;
        int selectedSectionId = 0;
        int selectedSubId = 0;
      
        
        public StudentGrades()
        {
            InitializeComponent();
            teacherId = specializationController.findTeacherId(UserLog.getUserId());
          ///  

            foreach(string grade in DataClass.getAllGrade())
            {
                if (sectionController.isHandledGradeInSection(grade))
                {
                    comboBox3.Items.Add(grade);
                }
            }
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
       
            button7.Enabled = true;
            button5.Enabled = true;
            refreshGrid();

        }

        private void refreshGrid()
        {
          
            listView1.Items.Clear();
            gradesController.fillLisdViewTeacher(ref listView1, selectedSectionId, selectedSubId, teacherId);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                addGradeStudent frm = new addGradeStudent(selectedSectionId, selectedSubId, teacherId,
                                                     listView1.SelectedItems[0].SubItems[0].Text,
                                                     listView1.SelectedItems[0].SubItems[1].Text,
                                                     double.Parse(listView1.SelectedItems[0].SubItems[2].Text),
                                                      double.Parse(listView1.SelectedItems[0].SubItems[3].Text),
                                                       double.Parse(listView1.SelectedItems[0].SubItems[4].Text),
                                                        double.Parse(listView1.SelectedItems[0].SubItems[5].Text),
                                                         double.Parse(listView1.SelectedItems[0].SubItems[6].Text));
                frm.ShowDialog();
                refreshGrid();
            }
            else
            {
                MessageBox.Show("Please Click the row you wanted to edit");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                  "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                if(listView1.SelectedItems.Count > 0)
                {
                    gradesController.deleteGrade(listView1.SelectedItems[0].SubItems[0].Text,
                                           selectedSubId, selectedSectionId, teacherId);
                    MessageBox.Show("Succesfully Remove Selected Student Grade");
                    refreshGrid();

                }
                else
                {
                    MessageBox.Show("No Grade Selected");
                }
            
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                DataSet ds = new DataSet();

                DataTable dt = new DataTable();
                dt.Columns.Add("Student Number", typeof(string));
                dt.Columns.Add("Student Name", typeof(string));
                dt.Columns.Add("1st Grading", typeof(string));
                dt.Columns.Add("2nd Grading", typeof(string));
                dt.Columns.Add("3rd Grading", typeof(string));
                dt.Columns.Add("4th Grading", typeof(string));
                dt.Columns.Add("Average", typeof(string));


                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    dt.Rows.Add(listView1.Items[i].SubItems[0].Text,
                        listView1.Items[i].SubItems[1].Text,
                        listView1.Items[i].SubItems[2].Text,
                        listView1.Items[i].SubItems[3].Text,
                        listView1.Items[i].SubItems[4].Text,
                        listView1.Items[i].SubItems[5].Text,
                        listView1.Items[i].SubItems[6].Text);
                }

               


                ds.Tables.Add(dt);
                // ds.WriteXmlSchema("studGrades.xml");
                gradeReport frm = new gradeReport(ds, selectedSectionId, comboBox1.SelectedItem.ToString());
                frm.ShowDialog();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectids = sectionController.fillComboSect4(ref comboBox2, teacherId,comboBox3.SelectedItem.ToString());
            comboBox2.Enabled = true;
        }
    }
}
