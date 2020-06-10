using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Cashier;
using CST.Models;
using CST.Reports;

namespace CST
{
    public partial class RemainingBalance : Form
    {
        OrController orcontroller = new OrController();
        loadingCashier loading = new loadingCashier();
        StudentsDetailsController studentsDetails = new StudentsDetailsController();
        StudentBalance studentBalance = new StudentBalance();
        string[] studentsDetailsArgs = { };
        string sno = "";
        double neededTopay = 0;

        public RemainingBalance()
        {
            InitializeComponent();
        
        }

        private void RemainingBalance_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment frm = new Payment();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(double.TryParse(textBox5.Text.ToString(), out _))
            {
                if (double.Parse(textBox5.Text.ToString()) >= neededTopay)
                {
                    if (neededTopay > 0)
                    {
                        backgroundWorker1.RunWorkerAsync();
                        loading.Show();
                        studentBalance.updateBalance(sno);
                        int orno = orcontroller.getRecentOr() + 1;

                        orcontroller.addOr(orno);
                        double change = double.Parse(textBox5.Text.ToString()) - neededTopay;
                        textBox4.Text = String.Format("PHP " + "{0:0.00}", change);
                        MessageBox.Show("Succesfully Pay the balance");

                        OrReport orep = new OrReport(neededTopay, sno, neededTopay+" PHP", "", neededTopay+" PHP", orno,0,0);
                        orep.ShowDialog();
                        clearData();
                    }
                    else
                    {

                        MessageBox.Show("There is no balance or no SNO Found");
                    }

                }
                else
                {
                    MessageBox.Show("The Payment should higher or equal than the downpayment");
                }
            }
            else
            {
                MessageBox.Show("Not A Number", "err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


          
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sno = "STUD-" + textBox1.Text.Trim();
            studentsDetailsArgs = studentsDetails.searchAllDetails2(sno);
            textBox2.Text = studentsDetailsArgs[1]+ " "  + studentsDetailsArgs[3]+ " " + studentsDetailsArgs[2];
            textBox3.Text = studentsDetailsArgs[12];
            studentBalance.fillDataGridBalance(ref dataGridView1, sno);
            neededTopay = studentBalance.getNeedToPay(sno);

            textBox6.Text = String.Format("PHP " + "{0:0.00}", neededTopay);
            if(textBox2.Text.Trim() == "")
            {
                MessageBox.Show("No Student Number found");
            }
        }

        private void clearData()
        {
            sno = "";
        
            neededTopay = 0;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            /*numericUpDown1.Value = 0;*/
            textBox6.Text = "";
            dataGridView1.DataSource = null;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789.";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loading.Hide();
        }
    }
}
