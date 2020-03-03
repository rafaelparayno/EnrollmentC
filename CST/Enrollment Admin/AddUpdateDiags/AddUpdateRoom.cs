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
        public AddUpdateRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            room.addRoom(cbRoom.SelectedItem.ToString(), int.Parse(txtRoomNo.Value.ToString()));
            this.Hide();
        }

        private void AddUpdateRoom_Load(object sender, EventArgs e)
        {
            cbRoom.SelectedIndex = 0;
        }
    }
}
