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
    public partial class ListofSection : Form
    {
        SectionController sectionController = new SectionController();
        SpecializationController specializationController = new SpecializationController();
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();

        int[] sect_ids = { };
        int Teacher_id = 0;
        int selectedSectIds = 0;

        public ListofSection()
        {
            InitializeComponent();
            radioButton2.Checked = true;
            Teacher_id = specializationController.findTeacherId(UserLog.getUserId());
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher fr1 = new Teacher ();
            fr1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

        

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ListofSection_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSectIds = sect_ids[comboBox2.SelectedIndex];
            studentsDetailsController.fillDataGridDetailsInSection(ref dataGridView1, selectedSectIds);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            clearGrid();
            if (radioButton1.Checked)
            {
                sect_ids = sectionController.fillComboSect5(ref comboBox2, Teacher_id);
            }
            else
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            clearGrid();
            if (radioButton2.Checked)
            {
                

                sect_ids = sectionController.fillComboSect4(ref comboBox2, Teacher_id);
            }
            else
            {

            }
        }

        private void clearGrid()
        {
            dataGridView1.DataSource = null;
        }
    }
}
