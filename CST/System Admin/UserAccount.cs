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
    public partial class UserAccount : Form
    {
        globalVariables gv = new globalVariables();
        
        public UserAccount(string MyLabelText, string hi)
        {
            InitializeComponent();
            txtUN.Text = MyLabelText;
            txtUT.Text = hi;
           
            //globalVariables.myServer = globalVariables.IPv4_Address;
            //globalVariables.myDatabase = "final_enroll";
            //globalVariables.myUsername = "cst_db";
            //globalVariables.myPassword = "Sohhrs6d2F1PBOQR";

            //btnSave.Enabled = false;    



        }

        private void UserAccount_Load(object sender, EventArgs e)

        {
            //globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            //gv.cn = new MySqlConnection(globalVariables.myConnection);

            //gv.cn.Open();
            //MySqlCommand command;
            //MySqlDataReader mdr;

            //string selectQuery = "  select * FROM school_year where sy_status='activate'";


            //command = new MySqlCommand(selectQuery, gv.cn);

            //mdr = command.ExecuteReader();
            //int count = 0;
            //string SY = string.Empty;
            //string sy_status = string.Empty;

            //while (mdr.Read())
            //{
            //    count = count + 1;
            //    SY = mdr["school_year"].ToString();
            //    sy_status = mdr["sy_status"].ToString();

            //}

            //if (count == 1)
            //{

            //    if (sy_status == "activate")
            //    {       //show admin windows

            //        label8.Text = SY;

            //    }
            //}
            //gv.cn.Close(); txtUN.Hide();
            //gbResetPass.Hide();
           
            //gbTeachForm.Hide();
            //txtUT.Hide();
            //label8.Hide();
            //MySqlCommand cmd = new MySqlCommand();
            
            //globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            //gv.cn = new MySqlConnection(globalVariables.myConnection);

            //MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `useraccounts` ", gv.cn);
            //DataTable dtbl = new DataTable();
            //sqlda.Fill(dtbl);

            //dgUserAccounts.DataSource = dtbl;
            //dgUserAccounts.DisplayedRowCount(true);
            //DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            //DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            //Console.WriteLine(mys);

            //label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            //timer1.Enabled = true;
        }
        
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            button5.Hide();
            gbUserForm.Hide();
            btnSave.Hide();
            btnRemove.Hide();
            btnResetPass.Hide();
            gbResetPass.Show();
            gbTeachForm.Hide();
        }

        private void cbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbUsertype.SelectedItem.Equals("Teacher"))
            {

                gbTeachForm.Show();
                gbUserForm.Hide();
                  }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin(txtUN.Text,txtUT.Text);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)

