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
    public partial class AssignSection : Form
    {

        SectionController sectionController = new SectionController();
        string[] grades = { };
        public string sectionName = "";
        public string grade = "";

        public AssignSection()
        {
            InitializeComponent();
        }

        private void AssignSection_Load(object sender, EventArgs e)
        {
            grades = sectionController.fillComboSect2(ref cbGradeLevel);
          
        }

        private void cbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            grade = grades[cbGradeLevel.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sectionName = cbGradeLevel.Text;
            this.Hide();
        }
    }
}
