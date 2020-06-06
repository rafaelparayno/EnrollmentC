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
            this.Hide();
        }
        

        
    }
}
