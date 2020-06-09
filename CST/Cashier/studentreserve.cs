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

namespace CST.Cashier
{
    public partial class studentreserve : Form
    {
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        StudentReserveController studentReserveController = new StudentReserveController();
        YearController YearController = new YearController();
        int syid = 0;
        public studentreserve()
        {
            InitializeComponent();
            syid = YearController.getSchoolYearId();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789.";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] details = studentsDetailsController.searchEnrollment(textBox1.Text.Trim(), syid);

            if (details[0] == "" || details[0] == null)
            {
                MessageBox.Show("No SNO exists or Student is already enrolled");
            }
            else
            {
                textBox2.Text = details[0] + " " + details[2] + " " + details[1];
                textBox3.Text = details[12];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(textBox4.Text.Trim(), out _))
            {
                
                double payment = double.Parse(textBox4.Text.Trim());
                if (payment >= 1000)
                {
                    studentReserveController.addReservation(payment, textBox1.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Minimum Payment should be 1000", "err", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }
            else
            {
                MessageBox.Show("Not A number", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //studentReserveController.addReservation(textbo)
        }
    }
}
