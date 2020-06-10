using CST.Models;
using CST.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Registrar
{
    public partial class RegRecordSched : Form
    {

        SchedSectionController schedSectionController = new SchedSectionController();
        StudentEnrolledController studentEnrolledController = new StudentEnrolledController();
        SectionController sectionController = new SectionController();
        int sectid = 0;
        string roomname = "";
        string sectionname = "";
        string grade = "";
        public RegRecordSched(string sno,string grade)
        {
            InitializeComponent();
            sectid = studentEnrolledController.getSchedId(sno);
            schedSectionController.fillListSched(ref listView1, sectid);

            roomname = schedSectionController.roomname(sectid);
            sectionname = sectionController.getSectionName(sectid);
            this.grade = grade;
            label3.Text +=  "\n" + roomname;
            label2.Text += "\n" + sectionname;
            label1.Text += "\n" + grade;

        }

        private void RegRecordSched_Load(object sender, EventArgs e)
        {
            //selectedSectIds = sectionIds[comboBox2.SelectedIndex];
            //listView1.Items.Clear();
            //schedSectionController.fillListSched(ref listView1, selectedSectIds);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Time Start", typeof(string));
            dt.Columns.Add("Time End", typeof(string));
            dt.Columns.Add("Subjects", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                dt.Rows.Add(listView1.Items[i].SubItems[0].Text,
                    listView1.Items[i].SubItems[1].Text,
                    listView1.Items[i].SubItems[2].Text,
                    listView1.Items[i].SubItems[3].Text);
            }

            ds.Tables.Add(dt);
            //  ds.WriteXmlSchema("StudSched.xml");

            StudentSchedRep form = new StudentSchedRep(ds, sectionname, grade);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
