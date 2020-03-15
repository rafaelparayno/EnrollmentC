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

namespace CST.Enrollment_Admin
{
    public partial class Bookeeping : Form
    {
        int[] syids = { };
        YearController yearController = new YearController();
        RoomController roomController = new RoomController();
        SectionController sectionController = new SectionController();
        SchoolRequirementsController requirementsController = new SchoolRequirementsController();
        int selectedSyid = 0;
        public Bookeeping()
        {
            InitializeComponent();
            syids = yearController.fillComboSy(ref comboBox2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            if(comboBox2.SelectedIndex > -1)
            {
                refreshGrid();
            }
        }

        private void Bookeeping_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            EnrollmentAdmin frm = new EnrollmentAdmin();
            frm.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSyid = syids[comboBox2.SelectedIndex];

            refreshGrid();
        }

        private void refreshGrid() {
            if (comboBox1.SelectedIndex == 0)
            {
                //rooms
                roomController.fillDataGridRoom(ref dataGridView1, selectedSyid);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //sections
                sectionController.fillDataGridSect(ref dataGridView1, selectedSyid);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //requirements
                requirementsController.fillDataGridSchoolReq(ref dataGridView1, selectedSyid);

            }
        }
    }
}
