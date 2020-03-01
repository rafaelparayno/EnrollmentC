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
    public partial class GradeLevel : Form
    {
        globalVariables gv = new globalVariables();
        public GradeLevel(string a, string b, string c)
        {
            InitializeComponent();
            this.label3.Text = a;
            this.label2.Text = b;
            this.label4.Text = c;
            globalVariables.myServer = globalVariables.IPv4_Address;
            globalVariables.myDatabase = "final_enroll";
            globalVariables.myUsername = "cst_db";
            globalVariables.myPassword = "Sohhrs6d2F1PBOQR";
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand();

            MySqlDataAdapter da = new MySqlDataAdapter();

            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);
            gv.cn.Open();
            cmd = new MySqlCommand("Insert into grade_level(Grade_type,grade_level,SY) VALUES(@Grade_type,@grade_level,@SY)", gv.cn);

            //string m = "offfline";
            //cmd.Parameters.AddWithValue("@status", m);
            cmd.Parameters.AddWithValue("@Grade_type", cbGradeLevel.Text);
            cmd.Parameters.AddWithValue("@grade_level", gradelevelno.Text);
            cmd.Parameters.AddWithValue("@SY", label4.Text);

            cmd.ExecuteNonQuery();



            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `Grade_level` ORDER BY `Grade_type` ASC", gv.cn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
            dataGridView1.DisplayedRowCount(true);

            MessageBox.Show(" Add level Success");

            // globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            //gv.cn = new MySqlConnection(globalVariables.myConnection);
            MySqlCommand command;
            MySqlDataReader mdr;

            //gv.cn.
            string selectQuery = "SELECT * FROM useraccounts  WHERE  Binary Username = '" + label3.Text + "';";
            command = new MySqlCommand(selectQuery, gv.cn);

            mdr = command.ExecuteReader();
            int count = 0;
            string userRole = string.Empty;
            string name = string.Empty;
            string last = string.Empty;
            string user = string.Empty;

            while (mdr.Read())
            {
                count = count + 1;
                userRole = mdr["Role"].ToString();
                name = mdr["firstname"].ToString();
                last = mdr["lastname"].ToString();

                user = mdr["username"].ToString();

            }

            if (count == 1)
            {

                if (label3.Text == user)
                {

                    gv.cn.Close();
                    gv.cn.Open();
                    string g = "User successfully added " + cbGradeLevel.Text + " " + gradelevelno.Text;
                    string usr = name + " " + last;

                    command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                    command.Parameters.AddWithValue("@Username", user);
                    command.Parameters.AddWithValue("@Action", g);
                    command.Parameters.AddWithValue("@Date_Time", label7.Text);
                    command.Parameters.AddWithValue("@user_type", userRole);
                    command.Parameters.AddWithValue("@user", usr);


                    command.ExecuteNonQuery();

                }

            }
            gv.cn.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Facilities fr3 = new Facilities(label3.Text, label2.Text, label4.Text);
            fr3.ShowDialog();
            return;

        }

        private void GradeLevel_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label2.Hide();
            label4.Hide();
            label7.Hide();
            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);
            gv.cn.Open();

            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `grade_level` ", gv.cn);
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

        private void txtGradeLevelNo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Facilities fr3 = new Facilities(label3.Text, label2.Text, label4.Text);
            fr3.ShowDialog();
            return;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();

            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
