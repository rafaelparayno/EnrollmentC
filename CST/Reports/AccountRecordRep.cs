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
    public partial class AccountRecordRep : Form
    {
        DataSet ds;
        public AccountRecordRep(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        private void AccountRecordRep_Load(object sender, EventArgs e)
        {
            studentAccount cos = new studentAccount();
            cos.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cos;
        }
    }
}
