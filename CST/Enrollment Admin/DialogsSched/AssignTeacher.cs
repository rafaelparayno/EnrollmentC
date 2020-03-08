﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;

namespace CST.Enrollment_Admin.DialogsSched
{
    public partial class AssignTeacher : Form
    {
        SpecializationController specializationController = new SpecializationController();
        TeacherSchedController teacherSchedController = new TeacherSchedController();
        YearController yrcontroller = new YearController();
        string timestart = "";
        string timeEnd = "";
        public string TeacherName = "";
        public int selectedIdTeacher = 0;
        int gradeNo = 0;
        string[] idsTeacher = { };
        public AssignTeacher(string grade_level,string subject,string timeS,string timeE)
        {
            InitializeComponent();
            gradeNo = int.Parse(grade_level.Split(' ')[1]);
            if(gradeNo < 7)
            {
                idsTeacher = specializationController.fillDataTeacherSect(ref cbTeacher, yrcontroller.getSchoolYearId());
            }

            timestart = timeS;
            timeEnd = timeE;

        }

        private void AssignTeacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (!teacherSchedController.isConflictWithTheTime(timeEnd,timestart, int.Parse(idsTeacher[cbTeacher.SelectedIndex])))
            {
                TeacherName = cbTeacher.Text;
                selectedIdTeacher = int.Parse(idsTeacher[cbTeacher.SelectedIndex]);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Teacher Has Conflict with that time", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
     
        }

        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}