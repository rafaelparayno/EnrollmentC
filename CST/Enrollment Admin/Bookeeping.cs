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

namespace CST.Enrollment_Admin
{
    public partial class Bookeeping : Form
    {
        int[] syids = { };
        YearController yearController = new YearController();
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        SectionController sectionController = new SectionController();
        StudentBalance studentBalance = new StudentBalance();
        int selectedSyid = 0;
        int[] sectIds = { };
        int selectedSectionId = 0;
        public Bookeeping()
        {
            InitializeComponent();
            syids = yearController.fillComboSy(ref comboBox2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            if(comboBox2.SelectedIndex > -1)
            {
                refreshGrid();
            }
        }

        private void Bookeeping_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EnrollmentAdmin frm = new EnrollmentAdmin();
            frm.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSyid = syids[comboBox2.SelectedIndex];

            refreshGrid();
        }

        private void refreshGrid() {
            comboBox3.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                //Student Info
                studentsDetailsController.fillDataGridDetails(ref dataGridView1, selectedSyid);
                label3.Text = "Grade Level : ";
                label3.Visible = true;
                comboBox3.Visible = true;
                
                foreach(string grade in DataClass.getAllGrade())
                {
                    comboBox3.Items.Add(grade);
                }

                label4.Visible = false;
                comboBox4.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Text = "Grade Level : ";
                label3.Visible = true;
                comboBox3.Visible = true;

                foreach (string grade in DataClass.getAllGrade())
                {
                    comboBox3.Items.Add(grade);
                }

                label4.Visible = true;
                comboBox4.Visible = true;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //requirements
                //requirementsController.fillDataGridSchoolReq(ref dataGridView1, selectedSyid);
                label4.Visible = false;
                comboBox4.Visible = false;
                label3.Visible = false;
                comboBox3.Visible = false;
                studentBalance.fillDataGridTotal(ref dataGridView1, selectedSyid);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                studentsDetailsController.fillDataGridDetails(ref dataGridView1, selectedSyid,comboBox3.SelectedItem.ToString());

            }
            else if(comboBox1.SelectedIndex == 1)
            {
                comboBox4.Items.Clear();
                sectIds = sectionController.fillComboSect3(ref comboBox4, comboBox3.SelectedItem.ToString(), selectedSyid);
            }
              
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSectionId = sectIds[comboBox4.SelectedIndex];
            studentsDetailsController.fillDataGridDetailsInSection(ref dataGridView1, selectedSectionId);
        }
    }
}
