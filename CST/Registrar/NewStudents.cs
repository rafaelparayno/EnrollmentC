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
using CST.Models.SchoolRequirementsMod;

namespace CST
{
    public partial class NewStudents : Form
    {
        SchoolRequirementsController schoolRequirements = new SchoolRequirementsController();
        public NewStudents()
        {
            InitializeComponent();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enrollment Enroll = new Enrollment();
            Enroll.Show();
            this.Hide();
        }

            private void NewStudents_Load(object sender, EventArgs e)
        {
           label3.Hide();
           label6.Hide(); 
           label49.Hide();
            label7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SchoolRequireModel> requireModels = new List<SchoolRequireModel>();
            foreach(SchoolRequireModel requ in requireModels)
            {

            }

            StudentForm SF = new StudentForm();
            SF.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGrid(cbType.SelectedItem.ToString());
        }

        private void fillDataGrid(string stud_type)
        {
            schoolRequirements.fillDataGridForTypeStud(ref dataGridView1, stud_type);
        }
    }
}
