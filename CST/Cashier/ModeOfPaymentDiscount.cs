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
    public partial class ModeOfPaymentDiscount : Form
    {
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        YearController YearController = new YearController();
        int syid = 0;
        private double disc = 0;
        public ModeOfPaymentDiscount()
        {
            InitializeComponent();
            syid = YearController.getSchoolYearId();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment P = new Payment();
            P.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (isValid())
            {
                this.Hide();
                Payment_Form fr1 = new Payment_Form("STUD-" +textBox1.Text.Trim(),textBox2.Text.Trim(),comboBox1.Text,textBox3.Text,disc);
                fr1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Complete the data");
            }
          



        }

        private void ModeOfPaymentDiscount_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] details = studentsDetailsController.searchEnrollment("STUD-" +textBox1.Text.Trim(), syid);

            if(details[0] == "" || details[0] == null)
            {
                MessageBox.Show("No SNO exists or Student is already enrolled");
            }
            else
            {
                textBox2.Text = details[0] + " " + details[2] + " " + details[1];
                textBox3.Text = details[12];
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label5.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                label5.Visible = false;
                numericUpDown1.Visible = false;
                disc = 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Visible = true;
                numericUpDown1.Visible = true;
           
            }
            else
            {
                label5.Visible = false;
                numericUpDown1.Visible = false;
             
                disc = 0;
            }
        }

        private bool isValid()
        {
            bool isValid = true;

            isValid = !(textBox1.Text.Trim() == "") && isValid;

            isValid = !(textBox2.Text.Trim() == "") && isValid;

            isValid = comboBox1.SelectedIndex > -1 && isValid;

       


            return isValid;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            disc = double.Parse(numericUpDown1.Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                groupBox3.Visible = true;
                label1.Visible = true;
               
            }
            else
            {
                groupBox3.Visible = false;
                label1.Visible = false;
                label5.Visible = false;
                numericUpDown1.Visible = false;
                radioButton3.Checked = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "";
            if (validKeys.IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }
        }
    }
}
