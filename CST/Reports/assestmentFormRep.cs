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

        DataSet ds = new DataSet();
        public assestmentFormRep(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        private void assestmentFormRep_Load(object sender, EventArgs e)
        {

        }
    }
}
