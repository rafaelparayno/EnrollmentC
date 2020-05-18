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
        string[] subIds = { };
        
        string[] subidInList;
        bool isAlreadyInTheList = false;
        bool isNullSubid = false;
        public string subjectsSelected = "";
        public string selectedSubId = "";
        public int selectedSubidss = 0;
        public AssignSubjects(string gradelevel,string[] subidss)
        {
            InitializeComponent();
    
            subIds = subjectController.getSubjectAssignForGrade(gradelevel,ref cbSubjects);

            subidInList = subidss;
            isNullSubid = true;
         
        
        }

        private void AssignSubjects_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNullSubid)
            {
                for (int i = 0; i < subidInList.Length; i++)
                {
                  
                    if (subidInList[i] != null)
                    {

                        int subid = int.Parse(subidInList[i]);
                        isFound(subid);

                        //       isAlreadyInTheList = subjectController.isFound(subid);
                        if (isAlreadyInTheList)
                        {
                            break;
                        }
                    }
                   
                }
                
            }

            if (!isAlreadyInTheList)
            {
                subjectsSelected = cbSubjects.Text;
                this.Hide();
            }
            else
            {
                selectedSubidss = 0;
                selectedSubId = "";
                MessageBox.Show("The Subject is already in the List");
            }

        }


        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubId = subIds[cbSubjects.SelectedIndex];
            selectedSubidss = int.Parse(subIds[cbSubjects.SelectedIndex]);
        }

        private void isFound(int idInTheList)
        {
            int selectedID = int.Parse(selectedSubId);
         
            if(selectedID == idInTheList)
            {
                isAlreadyInTheList = true;
            }
            else
            {
                isAlreadyInTheList = false;
            }
        
        }
    }
}
