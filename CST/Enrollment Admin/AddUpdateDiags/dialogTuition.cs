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
                    this.Hide();
                }
                else
                {
                    tf.addTuition(comboBox2.SelectedItem.ToString(), double.Parse(textBox1.Text),
                           comboBox1.SelectedItem.ToString());

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
