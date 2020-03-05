using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models.Student;
using CST.Models;

namespace CST.Registrar
{
    public partial class editStudFam : Form
    {
        string livingStatus = "";
        StudFamDetailsController studFamDetailsController = new StudFamDetailsController();
        string[] famDetails = new string[17];
        public editStudFam()
        {
            InitializeComponent();
            txtFLast.Text = StudentModel.getFather_name();
            txtFMobile.Text = StudentModel.getFather_no();
            txtFCompany.Text = StudentModel.getFather_comp();
            txtFOccupation.Text = StudentModel.getFather_occu();
            txtFCompanyMobile.Text = StudentModel.getFather_Ctel();
            txtFCompanyAddress.Text = StudentModel.getFather_CAdd();

            textBox12.Text = StudentModel.getMother_name();
            textBox5.Text = StudentModel.getMother_no();
            textBox6.Text = StudentModel.getMother_occu();
            textBox8.Text = StudentModel.getMother_comp();
            textBox7.Text = StudentModel.getMother_Ctel();
            textBox9.Text = StudentModel.getMother_CAdd();
            textBox13.Text = StudentModel.getGuardian_name();
            textBox14.Text = StudentModel.getGuardian_add();
            textBox16.Text = StudentModel.getGuardian_rel();
            textBox15.Text = StudentModel.getGuardian_no();

            livingStatus = StudentModel.getParent_status();

            //famDetails[0]
            
       

            if (livingStatus == "Living Together")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        /*    txtFLast.Text = StudentModel.getFather_name();
            txtFLast.Text = StudentModel.getFather_name();*/

        }

        private void txtFLast_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_name(txtFLast.Text.Trim());
        }

        private void txtFMobile_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_no(txtFMobile.Text.Trim());
        }

        private void txtFOccupation_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_occu(txtFOccupation.Text.Trim());
        }

        private void txtFCompany_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_compname(txtFCompany.Text.Trim());
        }

        private void txtFCompanyMobile_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_Ctelno(txtFCompanyMobile.Text.Trim());
        }

        private void txtFCompanyAddress_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_officeAdd(txtFCompanyAddress.Text.Trim());
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //mother
            StudentModel.setMother_name(textBox12.Text.Trim());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setMother_no(textBox5.Text.Trim());
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setMother_occu(textBox6.Text.Trim());
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setMother_compname(textBox8.Text.Trim());
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setMother_Ctelno(textBox7.Text.Trim());
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setMother_officeAdd(textBox9.Text.Trim());
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setGuardian_name(textBox13.Text.Trim());
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setGuardian_add(textBox14.Text.Trim());
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setGuardian_rel(textBox16.Text.Trim());
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setGuardian_no(textBox15.Text.Trim());
        }

        private void editStudFam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isValid = validationTab2();

            if (isValid)
            {
                getALlFamDetails();
                studFamDetailsController.updateFamDetails(famDetails, StudentModel.getSno());
                StudentModel.clearAll();
                MessageBox.Show("Succesfully Updated an Family Details");
                this.Hide();
            }
       
        }

        private bool validationTab2()
        {
            bool isValid = true;

            isValid = !(txtFLast.Text == "") && isValid;

            isValid = !(txtFMobile.Text == "") && isValid;

            isValid = !(textBox12.Text == "") && isValid;

            isValid = !(textBox5.Text == "") && isValid;

            isValid = !(txtFOccupation.Text == "") && isValid;

            isValid = !(textBox6.Text == "") && isValid;

            return isValid;
        }

        private void getALlFamDetails()
        {
            famDetails[0] = StudentModel.getFather_name();
            famDetails[1] = StudentModel.getFather_no();
            famDetails[2] = StudentModel.getFather_occu();
            famDetails[3] = StudentModel.getFather_comp();
            famDetails[4] = StudentModel.getFather_Ctel();
            famDetails[5] = StudentModel.getFather_CAdd();

            famDetails[6] = StudentModel.getMother_name();
            famDetails[7] = StudentModel.getMother_no();
            famDetails[8] = StudentModel.getMother_occu();
            famDetails[9] = StudentModel.getMother_comp();
            famDetails[10] = StudentModel.getMother_Ctel();
            famDetails[11] = StudentModel.getMother_CAdd();
            famDetails[12] = StudentModel.getGuardian_name();
            famDetails[13] = StudentModel.getGuardian_add();
            famDetails[14] = StudentModel.getGuardian_rel();
            famDetails[15] = StudentModel.getGuardian_no();

            famDetails[16] = StudentModel.getParent_status();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentModel.clearAll(); 
        }
    }
    
}
