using CST.Data;
using CST.Enrollment_Admin.AddUpdateDiags;
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

namespace CST.Enrollment_Admin
{
    public partial class Tfees : Form
    {
        TuitionFeeController tuitionFeeController = new TuitionFeeController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        public Tfees()
        {
            InitializeComponent();
        }

        private void Tfees_Load(object sender, EventArgs e)
        {
            label7.Hide();
            timer1.Start();

            foreach (string item in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(item);
            }
            refreshGrid();

            comboBox2.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SchoolFees frm = new SchoolFees();
            this.Hide();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dialogTuition frm = new dialogTuition();
            frm.ShowDialog();
            refreshGrid();
        }

        private void refreshGrid()
        {
            tuitionFeeController.fillAllTuition(ref dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
                return;

            dialogTuition frm = new dialogTuition(dataGridView2.SelectedRows[0].Cells[1].Value.ToString(),
                                                    dataGridView2.SelectedRows[0].Cells[3].Value.ToString(),
                                                    dataGridView2.SelectedRows[0].Cells[2].Value.ToString(),
                                                    int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
                                                    
            frm.ShowDialog();
            refreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "ALL")
            {
                refreshGrid();
            }
            else
            {
                tuitionFeeController.fillDataTuion2(ref dataGridView2, comboBox2.SelectedItem.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
                return;

            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                     "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                tuitionFeeController.removeTuition(int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show("Succesfully Remove Data");
                auditTrail.addAudit(label7.Text, "Remove Tuition Fee");
                refreshGrid();
            }
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
    }
}
