﻿using CST.Enrollment_Admin.AddUpdateDiags;
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
        public RoomType()
        {
            InitializeComponent();
        }

        private void RoomType_Load(object sender, EventArgs e)
        {
            fillRefreshGrid();
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

            DialogResult form1 = MessageBox.Show("Do you really want to Remove? ALL Related Data will Also be Deleted",
                   "Exit", MessageBoxButtons.YesNo);

            if(form1 == DialogResult.Yes)
            {
                typeController.RemoveRoomType(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show("Data Deleted");
                fillRefreshGrid();
            }
        }
    }
}
