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

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class addUpdateRequirements : Form
    {
        bool isValid = false;
        bool isEdited = false;
        private int id = 0;
        SchoolRequirementsController schoolRequirements = new SchoolRequirementsController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        public addUpdateRequirements()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
        }

        public addUpdateRequirements(string typeStud, string name, int id)
        {
            InitializeComponent();
            this.id = id;
            cbType.SelectedItem = typeStud;
            textBox1.Text = name;
            isEdited = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isValid = checkValidation();
            if (isValid)
            {
                if (!isEdited)
                {
                    schoolRequirements.addSchoolRequirements(cbType.SelectedItem.ToString(), textBox1.Text.Trim());
                    MessageBox.Show("Succesfully Added New Requirements");
                    auditTrail.addAudit(label3.Text, "Added Requirement"+ textBox1.Text.Trim() + " For " + cbType.SelectedItem.ToString());

                }
                else
                {
                    schoolRequirements.updateSchoolRequirements(cbType.SelectedItem.ToString(), textBox1.Text.Trim(),id);
                    MessageBox.Show("Succesfully Updated a Requirements");
                    auditTrail.addAudit(label3.Text, "Updated Requirement" + textBox1.Text.Trim() + " Of " + cbType.SelectedItem.ToString());
                }
                this.Hide();
            }
        }

        private void addUpdateRequirements_Load(object sender, EventArgs e)
        {
            label3.Hide();
            timer1.Start();

            /*   cbType.SelectedIndex = 0;*/
        }

        private bool checkValidation()
        {
            bool isValid = true;

            isValid = !(textBox1.Text.Trim() == "") && isValid;

            isValid = cbType.SelectedIndex > -1 && isValid;


            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return isValid;
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
