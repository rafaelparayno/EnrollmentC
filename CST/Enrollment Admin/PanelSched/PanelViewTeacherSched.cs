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

namespace CST.Enrollment_Admin.PanelSched
{
    public partial class PanelViewTeacherSched : Form
    {
        int[] teachersIds = { };
        int selectedTeacherId = 0;
        SpecializationController specializationController = new SpecializationController();
        YearController yrController = new YearController();
        SchedSectionController schedSection = new SchedSectionController();
        int syid = 0;
        public PanelViewTeacherSched()
        {
            InitializeComponent();
            syid = yrController.getSchoolYearId();
            teachersIds = specializationController.fillDataTeacherCombo(ref comboBox1);
            
        }

        private void PanelViewTeacherSched_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeacherId = teachersIds[comboBox1.SelectedIndex];
            listView1.Items.Clear();
            schedSection.fillListTeachSched(ref listView1, selectedTeacherId);
        }
    }
}
