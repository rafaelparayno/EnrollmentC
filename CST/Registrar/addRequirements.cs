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

namespace CST.Registrar
{
    public partial class addRequirements : Form
    {
        SchoolRequirementsController schoolRequirements = new SchoolRequirementsController();
        StudentsDetailsController studentsDetails = new StudentsDetailsController();
        StudentRequirementController studentRequirementController = new StudentRequirementController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        string sno = "";
        string name = "";
        string studType = "";
        int[] req_ids;
        int selectedReqId = 0;
        public addRequirements()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //comboBox2.Items.Clear();
         //   req_ids = schoolRequirements.fillComboReq(comboBox1.SelectedItem.ToString(), ref comboBox2);
         //   comboBox2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name = studentsDetails.searchName(textBox1.Text.Trim());
            studType = studentsDetails.searchStudType(textBox1.Text.Trim());

            label3.Text = "Name :" + name;
            label2.Text = "Type of Student : " + studType;
            comboBox2.Items.Clear();
            if (name == "")
            {
                MessageBox.Show("No Student Number Found");
                comboBox2.Enabled = false;
            }
            else
            {
                sno =  "STUD-"+textBox1.Text.Trim();
                req_ids = schoolRequirements.fillComboReq(studType, ref comboBox2);
                comboBox2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReqId = req_ids[comboBox2.SelectedIndex];
        }

        private bool Validation()
        {
            bool isValid = true;

            isValid = !(sno == "") && isValid;

            isValid = comboBox2.SelectedIndex > -1 && isValid;

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (!studentRequirementController.findSame(sno, selectedReqId))
                {
                    studentRequirementController.addStudentReq(sno,  selectedReqId);
                    auditTrail.addAudit(label7.Text, name + "Submit " +comboBox2.SelectedItem.ToString());
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already has the requirement", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            else
            {
                MessageBox.Show("Complete Required Field", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRequirements_Load(object sender, EventArgs e)
        {
            label7.Hide();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }
    }
}
