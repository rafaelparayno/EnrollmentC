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
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class Subject : Form
    {
        globalVariables gv = new globalVariables();
        public Subject(string a, string b, string c)
        {
            InitializeComponent();
            this.label4.Text = a;
            this.label3.Text = b;
            this.label5.Text = c;
            globalVariables.myServer = globalVariables.IPv4_Address;
            globalVariables.myDatabase = "final_enroll";
            globalVariables.myUsername = "cst_db";
            globalVariables.myPassword = "Sohhrs6d2F1PBOQR";
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label5.Hide();
            label4.Hide();
            label7.Hide();
            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);
            gv.cn.Open();

            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `subjects` ", gv.cn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            dataGridView1.DisplayedRowCount(true);
            gv.cn.Close();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();

            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Facilities fr3 = new Facilities();
            fr3.ShowDialog();
            return;
        }
    }
}
