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
using CST.Enrollment_Admin.AddUpdateDiags;

namespace CST
{
    public partial class AddTuitionFee : Form
    {

        TuitionFeeController tfcontrol = new TuitionFeeController();
        MiscController miscController = new MiscController();
        TotalFeeController totalFeeController = new TotalFeeController();
        private double totalFee = 0;
        string[] grades = { };
        public AddTuitionFee()
        {
            InitializeComponent();
            timer1.Start();
         
        }


        private void button5_Click(object sender, EventArgs e)
        {
            /*   this.Hide();
               SchoolFees fr3 = new SchoolFees();
               fr3.ShowDialog();
               return;*/
            EnrollmentAdmin frm = new EnrollmentAdmin();
            frm.Show();

            this.Hide();

        }

        private void AddTuitionFee_Load(object sender, EventArgs e)
        {
            foreach(string item in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(item);
            }
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            totalFee = 0;
            bool isSearch = IsSearchable();

            if (isSearch)
            {
                tfcontrol.fillDataTuition(ref dataGridView2, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                miscController.fillDataGridMisc(ref dataGridView1, comboBox2.SelectedItem.ToString());

                if (dataGridView2.Rows.Count > 0 && dataGridView1.Rows.Count > 0)
                {
                    button9.Enabled = true;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        totalFee += double.Parse(row.Cells["price"].Value.ToString());
                        //More code here


                    }

                    double tuitionFee = double.Parse(dataGridView2.Rows[0].Cells["tuition_fee"].Value.ToString());
                    totalFee += tuitionFee;
                    label3.Text = "Total Fee: " + totalFee;
                }
                else
                {
                    button9.Enabled = false;
                    label3.Text = "Total Fee: ";
                }
            }
            else
            {
                MessageBox.Show("Please Pick Mode of payment and grade level");
            }
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label5.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dialogTuition dialog = new dialogTuition();
            dialog.ShowDialog();
            totalFee = 0;
            button2.PerformClick();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            diagMisc frm = new diagMisc();
            frm.ShowDialog();
            totalFee = 0;
            button2.PerformClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            totalFeeController.addTotalFee(totalFee, int.Parse(dataGridView2.Rows[0].Cells["tf_id"].Value.ToString()));
            MessageBox.Show("Succesfully Saved Total Fee");
         
            EnrollmentAdmin frm = new EnrollmentAdmin();
            frm.Show();
            this.Hide();
        }

        private bool IsSearchable()
        {
            bool isValid = true;

            isValid = comboBox1.SelectedIndex > -1 && isValid;

            isValid = comboBox2.SelectedIndex > -1 && isValid;

            return isValid;
        }
    }
}
