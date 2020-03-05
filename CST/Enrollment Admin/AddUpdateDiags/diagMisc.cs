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
    public partial class diagMisc : Form
    {
        MiscController misc = new MiscController();
        public diagMisc()
        {
            InitializeComponent();
        }

        private void diagMisc_Load(object sender, EventArgs e)
        {
            foreach (string items in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(items);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isValid = validation();

            if(isValid){
                misc.addMisc(textBox1.Text.Trim(), double.Parse(numericUpDown1.Value.ToString()), comboBox2.SelectedItem.ToString());
                MessageBox.Show("Succesfully Added A new Misc");
                this.Hide();
            }
        }

        private bool validation()
        {
            bool isValid = true;

            isValid = comboBox2.SelectedIndex > -1 && isValid;

            isValid = !(textBox1.Text.Trim() == "") && isValid;

            return isValid;
        }
    }
}
