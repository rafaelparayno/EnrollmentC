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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
