using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using CST.Teacher;
using CST.Reports;

namespace CST
{
    public partial class StudentGrades : Form
    {
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        SpecializationController specializationController = new SpecializationController();
        SubjectController subjectController = new SubjectController();
        StudentGradesController gradesController = new StudentGradesController();
      
        int [] subjectids = { };
        int[] sectids = { };
        int teacherId = 0;
        int selectedSectionId = 0;
        int selectedSubId = 0;
      
        SectionController sectionController = new SectionController();
        public StudentGrades()
        {
            InitializeComponent();
            teacherId = specializationController.findTeacherId(UserLog.getUserId());
            sectids = sectionController.fillComboSect4(ref comboBox2, teacherId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherFrm fr1 = new TeacherFrm();
            fr1.ShowDialog();
        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            
        }

     

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // ComputeAverage();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           // ComputeAverage();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            if(selectedSubId>0 && selectedSectionId > 0)
            {
                addGradeStudent frm = new addGradeStudent(selectedSectionId, selectedSubId, teacherId);
                frm.ShowDialog();
                refreshGrid();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Enabled = true;
            
            selectedSectionId = sectids[comboBox2.SelectedIndex];
            subjectids = subjectController.fillComboSubjectsAssignTeacher(ref comboBox1, teacherId, selectedSectionId); 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSubId = subjectids[comboBox1.SelectedIndex];
            button3.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = true;
            refreshGrid();

        }

        private void refreshGrid()
        {
            gradesController.fillDataGridGrades(ref dataGridView1, selectedSectionId, selectedSubId, teacherId);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                addGradeStudent frm = new addGradeStudent(selectedSectionId, selectedSubId, teacherId,
                                                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                     double.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()),
                                                      double.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                                                       double.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()),
                                                        double.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                                                         double.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()));
                frm.ShowDialog();
                refreshGrid();
            }
            else
            {
                MessageBox.Show("Please Click the row you wanted to edit");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel (.xlsx)|  *.xlsx";
                sfd.FileName = "Output.xlsx";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                            Microsoft.Office.Interop.Excel._Workbook workbook = XcelApp.Workbooks.Add(Type.Missing);
                            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                            worksheet = workbook.Sheets["Sheet1"];
                            worksheet = workbook.ActiveSheet;
                            worksheet.Name = "Output";
                            worksheet.Application.ActiveWindow.SplitRow = 1;
                            worksheet.Application.ActiveWindow.FreezePanes = true;

                            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                            {
                                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                                worksheet.Cells[1, i].Font.NAME = "Calibri";
                                worksheet.Cells[1, i].Font.Bold = true;
                                worksheet.Cells[1, i].Interior.Color = Color.Wheat;
                                worksheet.Cells[1, i].Font.Size = 12;
                            }

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            worksheet.Columns.AutoFit();
                            workbook.SaveAs(sfd.FileName);
                            XcelApp.Quit();

                            ReleaseObject(worksheet);
                            ReleaseObject(workbook);
                            ReleaseObject(XcelApp);

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.Message, "Error");
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                  "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                if(dataGridView1.Rows.Count > 0)
                {
                    gradesController.deleteGrade(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                                           selectedSubId, selectedSectionId, teacherId);
                    MessageBox.Show("Succesfully Remove Selected Student Grade");
                    refreshGrid();

                }
                else
                {
                    MessageBox.Show("No Grade Selected");
                }
            
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataSet ds = new DataSet();

                DataTable dt = new DataTable();
                dt.Columns.Add("Student Number", typeof(string));
                dt.Columns.Add("Student Name", typeof(string));
                dt.Columns.Add("1st Grading", typeof(string));
                dt.Columns.Add("2nd Grading", typeof(string));
                dt.Columns.Add("3rd Grading", typeof(string));
                dt.Columns.Add("4th Grading", typeof(string));
                dt.Columns.Add("Average", typeof(string));

                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value);
                   
                }


                ds.Tables.Add(dt);
                // ds.WriteXmlSchema("studGrades.xml");
                gradeReport frm = new gradeReport(ds, selectedSectionId, comboBox1.SelectedItem.ToString());
                frm.ShowDialog();
            }
        }
    }
}
