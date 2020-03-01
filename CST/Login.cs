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
using CST.Models;
using CST.DbSettings;
using CST.DbSettings.UserLog;

namespace CST
{
    public partial class Login : Form

    {
        globalVariables gv = new globalVariables();
        crudFile cs = new crudFile();
        loginController control = new loginController();
        dbConnection dbConnection = new dbConnection();
        AuditTrailControl audittrail = new AuditTrailControl();

        bool isConnected;

        public Login(string a ,string b)
        { 
            InitializeComponent();

            a = txtUsername.Text;
            b = label7.Text;
            //globalVariables.myServer = globalVariables.IPv4_Address;
            //globalVariables.myDatabase = "final_enroll";
            //globalVariables.myUsername = "cst_db";
            //globalVariables.myPassword = "Sohhrs6d2F1PBOQR";

        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
                txtUN.Hide();
            txtUT.Hide();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            Console.WriteLine(mys);

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
            isConnected = dbConnection.EstablishConnection();


            if (isConnected)
            {
                label1.Text = "Connected";
                
            }

            //if (globalVariables.IPv4_Address != null)
            //{
            //    label1.Text = "Connected";
            //    if (label1.Text == "Connected")
            //    {

            //        label1.Text = "Connected";
            //        globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            //        gv.cn = new MySqlConnection(globalVariables.myConnection);

            //        gv.cn.Open();
            //        MySqlCommand command;
            //        MySqlDataReader mdr;

            //        string selectQuery = "  select * FROM school_year where sy_status='activate'";


            //        command = new MySqlCommand(selectQuery, gv.cn);

            //        mdr = command.ExecuteReader();
            //        int count = 0;
            //        string SY = string.Empty;

            //        string sy_status = string.Empty;

            //        while (mdr.Read())
            //        {
            //            count = count + 1;
            //            SY = mdr["school_year"].ToString();


            //            sy_status = mdr["sy_status"].ToString();

            //        }

            //        if (count == 1)
            //        {

            //            if (sy_status == "activate")
            //            {       //show admin windows

            //                label6.Text = SY;

            //            }
            //        }
            //        gv.cn.Close();


            //    }
            //}
            //else
            //{ }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label7_Click(object sender, EventArgs e)
        {

          
        }

        public void DateTicks_Tick(object sender, EventArgs e)
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



        private void btnLogin_Click(object sender, EventArgs e)

        {
            if (!isConnected)
            {
                label1.Text = "No Connection";
                MessageBox.Show("There is no connection to the database.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                IPConfigFormcs g = new IPConfigFormcs();
                g.ShowDialog();
            }
            else
            {
               string role = control.login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                


                if (role == "")
                {
                    MessageBox.Show("incorrect username or password");
                }
                else
                {
                    audittrail.addAudit(label7.Text.Trim(), "User has been Login");

                    if (role == "System Admin")
                    {
                        Admin frm = new Admin(UserLog.getUserName(), role);
                        frm.Show();
                        this.Hide();
                    }

                    else if (role == "Registrar")
                    {

                    }

                    else if (role == "Enrollment Admin")
                    {

                    }

                    else if (role == "Cashier")
                    {

                    }

                    else if (role == "Teacher")
                    {

                    }
                }
                


                // label1.Text = "Connected";
                //globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
                //gv.cn = new MySqlConnection(globalVariables.myConnection);
                //MySqlCommand command;
                //MySqlDataReader mdr;

                //gv.cn.Open();

                //string selectQuery = "SELECT * FROM useraccounts  WHERE  Binary Username = '" + txtUsername.Text + "' AND Binary password = '" + txtPassword.Text + "';";
                //command = new MySqlCommand(selectQuery, gv.cn);

                //mdr = command.ExecuteReader();
                //int count = 0;
                //string userRole = string.Empty;
                //string name = string.Empty;
                //string last = string.Empty;
                //string user = string.Empty;
                //string status = string.Empty;
                //while (mdr.Read())
                //{
                //    count = count + 1;
                //    userRole = mdr["Role"].ToString();
                //    name = mdr["firstname"].ToString();
                //    last = mdr["lastname"].ToString();
                //    status = mdr["status"].ToString();
                //    user = mdr["username"].ToString();

                //}

                //if (count == 1)
                //{
                //    if (status == "Online")
                //    {
                //        MessageBox.Show("This user is currently Online");


                //        return;
                //    }
                //    if (userRole == "System Admin")
                //    {       //show admin windows




                //        MessageBox.Show("Welcome " + name + " " + last, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //        this.Hide(); //UserAccount fr2 = new UserAccount();

                //        Admin frm = new Admin(user, userRole);
                //        frm.Show();


                //        gv.cn.Close();


                //        gv.cn.Open();
                //        string g = "User has been Login";
                //        string usr = name + " " + last;
                //        gv.cn.Close();
                //        gv.cn.Open();
                //        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                //        command.Parameters.AddWithValue("@Username", user);
                //        command.Parameters.AddWithValue("@Action", g);
                //        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                //        command.Parameters.AddWithValue("@user_type", userRole);
                //        command.Parameters.AddWithValue("@user", usr);


                //        command.ExecuteNonQuery();
                //        gv.cn.Close();
                //        gv.cn.Open();

                //        string m = "Online";
                //        MySqlCommand cmd = gv.cn.CreateCommand();

                //        cmd.CommandType = CommandType.Text;
                //        cmd.CommandText = "UPDATE useraccounts  set STATUS= '" + m + "'where username='" + txtUsername.Text + "'";
                //        cmd.ExecuteNonQuery();
                //        gv.cn.Close();
                //        return;



                //    }

                //    2
                //    else if (userRole == "Registrar")
                //    {       //show admin windows

                //        if (status == "Online")
                //        {
                //            MessageBox.Show("This user is currently Online");


                //            return;
                //        }


                //        MessageBox.Show("Welcome " + name + " " + last, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //        this.Hide(); //UserAccount fr2 = new UserAccount();


                //        RegistrarForm frm = new RegistrarForm(user, userRole);
                //        frm.Show();


                //        gv.cn.Close();
                //        gv.cn.Open();
                //        string g = "User has been Login";
                //        string usr = name + " " + last;
                //        gv.cn.Close();
                //        gv.cn.Open();
                //        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                //        command.Parameters.AddWithValue("@Username", user);
                //        command.Parameters.AddWithValue("@Action", g);
                //        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                //        command.Parameters.AddWithValue("@user_type", userRole);
                //        command.Parameters.AddWithValue("@user", usr);


                //        command.ExecuteNonQuery();
                //        gv.cn.Close();
                //        gv.cn.Open();

                //        string m = "Online";
                //        MySqlCommand cmd = gv.cn.CreateCommand();

                //        cmd.CommandType = CommandType.Text;
                //        cmd.CommandText = "UPDATE useraccounts  set STATUS= '" + m + "'where username='" + txtUsername.Text + "'";
                //        cmd.ExecuteNonQuery();
                //        gv.cn.Close();
                //        return;

                //    }


                //    3
                //    else if (userRole == "Enrollment Admin")
                //    {       //show admin windows

                //        if (status == "Online")
                //        {
                //            MessageBox.Show("This user is currently Online");


                //            return;
                //        }


                //        MessageBox.Show("Welcome " + name + " " + last, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //        this.Hide(); //UserAccount fr2 = new UserAccount();


                //        EnrollmentAdmin frm = new EnrollmentAdmin(user, userRole);
                //        frm.Show();


                //        gv.cn.Close();
                //        gv.cn.Open();
                //        string g = "User has been Login";
                //        string usr = name + " " + last;
                //        gv.cn.Close();
                //        gv.cn.Open();
                //        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                //        command.Parameters.AddWithValue("@Username", user);
                //        command.Parameters.AddWithValue("@Action", g);
                //        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                //        command.Parameters.AddWithValue("@user_type", userRole);
                //        command.Parameters.AddWithValue("@user", usr);


                //        command.ExecuteNonQuery();
                //        gv.cn.Close();
                //        gv.cn.Open();

                //        string m = "Online";
                //        MySqlCommand cmd = gv.cn.CreateCommand();

                //        cmd.CommandType = CommandType.Text;
                //        cmd.CommandText = "UPDATE useraccounts  set STATUS= '" + m + "'where username='" + txtUsername.Text + "'";
                //        cmd.ExecuteNonQuery();
                //        gv.cn.Close();
                //        return;

                //    }
                //    4
                //    else if (userRole == "Cashier")
                //    {
                //        if (status == "Online")
                //        {
                //            MessageBox.Show("This user is currently Online");


                //            return;
                //        }


                //        MessageBox.Show("Welcome " + name + " " + last, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //        this.Hide(); //UserAccount fr2 = new UserAccount();

                //        Cashier frm = new Cashier(user, userRole);
                //        frm.Show();


                //        gv.cn.Close();
                //        gv.cn.Open();
                //        string g = "User has been Login";

                //        string usr = name + " " + last;
                //        gv.cn.Close();
                //        gv.cn.Open();
                //        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                //        command.Parameters.AddWithValue("@Username", user);
                //        command.Parameters.AddWithValue("@Action", g);
                //        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                //        command.Parameters.AddWithValue("@user_type", userRole);
                //        command.Parameters.AddWithValue("@user", usr);


                //        command.ExecuteNonQuery();
                //        gv.cn.Close();
                //        gv.cn.Open();

                //        string m = "Online";
                //        MySqlCommand cmd = gv.cn.CreateCommand();

                //        cmd.CommandType = CommandType.Text;
                //        cmd.CommandText = "UPDATE useraccounts  set STATUS= '" + m + "'where username='" + txtUsername.Text + "'";
                //        cmd.ExecuteNonQuery();
                //        gv.cn.Close();
                //        return;
                //        5
                //    }
                //    else if (userRole == "Teacher")
                //    {
                //        if (status == "Online")
                //        {
                //            MessageBox.Show("This user is currently Online");


                //            return;
                //        }


                //        MessageBox.Show("Welcome " + name + " " + last, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                //        this.Hide(); //UserAccount fr2 = new UserAccount();

                //        Teacher frm = new Teacher(user, userRole);
                //        frm.Show();


                //        gv.cn.Close();
                //        gv.cn.Open();
                //        string g = "User has been Login";

                //        string usr = name + " " + last;
                //        gv.cn.Close();
                //        gv.cn.Open();
                //        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                //        command.Parameters.AddWithValue("@Username", user);
                //        command.Parameters.AddWithValue("@Action", g);
                //        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                //        command.Parameters.AddWithValue("@user_type", userRole);
                //        command.Parameters.AddWithValue("@user", usr);


                //        command.ExecuteNonQuery();
                //        gv.cn.Close();
                //        gv.cn.Open();

                //        string m = "Online";
                //        MySqlCommand cmd = gv.cn.CreateCommand();

                //        cmd.CommandType = CommandType.Text;
                //        cmd.CommandText = "UPDATE useraccounts  set STATUS= '" + m + "'where username='" + txtUsername.Text + "'";
                //        cmd.ExecuteNonQuery();
                //        gv.cn.Close();
                //        return;


                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Wrong Username or Password");

                //}

                //gv.cn.Close();

            }
           }
       



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {       // text null symbol only  prompt side 

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Please enter your Username");

                btnLogin.Enabled = false;

              
                 
            }


            else
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    btnLogin.Enabled = false;
                }
                else

                btnLogin.Enabled = true;
                errorProvider1.SetError(txtUsername, null);

                                return;

                            }


        }



        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // text null symbol only  prompt side 
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                 errorProvider1.SetError(txtPassword, "please enter your password");
         
