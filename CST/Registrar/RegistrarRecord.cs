using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Registrar;
using CST.Models;
using CST.Models.Student;
using CST.Reports;

namespace CST
{
    public partial class RegistrarRecord : Form
    {

        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        StudFamDetailsController studFamDetailsController = new StudFamDetailsController();
        StudHistDetailsController StudHistDetailsController = new StudHistDetailsController();
        YearController yearController = new YearController();
        int[] yrids = { };
        int selectedYrid = 0;
        string clickedBut = "";
        public RegistrarRecord()
        {
            InitializeComponent();
            timer1.Start();
            yrids = yearController.fillComboSy(ref comboBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsDetailsController.fillDataGridDetails(ref dataGridView1);
            clickedBut = "Personal";
            button6.Enabled = true;

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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudHistDetailsController.fillDataHist(ref dataGridView1);
            clickedBut = "History";
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studentsDetailsController.fillDataGridDetailsNotEnrolled(ref dataGridView1);
            clickedBut = "Personal";
            button6.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex == 1)
            {
                comboBox1.Visible = true;
                txtUsername.Visible = false;
            }
            else
            {
                comboBox1.Visible = false;
                txtUsername.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(comboBox3.SelectedIndex > -1)
            {
                if(comboBox3.SelectedIndex == 0)
                {
                    //Sno
                    studentsDetailsController.fillDataGridDetails(ref dataGridView1,"STUD-" + txtUsername.Text.Trim());

                }
                else
                {
                    //Year
                    if(comboBox3.SelectedIndex > -1)
                    {
                        studentsDetailsController.fillDataGridDetails(ref dataGridView1, selectedYrid);
                      
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
    }
}
