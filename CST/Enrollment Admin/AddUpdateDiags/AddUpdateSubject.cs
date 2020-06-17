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
    public partial class AddUpdateSubject : Form
    {
        string[] gradeAll = { };
        int[] subjectTypeIds = { };
        int selectedSubjectType = 0;
        bool isValid = false;
        bool isEdited = false;
        private int id;
        SubjectController subjectController = new SubjectController();
        SubjectTypeController SubjectTypeController = new SubjectTypeController();
        public AddUpdateSubject()
        {
            InitializeComponent();
           
            gradeAll = DataClass.getAllGrade();
            subjectTypeIds = SubjectTypeController.fillComboSubjectTypes(ref comboBox1);
            fillCombo();
        }

        public AddUpdateSubject(string gradelevel,string subject_name, int id,string subjectTypeName)
        {
            InitializeComponent();
           
            gradeAll = DataClass.getAllGrade();
            subjectTypeIds = SubjectTypeController.fillComboSubjectTypes(ref comboBox1);
            isEdited = true;
            fillCombo();
            textBox1.Text = subject_name;
            cbGradeLevel.SelectedItem = gradelevel;
            comboBox1.SelectedItem = subjectTypeName;
            this.id = id;
        }

        private void AddUpdateSection_Load(object sender, EventArgs e)
        {

          
            //cbGradeLevel.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isValid = checkValidation();

            if (isValid)
            {
                if (!isEdited)
                {
                    subjectController.addSubject(cbGradeLevel.SelectedItem.ToString(), textBox1.Text.Trim(),selectedSubjectType);
                 
                   
                }
                else
                {
                    subjectController.updateSubjects(cbGradeLevel.SelectedItem.ToString(), textBox1.Text.Trim(),selectedSubjectType, id);
                    MessageBox.Show("Succesfully Edited New Subject");
                    
                }
                    this.Hide();

            }
        }

        private bool checkValidation()
        {
            bool isValid = true;

            isValid = !(textBox1.Text.Trim() == "") && isValid;

       

            isValid = cbGradeLevel.SelectedIndex > -1 && isValid;


            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            return isValid;
        }

        private void fillCombo()
        {
            foreach (string grade in gradeAll)
            {
                cbGradeLevel.Items.Add(grade);
            }
        }

        private void cbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubjectType = subjectTypeIds[comboBox1.SelectedIndex];
        }
    }
}
