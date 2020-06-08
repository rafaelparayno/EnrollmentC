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
    public partial class EditSubjectSched : Form
    {
        SubjectController SubjectController = new SubjectController();
        public string sub = "";
        string subjectFromPanel = "";
        string[] subids;
        public int selectedId =0;
        public bool isChanged = false;
        public EditSubjectSched(string sub,string grade)
        {
            InitializeComponent();
            subids = SubjectController.getSubjectAssignForGrade(grade, ref cbSubjects);
            cbSubjects.SelectedItem = sub;
            subjectFromPanel = sub;
        }

        private void EditSubjectSched_Load(object sender, EventArgs e)
        {

        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub = cbSubjects.SelectedItem.ToString();
            selectedId = int.Parse(subids[cbSubjects.SelectedIndex]);
          
               // isChanged = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sub = cbSubjects.SelectedItem.ToString();
            selectedId = int.Parse(subids[cbSubjects.SelectedIndex]);
            if (subjectFromPanel != cbSubjects.SelectedItem.ToString())
             isChanged = true;
               
            
           this.Hide();
        }
    }
}
