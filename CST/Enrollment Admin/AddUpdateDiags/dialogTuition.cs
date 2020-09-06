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
    public partial class dialogTuition : Form
    {
        TuitionFeeController tf = new TuitionFeeController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        bool isEdited = false;
        string grade, tfee, mode;
        int id;
        public dialogTuition()
        {
            InitializeComponent();
            LoadGradeData();
        }

        public dialogTuition(string grade,string mode,string tfee,int id)
        {
            InitializeComponent();
            LoadGradeData();
            this.grade = grade;
            this.mode = mode;
            this.tfee = tfee;
            this.id = id;

            comboBox2.SelectedItem = grade;
            comboBox1.SelectedItem = mode;
            textBox1.Text = tfee;
            isEdited = true;

        }

        private void dialogTuition_Load(object sender, EventArgs e)
        {
            label3.Hide();
            timer1.Start();
        }

        private bool validation()
        {
            bool isValid = true;

            isValid = comboBox1.SelectedIndex > -1 && isValid;

            isValid = comboBox2.SelectedIndex > -1 && isValid;
            return isValid;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            double _;
            if (validation())
            {
                if (!double.TryParse(textBox1.Text, out _))
                {
                    MessageBox.Show("Input is not a number");
                    return;
                }

                if (isEdited)
                {
                    tf.updateTuition(comboBox2.SelectedItem.ToString(), double.Parse(textBox1.Text), comboBox1.SelectedItem.ToString(), id);
                    MessageBox.Show("Succesfully Updated");
                    auditTrail.addAudit(label3.Text, "Updated "+ comboBox2.SelectedItem.ToString()+ " Tuition Fee" );

                    this.Hide();
                }
                else
                {
                    tf.addTuition(comboBox2.SelectedItem.ToString(), double.Parse(textBox1.Text),
                           comboBox1.SelectedItem.ToString());
                    auditTrail.addAudit(label3.Text, "Added" + comboBox2.SelectedItem.ToString() + " Tuition Fee");

                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("Please Fill The Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dialogTuition_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789.";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadGradeData()
        {
            foreach (string items in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(items);
            }
        }
    }
}
