using CST.Data;
using CST.Models;
using CST.Teacher;
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
        StudentGradesController studentGradesController = new StudentGradesController();
      
        int[] yrids = { };
        int selectedYrds = 0;
       
        public StudentGradesReg()
        {
            InitializeComponent();
            yrids = yearController.fillComboSy(ref comboBox1);
            
        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYrds = yrids[comboBox1.SelectedIndex];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            studentGradesController.fillLvGrades(ref listView1,selectedYrds, "STUD-" + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewStudents newStudents = new NewStudents();
            newStudents.Show();
            this.Hide();
        }
    }
}
