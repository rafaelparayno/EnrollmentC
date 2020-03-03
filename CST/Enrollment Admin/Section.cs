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
using CST.Models;
using CST.Models.SchoolYear;
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class Section : Form
    {

        SectionController sectionController = new SectionController();
        public Section()
        {
            InitializeComponent();

            timer1.Start();
            label7.Text = SchoolYearModel.getSchoolYear();
         
        }

        private void Section_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Facilities F = new Facilities();
            F.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();

            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void refreshGrid()
        {
            sectionController.fillDataGridSect(ref dataGridView1);
        }
    }
}
