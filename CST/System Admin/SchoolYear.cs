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

    public partial class SchoolYear : Form
    {
        globalVariables gv = new globalVariables();
        int i;
        public SchoolYear(string MyLabelText, string hi)
        {
            InitializeComponent();

            txtUN.Text = MyLabelText;
            txtUT.Text = hi;
            label4.Text = "";

            globalVariables.myServer = globalVariables.IPv4_Address;
            globalVariables.myDatabase = "final_enroll";
            globalVariables.myUsername = "cst_db";
            globalVariables.myPassword = "Sohhrs6d2F1PBOQR";
        }

        private void SchoolYear_Load(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;

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

                    label4.Text = SY;

                }
            }
            gv.cn.Close();
            txtUN.Hide();
            txtUT.Hide();
            label4.Hide();
            txtSY.Hide();
            label7.Hide();
            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);

            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `school_year` ", gv.cn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            dgSY.DataSource = dtbl;
            dgSY.DisplayedRowCount(true);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSY.Text = i.ToString() + "-" + textBox1.Text;
            string sy = "activate";
            string dsy = "deactivate";
          
            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);
            gv.cn.Open();
            MySqlCommand command2;
            MySqlDataReader mdr1;
            string selectQuery = "SELECT school_year FROM school_year";
            command2 = new MySqlCommand(selectQuery, gv.cn);

            mdr1 = command2.ExecuteReader();
            int count = 0;
            string SY = string.Empty;


            while (mdr1.Read())
            {
                count = 1;
                SY = mdr1["school_year"].ToString();
            }
            if (count == 1)
            {
                if (txtSY.Text == SY)
                {
                    gv.cn.Close();
                    MessageBox.Show("The school year you enter is already exist");
                }

                else
                {

                    gv.cn.Close();
                    gv.cn.Open();
                    MySqlCommand cmd = gv.cn.CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE school_year  set sy_status= '" + dsy + "'where sy_status='" + sy + "'";
                    cmd.ExecuteNonQuery();
                    gv.cn.Close();
                    gv.cn.Open();
                    MySqlCommand command;
                    MySqlCommand command1;
                    MySqlDataReader mdr;
                    command1 = new MySqlCommand("INSERT INTO `school_year`( `school_year`, `sy_status`) VALUES (@school_year,@sy_status)", gv.cn);
                    command1.Parameters.AddWithValue("@school_year", txtSY.Text);
                    command1.Parameters.AddWithValue("@sy_status", sy);
                    command1.ExecuteNonQuery();
                    gv.cn.Close();
                    gv.cn.Open();
                    string selectQuery1 = "SELECT * FROM useraccounts  WHERE Username = '" + txtUN.Text + "'";
                    command = new MySqlCommand(selectQuery1, gv.cn);

                    mdr = command.ExecuteReader();
                    int count1 = 0;
                    string userRole = string.Empty;
                    string name = string.Empty;
                    string last = string.Empty;
                    string user = string.Empty;

                    while (mdr.Read())
                    {
                        count1 = 1;
                        userRole = mdr["Role"].ToString();
                        name = mdr["firstname"].ToString();
                        last = mdr["lastname"].ToString();

                        user = mdr["username"].ToString();

                    }

                    if (count1 == 1)
                    {

                        if (txtUN.Text == user)
                        {

                            gv.cn.Close();
                            gv.cn.Open();
                            string g = "User successfully activate school year " + txtSY.Text;
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
                    MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `school_year` ", gv.cn);
                    DataTable dtbl = new DataTable();
                    sqlda.Fill(dtbl);

                    dgSY.DataSource = dtbl;
                    dgSY.DisplayedRowCount(true);
                    MessageBox.Show("Activation Success");
                }

            }
            gv.cn.Close();
        

                /* DialogResult form1 = MessageBox.Show("Activate this Year?",
                                   "Exit", MessageBoxButtons.YesNo);
                 if (form1 == DialogResult.Yes)
                 {
                     txtSY.Text = i.ToString() + "-" + textBox1.Text;
                     string sy = "activate";
                     MessageBox.Show("Activate Success");
                     globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
                     gv.cn = new MySqlConnection(globalVariables.myConnection);
                     gv.cn.Open();
                     MySqlCommand command2;
                     MySqlDataReader mdr1;
                     string selectQuery = "SELECT sy_status FROM school_year";
                     command2 = new MySqlCommand(selectQuery, gv.cn);

                     mdr1 = command2.ExecuteReader();
                     int count = 0;
                     string SY = string.Empty;


                     while (mdr1.Read())
                     {
                         count = count + 1;
                         SY = mdr1["sy_status"].ToString();
                     }
                     if (count == 1)
                     {
                         if (txtSY.Text == SY)
                         {
                             gv.cn.Close();
                             MessageBox.Show("The school year you enter is already exist");
                         }
                         else
                         {
                             gv.cn.Close();
                             gv.cn.Open();
                             string m = "deactivate";
                             string status = "activate";
                             MySqlCommand cmd = gv.cn.CreateCommand();

                             cmd.CommandType = CommandType.Text;
                             cmd.CommandText = "UPDATE school_year  set sy_status= '" + m + "'where sy_status='" + status + "'";
                             cmd.ExecuteNonQuery();
                             gv.cn.Close();
                             gv.cn.Open();
                             MySqlCommand command;
                             MySqlCommand command1;
                             MySqlDataReader mdr;
                             command1 = new MySqlCommand("INSERT INTO `school_year`( `school_years`, `sy_status`) VALUES (@school_year,@sy_status)", gv.cn);
                             command1.Parameters.AddWithValue("@school_year", txtSY.Text);
                             command1.Parameters.AddWithValue("@sy_status", sy);
                             command1.ExecuteNonQuery();
                             gv.cn.Close();
                             gv.cn.Open();
                             string selectQuery1 = "SELECT * FROM useraccounts  WHERE Username = '" + txtUN.Text + "'";
                             command = new MySqlCommand(selectQuery1, gv.cn);

                             mdr = command.ExecuteReader();
                             int count1 = 0;
                             string userRole = string.Empty;
                             string name = string.Empty;
                             string last = string.Empty;
                             string user = string.Empty;

                             while (mdr.Read())
                             {
                                 count1 = count + 1;
                                 userRole = mdr["Role"].ToString();
                                 name = mdr["firstname"].ToString();
                                 last = mdr["lastname"].ToString();

                                 user = mdr["username"].ToString();

                             }

                             if (count1 == 1)
                             {

                                 if (txtUN.Text == user)
                                 {

                                     gv.cn.Close();
                                     gv.cn.Open();
                                     string g = "User successfully activate school year " + txtSY.Text;
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
                         }

                     }
                     gv.cn.Close();
                 }

                 */

            }

        private void button2_Click(object sender, EventArgs e)


        {
            this.Hide();
            Admin frm = new Admin(txtUN.Text, txtUT.Text);
            frm.Show();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = "";
            }



           
            if (int.TryParse(textBox2.Text, out i))
            {
                textBox1.Text = (i + 1).ToString();
            }
    
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
    }
}