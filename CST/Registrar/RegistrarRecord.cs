using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CST.Registrar;
using CST.Models;
using CST.Models.Student;
using CST.Reports;

namespace CST
{
    public partial class RegistrarRecord : Form
    {


        SchedSectionController SchedSectionController = new SchedSectionController();
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        StudFamDetailsController studFamDetailsController = new StudFamDetailsController();
        StudHistDetailsController StudHistDetailsController = new StudHistDetailsController();
        StudentEnrolledController studentEnrolledController = new StudentEnrolledController();
        EnrollScheduleController enrollSchedule = new EnrollScheduleController();
        SectionController sectionController = new SectionController();
        YearController yearController = new YearController();
        TuitionFeeController tfController = new TuitionFeeController();
        MiscController mfController = new MiscController();
        StudentBalance StudentBalance = new StudentBalance();
        CultureInfo provider = CultureInfo.InvariantCulture;
        int[] yrids = { };
        int selectedYrid = 0;
        string clickedBut = "";
        public RegistrarRecord()
        {
            InitializeComponent();
            timer1.Start();
            yrids = yearController.fillComboSy(ref comboBox1);
            label6.Text = yearController.getSyActivated();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsDetailsController.fillDataGridDetails(ref dataGridView1);
            clickedBut = "Personal";
           
            button6.Enabled = true;
            button11.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            if (comboBox3.SelectedIndex == 1)
            {
                button11.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm reg = new RegistrarForm();
            reg.Show();
            this.Hide();
        }

        private void RegistrarRecord_Load(object sender, EventArgs e)
        {
            studentsDetailsController.fillDataGridDetails(ref dataGridView1);
            clickedBut = "Personal";
            button6.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                if (clickedBut == "Personal")
                {
                    editStudentForm frm = new editStudentForm(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                              int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                                                              dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                              );
                    //string fn,string ln,string mn,string gen,int age,string bd,string pob, string cn,string nat,string rel,string add,string sno
                    frm.ShowDialog();
                    StudHistDetailsController.fillDataHist(ref dataGridView1);
                   
                }
                else if (clickedBut == "Family")
                {
                    StudentModel.setSno(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    StudentModel.setFather_name(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    StudentModel.setFather_no(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    StudentModel.setFather_occu(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    StudentModel.setFather_compname(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    StudentModel.setFather_Ctelno(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    StudentModel.setFather_officeAdd(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                    StudentModel.setMother_name(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                    StudentModel.setMother_no(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                    StudentModel.setMother_occu(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
                    StudentModel.setMother_compname(dataGridView1.SelectedRows[0].Cells[10].Value.ToString());
                    StudentModel.setMother_Ctelno(dataGridView1.SelectedRows[0].Cells[11].Value.ToString());
                    StudentModel.setMother_officeAdd(dataGridView1.SelectedRows[0].Cells[12].Value.ToString());
                    StudentModel.setGuardian_name(dataGridView1.SelectedRows[0].Cells[13].Value.ToString());
                    StudentModel.setGuardian_add(dataGridView1.SelectedRows[0].Cells[14].Value.ToString());
                    StudentModel.setGuardian_rel(dataGridView1.SelectedRows[0].Cells[15].Value.ToString());
                    StudentModel.setGuardian_no(dataGridView1.SelectedRows[0].Cells[16].Value.ToString());
                    StudentModel.setParent_status(dataGridView1.SelectedRows[0].Cells[17].Value.ToString());
                    editStudFam frm = new editStudFam();
                    frm.ShowDialog();
                    studFamDetailsController.filldataGridFam(ref dataGridView1);
                

                }
                else if (clickedBut == "History")
                {
                    editStudHist frm = new editStudHist(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    frm.ShowDialog();

                }
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            studFamDetailsController.filldataGridFam(ref dataGridView1);
            clickedBut = "Family";
            button6.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudHistDetailsController.fillDataHist(ref dataGridView1);
            clickedBut = "History";
            button6.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studentsDetailsController.fillDataGridDetailsNotEnrolled(ref dataGridView1);
            clickedBut = "PersonalUnEnrolled";
            button6.Enabled = true;
            button11.Enabled = true;
            button9.Enabled = false;
            button10.Enabled = false;
            if (comboBox3.SelectedIndex == 1)
            {
                button11.Enabled = false;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex == 1)
            {
                comboBox1.Visible = true;
                txtUsername.Visible = false;
                button11.Enabled = false;
            }
            else
            {
                comboBox1.Visible = false;
                txtUsername.Visible = true;
                button11.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex > -1)
            {
                if(comboBox3.SelectedIndex == 0)
                {
                    //Sno
                    if(clickedBut == "Personal")
                    {
                        studentsDetailsController.fillDataGridDetails(ref dataGridView1, "STUD-" + txtUsername.Text.Trim());
                    }else if(clickedBut == "PersonalUnEnrolled")
                    {
                        studentsDetailsController.fillDataGridDetailsNotEnrolledWithSno(ref dataGridView1, "STUD-" + txtUsername.Text.Trim());
                    }
                  

                }
                else
                {
                    //Year
                    if(comboBox3.SelectedIndex > -1)
                    {
                        if (clickedBut == "Personal")
                        {
                            studentsDetailsController.fillDataGridDetails(ref dataGridView1, selectedYrid);
                        }
                        else if (clickedBut == "PersonalUnEnrolled")
                        {

                        }


                    }
                    else
                    {
                        MessageBox.Show("Please Select in the Combobox");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Select in the Combobox");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYrid = yrids[comboBox1.SelectedIndex];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                RegFormRep frm = new RegFormRep(sno);
                frm.ShowDialog();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
             if (dataGridView1.Rows.Count > 0)
            {
                string sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string grade = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                RegRecordSched frm = new RegRecordSched(sno,grade);
                frm.ShowDialog();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double tf = 0;
                double mf = 0;
                double total = 0;
                double disc = 0;
                string roomname = "";
                string sectionname = "";
                double upon = 0;
                string sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string grade = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " +
                                  dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + " " +
                                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                int sectid = studentEnrolledController.getSchedId(sno);
              
                string mod = StudentBalance.getModOfPayment(sno);
                string yrName = yearController.getSyActivated();
            
                double neededTopay = StudentBalance.getNeedToPay(sno);
                tf = tfController.getTfPriceGrade(grade, mod);
                mf = mfController.getMiscFeeForGrade(grade);
                disc = StudentBalance.getDisc(sno);
                upon = StudentBalance.getUponPay(sno);
                total = (tf + mf) - disc;
                string endDate = enrollSchedule.getEnrollSched()[2];
                string tfPhp = "₱ " + tf;
                string mfPhp = "₱ " + mf;
                string discPhp = disc == 0 ? "₱ 0" : "₱ " + disc;
                string totalPhp = "₱ " + total;
                string uponPhp = mod == "Fullpayment" ? "" : "Upon Enrollment : ₱ " + upon;
                string detailMf = mfController.getInfoMiscForGrade(grade);
                roomname = SchedSectionController.roomname(sectid);
                sectionname = sectionController.getSectionName(sectid);

                DataSet ds = new DataSet();
                
               // MessageBox.Show(endDate);
                SchedSectionController.getStudSchedDataSet(sectid, ref ds);
                string dueDates = mod == "Fullpayment" ? "Upon Enrollment : " + DateTime.ParseExact(endDate,"dd/MM/yyyy",provider).ToString("MMMM,dd") + " - " + totalPhp : setDueDates(mod, endDate, neededTopay);
                string[] dataParam = new string[13];
                dataParam[0] = fullname;
                dataParam[1] = roomname;
                dataParam[2] = yrName;
                dataParam[3] = sectionname;
                dataParam[4] = sno;
                dataParam[5] = tfPhp;
                dataParam[6] = mfPhp;
                dataParam[7] = mod;
                dataParam[8] = detailMf;
                dataParam[9] = totalPhp;
                dataParam[10] = discPhp;
                dataParam[11] = dueDates;
                dataParam[12] = uponPhp;
                assestmentFormRep frm = new assestmentFormRep(ds, dataParam);
                frm.Show();

            }
        }



        private string setDueDates(string mod,string dateEnd,double payments)
        {
            string dues = "" ;
            string duess = "";
            DateTime date = DateTime.ParseExact(dateEnd, "dd/MM/yyyy", provider);
            DateTime dateEndPayment = DateTime.ParseExact(dateEnd, "dd/MM/yyyy", provider).AddMonths(9);

            dateEndPayment.AddMonths(9);
            switch (mod)
            {
            

                case "Semi-Annual":
                   date = date.AddMonths(4);
                    dues = "Due Date of Payment : \n" + date.ToString("MMMM") + " 15" + "-" + dateEndPayment.ToString("MMMM") + "- ₱" + payments;
                    break;
                case "Quarterly":
                    duess = "Due Date of Payment : \n";
                    for (int i = 0; i < 3; i++)
                    {
                        date = date.AddMonths(3);
                        duess +=  date.ToString("MMMM") + " 15 " + date.ToString("yyyy")  + " | ₱" + payments + "\n";      
                    }
                    dues = duess;
                    break;

                case "Monthly":
                     duess = "Dute Date of Payment : \n";
                     for(int i = 0; i < 9; i++)
                    {
                        date =  date.AddMonths(1);
                        duess +=  date.ToString("MMMM") + ", 15 " + date.ToString("yyyy") + " |  ₱" + payments + "\n";
                    }
                    dues = duess;
                    break;
            }

            return dues;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                string sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " +
                                      dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + " " +
                                        dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                editGradeAndSection frm = new editGradeAndSection(sno,fullname);
                frm.ShowDialog();
            }
           
        }

        private async void button13_Click(object sender, EventArgs e)
        {

            
           
             DataSet dss = await studentsDetailsController.getEnrolledStudent();

            enrolledstudent frm = new enrolledstudent(dss);
            frm.ShowDialog();

            //   dss.WriteXmlSchema("enrolledstudent.xml");
        }
    }
}
