using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CST.Models;
using CST.Models.Student;

namespace CST
{
    public partial class StudentForm : Form
    {
        YearController yearcontroller = new YearController();
        StudentsDetailsController StudentsDetailsController = new StudentsDetailsController();
        StudFamDetailsController studFam = new StudFamDetailsController();
        string[] studentDetails = new string[12];
        string[] famDetails = new string[17];
        int currentTab = 0;
        string currentSy = "";
        public StudentForm()
        {
            InitializeComponent();
            currentSy = yearcontroller.getSyActivated();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            rbNew.Checked = true;
            radioButton1.Checked = true;
            radioButton12.Checked = true;
            radioButton3.Checked = true;
            dateTimePicker1.MaxDate = DateTime.Now;
            StudentModel.setBd(dateTimePicker1.Value.ToString().Split()[0]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
         


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                btnSearch.Visible = false;
                txtStudentID.Text = generateSNO();
                txtStudentID.Enabled = false;
                StudentModel.setSno(generateSNO());

            }
            else
            {
                txtStudentID.Text = "";
                txtStudentID.Enabled = true;
                btnSearch.Visible = true;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            /*if (rbOld.Checked)
            {
                btnSearch.Visible = true;
            }
            else
            {

            }*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            NewStudents frm = new NewStudents();
            frm.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Succesfully Added Student Details");
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save!!
            //executes query 
            //getAllDetails();
            getAllFamDetails();
            studFam.addFamDetails(StudentModel.getSno(), famDetails);
            /*StudentsDetailsController.addStudDetails(studentDetails);
            backgroundWorker1.RunWorkerAsync();
            progressBar1.Show();
            tabControl1.Enabled = false;*/


        }

        private void getAllFamDetails()
        {
            famDetails[0] = StudentModel.getFather_name();
            famDetails[1] = StudentModel.getFather_no();
            famDetails[2] = StudentModel.getFather_occu();
            famDetails[3] = StudentModel.getFather_comp();
            famDetails[4] = StudentModel.getFather_Ctel();
            famDetails[5] = StudentModel.getFather_CAdd();
/*
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
            famDetails[17] = StudentModel.getParent_status();*/

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
            
        }

        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(StudentModel.getAddress() == "") && isValid;

            isValid = !(StudentModel.getFn() == "") && isValid;

            isValid = !(StudentModel.getLn() == "") && isValid;

            isValid = !(StudentModel.getGen() == "") && isValid;

            isValid = !(StudentModel.getAge() ==  0) && isValid;

            isValid = !(StudentModel.getbirthdate() == "") && isValid;

            isValid = !(StudentModel.getPob() == "") && isValid;

            isValid = !(StudentModel.getCn() == "") && isValid;

            isValid = !(StudentModel.getNat() == "") && isValid;

            isValid = !(StudentModel.getRel() == "") && isValid;

            isValid = !(StudentModel.getAddress() == "") && isValid;


        
            return isValid;
        }

        private string generateSNO()
        {
            string sno = "";
            int lastid = StudentsDetailsController.getRecentStudentId();
            sno = "STUD-" + currentSy.Split('-')[1] + "-" + fixID(lastid);

            return sno;
        }

        private string fixID(int lastid)
        {
            string id = "";
            if(lastid < 10)
            {
                id = "000" + lastid;
            }else if(lastid>= 10 && lastid< 100)
            {
                id = "00" + lastid;
            }else if(lastid>100 && lastid< 1000)
            {
                id = "0" + lastid;
            }else if (lastid > 999)
            {
                id = lastid + "";
            }
            return id;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setLn(txtLastname.Text.Trim());
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFn(txtFirstname.Text.Trim());

        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setMn(txtMiddlename.Text.Trim());
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if(textBox19.Text != "")
            {
                StudentModel.setAge(int.Parse(textBox19.Text.Trim()));
            }
           
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            StudentModel.setBd(dateTimePicker1.Value.ToString().Split()[0]);
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setCn(textBox24.Text.Trim());
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789+";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setNat(txtNationality.Text.Trim());
        }

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setRel(txtReligion.Text.Trim());
        }

        private void txtPOB_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setPlaceofbirth(txtPOB.Text.Trim());
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setAddress(txtAddress.Text.Trim());
        }

        private void getAllDetails()
        {
            studentDetails[0] = StudentModel.getSno();
            studentDetails[1] = StudentModel.getFn();
            studentDetails[2] = StudentModel.getLn();
            studentDetails[3] = StudentModel.getMn();
            studentDetails[4] = StudentModel.getGen();
            studentDetails[5] = StudentModel.getAge() + "";
            studentDetails[6] = StudentModel.getbirthdate();
            studentDetails[7] = StudentModel.getPob();
            studentDetails[8] = StudentModel.getCn();
            studentDetails[9] = StudentModel.getNat();
            studentDetails[10] = StudentModel.getRel();
            studentDetails[11] = StudentModel.getAddress();

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                StudentModel.setGender("Male");
            }
            else
            {
                StudentModel.setGender("Female");
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
           /* if (currentTab == 0)
            {


                int changedPage = tabControl1.SelectedIndex;
                bool isValidToNextPage = validationTab1();
                if (isValidToNextPage)
                {
                    tabControl1.SelectedIndex = changedPage;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Complete Information for the Personal Details", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

        }

        private void txtFLast_TextChanged(object sender, EventArgs e)
        {
            //father
            StudentModel.setFather_name(txtFLast.Text.Trim());
        }

        private void txtFFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFMiddle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFMobile_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_no(txtFMobile.Text.Trim());
        }

        private void txtFOccupation_TextChanged(object sender, EventArgs e)
        {
            StudentModel.setFather_occu(txtFOccupation.Text.Trim());
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //mother
            StudentModel.setMother_name(textBox12.Text.Trim());
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                StudentModel.setParent_status("Living Together");
            }
            else
            {
                StudentModel.setParent_status("separated");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                StudentModel.setParent_status("Living Together");
            }
            else
            {
                StudentModel.setParent_status("separated");
            }
        }
    }
}
