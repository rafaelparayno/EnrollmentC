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
using CST.Models;
using MySql.Data.MySqlClient;
using CST.Enrollment_Admin.AddUpdateDiags;

namespace CST
{
    public partial class SchoolRequirements : Form
    {

        SchoolRequirementsController schoolRequirementsController = new SchoolRequirementsController();
        private int schoolYrId = 0;
        YearController yearController = new YearController();
        public SchoolRequirements()
        {
            InitializeComponent();
            timer1.Start();
            cbRoom.SelectedIndex = 0;
            
        }

        private void SchoolRequirements_Load(object sender, EventArgs e)
        {
            schoolYrId = yearController.getSchoolYearId();
            refreshGrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Facilities fr3 = new Facilities();
            fr3.ShowDialog();
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();

            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

          

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            addUpdateRequirements frm = new addUpdateRequirements();
            frm.ShowDialog();

            refreshGrid();
        }

        private void refreshGrid()
        {
            schoolRequirementsController.fillDataGridSchoolReq(ref dataGridView1, schoolYrId);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                addUpdateRequirements frm = new addUpdateRequirements(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                                dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                                int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();

                refreshGrid();
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if(dataGridView1.Rows.Count> 0)
            {
                DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


                if (form1 == DialogResult.Yes)
                {
                    schoolRequirementsController.removeSchoolReq(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show("Succesfully Remove Requirements");
                    refreshGrid();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                refreshGrid();
            }
            else
            {
                schoolRequirementsController.searchGrid(cbRoom.SelectedItem.ToString(), textBox1.Text.Trim(), ref dataGridView1, schoolYrId);
            }
        }
    }
}
