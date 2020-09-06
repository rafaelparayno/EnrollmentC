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
    public partial class AddUpdateSection : Form
    {
        SpecializationController sp = new SpecializationController();
        YearController yr = new YearController();
        SectionController sect = new SectionController();
        AuditTrailControl auditTrail = new AuditTrailControl();


        private string[] user_ids = { };
        private int sect_id = 0;
        int teacherId = 0;
        private bool isEdited = false;
      
        public AddUpdateSection()
        {
            InitializeComponent();
            fillCombo();
        }

        public AddUpdateSection(int sect_id,string grade_level,string fullName,string section_name,int caps)
        {
            InitializeComponent();
            fillCombo();
            isEdited = true;
            textBox1.Text = section_name;
            comboBox1.SelectedIndex = comboBox1.FindStringExact(grade_level);
            this.sect_id = sect_id;
            string teachernameWithID = sp.findTeacherName(fullName.Split(' ')[0], fullName.Split(' ')[1]);
            comboBox2.SelectedItem = teachernameWithID.Split('-')[0];
            teacherId = int.Parse(teachernameWithID.Split('-')[1]);
            textBox2.Text = caps + "";
        }

        private void AddUpdateSection_Load(object sender, EventArgs e)
        {
            label5.Hide();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = checkValidation();

            if (isValid)
            {
                if (!isEdited)
                {
                    sect.addSection(comboBox1.SelectedItem.ToString(), teacherId, textBox1.Text.Trim(), int.Parse(textBox2.Text.ToString().Trim()));
                    auditTrail.addAudit(label5.Text, "Added Section " + textBox1.Text.Trim() + " For " + comboBox1.SelectedItem.ToString());

                    this.Hide();
                }
                else
                {
                    sect.updateSection(sect_id, comboBox1.SelectedItem.ToString(), teacherId, textBox1.Text.Trim(), yr.getSchoolYearId(),int.Parse(textBox2.Text.Trim()));
                    auditTrail.addAudit(label5.Text, "Updated Section For " + comboBox1.SelectedItem.ToString());
                    this.Hide();
                }
               
            }

        }

        private bool checkValidation()
        {
            bool isValid = true;
            int _;

            isValid = comboBox1.SelectedIndex > -1 && isValid;

            isValid = comboBox2.SelectedIndex > -1 && isValid;

            isValid = !(textBox1.Text == "") && isValid;

            isValid = int.TryParse(textBox2.Text.Trim(),out _) && isValid;

            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return isValid;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherId = int.Parse(user_ids[comboBox2.SelectedIndex]);
        }

        private void fillCombo()
        {
            string[] grade = DataClass.getAllGrade();

            for (int i = 0; i < grade.Length; i++)
            {
                comboBox1.Items.Add(grade[i]);
            }

            user_ids = sp.fillDataTeacherSect(ref comboBox2);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 8 )
            {
                comboBox2.Items.Clear();
                user_ids = sp.fillComboSecondaryTeacher(ref comboBox2);
            }
            else
            {
                comboBox2.Items.Clear();
                user_ids = sp.fillDataTeacherSect(ref comboBox2);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label5.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
