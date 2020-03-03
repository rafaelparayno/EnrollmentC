using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Data;
using CST.Models;

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class AddUpdateGrade : Form
    {

        bool isValid = false;
        GradeLevelController gradeLevelController = new GradeLevelController();


        public AddUpdateGrade()
        {
            InitializeComponent();
            cbGradeLevel.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isValid = checkValidation();
            

            if (isValid)
            {
                gradeLevelController.addGradeLevel(cbGradeLevel.Text.ToString(), gradelevelno.Text.Trim());
                
                this.Hide();
            }
         
        }

        private void cbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] grades = { };
            gradelevelno.Items.Clear();
            if (cbGradeLevel.SelectedIndex == 0)
            {
                grades = DataClass.preSchool();
            }else if(cbGradeLevel.SelectedIndex == 1)
            {
                grades = DataClass.primarySchool();
            }
            else if(cbGradeLevel.SelectedIndex == 2) 
            {
                grades = DataClass.secondarySchool();
            }

            foreach(string grade in grades)
            {
                gradelevelno.Items.Add(grade);
            }
        }

        private bool checkValidation()
        {
            bool isValid = true;

            isValid = cbGradeLevel.SelectedIndex > -1 && isValid;

            isValid = gradelevelno.SelectedIndex > -1 && isValid;


            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return isValid;
        }
    }
}
