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
        public string TeacherName = "";
        public AssignTeacher(string grade_level,string subject)
        {
            InitializeComponent();

        }

        private void AssignTeacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
