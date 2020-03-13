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
using CST.Models;

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
    }
}
