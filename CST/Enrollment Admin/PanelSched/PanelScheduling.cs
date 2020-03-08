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
using CST.Enrollment_Admin.DialogsSched;

namespace CST.Enrollment_Admin.PanelSched
{
    public partial class PanelScheduling : Form
    {
        public string gradelevel = "";
    

        public string timestamp = "";
        SectionController sectionController = new SectionController();

        List<DateTime> timestampStart = new List<DateTime>();
        List<DateTime> timestampEnd = new List<DateTime>();
        string[] subjid;
        List<string> timeStampId = new List<string>();
        int sect_id = 0;
        public PanelScheduling()
        {
            InitializeComponent();

        }

        public string myValue
        {
            get { return label1.Text; }
        }

        public PanelScheduling(string name)
        {
            InitializeComponent();
             ListViewItem lv = new ListViewItem();
                  lv.Text = name;
            listView1.Items.Add(lv);
        }
        private void PanelScheduling_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignGrade frm = new AssignGrade();
      
            frm.ShowDialog();
            gradelevel = frm.gradelevell;
            label1.Text = "Grade Level : " + gradelevel;
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isClose = false;
            panelTimeTable p = new panelTimeTable(timestampEnd, timestampStart, timeStampId);
            p.button2.Visible = false;
            p.button1.Visible = true;
            p.ShowDialog();
            isClose = p.IsClose;

            if (!isClose)
            {
                timestampStart.Add(DateTime.Parse(p.timeStart));
                timestampEnd.Add(DateTime.Parse(p.timeEnd));
                timeStampId.Add(p.ts_id);
                subjid = new string[timestampStart.Count];
                arrangeTimestamp();
                listView1.Items.Clear();


                refreshList();



            }
        
        }

        private void arrangeTimestamp()
        {

            timestampStart = timestampStart.OrderBy(x => x.TimeOfDay).ToList();
            timestampEnd = timestampEnd.OrderBy(x => x.TimeOfDay).ToList();


        }


        private void refreshList()
        {
            for (int i = 0; i < timestampEnd.Count; i++)
            {
                ListViewItem lv = new ListViewItem();
              
                TimeSpan duration = DateTime.Parse(timestampEnd[i].ToShortTimeString()).Subtract(DateTime.Parse(timestampStart[i].ToShortTimeString()));
                lv.Text = timestampStart[i].ToShortTimeString();
                lv.SubItems.Add(timestampEnd[i].ToShortTimeString());
                lv.SubItems.Add(duration.ToString());
                lv.SubItems.Add("");
                lv.SubItems.Add("");


                listView1.Items.Add(lv);

            }
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            AssignSection frm = new AssignSection();
            frm.ShowDialog();

          
            if(frm.grade != "")
            {
                gradelevel = sectionController.getGradeLevelinSections(int.Parse(frm.grade));
                sect_id = int.Parse(frm.grade);
            }
           
            label1.Text = "Grade Level : " + gradelevel;
            label2.Text = "Section : " + frm.sectionName;
            listView1.Items.Clear();
            timestampStart.Clear();
            timestampEnd.Clear();
            timeStampId.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(timestampStart.Count()> 0 && label1.Text != "")
            {
            
                //  subjects.Add(frm.subjectsSelected);
                if (listView1.SelectedItems.Count > 0)
                {
                    AssignSubjects frm = new AssignSubjects(gradelevel, subjid);
                    frm.ShowDialog();
                    listView1.SelectedItems[0].SubItems[3].Text = frm.subjectsSelected;
                    //     MessageBox.Show(listView1.SelectedIndices[0].ToString());
                    subjid[listView1.SelectedIndices[0]] = frm.selectedSubId;
                
                }
                else
                {
                    MessageBox.Show("Please Select In the List");
                }
             
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

         
            if (listView1.SelectedItems.Count > 0)
            {
                AssignTeacher frm = new AssignTeacher(gradelevel, listView1.SelectedItems[0].SubItems[3].Text);
                frm.ShowDialog();
                listView1.SelectedItems[0].SubItems[4].Text = frm.TeacherName;

            }
            else
            {
                MessageBox.Show("Please Select In the List");
            }
        }
    }
}
