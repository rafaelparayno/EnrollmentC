using CST.Data;
using CST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Registrar
{
    public partial class StudentGradesReg : Form
    {
        YearController yearController = new YearController();
        SectionController sectionController = new SectionController();
        int[] yrids = { };
        int []sectionids = { };
        int selectyrid = 0;
        string selectedGrade = "";
        public StudentGradesReg()
        {
            InitializeComponent();
            yrids = yearController.fillComboSy(ref comboBox1);
            foreach(string grade in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(grade);
            }
        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectyrid = yrids[comboBox1.SelectedIndex];
            comboBox2.SelectedIndex = 0;
            //comboBox3.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                selectedGrade = "";
            
                comboBox3.Items.Clear();
                comboBox3.Items.Add("*");
            }
            else
            {
                selectedGrade = comboBox2.SelectedItem.ToString();
                comboBox3.Items.Clear();
                sectionids = sectionController.fillComboSect4(ref comboBox3, comboBox2.Text,selectyrid);
                comboBox2.Enabled = true;
            }
        }
    }
}
