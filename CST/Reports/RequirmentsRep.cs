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
    public partial class RequirmentsRep : Form
    {
        DataSet ds = null;
        YearController yearController = new YearController();
        string syLevel = "";
        public RequirmentsRep(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
            syLevel = yearController.getSyActivated();

        }

        private void RequirmentsRep_Load(object sender, EventArgs e)
        {
            studentReq cos = new studentReq();
            cos.SetDataSource(ds);
            cos.SetParameterValue("syParam", syLevel);
            cos.SetParameterValue("nameLogParam", UserLog.getFullName());
            crystalReportViewer1.ReportSource = cos;
        }
    }
}
