using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class BackupAndRestore : Form
    {
        globalVariables gv = new globalVariables(); 
        public BackupAndRestore(string MyLabelText, string hi)
        {
            InitializeComponent();
            txtUN.Text = MyLabelText;
            txtUT.Text = hi;
            globalVariables.myServer = globalVariables.IPv4_Address;
            globalVariables.myDatabase = "final_enroll";
            globalVariables.myUsername = "cst_db";
            globalVariables.myPassword = "Sohhrs6d2F1PBOQR";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to back up data?",
                  "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
                
            {
            //    globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            //    gv.cn = new MySqlConnection(globalVariables.myConnection);

                
            //    string file = @"C:\Users\User\Desktop\back-up";
            //using (MySqlConnection conn = new MySqlConnection(globalVariables.myConnection))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand())
            //    {
            //        using (MySqlBackup mb = new MySqlBackup(cmd))
            //        {
            //            cmd.Connection = conn;  
            //            conn.Open();
            //            mb.ExportToFile(file);
            //            conn.Close();
            //        }
            //    }
            //}




                MessageBox.Show("Back Up Data Success");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to restore data?",
                  "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                MessageBox.Show("Restore Data  Success");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();
        }

        private void BackupAndRestore_Load(object sender, EventArgs e)
        {
            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);

            gv.cn.Open();
            MySqlCommand command;
            MySqlDataReader mdr;

            string selectQuery = "  select * FROM school_year where sy_status='activate'";


            command = new MySqlCommand(selectQuery, gv.cn);

            mdr = command.ExecuteReader();
            int count = 0;
            string SY = string.Empty;
            string sy_status = string.Empty;

            while (mdr.Read())
            {
                count = count + 1;
                SY = mdr["school_year"].ToString();
                sy_status = mdr["sy_status"].ToString();

            }

            if (count == 1)
            {

                if (sy_status == "activate")
                {       //show admin windows

                    label2.Text = SY;

                }
            }
            gv.cn.Close();
            txtUN.Hide();
            txtUT.Hide();
            label2.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void txtUT_Click(object sender, EventArgs e)
        {

        }

        private void txtUN_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
