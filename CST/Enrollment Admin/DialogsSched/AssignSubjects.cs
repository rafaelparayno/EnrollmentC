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
    public partial class AssignSubjects : Form
    {
        SubjectController subjectController = new SubjectController();
        public string subjectsSelected = "";
        public AssignSubjects(string gradelevel)
        {
            InitializeComponent();

            subjectController.getSubjectAssignForGrade(gradelevel,ref cbSubjects);
        }

        private void AssignSubjects_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            subjectsSelected = cbSubjects.Text;
            this.Hide();
        }
    }
}