                 btnLogin.Enabled = false;
                                        
                 
                    
                }
            
         
        

            else
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    btnLogin.Enabled = false;
                }
                else
               
                btnLogin.Enabled = true;
                errorProvider1.SetError(txtPassword, null);
            

                return;


            }
            





        }

        private void label6_Click(object sender, EventArgs e)
        {





         
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

           if( label1.Text == "No Connection")
            {
                this.Hide();
                IPConfigFormcs g = new IPConfigFormcs();
                   g.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
          
             if (e.KeyCode == Keys.F1)
            {
                /* Admin-S */
                txtUsername.Text = "kbadiana2416";
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "12345678";
            }
            else if (e.KeyCode == Keys.F2)
            {
                /* Admin-E */
                txtUsername.Text = "puy4120";
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "1234567";
            }
            else if (e.KeyCode == Keys.F3)
            {
                /* Registrar */
                txtUsername.Text = "mjadlocon6188";
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "12345678";
            }
            else if (e.KeyCode == Keys.F4)
            {
                /* Cashier */
                txtUsername.Text = "mdavalos4028";
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "431187";
            }

             else if (e.KeyCode == Keys.F5)
            {
                txtUsername.Text = "Syang0900";
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "123456";
            }
        //    else if (e.KeyCode == Keys.F6)
        //    {
        //        globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
        //        gv.cn = new MySqlConnection(globalVariables.myConnection);
        //        string m = "Offline";
        //        gv.cn.Open();
                
        //        try
        //        {
        //            MySqlCommand cmd = gv.cn.CreateCommand();

        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = "UPDATE useraccounts  set STATUS= '"+m+"'where username='" + txtUsername.Text + "'";
        //            cmd.ExecuteNonQuery();
        //            gv.cn.Close();
        //        }
        //        catch (Exception err)
        //        {
        //        MessageBox.Show("Can't update User's Status because there is no Username" + err.Message);
        //        }
        //}

    }

    private void pbMinimized_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
    }



