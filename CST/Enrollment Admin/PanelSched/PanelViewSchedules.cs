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

namespace CST.Enrollment_Admin.PanelSched
{
    public partial class PanelViewSchedules : Form
    {
        int[] sectionIds = { };
        int selectedSectIds = 0;
        SectionController sectionController = new SectionController();
        SchedSectionController schedSectionController = new SchedSectionController();
        public PanelViewSchedules()
        {
            InitializeComponent();

            foreach(string grade in DataClass.getAllGrade())
            {
                comboBox1.Items.Add(grade);
            }
        }

        private void PanelViewSchedules_Load(object sender, EventArgs e)
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
            schedSectionController.fillListSched2(ref listView1, selectedSectIds);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult form1 = MessageBox.Show("Do you really want to Delete this Schedule for this Section?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                if(listView1.Items.Count > 0)
                {
                    schedSectionController.deleteSchedSection(selectedSectIds);

                    listView1.Items.Clear();
                    selectedSectIds = 0;
                    comboBox2.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No Data To be deleted");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
