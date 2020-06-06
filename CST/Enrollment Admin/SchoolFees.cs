using CST.Data;
using CST.Enrollment_Admin;
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
        public SchoolFees()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            
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
                

              
            }
            else
            {
                MessageBox.Show("Please Pick Mode of payment and grade level");
            }
        }
    }
}