{
            DialogResult form1 = MessageBox.Show("Do you want to reset your Password?",
                               "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                
                globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
                gv.cn = new MySqlConnection(globalVariables.myConnection);
                MySqlCommand command;
                MySqlDataReader mdr;

                gv.cn.Open();
                MySqlCommand cmd = gv.cn.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE useraccounts  set password= '" + textBox1.Text+ "'where username='"+textBox2.Text+"'";
                cmd.ExecuteNonQuery();
                txtuname.Text = textBox2.Text;
                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `useraccounts` ORDER BY `Firstname` ASC", gv.cn);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);

                dgUserAccounts.DataSource = dtbl;
                dgUserAccounts.DisplayedRowCount(true);


                string selectQuery = "SELECT * FROM useraccounts  WHERE  Binary Username = '" + txtUN.Text + "';";
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

                    if (txtUN.Text == user)
                    {
                       
                        gv.cn.Close();
                        gv.cn.Open();
                            string g = "User successfully reset  password of  " + txtuname.Text;
                        string usr = name + " " + last;

                        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                        command.Parameters.AddWithValue("@Username", user);
                        command.Parameters.AddWithValue("@Action", g);
                        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                        command.Parameters.AddWithValue("@user_type", userRole);
                        command.Parameters.AddWithValue("@user", usr);


                        command.ExecuteNonQuery();
                       
                    }
                }gv.cn.Close();



                MessageBox.Show("New Password Success");
                gbResetPass.Hide();

             


                gbUserForm.Show();
                btnRemove.Show();
                btnResetPass.Show();
                btnSave.Show();

                foreach (Control c in gbUserForm.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }

                txtFirstname.Enabled = true;
                txtLastname.Enabled = true;
                txtMiddlename.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                cbUsertype.Enabled = true;
                btnSave.Enabled = true;
                btnRemove.Enabled = false;
           
                gv.cn.Close();
            } return;
            






         }

        private void btnRemove_Click(object sender, EventArgs e)

        {
            

            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)

             
            {



                globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
                gv.cn = new MySqlConnection(globalVariables.myConnection);
                MySqlCommand command;
                MySqlDataReader mdr;


                gv.cn.Open();
                MySqlCommand cmd = gv.cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete From useraccounts where username='" + txtUsername.Text + "'";
                txtuname.Text = txtUsername.Text;
                cmd.ExecuteNonQuery();
              

              
                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `useraccounts` ORDER BY `Firstname` ASC", gv.cn);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);

                dgUserAccounts.DataSource = dtbl;
                dgUserAccounts.DisplayedRowCount(true);

                string selectQuery = "SELECT * FROM useraccounts  WHERE  Binary Username = '" + txtUsername.Text + "';";
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

                    if (txtUN.Text == user)
                    {

                      gv.cn.Close();
                       gv.cn.Open();
                        string g = "User successfully remove  account of  " + txtuname.Text;
                        string usr = name + " " + last;

                        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                        command.Parameters.AddWithValue("@Username", user);
                        command.Parameters.AddWithValue("@Action", g);
                        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                        command.Parameters.AddWithValue("@user_type", userRole);
                        command.Parameters.AddWithValue("@user", usr);


                        command.ExecuteNonQuery();
                        MessageBox.Show("Remove Success!");
                    }
                }
                gv.cn.Close();


                         }
          
        }


        public void btnSave_Click(object sender, EventArgs e)


       {
            Random random = new Random();
            int value = random.Next(1000000);
            txtPassword.Text = value.ToString();


            Random randomen = new Random();
            int values = random.Next(10000);
            textBox3.Text = "CST-2013-" + values.ToString();




            string newString = txtFirstname.Text.Substring(0, 1);
            string newStrings = txtPassword.Text.Substring(0, 4);
            txtUsername.Text =newString+txtLastname.Text+newStrings;


            DialogResult form2 = MessageBox.Show("Do you really want to Add this New User ?",
                  "Exit", MessageBoxButtons.YesNo);

            
            if (form2 == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand();
                
                MySqlDataAdapter da = new MySqlDataAdapter();

                globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
                gv.cn = new MySqlConnection(globalVariables.myConnection);
                gv.cn.Open();
                cmd = new MySqlCommand("Insert into useraccounts(acc_id,Username,Firstname,Middlename,Lastname,role,Password,create_at,status) VALUES(@ID,@Username,@Firstname,@Middlename,@Lastname,@role,@Password,@create_at,'offline')",gv.cn);
                
                //string m = "offfline";
                //cmd.Parameters.AddWithValue("@status", m);
                cmd.Parameters.AddWithValue("@ID", textBox3.Text);
                cmd.Parameters.AddWithValue("@Username",txtUsername.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text);
                cmd.Parameters.AddWithValue("@role", cbUsertype.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Password",txtPassword.Text);
                cmd.Parameters.AddWithValue("@create_at", label7.Text);
                
                cmd.ExecuteNonQuery();
                txtuname.Text = txtUsername.Text;
                MessageBox.Show("Add New User Success");

               // globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
                //gv.cn = new MySqlConnection(globalVariables.myConnection);
                MySqlCommand command;
                MySqlDataReader mdr;

                //gv.cn.
                string selectQuery = "SELECT * FROM useraccounts  WHERE  Binary Username = '" + txtUN.Text + "';";
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

                    if (txtUN.Text == user)
                    {

                        gv.cn.Close();
                        gv.cn.Open();
                        string g = "User successfully added " + txtuname.Text;
                        string usr = name + " " + last;

                        command = new MySqlCommand("INSERT INTO `audit_trail`( `Username`, `Date_Time`, `Action`, `User_type`,`User`) VALUES (@Username,@Date_Time,@Action,@User_type,@user)", gv.cn);
                        command.Parameters.AddWithValue("@Username", user);
                        command.Parameters.AddWithValue("@Action", g);
                        command.Parameters.AddWithValue("@Date_Time", label7.Text);
                        command.Parameters.AddWithValue("@user_type", userRole);
                        command.Parameters.AddWithValue("@user", usr);


                        command.ExecuteNonQuery();

                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `useraccounts` ORDER BY `Firstname` ASC", gv.cn);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);

                dgUserAccounts.DataSource = dtbl;
                dgUserAccounts.DisplayedRowCount(true);

                    }
                }
                gv.cn.Close();



                MessageBox.Show("New Password Success");
                gbResetPass.Hide();




                gbUserForm.Show();
                btnRemove.Show();
                btnResetPass.Show();
                btnSave.Show();

                foreach (Control c in gbUserForm.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }

                txtFirstname.Enabled = true;
                txtLastname.Enabled = true;
                txtMiddlename.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                cbUsertype.Enabled = true;
                btnSave.Enabled = true;
                btnRemove.Enabled = false;

                gv.cn.Close();
            }
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbResetPass.Hide();
            gbUserForm.Show();
            btnRemove.Show();
            btnSave.Show();
            btnResetPass.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbTeachForm.Hide();
            gbUserForm.Show();
            btnRemove.Show();
            btnSave.Show();
            btnResetPass.Show();
        }


        public void dgUserAccounts_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgUserAccounts.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtMiddlename.Text = row.Cells["Middlename"].Value.ToString();
                txtLastname.Text = row.Cells["Lastname"].Value.ToString();
                txtFirstname.Text = row.Cells["Firstname"].Value.ToString();
                cbUsertype.SelectedItem = row.Cells["Role"].Value.ToString();
                textBox2.Text = row.Cells["Username"].Value.ToString();
                textBox3.Text = row.Cells["acc_id"].Value.ToString();


                txtFirstname.Enabled = false;
                txtLastname.Enabled = false;
                txtMiddlename.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                cbUsertype.Enabled = false;
                btnSave.Enabled = false;
                btnResetPass.Enabled = true;


                if (txtUsername.Text ==txtUN.Text)
                {
            
                    btnRemove.Enabled = false;
                    
                }
                else
                {
                    btnRemove.Enabled = true;
                }

            }

        }
                
            
           
        




        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
                   foreach (Control c in gbUserForm.Controls)
            {
                if( c is TextBox)
                {
                    c.Text = "";
                }
            }

            txtFirstname.Enabled = true;
            txtLastname.Enabled = true;
            txtMiddlename.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            cbUsertype.Enabled = true;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(1000000);
            textBox1.Text = value.ToString();
        }

        private void gbUserForm_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbUserForm.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                }
            }
                    btnSave.Enabled = false;
            txtFirstname.Enabled = true;
            txtLastname.Enabled = true;
            txtMiddlename.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            cbUsertype.Enabled = true;
            btnRemove.Enabled = false;
            btnResetPass.Enabled = false;
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void gbResetPass_Enter(object sender, EventArgs e)
        {

        }

        private void gbUserForm_Enter(object sender, EventArgs e)
        {

        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

   

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                errorProvider1.SetError(txtLastname, "Please enter your Lastname");

                btnSave.Enabled = false;



            }


            else { 
            
              if (string.IsNullOrWhiteSpace(txtFirstname.Text))  {
              
                    btnSave.Enabled = false;}
                
  
                else

                    btnSave.Enabled = true;
                errorProvider1.SetError(txtLastname, null);
            

                return;

}
            }

        

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void gbTeachForm_Enter(object sender, EventArgs e)
        {
            if(cbBachelorsDegree.SelectedText.Equals ("Primary Education"))
                {
                cbSpecialization.SelectedItem.Equals("All");
                }
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                errorProvider1.SetError(txtFirstname, "Please enter your Firstname");

                btnSave.Enabled = false;



            }


            else
            {
                if (string.IsNullOrWhiteSpace(txtLastname.Text))
                {
                    btnSave.Enabled = false;
                }
                else

                    btnSave.Enabled = true;
                errorProvider1.SetError(txtFirstname, null);


                return;


            }
        }

   
    }
}

    
