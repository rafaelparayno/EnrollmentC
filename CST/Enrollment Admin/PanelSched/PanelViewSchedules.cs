using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Data;
using CST.Enrollment_Admin.DialogsSched;
using CST.Models;

namespace CST.Enrollment_Admin.PanelSched
{
    public partial class PanelViewSchedules : Form
    {
        int[] ssids;
        int[] sectionIds = { };
        int selectedSectIds = 0;
        SectionController sectionController = new SectionController();
        SchedSectionController schedSectionController = new SchedSectionController();
        IDictionary<int, int> subjectdata = new Dictionary<int, int>();
        IDictionary<int, int> teacherData = new Dictionary<int, int>();
        Loading load = new Loading();
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
            clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            getSchedSections();
           
        }

        private void getSchedSections()
        {
            selectedSectIds = sectionIds[comboBox2.SelectedIndex];
            listView1.Items.Clear();
            ssids = schedSectionController.fillListSched2(ref listView1, selectedSectIds);
            label3.Text = "Room :" + schedSectionController.roomname(selectedSectIds);
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
            if (CheckingSubjects())
            {
                backgroundWorker1.RunWorkerAsync();
                load.Show();
                if (subjectdata != null)
                {
                    foreach(KeyValuePair<int,int> entry in subjectdata)
                    {
                        schedSectionController.updateSchedBySubjects(entry.Key, entry.Value);
                    }
                }
                if(teacherData != null)
                {
                    foreach(KeyValuePair<int,int> entry in teacherData)
                    {
                        schedSectionController.updateSchedByTeachers(entry.Key, entry.Value);
                    
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Cannot have the same subject", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePosition = listView1.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listView1.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);

            if(listView1.Items.Count > 0)
            {
                switch (columnindex)
                {
                    case 2:
                        EditSubjectSched frm = new EditSubjectSched(listView1.SelectedItems[0].SubItems[2].Text,comboBox1.SelectedItem.ToString());
                        frm.ShowDialog();
                        if (frm.selectedId != 0 && frm.isChanged)
                        {
                            // MessageBox.Show(ssids[listView1.SelectedIndices[0]]+"");
                            subjectdata[ssids[listView1.SelectedIndices[0]]] = frm.selectedId;
                            styledUpdateCells(2);
                            listView1.SelectedItems[0].SubItems[2].Text = frm.sub;
                            button1.Enabled = true;
                        }
                   
                        break;
                    case 3:
                        EditTeacherSched frm2 = new EditTeacherSched(comboBox1.SelectedItem.ToString(), 
                                                                    listView1.SelectedItems[0].SubItems[2].Text, 
                                                                    listView1.SelectedItems[0].SubItems[0].Text,
                                                                    listView1.SelectedItems[0].SubItems[1].Text);
                        frm2.ShowDialog();
                        if(frm2.selectedId !=0)
                        {
                            listView1.SelectedItems[0].SubItems[3].Text = frm2.TeacherName;
                            teacherData[ssids[listView1.SelectedIndices[0]]] = frm2.selectedId;
                            styledUpdateCells(3);
                            button1.Enabled = true;
                        }
                        break;
                    default:
                        MessageBox.Show("time");
                        break;
                }
            }
            

        }

        private void styledUpdateCells(int index)
        {
            listView1.Items[listView1.SelectedIndices[0]].UseItemStyleForSubItems = false;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[index].BackColor = Color.DarkSeaGreen;
            listView1.Items[listView1.SelectedIndices[0]].SubItems[index].ForeColor = Color.White;
        }

        private void clear()
        {
            listView1.Items.Clear();
            if(ssids != null)
                Array.Clear(ssids, 0, ssids.Length);
            subjectdata.Clear();
            teacherData.Clear();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool CheckingSubjects()
        {
            bool isValid = true;
            string[] subjectsname = new string[listView1.Items.Count]; 
           for(int i= 0;i < listView1.Items.Count; i++)
            {
                subjectsname[i] = listView1.Items[i].SubItems[2].Text;
            }
            if (subjectsname.Distinct().Count() != subjectsname.Count())
            {
                isValid = false;
               
            }

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

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            load.Hide();
            getSchedSections();
        }
    }
}
