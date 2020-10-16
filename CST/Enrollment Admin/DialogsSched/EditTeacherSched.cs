using CST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Enrollment_Admin.DialogsSched
{
    public partial class EditTeacherSched : Form
    {
        int gradeNo = 0;
        int subjid = 0;
        int[] idsTeachers;
        public  int selectedId = 0;
        public string TeacherName = "";
        SpecializationController specializationController = new SpecializationController();
        SubjectController subjectController = new SubjectController();
        public EditTeacherSched(string grade,string subject,string starttime,string endtime)
        {
            InitializeComponent();
            subjid = subjectController.getIdBySubnameAndGrade(subject, grade);




            //if (grade.Contains("Grade"))
            //{
            //    gradeNo = int.Parse(grade.Split(' ')[1]);
            //    if (gradeNo < 7)
            //    {
            //        idsTeachers = specializationController.teacherAvailWithTime(starttime, endtime, ref cbTeacher);
            //    }
            //    else
            //    {
            //        idsTeachers = specializationController.teacherAvailWithSubjsAndTime(starttime, endtime, subjid.ToString(), ref cbTeacher);
            //    }

            //    timestart = timeS;
            //    timeEnd = timeE;
            //}
            //else
            //{
            //    idsTeachers = specializationController.teacherAvailWithTime(starttime, endtime, ref cbTeacher);
            //    timestart = timeS;
            //    timeEnd = timeE;
            //}

            idsTeachers = specializationController.teacherAvailWithSubjsAndTime(starttime, endtime, subjid.ToString(), ref cbTeacher);

        }

        private void EditTeacherSched_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = idsTeachers[cbTeacher.SelectedIndex];
            TeacherName = cbTeacher.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedId = idsTeachers[cbTeacher.SelectedIndex];
            TeacherName = cbTeacher.SelectedItem.ToString();
            this.Hide();
        }
    }
}
