using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CST.Enrollment_Admin.AddUpdateDiags;
using CST.Models;
using CST.Models.SchoolYear;
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class Section : Form
    {

        SectionController sectionController = new SectionController();
        YearController yr = new YearController();

        public Section()
        {
            InitializeComponent();

            timer1.Start();
            label7.Text = SchoolYearModel.getSchoolYear();
         
        }

        private void Section_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Facilities F = new Facilities();
            F.Show();
            this.Hide();
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
            sectionController.fillDataGridSect(ref dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdateSection frm = new AddUpdateSection();
            frm.ShowDialog();
            refreshGrid();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUpdateSection frm = new AddUpdateSection(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                                                        dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                        int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()));
            frm.ShowDialog();
            refreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                sectionController.removeSection(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                                                yr.getSchoolYearId());

                MessageBox.Show("Succesfully Remove a section");
                refreshGrid();
            }
        }
    }
}
