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
using CST.Models;

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class dialogTuition : Form
    {
        TuitionFeeController tf = new TuitionFeeController();
        public dialogTuition()
        {
            InitializeComponent();
        }

        private void dialogTuition_Load(object sender, EventArgs e)
        {
            foreach (string items in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(items);
            }
        }

        private bool validation()
        {
            bool isValid = true;

            isValid = comboBox1.SelectedIndex > -1 && isValid;

            isValid = comboBox2.SelectedIndex > -1 && isValid;
            return isValid;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isValid = validation();

            if (isValid)
            {

                tf.addTuition(comboBox2.SelectedItem.ToString(), double.Parse(numericUpDown1.Value.ToString()),
                              comboBox1.SelectedItem.ToString());
             
                this.Hide();
            }
        }
    }
}
