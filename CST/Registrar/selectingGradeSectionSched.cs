using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Data;
using CST.Models;
using CST.Reports;

namespace CST.Registrar
{
    public partial class selectingGradeSectionSched : Form
    {

        string[] grades = { };
        string sno = "";
        string fn = "";
        int[] sectionIds = { };
        int selectedSectIds = 0;
        SectionController sectionController = new SectionController();
        SchedSectionController schedSectionController = new SchedSectionController();
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        public selectingGradeSectionSched(string studno,string name)
        {
            InitializeComponent();
            grades = DataClass.getAllGrade();
            foreach(string grade in grades)
            {
                comboBox1.Items.Add(grade);
            }
            sno = studno;
            fn = name;
            label4.Text = "Student No: " + sno;
            label5.Text = "Student Name: " + fn;
        }

        private void selectingGradeSectionSched_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            sectionIds = sectionController.fillComboSect3(ref comboBox2, comboBox1.Text);
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSectIds = sectionIds[comboBox2.SelectedIndex];
            listView1.Items.Clear();
            schedSectionController.fillListSched(ref listView1, selectedSectIds);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                studentsDetailsController.updateSectAndGrade(selectedSectIds, comboBox1.Text, sno);
                this.Hide();
                RegistrarForm frm = new RegistrarForm();
                frm.Show();
                MessageBox.Show("Succesfully Added Student section and grade");
            }
            else
            {
                MessageBox.Show("Please Select Grade And Section", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isValid()
        {
            bool isvalid = true;

            isvalid = comboBox1.SelectedIndex > -1 && isvalid;

            isvalid = comboBox2.SelectedIndex > -1 && isvalid;

            return isvalid;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex> -1)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Time Start", typeof(string));
            dt.Columns.Add("Time End", typeof(string));
            dt.Columns.Add("Subjects", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                dt.Rows.Add(listView1.Items[i].SubItems[0].Text,
                    listView1.Items[i].SubItems[1].Text, 
                    listView1.Items[i].SubItems[2].Text, 
                    listView1.Items[i].SubItems[3].Text);
            }

            ds.Tables.Add(dt);
            //  ds.WriteXmlSchema("StudSched.xml");

            StudentSchedRep form = new StudentSchedRep(ds, comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
            form.ShowDialog();

        }
    }
}
