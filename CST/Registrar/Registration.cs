using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST
{
    public partial class Enrollment : Form
    {
        public Enrollment( )
        {
            InitializeComponent();
           
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        

        

        private void button7_Click(object sender, EventArgs e)
        {

        }


        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

    }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
         


            
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                errorProvider1.SetError(txtFirstname, "Please insert a Firstname of Student  ");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtMiddlename.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtFMiddle.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFirstname, null);


                return;


            }

        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedItem.Equals(""))
            {
                errorProvider1.SetError(cbGender, "Please choose the Sex of student");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }
               
                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }
              

                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(cbGender, null);


                return;


            }
}

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtReligion.Text))
            {
                errorProvider1.SetError(txtReligion, "Please insert a Religion ");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtReligion, null);


                return;


            }

        }

        private void txtPOB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPOB.Text))
            {
                errorProvider1.SetError(txtPOB, "Please insert a Place of Birth ");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtPOB, null);


                return;


            }

        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationality.Text))
            {
                errorProvider1.SetError(txtNationality, "Please insert a Nationality");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtNationality, null);


                return;


            }


        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Please insert a address");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtAddress, null);


                return;


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(txtPOB, "Please insert a a Grade Level");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(textBox1, null);


                return;


            }

        }

        private void txtFLast_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFLast.Text))
            {
                errorProvider1.SetError(txtFLast, "Please insert a Lastname of Father");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFLast, null);


                return;


            }

        }

        private void txtFFirst_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFFirst.Text))
            {
                errorProvider1.SetError(txtFFirst, "Please insert a Firstname of father");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFFirst, null);


                return;


            }

        }

        private void txtFMiddle_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFMobile_Keydown(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);



            if (string.IsNullOrWhiteSpace(txtFMobile.Text))
            {
                errorProvider1.SetError(txtFMiddle, "Please insert a Mobile Number");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFMobile, null);


                return;


            }

        }

        private void txtFOccupation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
            {
                errorProvider1.SetError(txtFOccupation, "Please insert a Occupation or none if not employee");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFOccupation, null);


                return;


            }

        }

        private void txtFCompany_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtFCompanyMobile_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);



          
            }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                errorProvider1.SetError(textBox9, "Please insert Company or None if not employee");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFCompany, null);


                return;


            }

        }

        private void txtFCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFCompanyAddress.Text))
            {
                errorProvider1.SetError(txtFCompanyAddress, "Please insert Company address or None if not employee");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFCompanyAddress, null);


                return;


            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox12.Text))
            {
                errorProvider1.SetError(textBox12, "Please insert Mother Firstname");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(textBox12, null);


                return;


            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox11.Text))
            {
                errorProvider1.SetError(txtFCompany, "Please insert ");

                button7.Enabled = false;



            }


            else
            {// CHild personal data
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFirstname.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(cbGender.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(dpBirthdate.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(txtReligion.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtPOB.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtNationality.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    button7.Enabled = false;
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    button7.Enabled = false;
                }

                // Child Family Data (father)
                if (string.IsNullOrWhiteSpace(txtFLast.Text))
                {
                    button7.Enabled = false;
                }

                if (string.IsNullOrWhiteSpace(txtFFirst.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFMobile.Text))
                {
                    button7.Enabled = false;
                }


                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompanyMobile.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(txtFCompany.Text))
                {
                    button7.Enabled = false;

                }


                // Child Family Data (Mother)


                if (string.IsNullOrWhiteSpace(textBox12.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    button7.Enabled = false;

                }
                if (string.IsNullOrWhiteSpace(textBox8.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    button7.Enabled = false;

                }

                if (string.IsNullOrWhiteSpace(textBox9.Text))
                {
                    button7.Enabled = false;

                }

                else

                    button7.Enabled = true;
                errorProvider1.SetError(txtFCompany, null);


                return;


            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OldStudents OS = new OldStudents(label5.Text,label49.Text,label6.Text);
            OS.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            TransfereeStudents TS = new TransfereeStudents(label5.Text, label49.Text, label6.Text);
            TS.Show();
            this.Hide();
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            NewStudents NS = new NewStudents();
            NS.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ReturneeStudents RS = new ReturneeStudents(label5.Text, label49.Text, label6.Text);
            RS.Show();
            this.Hide();
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










