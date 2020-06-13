using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CST.Models;
using MySql.Data.MySqlClient;
using CST.Enrollment_Admin.AddUpdateDiags;

namespace CST
{
    public partial class Subject : Form
    {

        SubjectController SubjectController = new SubjectController();
        YearController YearController = new YearController();
        public Subject(string a, string b, string c)
        {
            InitializeComponent();
            timer1.Start();
            label5.Text = YearController.getSyActivated();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();

            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

      

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Facilities fr3 = new Facilities();
            fr3.ShowDialog();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdateSubject frm = new AddUpdateSubject();
            frm.ShowDialog();
            refreshGrid();
        }

        private void refreshGrid()
        {
            SubjectController.fillDataGridSub(ref dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count> 0)
            {
                AddUpdateSubject frm = new AddUpdateSubject(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                        dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                        int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                frm.ShowDialog();
                refreshGrid();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


                if (form1 == DialogResult.Yes)
                {
                    SubjectController.removeSubjects(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));

                    MessageBox.Show("Succesfully Remove Selected Subject");
                    refreshGrid();
                }
            }
        }
    }
}
