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
    public partial class RoomType : Form
    {
        RoomTypeController typeController = new RoomTypeController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        public RoomType()
        {
            InitializeComponent();
        }

        private void RoomType_Load(object sender, EventArgs e)
        {
            fillRefreshGrid();
            label7.Hide();
            timer1.Start();

        }

        private void fillRefreshGrid()
        {
            typeController.fillDataGridRoom(ref dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdaateRoomType frm = new AddUpdaateRoomType();
            frm.ShowDialog();
            fillRefreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facilities frm = new Facilities();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult form1 = MessageBox.Show("Do you really want to Remove? ALL Related Data will Also be Deleted",
                   "Exit", MessageBoxButtons.YesNo);

                if (form1 == DialogResult.Yes)
                {
                    typeController.RemoveRoomType(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show("Data Deleted");
                    auditTrail.addAudit(label7.Text, "Remove Room Type");
                    fillRefreshGrid();
                }
            }
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
