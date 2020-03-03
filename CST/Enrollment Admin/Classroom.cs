using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CST.Enrollment_Admin.AddUpdateDiags;
using CST.Models;
using MySql.Data.MySqlClient;


namespace CST
{
    public partial class Classroom : Form
    {

        YearController yr = new YearController();
        RoomController rm = new RoomController();
        private int syid = 0;
        public Classroom()
        {
            InitializeComponent();
        
        }

        private void Classroom_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = yr.getSyActivated();
            syid = yr.getSchoolYearId();

            refreshGrid();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtCapacity_ValueChanged(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Facilities fr3 = new Facilities();
            fr3.ShowDialog();
            return;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Facilities F = new Facilities();
            F.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddUpdateRoom frm = new AddUpdateRoom();
            frm.ShowDialog();
            refreshGrid();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                rm.removeRoom(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show("Succesfully Remove Room");
                refreshGrid();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void refreshGrid()
        {
            rm.fillDataGridRoom(ref dataGridView1, syid);
        }
    }
}
