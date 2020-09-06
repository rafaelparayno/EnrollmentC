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
using System.Threading;

namespace CST.Enrollment_Admin.PanelSched
{
    public partial class PanelScheduling : Form
    {
        public string gradelevel = "";
    

        public string timestamp = "";
        SectionController sectionController = new SectionController();
        SubjectController subjectController = new SubjectController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        List<DateTime> timestampStart = new List<DateTime>();
        List<DateTime> timestampEnd = new List<DateTime>();
        string[] subjid;
        int[] subids;
        int[] teacherIds;
        int roomId = 0;
        List<string> timeStampId = new List<string>();
        int sect_id = 0;
        SchedSectionController schedSectionController = new SchedSectionController();

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
            label7.Hide();
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AssignGrade frm = new AssignGrade();
      
            //frm.ShowDialog();
            //gradelevel = frm.gradelevell;
            //label1.Text = "Grade Level : " + gradelevel;
      
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
                teacherIds = new int[timestampStart.Count];
                subjid = new string[timestampStart.Count];
                subids = new int[timestampStart.Count];
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
            label3.Text = "Room : ";
            roomId = 0;
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
            if(gradelevel != "")
            {
                AssignSection frm = new AssignSection(gradelevel);
                frm.ShowDialog();


                if (frm.selectedId != "")
                {

                    sect_id = int.Parse(frm.selectedId);
                }


                label2.Text = "Section : " + frm.sectionName;
                resetSched();
            }
            else
            {
                MessageBox.Show("Error Please Select A Grade first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        
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
                    if(frm.subjectsSelected != "")
                    {
                        listView1.SelectedItems[0].SubItems[3].Text = frm.subjectsSelected;
                        //     MessageBox.Show(listView1.SelectedIndices[0].ToString());
                        subjid[listView1.SelectedIndices[0]] = frm.selectedSubId;
                        subids[listView1.SelectedIndices[0]] = frm.selectedSubidss;
                        button1.Enabled = true;
                        listBox1.Items.Clear();
                        fillListBox();
                        if (listBox1.Items.Count == 0)
                        {
                            button6.Enabled = false;
                        }
                    }
                   
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
                if(subjid[listView1.SelectedIndices[0]] != null)
                {
                    AssignTeacher frm = new AssignTeacher(gradelevel, listView1.SelectedItems[0].SubItems[3].Text,
                                                      listView1.SelectedItems[0].SubItems[0].Text,
                                                            listView1.SelectedItems[0].SubItems[1].Text,
                                                            int.Parse(subjid[listView1.SelectedIndices[0]]));
                    frm.ShowDialog();
                    listView1.SelectedItems[0].SubItems[4].Text = frm.TeacherName;
                    teacherIds[listView1.SelectedIndices[0]] = frm.selectedIdTeacher;
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please assign a subject in the list");
                }
               
            }
            else
            {
                MessageBox.Show("Please Select In the List");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                int lastIndex = listView1.Items.Count;
                AssignRoom frm = new AssignRoom(listView1.Items[lastIndex - 1].SubItems[1].Text,
                                                listView1.Items[0].SubItems[0].Text);
                frm.ShowDialog();
                label3.Text = "Room : " + frm.roomName;
                roomId = frm.selectedRoomId2;
                // MessageBox.Show(listView1.Items[lastIndex - 1].SubItems[1].Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isValid())
            {
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Show();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    int ts_id = int.Parse(timeStampId[i]);
                    int subss_id = int.Parse(subjid[i]);
                    int teach_id = teacherIds[i];
                    int c_id = roomId;
                    int sect = sect_id;
                    schedSectionController.saveSchedSection(ts_id, subss_id, teach_id, c_id, sect);
                }
                    auditTrail.addAudit(label7.Text, "Save Schedule");


            }
            else
            {
                MessageBox.Show("Please Fill the Requirements", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private bool isValid()
        {
            bool isValid = true;
            bool notFound = true;
            bool notFound2 = true;
            isValid = !(roomId == 0) && isValid;
            isValid = !(sect_id == 0) && isValid;
            isValid = timeStampId.Count > 0 && isValid;
            isValid = listBox1.Items.Count == 0 && isValid;
            foreach (int ids in teacherIds)
            {
                if (ids == 0)
                {
                    notFound = false;
                    break;
                }
            }

            foreach (string id in subjid)
            {
                if (id == null)
                {
                    notFound2 = false;
                    break;
                }
            }

            isValid = notFound && isValid;

            isValid = notFound2 && isValid;


            return isValid;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            MessageBox.Show("Succesfully Save a Schedule");


            this.Hide();
        }

        private void fillListBox()
        {
        
            subjectController.fillDataGridSubForGrade(ref listBox1, gradelevel, subids);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AssignGrade frm = new AssignGrade();
            frm.ShowDialog();

            if (frm.gradelevell != "")
            {
             
                gradelevel = frm.gradelevell;
                label1.Text = "Grade Level : " + gradelevel;
                resetSched();
            }



        }

        private void resetSched()
        {
            label3.Text = "Room : ";
            roomId = 0;
            subjid = null;
            subids = null;
            teacherIds = null;
            button6.Enabled = true;
            listView1.Items.Clear();
            timestampStart.Clear();
            timestampEnd.Clear();
            timeStampId.Clear();
            listBox1.Items.Clear();
            fillListBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }
    }
}
