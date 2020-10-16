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
    public partial class enrolledstudent : Form
    {
        DataSet ds;
        YearController yearController = new YearController();
        string sy = "";

        public enrolledstudent(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
            sy = yearController.getSyActivated();
        }

        private void enrolledstudent_Load(object sender, EventArgs e)
        {
            enrolledStudentsRep rep = new enrolledStudentsRep();
            rep.SetDataSource(ds);
            rep.SetParameterValue("syParam", sy);
            rep.SetParameterValue("nameLogParam", UserLog.getFullName());
            crystalReportViewer1.ReportSource = rep;
        }
    }
}
