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
using Org.BouncyCastle.Asn1.Cms;

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class addTimeStamp : Form
    {
        TimestampController timestampController = new TimestampController();
        public addTimeStamp()
        {
            InitializeComponent();
            time_start.ShowUpDown = true;
        }

        private void addTimeStamp_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

          

            time_end.Value = time_start.Value.AddMinutes(double.Parse(numericUpDown1.Value.ToString()));


        }

        private void time_start_DropDown(object sender, EventArgs e)
        {
            time_start.Value = time_start.Value.AddMinutes(10);
        }

        private void time_start_ValueChanged(object sender, EventArgs e)
        {
            time_end.Value = time_start.Value.AddMinutes(double.Parse(numericUpDown1.Value.ToString()));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timestampController.addTime(time_end.Value.ToString("HH:mm"), time_start.Value.ToString("HH:mm"));
            this.Hide();
          
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "";
            if (validKeys.IndexOf(e.KeyChar) < 0 )
            {
                e.Handled = true;
            }

        }
    }
}
