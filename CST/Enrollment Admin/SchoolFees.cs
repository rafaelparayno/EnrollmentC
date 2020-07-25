using CST.Data;
using CST.Enrollment_Admin;
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

namespace CST
{
    
    public partial class SchoolFees : Form
    {
        YearController yrController = new YearController();
        MiscController miscController = new MiscController();
        TuitionFeeController tfController = new TuitionFeeController();
        public SchoolFees()
        {
            InitializeComponent();

            label6.Text = yrController.getSyActivated();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            EnrollmentAdmin frm = new EnrollmentAdmin();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tfees frm = new Tfees();
            frm.Show();
            this.Hide();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MiscFee frm = new MiscFee();
            frm.Show();
            this.Hide();


        }

        private void SchoolFees_Load(object sender, EventArgs e)
        {
            timer1.Start();
            foreach (string item in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(item);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

     

            label4.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool IsSearchable()
        {
            bool isValid = true;

            isValid = comboBox1.SelectedIndex > -1 && isValid;

            isValid = comboBox2.SelectedIndex > -1 && isValid;

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsSearchable())
            {
                
                if(comboBox1.SelectedItem.ToString() == "All")
                {
                    LoadGridMisc(comboBox2.SelectedItem.ToString());
                    LoadGridTuition(comboBox2.SelectedItem.ToString());
                    label3.Visible = false;
                }
                else
                {
                    LoadGridMisc(comboBox2.SelectedItem.ToString());
                    LoadGridTutioWithMode();
                    label3.Visible = true;

                    float tf = tfController.getTfPriceGrade(comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
                    float totalAMount = TotalMisc() + tf;

                    label3.Text = "TOTAL:  PHP " + totalAMount;
                }
              
            }
            else
            {
                MessageBox.Show("Please Pick Mode of payment and grade level");
            }
        }

        private void LoadGridMisc(string grade)
        {
            miscController.fillDataGridMisc(ref dataGridView1, grade);
        }

        private void LoadGridTuition(string grade)
        {
            tfController.fillDataTuion2(ref dataGridView2, grade);
        }

        private void LoadGridTutioWithMode()
        {
            tfController.fillDataTuition(ref dataGridView2,comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString());
        }

        private float TotalMisc()
        {
            float totalMisc = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                totalMisc += float.Parse(dr.Cells["price"].Value.ToString());
            }

            return totalMisc;
        }
    }
}
