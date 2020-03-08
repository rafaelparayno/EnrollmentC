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
        List<DateTime> s = new List<DateTime>();
        List<DateTime> e = new List<DateTime>();
       
  /*      bool isConflict = false;*/
        public string timeStamps = "";
        public string timeStart = "";
        public string timeEnd = "";
        public string ts_id = "";
        List<string> ts_id2 = new List<string>();
        bool isConflict = false;
        bool isConflict2 = false;

        public bool IsClose = false;
    
        public panelTimeTable()
        {
            InitializeComponent();
        }

        public panelTimeTable(List<DateTime> timeEnds, List<DateTime> timeStarts,List<string> ids2)
        {
            InitializeComponent();
            s = timeStarts;           
            e = timeEnds;
            ts_id2 = ids2;

            // startEndss =
            
            if (e.Count > 0)
            {
                isConflict = true;
            }
           
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
        }

        private void addToTheList()
        {
            DateTime tsGrid = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            DateTime teGrid = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());




            for (int i = 0; i < s.Count; i++)
            {

            
                isConflict = tsGrid < e[i] && s[i] < teGrid;
                if (isConflict)
                {
                    break;
                }

            }

            for (int i = 0; i < ts_id2.Count; i++)
            {
                if(int.Parse(ts_id2[i]) == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    isConflict2 = true;
                    break;
                }
            }
            IsClose = isConflict || isConflict2;
        
            if (isConflict)
            {
                MessageBox.Show("Added Time is conflict with the list");
            }
            timeStart = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            timeEnd = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ts_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            IsClose = true;
            this.Hide();
        }
    }
}
