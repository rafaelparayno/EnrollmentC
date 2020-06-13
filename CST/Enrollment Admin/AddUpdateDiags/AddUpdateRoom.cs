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
                this.Hide();
            }
           
        }

        private void AddUpdateRoom_Load(object sender, EventArgs e)
        {
            roomtypeids = typeController.fillCombo(ref cbRoom);
         
        }

        private void txtRoomNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecteRoomTypeIds = int.Parse(roomtypeids[cbRoom.SelectedIndex]);
        }
    }
}
