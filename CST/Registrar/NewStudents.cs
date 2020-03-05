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
using CST.Models.SchoolRequirementsMod;
using CST.Models.Student;

namespace CST
{
    public partial class NewStudents : Form
    {
        SchoolRequirementsController schoolRequirements = new SchoolRequirementsController();
        public NewStudents()
        {
            InitializeComponent();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

            private void NewStudents_Load(object sender, EventArgs e)
            {
            cbType.SelectedIndex = 0;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenghtDatagrid = dataGridView1.RowCount;
          
            List<int> reqIds = new List<int>();

            for(int i = 0; i < lenghtDatagrid; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "True")
                {
                    reqIds.Add(int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                
                }

            }
      
            int lenghtReqArr = reqIds.Count;
            int[] arrReqIds = new int[lenghtReqArr];
            for(int i = 0; i < lenghtReqArr; i++)
            {
                arrReqIds[i] = reqIds[i];
          
            }
            StudentModel.setReq_ids(arrReqIds);
            StudentForm SF = new StudentForm();
            SF.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGrid(cbType.SelectedItem.ToString());
        }

        private void fillDataGrid(string stud_type)
        {
            schoolRequirements.fillDataGridForTypeStud(ref dataGridView1, stud_type);
        }
    }
}
