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

namespace  CST 
{
    public partial class RegistrarForm : Form
    {
        globalVariables gv = new globalVariables();
        public RegistrarForm(string MyLabelText, string hi)
        {
            InitializeComponent();
            this.label5.Text = MyLabelText;
            this.label1.Text = hi;
           
            globalVariables.myServer = globalVariables.IPv4_Address;
            globalVariables.myDatabase = "final_enroll";
            globalVariables.myUsername = "cst_db";
            globalVariables.myPassword = "Sohhrs6d2F1PBOQR";

        }

        private void RegistrarForm_Load(object sender, EventArgs e)
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

                    label6.Text = SY;

                }
            }
            gv.cn.Close();

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Enrollment Enroll = new Enrollment(label5.Text,label1.Text,label6.Text);
            Enroll.Show();
            this.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                               "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
                gv.cn = new MySqlConnection(globalVariables.myConnection);

                MySqlCommand command;
                MySqlDataReader mdr;
                gv.cn.Open();

                string selectQuery = "SELECT * FROM useraccounts WHERE Username = '" + label5.Text + "';";
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

                    if (user == label5.Text)
                    {       //show admin wiNDOWS    
                        gv.cn.Close();
                        gv.cn.Open();
                        string g = "User has been Logout";
                        string usr = name + " " + last;
                        gv.cn.Close();
                        gv.cn.Open();
                        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                        command.Parameters.AddWithValue("@Username", user);
                        command.Parameters.AddWithValue("@Action", g);
                        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                        command.Parameters.AddWithValue("@user_type", userRole);
                        command.Parameters.AddWithValue("@user", usr);


                        command.ExecuteNonQuery();
                        gv.cn.Close();
                        gv.cn.Open();
                        string m = "Offline";
                        MySqlCommand cmd = gv.cn.CreateCommand();

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE useraccounts  set STATUS= '" + m + "'where username='" + label5.Text + "'";
                        cmd.ExecuteNonQuery();
                        gv.cn.Close();

                        this.Hide();
                        Login ne2 = new Login(label5.Text, label1.Text);
                        ne2.ShowDialog();

                        return;


                    }
                }
                gv.cn.Close();
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarRecord RR = new RegistrarRecord(label5.Text, label1.Text, label6.Text);
            RR.Show();
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
    }
}
