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
    public partial class assestmentFormRep : Form
    {

        DataSet ds = null;
        string[] datasParam;
        public assestmentFormRep(DataSet ds,string[] datasParam)
        {
            InitializeComponent();
            this.ds = ds;
            this.datasParam = datasParam;
        }

        private void assestmentFormRep_Load(object sender, EventArgs e)
        {
            assestmentRep cos = new assestmentRep();
            cos.SetDataSource(ds);
            cos.SetParameterValue("studNameParam", datasParam[0]);
            cos.SetParameterValue("roomNameParam", datasParam[1]);
            cos.SetParameterValue("syParam", datasParam[2]);
            cos.SetParameterValue("sectionNameParam", datasParam[3]);
            cos.SetParameterValue("studNoParam", datasParam[4]);
            cos.SetParameterValue("tfParam", datasParam[5]);
            cos.SetParameterValue("msParam", datasParam[6]);
            cos.SetParameterValue("modParam", datasParam[7]);
            datasParam[8] += "\n" + "Discount: " + datasParam[10] + "\n" + "Total : "  + datasParam[9]; 
            cos.SetParameterValue("listofMiscParam", datasParam[8]);
         
            cos.SetParameterValue("duesParam", datasParam[11]);
            cos.SetParameterValue("regParam", UserLog.getFullName());
            cos.SetParameterValue("uponPaymentParams", datasParam[12]);
            crystalReportViewer1.ReportSource = cos;
        }
    }
}
