using CST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Reports
{
    public partial class StudentSchedRep : Form
    {
        DataSet ds = null;
        string sectionName = "";
        string gradeLevel = "";
        public StudentSchedRep(DataSet d2f,string sectname,string gradelvl)
        {
            InitializeComponent();
            this.ds = d2f;
            sectionName = sectname;
            gradeLevel = gradelvl;

        }

        private void StudentSchedRep_Load(object sender, EventArgs e)
        {
            reportSched cos = new reportSched();
            cos.SetDataSource(ds);
            cos.SetParameterValue("SectName", sectionName);
            cos.SetParameterValue("GradeLevel", gradeLevel);
            cos.SetParameterValue("nameLogParam", UserLog.getFullName());
            crystalReportViewer1.ReportSource = cos;
        }
    }
}
