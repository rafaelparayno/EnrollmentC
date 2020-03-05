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

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class addUpdateTuition : Form
    {
        
        public addUpdateTuition()
        {
            InitializeComponent();
            foreach (string items in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(items);
            }
        }

        private void addUpdateTuition_Load(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
