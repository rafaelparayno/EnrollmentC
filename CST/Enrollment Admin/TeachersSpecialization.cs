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
    public partial class TeachersSpecialization : Form
    {
        SpecializationController specialization = new SpecializationController();
        public TeachersSpecialization()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            UpdateTeacherSpecialization fr3 = new UpdateTeacherSpecialization();
            fr3.ShowDialog();
            refreshGrid();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentAdmin fr3 = new EnrollmentAdmin ();
            fr3.ShowDialog();
            return;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeachersSpecialization_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void refreshGrid()
        {
            specialization.fillDataGridTeacher(ref dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count> 0)
            {
                DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                     "Exit", MessageBoxButtons.YesNo);


                if (form1 == DialogResult.Yes)
                {

                    specialization.removeTeacher(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show("Succesfully Remove Data");
                    refreshGrid();
                }
            }
        }
    }
}
