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

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class AddUpdaateRoomType : Form
    {
        RoomTypeController typeController = new RoomTypeController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        public AddUpdaateRoomType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                return;
            }

            typeController.addRoomType(textBox1.Text.Trim());
            auditTrail.addAudit(label1.Text, "Added Room Type");
            this.Hide();
        }

        private void AddUpdaateRoomType_Load(object sender, EventArgs e)
        {
            label1.Hide();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label1.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;
        }
    }
}
