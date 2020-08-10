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

namespace CST.Enrollment_Admin.DialogsSched
{
    public partial class AssignRoom : Form
    {
        RoomController roomController = new RoomController();
        string[] r_ids = { };
        public string selectedRoomid = "";
        public int selectedRoomId2 = 0;
        int[] roomIds = { };
        public string roomName = "";

        public AssignRoom(string te, string ts)
        {
            InitializeComponent();
            //   r_ids = roomController.fillClassRoomAvail(ref comboBox1, te, ts);
            DateTime timestart = DateTime.Parse(ts);
            DateTime timeEnd = DateTime.Parse(te);
            string teFormat = timeEnd.ToString("HH:mm:ss");
            string tsFormat = timestart.ToString("HH:mm:ss");

            roomIds = roomController.fillRoomAvail(ref comboBox1, teFormat, tsFormat);
        }

        private void AssignRoom_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > -1)
            {
                roomName = comboBox1.Text;
             //   selectedRoomid = r_ids[comboBox1.SelectedIndex];
                selectedRoomId2 = roomIds[comboBox1.SelectedIndex];
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Pick a Room");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedRoomId2 = 0;
            this.Hide();
        }
    }
}
