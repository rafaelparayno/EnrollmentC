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
    public partial class SubjectType : Form
    {
        SubjectTypeController subjectTypeController = new SubjectTypeController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        public SubjectType()
        {
            InitializeComponent();
        }

        private void SubjectType_Load(object sender, EventArgs e)
        {
            fillGrid();
            label7.Hide();
            timer1.Start();

        }

        private void fillGrid()
        {
            subjectTypeController.fillDataGridSubType(ref dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddUpdateSubjectType frm = new AddUpdateSubjectType();

            frm.ShowDialog();
            fillGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                AddUpdateSubjectType frm = new AddUpdateSubjectType(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                                                                        dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

                frm.ShowDialog();
                fillGrid();
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
                    subjectTypeController.removeSubjectType(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show("Succesfully Remove Data");
                    auditTrail.addAudit(label7.Text, "Remove Subject Type");
                }

                //frm.ShowDialog();
                fillGrid();
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Facilities frm = new Facilities();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }
    }
}
