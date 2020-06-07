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
using CST.Enrollment_Admin.PanelSched;

namespace CST.Enrollment_Admin.DialogsSched
{
    public partial class AssignGrade : Form
    {
        public string gradelevell = "";
        public AssignGrade()
        {
            InitializeComponent();
        }

        private void AssignGrade_Load(object sender, EventArgs e)
        {
            foreach(string item in DataClass.getAllGrade())
            {
                cbGradeLevel.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gradelevell= cbGradeLevel.SelectedItem.ToString();

            this.Hide();
            
            
        }

        private void cbGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradelevell = cbGradeLevel.SelectedItem.ToString();
        }
    }
}
