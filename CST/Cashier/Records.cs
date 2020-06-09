using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Cashier;
using CST.Models;
using CST.Reports;

namespace CST
{
    public partial class Records : Form
    {
        StudentBalance studentBalance = new StudentBalance();
        public Records()
        {
            InitializeComponent();
            studentBalance.fillDataGridTotal(ref dataGridView1);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashierDashboard c = new CashierDashboard();
      //      Cashier C = new Cashier();
            c.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
           // RemainingBalance fr7 = new RemainingBalance(label5.Text, label3.Text, label6.Text,label9.Text);
         //   fr7.ShowDialog();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            label3.Hide();
            //label9.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataSet ds = new DataSet();

                DataTable dt = new DataTable();
                dt.Columns.Add("Student Number", typeof(string));
                dt.Columns.Add("Student Name", typeof(string));
                dt.Columns.Add("Total Payment", typeof(string));
                dt.Columns.Add("Remaining Balance", typeof(string));
                dt.Columns.Add("Mode of Payment", typeof(string));


                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);

                }


                ds.Tables.Add(dt);
             
                AccountRecordRep rep = new AccountRecordRep(ds);
                rep.ShowDialog();

              
            }
        }
    }
}
