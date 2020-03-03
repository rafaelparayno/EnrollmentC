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
        SubjectController subj = new SubjectController();
        private string[] user_ids = { };
        private string selectedId = "";
        private string[] subjects = { };
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
            subjects = subj.getAllSubjects();
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
                specializationController.addSpecialization(selectedId, sub,cbType.SelectedItem.ToString());
                MessageBox.Show("Succesfully Assign a teacher");
                this.Hide();
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubjects.Items.Clear();
            if(cbType.SelectedIndex == 0)
            {

                cbSubjects.Enabled = false;
                label5.Visible = false;
                cbSubjects.Visible = false;
                sub = "none";
            }
            else
            {
                cbSubjects.Enabled = true;
                label5.Visible = true;
                cbSubjects.Visible = true;
                for (int i = 0; i < subjects.Length; i++)
                {
                    string[] arr = subjects[i].Split('-');
                    int grade = int.Parse(arr[1]);

                    if (grade >= 7)
                    {
                        cbSubjects.Items.Add(arr[0]);
                    }
                }
            }
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub = cbSubjects.SelectedItem.ToString();
        }

        private bool checkValidation()
        {
            bool isValid = true;

            isValid = cbTeacher.SelectedIndex > -1 && isValid;

            isValid = cbType.SelectedIndex > -1 && isValid;


            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return isValid;
        }
    }
}
