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
        TotalFeeController TotalFeeController = new TotalFeeController();
        StudentBalance studentBalance = new StudentBalance();
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        public Payment_Form(string snoo,string fn,string md,string gr, double ds)
        {
            InitializeComponent();
            sno = snoo;
            fullname = fn;
            mod = md;
            grade = gr;
            disc = ds;

            textBox1.Text = sno;
            textBox2.Text = fullname;
            textBox3.Text = grade;

            total = TotalFeeController.getTotal(mod, grade);
        
            if (mod == "Fullpayment")
            {
                label8.Text = "Fee";
                disc = disc / 100;
                totalDisc = total * disc;

                downPay = total - totalDisc;
              
            }
            else if (mod == "Semi-Annual")
            {
                label8.Text = "Downpayment";
                downPay = total /  2;
                label10.Visible = false;
                textBox10.Visible = false;

            }
            else if (mod == "Quarterly")
            {
                label8.Text = "Downpayment";
                downPay  = total / 4;
                label10.Visible = false;
                textBox10.Visible = false;
            }
            else
            {
                label8.Text = "Downpayment";
                downPay = 5500;
                label10.Visible = false;
                textBox10.Visible = false;
            }
            textBox8.Text = String.Format("PHP " + "{0:0.00}", downPay);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModeOfPaymentDiscount frm = new ModeOfPaymentDiscount();
            frm.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(double.Parse(numericUpDown1.Value.ToString()) >= downPay)
            {
                double balance = 0;
                double neededToPay = 0;
                double change = 0;
                //     studentBalance.addBalance(sno,)
                if (mod == "Fullpayment")
                {

                change = double.Parse(numericUpDown1.Value.ToString()) -downPay; 

                }
                else if (mod == "Semi-Annual")
                {

                     balance = total - double.Parse(numericUpDown1.Value.ToString());
                     neededToPay = balance;
                }
                else if (mod == "Quarterly")
                {
                     balance = total - double.Parse(numericUpDown1.Value.ToString());
                    neededToPay = balance / 3; 
                }
                else
                {
                     balance = total - double.Parse(numericUpDown1.Value.ToString());
                    neededToPay = balance / 10;
                }

                studentBalance.addBalance(sno, balance, mod, neededToPay);
                studentsDetailsController.updateEnrolled( sno);
                textBox10.Text = String.Format("PHP " + "{0:0.00}", change);
                MessageBox.Show("The student is Succesfully Enrolled");
                ModeOfPaymentDiscount frm = new ModeOfPaymentDiscount();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("The Payment should higher or equal than the downpayment");
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
    }
}
