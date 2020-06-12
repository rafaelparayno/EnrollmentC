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
    public partial class ListRequirements : Form
    {

        StudentRequirementController studentRequirementController = new StudentRequirementController();
        
        public ListRequirements()
        {
            InitializeComponent();
        }

        private void ListRequirements_Load(object sender, EventArgs e)
        {
            refreshGrid();
            cbType.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addRequirements frm = new addRequirements();
            frm.ShowDialog();
            refreshGrid();
        }

        private void refreshGrid()
        {
            studentRequirementController.fillGridReq(ref dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                studentRequirementController.removeReq(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                refreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "";
            if(cbType.SelectedIndex == 0)
            {  
                //ALL type of requirements
              
                if(radioButton1.Checked == true)
                {
                    if(comboBox1.SelectedIndex == 1)
                    {

                        //sno

                         sql = String.Format(@"SELECT student_req_id AS 'Requirement ID' ,requirement_name As 'Requirements',
                                        student_detail.sno,Concat(firstname,' ',lastname) AS 'Student name'
                                        FROM students_requirement 
                                        LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN  school_requirements ON school_requirements.req_id = students_requirement.req_id 
                                        WHERE students_requirement.student_no = '{0}'",
                                                  "STUD-" + txtUsername.Text.Trim());

                        studentRequirementController.RawQuery(ref dataGridView1, sql);
                    }
                    else if(comboBox1.SelectedIndex == 2)
                    {
                        //name

                         sql = String.Format(@"SELECT student_req_id AS 'Pass_id' ,requirement_name,student_detail.sno, 
                                        Concat(firstname,' ',lastname) AS 'Studentname' FROM students_requirement 
                                        LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN school_requirements ON school_requirements.req_id = students_requirement.req_id 
                                        WHERE Concat(firstname,' ',lastname) LIKE '%{0}%'", txtUsername.Text.Trim());

                        studentRequirementController.RawQuery(ref dataGridView1, sql);
                    }
                    else
                    {
                        //*
                        refreshGrid();
                    }
                }
                else
                {
                 //TODO
                  

                }
            }
            else
            {


                if (radioButton1.Checked == true)
                {
                    if (comboBox1.SelectedIndex == 1)
                    {

                        //sno

                         sql = String.Format(@"SELECT student_req_id AS 'Requirement ID' ,requirement_name As 'Requirements',student_detail.sno,
                                        Concat(firstname,' ',lastname) AS 'Student name' FROM students_requirement 
                                        LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN  school_requirements ON school_requirements.req_id = students_requirement.req_id 
                                        WHERE students_requirement.student_no = '{0}' AND school_requirements.type_of_student = '{1}'",
                                        "STUD-" + txtUsername.Text.Trim(), cbType.SelectedItem.ToString());

                        studentRequirementController.RawQuery(ref dataGridView1, sql);
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        //name


                         sql = String.Format(@"SELECT student_req_id AS 'Pass_id' ,requirement_name,student_detail.sno,
                                        Concat(firstname,' ',lastname) AS 'Studentname' FROM students_requirement 
                                        LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN school_requirements ON school_requirements.req_id = students_requirement.req_id 
                                        WHERE Concat(firstname,' ',lastname) LIKE '%{0}%' AND school_requirements.type_of_student = '{1}'", 
                                        txtUsername.Text.Trim(), cbType.SelectedItem.ToString());

                        studentRequirementController.RawQuery(ref dataGridView1, sql);
                    }
                    else
                    {
                        //*

                        sql = String.Format(@"SELECT student_req_id AS 'Pass_id' ,requirement_name,student_detail.sno,
                                        Concat(firstname,' ',lastname) AS 'Studentname' FROM students_requirement 
                                        LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN school_requirements ON school_requirements.req_id = students_requirement.req_id 
                                         WHERE school_requirements.type_of_student = '{0}'",
                                        cbType.SelectedItem.ToString());
                        studentRequirementController.RawQuery(ref dataGridView1, sql);
                    }
                }
                else
                {

                    //TODO

                }
           

            }
           

           
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
