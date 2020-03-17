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
    public partial class ClassListReport : Form
    {
        DataSet dataset = null;
        SectionController sectionController = new SectionController();
        YearController yearController = new YearController();
        SpecializationController specializationController = new SpecializationController();
        string gradelevel = "";
        int teacherId = 0;
        string adviserName = "";
        string sectionName = "";
        string syLevel = "";

        public ClassListReport(DataSet ds,int sectionId)
        {
            InitializeComponent();
            dataset = ds;
            syLevel = yearController.getSyActivated();
            gradelevel = sectionController.getSectionGrade(sectionId);
            sectionName = sectionController.getSectionName(sectionId);
            teacherId = sectionController.getTeacherId(sectionId);

            adviserName = specializationController.AdviserName(teacherId);

        }

        private void ClassListReport_Load(object sender, EventArgs e)
        {
            classList cos = new classList();
            cos.SetDataSource(dataset);
            cos.SetParameterValue("sectionParam", sectionName);
            cos.SetParameterValue("syParam", syLevel);
            cos.SetParameterValue("adviserParam", adviserName);
            cos.SetParameterValue("gLevelParam", gradelevel);
            crystalReportViewer1.ReportSource = cos;
        }
    }
}
