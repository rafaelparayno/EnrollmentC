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
    public partial class editStudentForm : Form
    {
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        string gender = "";
        public editStudentForm(string fn, string ln, string mn, string gen, int age, string bd, string pob, string cn, string nat, string rel, string add, string sno)
        {
            InitializeComponent();
            txtStudentID.Text = sno;
            txtFirstname.Text = fn;
            txtLastname.Text = ln;
            txtMiddlename.Text = mn;
            txtNationality.Text = nat;
            txtAddress.Text = add;
            txtPOB.Text = pob;
            txtReligion.Text = rel;
            textBox24.Text = cn;
            textBox19.Text = age +"";
            gender = gen;
            if(gen == "Male")
            {
                radioButton12.Checked = true;
            }
            else
            {
                radioButton13.Checked = true;
            }
           
        }

        private void editStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = validationTab1();

            if (isValid)
            {
                studentsDetailsController.updateStudDetails(txtFirstname.Text.Trim(), txtLastname.Text.Trim(), txtMiddlename.Text.Trim(), gender,
                                                            int.Parse(textBox19.Text.Trim()), dateTimePicker1.Value.ToShortDateString(), txtPOB.Text.Trim(),
                                                            textBox24.Text.Trim(),txtNationality.Text.Trim(),txtReligion.Text.Trim(),txtAddress.Text.Trim(),
                                                            txtStudentID.Text.Trim());
                MessageBox.Show("Succesfully Updated Student Personal Info");
                this.Hide();
            }
        }

        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(txtFirstname.Text == "") && isValid;

            isValid = !(txtLastname.Text == "") && isValid;

            isValid = !(txtNationality.Text == "") && isValid;

            isValid = !(txtAddress.Text == "") && isValid;

            isValid = !(txtPOB.Text == "") && isValid;

            isValid = !(txtReligion.Text == "") && isValid;

            isValid = !(textBox24.Text == "") && isValid;

            isValid = !(textBox19.Text == "") && isValid;

       

            return isValid;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
