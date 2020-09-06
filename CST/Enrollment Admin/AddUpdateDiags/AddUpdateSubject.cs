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

        AuditTrailControl auditTrail = new AuditTrailControl();
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
            label3.Hide();
            timer1.Start();

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
                    auditTrail.addAudit(label3.Text, "Added " + textBox1.Text.Trim() +" Subject For " + cbGradeLevel.SelectedItem.ToString());


                }
                else
                {
                    subjectController.updateSubjects(cbGradeLevel.SelectedItem.ToString(), textBox1.Text.Trim(),selectedSubjectType, id);
                    MessageBox.Show("Succesfully Edit Subject");
                    auditTrail.addAudit(label3.Text, "Edit Subject");


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label3.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
