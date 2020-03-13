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
    public partial class RemainingBalance : Form
    {
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
          if(double.Parse(numericUpDown1.Value.ToString()) >= neededTopay)
            {
                if(neededTopay > 0)
                {
                    studentBalance.updateBalance(sno);
                    clearData();
                    double change = double.Parse(numericUpDown1.Value.ToString()) - neededTopay;
                    textBox4.Text = String.Format("PHP " + "{0:0.00}", change);
                    MessageBox.Show("Succesfully Pay the balance");
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

        private void button1_Click(object sender, EventArgs e)
        {
            sno = textBox1.Text.Trim();
            studentsDetailsArgs = studentsDetails.searchAllDetails(sno);
            textBox2.Text = studentsDetailsArgs[0]+ " "  + studentsDetailsArgs[2]+ " " + studentsDetailsArgs[1];
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
    }
}
