using CST.Models;
using CST.Reports;
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
        OrController orController = new OrController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        bool isValid = false;
        string sno = "";
        int orno = 0;
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
            string[] details = studentsDetailsController.searchEnrollment( "STUD-" +textBox1.Text.Trim(), syid);

            if (details[0] == "" || details[0] == null)
            {
                MessageBox.Show("No SNO exists or Student is already enrolled");
                sno = "";
            }
            else
            {
                textBox2.Text = details[0] + " " + details[2] + " " + details[1];
                textBox3.Text = details[12];
                sno = "STUD-" + textBox1.Text.Trim();
                isValid = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double _;
            if(double.TryParse(textBox4.Text.Trim(), out _))
            {
               
                double payment = double.Parse(textBox4.Text.Trim());
                if (payment >= 1000)
                {
                    if (isValid)
                    {
                        studentReserveController.addReservation(payment,sno);
                        orno = orController.getRecentOr() + 1;
                        string ornumber = "OR#" + orno;
                        DateTime today = DateTime.Today;
                    
                        orController.addOr(ornumber, sno, payment, today.ToString("dd/MM/yyyy"));

                        string totalPhp = "PHP " + payment;

                        OrReport frm2 = new OrReport(payment, sno,
                                                    totalPhp, "",
                                                    totalPhp, orno,
                                                    0, 0, "reservation");
                        frm2.ShowDialog();

                        textBox1.Text = "";
                        sno = "";
                        auditTrail.addAudit(label11.Text, textBox2.Text.Trim() + " Paid Reservation");
                    }
                    else
                    {
                        MessageBox.Show("Please Search A Valid Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void studentreserve_Load(object sender, EventArgs e)
        {
            label11.Hide();
            timer1.Start();

        }
    }
}
