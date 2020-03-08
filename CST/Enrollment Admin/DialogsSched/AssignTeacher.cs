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

namespace CST.Enrollment_Admin.DialogsSched
{
    public partial class AssignTeacher : Form
    {
        SpecializationController specializationController = new SpecializationController();
        YearController yrcontroller = new YearController();
        public string TeacherName = "";
        int gradeNo = 0;
        string[] idsTeacher = { };
        public AssignTeacher(string grade_level,string subject)
        {
            InitializeComponent();
            gradeNo = int.Parse(grade_level.Split(' ')[1]);
            if(gradeNo < 7)
            {
                idsTeacher = specializationController.fillDataTeacherSect(ref cbTeacher, yrcontroller.getSchoolYearId());
            }

        }

        private void AssignTeacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherName = cbTeacher.Text;
            this.Hide();
        }
    }
}
