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
using CST.Registrar;
using CST.Data;

namespace CST
{
    public partial class StudentForm : Form
    {
        YearController yearcontroller = new YearController();
        StudentsDetailsController StudentsDetailsController = new StudentsDetailsController();
        StudFamDetailsController studFam = new StudFamDetailsController();
        StudHistDetailsController studHis = new StudHistDetailsController();
        StudentRequirementController studReq = new StudentRequirementController();
        
       // StudentEnrolledController studentEnrolledController = new StudentEnrolledController();
        bool isUpdate = false;
        string sno = "";
        string[] studentDetails = new string[13];
        string[] famDetails = new string[17];
        bool inValid2 = false;
        int currentTab = 0;
        string currentSy = "";
        string isVacinated = "";
        bool inValid = false;
        public StudentForm()
        {
            InitializeComponent();
            currentSy = yearcontroller.getSyActivated();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            label44.Hide();
            if (StudentModel.getTypeStud() == "New Student" || StudentModel.getTypeStud() == "Transferee Student")
            {
                btnSearch.Visible = false;
                txtStudentID.Text = generateSNO();
                txtStudentID.Enabled = false;
                StudentModel.setSno(generateSNO());
                dateTimePicker1.MaxDate = DateTime.Now;
                inValid = true;
                inValid2 = true;
            }
            else
            {
                inValid = false;
                inValid2 = false;
                isUpdate = true;
                txtStudentID.Text = "";
                txtStudentID.Enabled = true;
                btnSearch.Visible = true;
         
            }

            radioButton1.Checked = true;
            radioButton12.Checked = true;
            radioButton3.Checked = true;
            radioButton7.Checked = true;
         
            StudentModel.setBd(dateTimePicker1.Value.ToString().Split()[0]);
            foreach(string grade in DataClass.getAllGrade())
            {
                cbPastLevel.Items.Add(grade);
            }
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
      
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
          
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
            if (StudentModel.getTypeStud() == "New Student" || StudentModel.getTypeStud() == "Transferee Student")
            {
                selectingGradeSectionSched frm = new selectingGradeSectionSched(txtStudentID.Text.Trim(), txtFirstname.Text.Trim() + " " + txtLastname.Text.Trim(), StudentModel.getTypeStud());
                frm.Show();
               
            }
            else
            {
                selectingGradeSectionSched frm = new selectingGradeSectionSched("STUD-" +txtStudentID.Text.Trim(), txtFirstname.Text.Trim() + " " + txtLastname.Text.Trim(),StudentModel.getTypeStud());
                frm.Show();
               
            }
            StudentModel.clearAll();
            this.Hide();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save!!
            //executes query 
            bool isvalid = true;
            isvalid = validationTab3() && isvalid;
            isvalid = validationTab1() && isvalid;
            isvalid = validationTab2() && isvalid;
            isvalid = inValid && isvalid;
            isvalid = inValid2 && isvalid;
            if (isvalid)
            {
                getAllDetails();
                getAllFamDetails();

                backgroundWorker1.RunWorkerAsync();
                progressBar1.Show();
                tabControl1.Enabled = false;
                if (!isUpdate)
                {
          
                    StudentsDetailsController.addStudDetails(studentDetails);
                 
                    studFam.addFamDetails(StudentModel.getSno(), famDetails);
                    studHis.addHisDetails(StudentModel.getSno(), txtPastSchool.Text.Trim(), txtPastAdd.Text.Trim(), cbPastLevel.SelectedItem.ToString().Trim(),
                                        dateTimePicker2.Value.ToShortDateString(), isVacinated, txtVaccination.Text.Trim());
                    int[] reqIds = StudentModel.getReq_ids();

                    for (int i = 0; i < reqIds.Length; i++)
                    {
                        studReq.addStudentReq(StudentModel.getSno(), reqIds[i]);

                    }

                }
                else
                {
                    StudentsDetailsController.updateStudDetails2(studentDetails[1], studentDetails[2], studentDetails[3],
                                                                 studentDetails[4], int.Parse(studentDetails[5]), studentDetails[6],
                                                                 studentDetails[7], studentDetails[8], studentDetails[9],
                                                                 studentDetails[10], studentDetails[11], StudentModel.getTypeStud(),sno);
                    studFam.updateFamDetails(famDetails, sno);
                    studHis.updateHisDetails(sno, txtPastSchool.Text.Trim(), txtPastAdd.Text.Trim(), cbPastLevel.SelectedItem.ToString().Trim(),
                                            dateTimePicker2.Value.ToShortDateString(), isVacinated, txtVaccination.Text.Trim());
                    int[] reqIds = StudentModel.getReq_ids();

                    for (int i = 0; i < reqIds.Length; i++)
                    {
                        studReq.addStudentReq(sno, reqIds[i]);

                    }
                }

                

           
                
            }
            else
            {
                MessageBox.Show("Please Complete Information for the Details or Student Already Enrolled..", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }

        private void getAllFamDetails()
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
            
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

          

            isValid = !(StudentModel.getNat() == "") && isValid;

            isValid = !(StudentModel.getRel() == "") && isValid;

            isValid = !(StudentModel.getAddress() == "") && isValid;


        
            return isValid;
        }

        private bool validationTab3()
        {
            bool isValid = true;


            isValid = isValid && (cbPastLevel.SelectedItem.ToString() != "");
            isValid = isValid && (txtPastSchool.Text != "");
          

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
            studentDetails = StudentsDetailsController.searchEnrollment("STUD-" + txtStudentID.Text.Trim());
            famDetails = studFam.getAllFamDetails("STUD-"+txtStudentID.Text.Trim());
            if (studentDetails[0] == null)
            {

                MessageBox.Show("No Student Found");
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtMiddlename.Text = "";
                textBox19.Text = "";


                textBox24.Text = "";
                txtPOB.Text = "";
                txtReligion.Text = "";
                txtNationality.Text = "";
                txtAddress.Text = "";
                inValid = false;
                inValid2 = false;
            }
            else
            {
                //student_details
                inValid = true;
                inValid2 = studentDetails[12] == null || studentDetails[12] == "" ? true : false;
                sno = studentDetails[0];
                txtFirstname.Text = studentDetails[1];
                txtLastname.Text = studentDetails[2];
                txtMiddlename.Text = studentDetails[3];
                if (studentDetails[4] == "Male")
                {
                    radioButton12.Checked = true;
                }
                else
                {
                    radioButton13.Checked = true;
                }
                textBox19.Text = studentDetails[5];
            
                string bday = studentDetails[6].Split('/')[0] + "/" + studentDetails[6].Split('/')[1] + "/" + studentDetails[6].Split('/')[2];
             //   MessageBox.Show(bday);
                DateTime bdate = DateTime.Parse(bday);

                dateTimePicker1.Value = bdate;
                textBox24.Text = studentDetails[8];
                txtPOB.Text = studentDetails[7];
                txtReligion.Text = studentDetails[10];
                txtNationality.Text = studentDetails[9];

                txtAddress.Text = studentDetails[11];
                //student Details

                //Family Details

                txtFLast.Text = famDetails[0];
                txtFMobile.Text = famDetails[1];
                txtFOccupation.Text = famDetails[2];
                txtFCompany.Text = famDetails[3];
                txtFCompanyMobile.Text = famDetails[4];
                txtFCompanyAddress.Text = famDetails[5];

                textBox12.Text = famDetails[6];
                textBox5.Text = famDetails[7];
                textBox6.Text = famDetails[8];
                textBox8.Text = famDetails[9];
                textBox7.Text = famDetails[10];
                textBox9.Text = famDetails[11];

                textBox13.Text = famDetails[12];
                textBox14.Text = famDetails[13];
                textBox16.Text = famDetails[14];
                textBox15.Text = famDetails[15];

                if(famDetails[16] == "Living Together")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                //famDetails

                //stud hist

                txtPastSchool.Text = studHis.getHistStudent("STUD-" + txtStudentID.Text.Trim())[0];
                txtPastAdd.Text = studHis.getHistStudent("STUD-" + txtStudentID.Text.Trim())[1];
                cbPastLevel.Text = studHis.getHistStudent("STUD-" + txtStudentID.Text.Trim())[2];
                dateTimePicker2.Value = DateTime.Parse(studHis.getHistStudent("STUD-" + txtStudentID.Text.Trim())[3]);
                if (studHis.getHistStudent(txtStudentID.Text.Trim())[4] == "Yes")
                {
                    radioButton7.Checked = true;
                }
                else
                {
                    radioButton6.Checked = true;
                }
                txtVaccination.Text = studHis.getHistStudent(txtStudentID.Text.Trim())[5];
         
            }
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
            StudentModel.setBd(dateTimePicker1.Value.ToString("MM/dd/yyyy"));
         
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
            studentDetails[12] = StudentModel.getTypeStud();
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

        private void errorHandlingIsEmpty(ref TextBox tb,string message)
        {
            if(tb.Text == string.Empty)
            {
                errorProvider1.SetError(tb, message);
            }
          
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
        
            if (currentTab == 0)
            {

              
                int changedPage = tabControl1.SelectedIndex;
                bool isValidToNextPage = validationTab1();
                if (isValidToNextPage)
                {
                    
                    currentTab = changedPage;
                    tabControl1.SelectedIndex = changedPage;
                    errorProvider1.Clear();
            
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Complete Information for the Personal Details", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorHandlingIsEmpty(ref txtAddress, "Enter Address");
                    errorHandlingIsEmpty(ref txtLastname, "Enter Lastname");
                    errorHandlingIsEmpty(ref txtMiddlename, "Enter Middlename");
                    errorHandlingIsEmpty(ref txtFirstname, "Enter Firstname");
                    errorHandlingIsEmpty(ref textBox19, "Enter Age");
          
                    errorHandlingIsEmpty(ref txtNationality, "Enter Nationality");
                    errorHandlingIsEmpty(ref txtReligion, "Enter Religion");
                    errorHandlingIsEmpty(ref txtPOB, "Enter Place of birth");
            


                }
            }else if(currentTab == 1)
            {
            
                int changedPage = tabControl1.SelectedIndex;
           
                bool isValidToNextPage = validationTab2();
                if (isValidToNextPage)
                {
               
                    currentTab = changedPage;
                    tabControl1.SelectedIndex = changedPage;
                    errorProvider1.Clear();
                }
                else
                {
                    e.Cancel = true;
                    errorHandlingIsEmpty(ref txtFLast, "Enter Fathers name");
                    errorHandlingIsEmpty(ref txtFMobile, "Enter Fathers Mobile");
                    errorHandlingIsEmpty(ref txtMiddlename, "Enter Father's Occu");
                    errorHandlingIsEmpty(ref textBox12, "Enter Mother's name");
                    errorHandlingIsEmpty(ref textBox5, "Enter Mothers Mobile");

                    errorHandlingIsEmpty(ref textBox6, "Enter Mothers number");

                    MessageBox.Show("Please Complete Information for the Family Details", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(currentTab == 2)
            {
            
               
                int changedPage = tabControl1.SelectedIndex;

                currentTab = changedPage;
                tabControl1.SelectedIndex = changedPage;
             

            }

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

        private void txtFMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFCompanyMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                isVacinated = "Yes";
                txtVaccination.Enabled = true;
            }
            else
            {
                isVacinated = "No";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                txtVaccination.Enabled = false;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                textBox17.Enabled = true;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                textBox17.Enabled = false;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                textBox18.Enabled = true;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                textBox18.Enabled = false;
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
