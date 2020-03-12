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
using CST.Teacher;

namespace CST
{
    public partial class TeacherSchedule : Form
    {

        SpecializationController specializationController = new SpecializationController();
        SchedSectionController schedSectionController = new SchedSectionController();
        
        int teacher_id = 0;
        public TeacherSchedule()
        {
            InitializeComponent();
            teacher_id = specializationController.findTeacherId(UserLog.getUserId());
            schedSectionController.fillListTeachSched(ref listView1, teacher_id);
            foreach(string grade in DataClass.getAllGrade())
            {
                comboBox1.Items.Add(grade);
            }
        }

        private void TeacherSchedule_Load(object sender, EventArgs e)
        {
           
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TeacherFrm fr3 = new TeacherFrm();
            fr3.ShowDialog();

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
            /* comboBox1.SelectedIndex = ;*/
            listView1.Items.Clear();
            schedSectionController.fillListTeachSched(ref listView1, teacher_id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            schedSectionController.fillListTeachSched2(ref listView1, teacher_id, comboBox1.SelectedItem.ToString());
        }
    }
    }

