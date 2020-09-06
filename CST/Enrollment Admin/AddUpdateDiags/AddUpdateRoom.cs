using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class AddUpdateRoom : Form
    {
        RoomController room = new RoomController();
        RoomTypeController typeController = new RoomTypeController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        string[] roomtypeids;
        int selecteRoomTypeIds = 0;
        public AddUpdateRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbRoom.SelectedIndex > -1)
            {
                room.addRoom(selecteRoomTypeIds, int.Parse(txtRoomNo.Value.ToString()));
                auditTrail.addAudit(label5.Text, "Added Room Number");

                this.Hide();
            }
           
        }

        private void AddUpdateRoom_Load(object sender, EventArgs e)
        {
            label5.Hide();
            timer1.Start();
            roomtypeids = typeController.fillCombo(ref cbRoom);
         
        }

        private void txtRoomNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecteRoomTypeIds = int.Parse(roomtypeids[cbRoom.SelectedIndex]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label5.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
