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
        string[] sect_ids = { };
        public string sectionName = "";
        //public string grade = "";
        public string selectedId = "";
        string grade = "";

        public AssignSection(string grade)
        {
            InitializeComponent();
            this.grade = grade;

        }

        private void AssignSection_Load(object sender, EventArgs e)
        {
            sect_ids = sectionController.fillComboSect2(ref cbGradeLevel,grade);

        }

        private void cbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = sect_ids[cbGradeLevel.SelectedIndex];
            sectionName = cbGradeLevel.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sectionName = cbGradeLevel.Text;
            this.Hide();
        }
    }
}
