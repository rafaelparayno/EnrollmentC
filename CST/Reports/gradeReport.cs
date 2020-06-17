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


namespace CST.Reports
{
    public partial class gradeReport : Form
    {
        DataSet ds = null;
        string sectionName = "";
        string gradeLevel = "";
        string sy = "";
        string subject = "";
        YearController yearController = new YearController();
        SectionController sectionController = new SectionController();
        public gradeReport(DataSet dataset,int sectionId,string subname)
        {
            InitializeComponent();
            ds = dataset;
            sy = yearController.getSyActivated();
            sectionName = sectionController.getSectionName(sectionId);
            gradeLevel = sectionController.getSectionGrade(sectionId);
            subject = subname;


        }

        private void gradeReport_Load(object sender, EventArgs e)
        {
            GradeCsReport rep = new GradeCsReport();
            rep.SetDataSource(ds);
            rep.SetParameterValue("sectionParam", sectionName);
            rep.SetParameterValue("gradeLevelParam", gradeLevel);
            rep.SetParameterValue("syParam", sy);
            rep.SetParameterValue("subjectParam", subject);
            rep.SetParameterValue("nameLogParam", UserLog.getFullName());

            crystalReportViewer1.ReportSource = rep;
        }
    }
}
