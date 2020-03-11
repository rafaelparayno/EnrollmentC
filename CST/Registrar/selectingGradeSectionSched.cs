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
    }
}
