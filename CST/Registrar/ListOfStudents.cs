using CST.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CST.Models;
using CST.Reports;

namespace CST
{
    public partial class ListOfStudents : Form
    {
        int[] sectIds = { };
        int selectedSectionId = 0;
        SectionController sectionController = new SectionController();
        StudentsDetailsController StudentsDetailsController = new StudentsDetailsController();
        public ListOfStudents()
        {
            InitializeComponent();
            foreach(string grade in DataClass.getAllGrade())
            {
                cbLevel.Items.Add(grade);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       private void ListOfStudents_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox1.Items.Clear();
            sectIds = sectionController.fillComboSect3(ref comboBox1, cbLevel.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSectionId = sectIds[comboBox1.SelectedIndex];
            StudentsDetailsController.fillDataGridDetailsInSection(ref dataGridView1, selectedSectionId);

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            if(dataGridView1.Rows.Count > 0)
            {
                DataSet ds = new DataSet();

                DataTable dt = new DataTable();
                dt.Columns.Add("StudentNumber", typeof(string));
                dt.Columns.Add("StudentName", typeof(string));
                dt.Columns.Add("GradeLevel", typeof(string));

                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2]);
                }

                ds.Tables.Add(dt);
                ClassListReport frm = new ClassListReport(ds,selectedSectionId);
                frm.ShowDialog();
            }
          
        }
    }
}
