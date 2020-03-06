using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Enrollment_Admin.AddUpdateDiags;
using CST.Models;
using CST.Models.Timetable;

namespace CST.Enrollment_Admin.PanelSched
{
    public partial class panelTimeTable : Form
    {
        YearController yearController = new YearController();
        TimestampController timestampController = new TimestampController();
        // List<string> datestamp = new List<string>();
        public string timeStamps = "";
    
        public panelTimeTable()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addTimeStamp ad = new addTimeStamp();
            ad.ShowDialog();
            refreshGrid();
        }

        private void panelTimeTable_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            timestampController.fillDataTime(ref dataGridView1, yearController.getSchoolYearId());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addToTheList();
            this.Hide();
        /*    ListViewItem lv = new ListViewItem();
            lv.Text = timeStamp;
            PanelScheduling p = new PanelScheduling();
            p.listView1.Items.Add(lv);*/
            /*  PanelScheduling p = new PanelScheduling(timeStamp);*/
            /*ts.addTime()*/
        }

        private void addToTheList()
        {
            timeStamps = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            /*ListViewItem lv = new ListViewItem();
            lv.Text = timeStamp;
            lv.SubItems.Add(timeStamp);
            lv.SubItems.Add(timeStamp);
            lv.SubItems.Add(timeStamp);
            PanelScheduling p = new PanelScheduling();
            p.listView1.Items.Add(lv);*/


        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
