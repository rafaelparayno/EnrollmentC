using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Enrollment_Admin.DialogsSched;

namespace CST.Enrollment_Admin.PanelSched
{
    public partial class PanelScheduling : Form
    {
        public string gradelevel = "";
        public string timestamp = "";
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
            // frm.gradelevel = gradelevel;

            frm.ShowDialog();
            gradelevel = frm.gradelevell;
            label1.Text = "Grade Level : " + gradelevel;
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelTimeTable p = new panelTimeTable();
            p.button1.Visible = true;
            p.ShowDialog();
            timestamp = p.timeStamps;
         
         ListViewItem lv = new ListViewItem();
         lv.Text = timestamp;

         //   PanelScheduling p = new PanelScheduling();
         //p.listView1.Items.Add(lv);
         listView1.Items.Add(lv);
        }
    }
}
