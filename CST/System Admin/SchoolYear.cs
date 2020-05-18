using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CST.Models;
using CST.Models.SchoolYear;

namespace CST
{

    public partial class SchoolYear : Form
    {
        YearController yearC = new YearController();
        public SchoolYear()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void SchoolYear_Load(object sender, EventArgs e)
        {
            yearC.fillDataGridSY(ref dgSY);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4)
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            yearC.updateSY(int.Parse(dgSY.SelectedRows[0].Cells[0].Value.ToString()));
            yearC.fillDataGridSY(ref dgSY);
            SchoolYearModel.setSchoolYear(dgSY.SelectedRows[0].Cells[1].Value.ToString());
            MessageBox.Show("Succesfully Updated School Year");
        }

        private void button2_Click(object sender, EventArgs e)


        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 4)
            {
                textBox1.Enabled = true;

            }
            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

       

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int yearSelect = int.Parse(dateTimePicker1.Value.ToString("yyyy"));

            if (yearC.addNewSy(yearSelect.ToString(), textBox1.Text.Trim()))
            {
                MessageBox.Show("Succesfully Added A new School Year");
            }
            
            yearC.fillDataGridSY(ref dgSY);
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int yearSelect = int.Parse(dateTimePicker1.Value.ToString("yyyy"));
            int toyear = yearSelect+ 1;

            textBox1.Text = toyear + "";
            
        }
    }
}