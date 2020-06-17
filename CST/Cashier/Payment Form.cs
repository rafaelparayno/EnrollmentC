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
    public partial class Payment_Form : Form
    {
        string sno = "";
        string fullname = "";
        string mod = "";
        string grade = "";
        double disc = 0;
        double totalDisc = 0;
        double total = 0;
        double downPay = 0;
        int orno = 0;
        double reservationFee = 0;
        bool isChange = false;

        loadingCashier loadingCashier = new loadingCashier();
     
        TuitionFeeController TuitionFeeController = new TuitionFeeController();

        MiscController miscController = new MiscController();
        StudentBalance studentBalance = new StudentBalance();
        OrController orController = new OrController();
        StudentEnrolledController StudentEnrolledController = new StudentEnrolledController();
        StudentReserveController studentReserveController = new StudentReserveController();
        public Payment_Form(string snoo,string fn,string md,string gr, double ds)
        {
            InitializeComponent();
            sno = snoo;
            fullname = fn;
            mod = md;
            grade = gr;
            disc = ds;
            timer1.Start();
            textBox1.Text = sno;
            textBox2.Text = fullname;
            textBox3.Text = grade;
            reservationFee = studentReserveController.getReservationFee(sno);

            textBox7.Text = mod;
            textBox5.Text = String.Format("PHP " + "{0:0.00}",
                                         TuitionFeeController.getTfPriceGrade(grade,mod));
            textBox6.Text = String.Format("PHP " + "{0:0.00}",
                                         miscController.getMiscFeeForGrade(grade));

            total = getTotalFee();
           
            label7.Text = "MISC:" + "\n" + miscController.getInfoMiscForGrade(grade);

            if (reservationFee != 0)
            {
                label7.Text = label7.Text + "\n" + "Reservation Fee : " + String.Format("PHP " + "{0:0.00}",
                                        reservationFee);
            }


            initPayment(mod);
            
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeOfPaymentDiscount frm = new ModeOfPaymentDiscount();
            frm.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double _;
            bool isValidNumber = double.TryParse(textBox4.Text.Trim(),out _);

            if (isValidNumber)
            {
                if(double.Parse(textBox4.Text.ToString())>= downPay)
                {
                    backgroundWorker1.RunWorkerAsync();
                    loadingCashier.Show();
                    double balance = 0;
                    double neededToPay = 0;
                    double change = 0;
                    double receivePayment = 0;
                    double forOrPay = 0;
                    switch (mod)
                    {
                        case "Fullpayment":
                            change = double.Parse(textBox4.Text.ToString()) - downPay;
                            receivePayment = downPay;
                            receivePayment += reservationFee;
                            break;
                        case "Semi-Annual":
                            if (isChange)
                            {
                                change  = double.Parse(textBox4.Text.ToString()) - downPay;
                                balance = total - downPay;
                                receivePayment = downPay + reservationFee;
                                balance -= reservationFee;
                                neededToPay = balance;

                            }
                            else
                            {
                                if(double.Parse(textBox4.Text.ToString()) > total)
                                {
                                    MessageBox.Show("Cannot be greather than the total payment");
                                    return;
                                }
                                else
                                {
                                    balance = total - double.Parse(textBox4.Text.ToString());
                                    receivePayment = double.Parse(textBox4.Text.ToString());
                                    receivePayment += reservationFee;
                                    neededToPay = balance;
                                    neededToPay = Math.Round((Double)neededToPay, 2);
                                }
                              
                            }
                            break;
                        case "Quarterly":
                            if (isChange)
                            {
                                change = double.Parse(textBox4.Text.ToString()) - downPay;

                                balance = total - downPay;
                                receivePayment = downPay + reservationFee;
                           
                                neededToPay = balance/3;
                                neededToPay = Math.Round((Double)neededToPay, 2);

                            }
                            else
                            {
                                if (double.Parse(textBox4.Text.ToString()) > total)
                                {
                                    MessageBox.Show("Cannot be greather than the total payment");
                                    return;
                                }
                                else
                                {
                                    balance = total - double.Parse(textBox4.Text.ToString());
                                    receivePayment = double.Parse(textBox4.Text.ToString());
                                    receivePayment += reservationFee;
                                    neededToPay = balance/3;
                                    neededToPay = Math.Round((Double)neededToPay, 2);
                                }

                            }
                          
                            break;
                        case "Monthly":
                            if (isChange)
                            {
                                change = double.Parse(textBox4.Text.ToString()) - downPay;

                                balance = total - downPay;
                                receivePayment = downPay + reservationFee;

                                neededToPay = balance / 9;
                                neededToPay = Math.Round((Double)neededToPay, 2);

                            }
                            else
                            {
                                if (double.Parse(textBox4.Text.ToString()) > total)
                                {
                                    MessageBox.Show("Cannot be greather than the total payment");
                                    return;
                                }
                                else
                                {
                                    balance = total - double.Parse(textBox4.Text.ToString());
                                    receivePayment = double.Parse(textBox4.Text.ToString());
                                    receivePayment += reservationFee;
                                    neededToPay = balance / 9;
                                    neededToPay = Math.Round((Double)neededToPay, 2);
                                }

                            }
                           
                            break;

                    }
                   studentBalance.addBalance(sno, balance, mod, neededToPay,receivePayment,totalDisc,receivePayment);

                    StudentEnrolledController.updateEnrolled(sno);
                    textBox10.Text = String.Format("PHP " + "{0:0.00}", change);
                    orno = orController.getRecentOr() + 1;
                    string ornumber = "OR#" + orno;
                    DateTime today = DateTime.Today;
                    forOrPay = receivePayment - reservationFee;
                    orController.addOr(ornumber, sno, forOrPay, today.ToString("dd/MM/yyyy"));
                    receivePayment -= reservationFee;
                    if (mod== "Fullpayment")
                    {
                        string totalPhp = "PHP " + downPay;
                      
                        OrReport frm2 = new OrReport(receivePayment, sno,
                                                    textBox5.Text, textBox6.Text,
                                                    totalPhp, orno,
                                                    totalDisc, reservationFee,"enrollment");
                        frm2.ShowDialog();
                    }
                    else
                    {
                        string totalPhp = "PHP " + receivePayment;
                        OrReport frm2 = new OrReport(receivePayment, sno,
                                                    totalPhp, "",
                                                    totalPhp, orno,
                                                    0,0, "enrollment");
                        frm2.ShowDialog();

                    }

                  
                }
                else
                {
                    MessageBox.Show("The Payment should higher or equal than the downpayment");
                }
            }
            else
            {
                MessageBox.Show("Not A number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

       

            label11.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }




        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789.";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private float getTotalFee()
        {
            float total = 0;
            float miscFee = 0;
            float tuition = 0;
            miscFee = miscController.getMiscFeeForGrade(grade);
            tuition = TuitionFeeController.getTfPriceGrade(grade, mod);

            total = tuition + miscFee;
            return total;
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
            loadingCashier.Hide();
            button3.Enabled = false;
            groupBox3.Enabled = false;
            MessageBox.Show("The student is Succesfully Enrolled");
            //frmload.Hide();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox10.Visible = true;
                label10.Visible = true;
                isChange = true;

            }
            else
            {
                textBox10.Visible = false;
                label10.Visible = false;
            }
        }

        private void initPayment(string mode)
        {
            if (mode == "Fullpayment")
            {
                label8.Text = "Fee";
                disc = disc / 100;
                totalDisc = TuitionFeeController.getTfPriceGrade(grade, mod) * disc;

                downPay = total - totalDisc;
                label7.Text = label7.Text + "\n" + "Discount : " + String.Format("PHP " + "{0:0.00}",
                                        totalDisc) + " - " + disc + "%";
                groupBox3.Visible = false;
                radioButton1.Checked = true;

            }
            else if (mode == "Semi-Annual")
            {
                label8.Text = "Downpayment";
                downPay = total / 2;
                label10.Visible = false;
                textBox10.Visible = false;
                radioButton2.Checked = true;

            }
            else if (mode == "Quarterly")
            {
                label8.Text = "Downpayment";
                downPay = total / 4;
                label10.Visible = false;
                textBox10.Visible = false;
                radioButton2.Checked = true;
            }
            else
            {
                label8.Text = "Downpayment";
                downPay = 5500;
                label10.Visible = false;
                textBox10.Visible = false;
                radioButton2.Checked = true;
            }
            downPay -= reservationFee;
            total -= reservationFee;
            textBox8.Text = String.Format("PHP " + "{0:0.00}", downPay);
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox10.Visible = false;
                label10.Visible = false;
                isChange = false;
            }
            else
            {
                textBox10.Visible = true;
                label10.Visible = true;
            }
        }
    }
}
