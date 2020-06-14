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

namespace CST
{
    public partial class UpdateTeacherSpecialization : Form
    {
        SpecializationController specializationController = new SpecializationController();
        SubjectTypeController SubjectTypeController = new SubjectTypeController();
        SubjectController subj = new SubjectController();
        private string[] user_ids = { };
        private string selectedId = "";
        private int[] subjectsids = { };
        private int selectedSubIds = 0;
     //   private int[] subids = { };
        private string sub = "";

        public UpdateTeacherSpecialization()
        {
            InitializeComponent();
           
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersSpecialization fr3 = new TeachersSpecialization();
            fr3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTeacherSpecialization_Load(object sender, EventArgs e)
        {
            timer1.Start();
            user_ids = specializationController.fillDataTeacher(ref cbTeacher);
            subjectsids = SubjectTypeController.fillComboSubjectTypes(ref cbSubjects);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

         

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = user_ids[cbTeacher.SelectedIndex];
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*specializationController.addSpecialization()*/

            bool isValid = checkValidation();

            if (isValid)
            {
                specializationController.addSpecialization(selectedId,cbType.SelectedItem.ToString(),selectedSubIds);
                MessageBox.Show("Succesfully Assign a teacher");
                this.Hide();
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(cbType.SelectedIndex == 0)
            {

                cbSubjects.Enabled = false;
                label5.Visible = false;
                cbSubjects.Visible = false;
                sub = "none";
                selectedSubIds = 0;
            }
            else
            {
                cbSubjects.Enabled = true;
                label5.Visible = true;
                cbSubjects.Visible = true;
           
            }
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub = cbSubjects.SelectedItem.ToString();
            selectedSubIds = subjectsids[cbSubjects.SelectedIndex];
        }

        private bool checkValidation()
        {
            bool isValid = true;

            isValid = cbTeacher.SelectedIndex > -1 && isValid;

            isValid = cbType.SelectedIndex > -1 && isValid;

            if (cbType.SelectedIndex > 0)
            {
                isValid = cbSubjects.SelectedIndex > -1 && isValid;
            }

            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return isValid;
        }
    }
}
