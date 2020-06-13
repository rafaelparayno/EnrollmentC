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
    public partial class StudentPaymentReps : Form
    {

        DataSet ds = null;
        string[] data = { };
        public StudentPaymentReps(DataSet ds,string [] data)
        {
            InitializeComponent();
            this.ds = ds;
            this.data = data;
        }

        private void StudentPaymentReps_Load(object sender, EventArgs e)
        {
            studentPaymentsRep cos = new studentPaymentsRep();
            cos.SetDataSource(ds);
            cos.SetParameterValue("nameParam", data[0]);
            cos.SetParameterValue("noParam", data[1]);
            cos.SetParameterValue("bdateParam", data[2]);
            cos.SetParameterValue("addParam", data[3]);
            cos.SetParameterValue("sexParam", data[4]);
            cos.SetParameterValue("fNameParam", data[5]);
            cos.SetParameterValue("mNameParam", data[6]);
            cos.SetParameterValue("fOccuParam", data[7]);
            cos.SetParameterValue("mOccuParam", data[8]);
            cos.SetParameterValue("bsAddF", data[9]);
            cos.SetParameterValue("bsAddM", data[10]);
            cos.SetParameterValue("modParam", data[11]);
            cos.SetParameterValue("totalBalanceParam", data[12]);
            cos.SetParameterValue("remBalanceParam", data[13]);
            crystalReportViewer1.ReportSource = cos;
        }
    }
}
