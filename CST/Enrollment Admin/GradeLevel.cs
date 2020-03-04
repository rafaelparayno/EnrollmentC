using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CST.Enrollment_Admin.AddUpdateDiags;
using CST.Models.SchoolYear;
using CST.Models;

namespace CST
{
    public partial class GradeLevel : Form
    {

        GradeLevelController gradeLevelController = new GradeLevelController();
        YearController YearController = new YearController();
        public GradeLevel()
        {
            InitializeComponent();
            timer1.Start();
            label4.Text = SchoolYearModel.getSchoolYear();

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Facilities fr3 = new Facilities();
            fr3.ShowDialog();
            return;

        }

        private void GradeLevel_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void txtGradeLevelNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Facilities fr3 = new Facilities();
            fr3.ShowDialog();
            return;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();

            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

       

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddUpdateGrade frm = new AddUpdateGrade();
            frm.ShowDialog();
            refreshGrid();
        }

        private void refreshGrid()
        {
            gradeLevelController.fillDataGridGrade(ref dataGridView1, YearController.getSchoolYearId());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {


            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                gradeLevelController.removeGradeLevel(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                refreshGrid();
            }
        }
    }
}
