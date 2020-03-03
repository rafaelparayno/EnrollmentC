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
using CST.Models.SchoolYear;
using CST.Models;


namespace CST
{
    public partial class Login : Form

    {
      
        loginController control = new loginController();
        dbConnection dbConnection = new dbConnection();
        AuditTrailControl audittrail = new AuditTrailControl();
        YearController year = new YearController();
        string sy = "";

        bool isConnected;

        public Login()
        { 
            InitializeComponent();

           

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

                sy = year.getSyActivated();

                SchoolYearModel sc = new SchoolYearModel(sy);

                label6.Text = sy;
                label6.Visible = true;

            }

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
                    MessageBox.Show("incorrect username or password","Validation",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    audittrail.addAudit(label7.Text.Trim(), "User has been Login");

                    if (role == "System Admin")
                    {
                        Admin frm = new Admin();
                        frm.Show();
                        this.Hide();
                    }

                    else if (role == "Registrar")
                    {

                    }

                    else if (role == "Enrollment Admin")
                    {
                        EnrollmentAdmin frm = new EnrollmentAdmin();
                        frm.Show();
                        this.Hide();
                    }

                    else if (role == "Cashier")
                    {

                    }

                    else if (role == "Teacher")
                    {

                    }
                }
                

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



