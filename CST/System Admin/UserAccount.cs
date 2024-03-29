﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CST.Models;
using CST.System_Admin;


namespace CST
{
    public partial class UserAccount : Form
    {
        globalVariables gv = new globalVariables();
        UserController userController = new UserController();
        AuditTrailControl auditTrail = new AuditTrailControl();
      
        public UserAccount(string MyLabelText, string hi)
        {
            InitializeComponent();
            txtUN.Text = MyLabelText;
            txtUT.Text = hi;
            comboBox1.SelectedIndex = 0;
          



        }

        private void UserAccount_Load(object sender, EventArgs e)

        {
            label2.Show();
            label7.Hide();
            timer1.Start();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");


            userController.fillDataGridUser(ref dgUserAccounts);
            encryptPasswordGrid();


        }
        
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string userName = dgUserAccounts.SelectedRows[0].Cells[4].Value.ToString();
            DialogResult form1 = MessageBox.Show("Do you want to reset this " + userName +  " Password?" ,
                        "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                string userId = dgUserAccounts.SelectedRows[0].Cells[0].Value.ToString();
               userController.ResetPassword(userId);
                auditTrail.addAudit(label7.Text, "Reset Password of " + userName);
               userController.fillDataGridUser(ref dgUserAccounts);
                encryptPasswordGrid();
            }
        }

        private void cbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbUsertype.SelectedItem.Equals("Teacher"))
            {

                //gbTeachForm.Show();
                //gbUserForm.Hide();
              //  gbTeachForm.Enabled = true;
            }
            else
            {
                //gbTeachForm.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)

{
          


         }

        private void btnRemove_Click(object sender, EventArgs e)

        {
            

            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                string userId = dgUserAccounts.SelectedRows[0].Cells[0].Value.ToString();
                userController.deleteUser(userId);
                auditTrail.addAudit(label7.Text, "Delete a User Account ");
                userController.fillDataGridUser(ref dgUserAccounts);
                encryptPasswordGrid();
                MessageBox.Show("Succesfully Remove Data");

            }
          
        }


        public void btnSave_Click(object sender, EventArgs e)
       {
            Random random = new Random();
            int value = random.Next(1000000);
         //   txtPassword.Text = value.ToString();


            Random randomen = new Random();
            int values = random.Next(10000);
            //textBox3.Text = "CST-2013-" + values.ToString();

            string userId = "CST-2013-" + values.ToString(); 


            //string newString = txtFirstname.Text.Substring(0, 1);
            //string newStrings = txtPassword.Text.Substring(0, 4);
            //txtUsername.Text = newString + txtLastname.Text + newStrings;


            DialogResult form2 = MessageBox.Show("Do you really want to Add this New User ?",
                  "Exit", MessageBoxButtons.YesNo);

            if(form2 == DialogResult.Yes)
            {
                userController.addUser(userId, txtUsername.Text.Trim(), txtFirstname.Text.Trim(),
                                        txtLastname.Text.Trim(), txtMiddlename.Text.Trim(), cbUsertype.SelectedItem.ToString(),
                                        label7.Text);
                MessageBox.Show("Succesfully Added");
                auditTrail.addAudit(label7.Text, "Addded new User Accounts");
                clearData();
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  gbResetPass.Hide();
            gbUserForm.Show();
            btnRemove.Show();
            btnSave.Show();
            btnResetPass.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  gbTeachForm.Hide();
            gbUserForm.Show();
            btnRemove.Show();
            btnSave.Show();
            btnResetPass.Show();
        }


        public void dgUserAccounts_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
         

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
          //  txtPassword.Enabled = true;
            cbUsertype.Enabled = true;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int value = random.Next(1000000);
          //  textBox1.Text = value.ToString();
        }

        private void gbUserForm_Click(object sender, EventArgs e)
        {
     //       foreach (Control c in gbUserForm.Controls)
     //       {
     //           if (c is TextBox)
     //           {
     //               c.Text = "";

     //           }
     //       }
     //               btnSave.Enabled = false;
     //       txtFirstname.Enabled = true;
     //       txtLastname.Enabled = true;
     //       txtMiddlename.Enabled = true;
     //       txtUsername.Enabled = true;
     ////       txtPassword.Enabled = true;
     //       cbUsertype.Enabled = true;
     //       btnRemove.Enabled = false;
     //       btnResetPass.Enabled = false;
           

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
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Please enter your username");

                btnSave.Enabled = false;



            }


            else
            {

                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {

                    btnSave.Enabled = false;
                }


                else

                    btnSave.Enabled = true;
                errorProvider1.SetError(txtUsername, null);


                return;

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void gbTeachForm_Enter(object sender, EventArgs e)
        {
     
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

        private void dgUserAccounts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearData()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtMiddlename.Text = "";
            txtUsername.Text = "";
            cbUsertype.Text = "";

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            addUserAccounts ad = new addUserAccounts();
            ad.ShowDialog();
            userController.fillDataGridUser(ref dgUserAccounts);
            encryptPasswordGrid();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //     UserAccount.Width = 300;
            int size = this.Size.Height;
            if(size < 590)
            {
                size += 50;

                this.Size = new Size(this.Size.Width, size);

            }
          
            if(size > 590)
            {
                timer2.Stop();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            addUserAccounts ad = new addUserAccounts(dgUserAccounts.SelectedRows[0].Cells[4].Value.ToString(),
                                                       dgUserAccounts.SelectedRows[0].Cells[1].Value.ToString(),
                                                       dgUserAccounts.SelectedRows[0].Cells[3].Value.ToString(),
                                                       dgUserAccounts.SelectedRows[0].Cells[2].Value.ToString(),
                                                       dgUserAccounts.SelectedRows[0].Cells[6].Value.ToString(),
                                                       dgUserAccounts.SelectedRows[0].Cells[0].Value.ToString());
            ad.ShowDialog();
            userController.fillDataGridUser(ref dgUserAccounts);
            encryptPasswordGrid();
                
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                userController.fillDataGridUser(ref dgUserAccounts);
                encryptPasswordGrid();
            }
            else
            {
                string condition = "";
                if (comboBox1.SelectedItem.ToString() == "ID")
                {
                    condition = "acc_id";
                }
                else
                {
                    condition = comboBox1.SelectedItem.ToString();
                }
                userController.searchGrid(condition, textBox1.Text.Trim(),ref dgUserAccounts);
                encryptPasswordGrid();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void encryptPasswordGrid()
        {
            foreach (DataGridViewRow dr in dgUserAccounts.Rows)
            {               
                if(int.Parse(dr.Cells["isPaswordChanged"].Value.ToString()) == 1)
                {
                    dr.Cells["Password"].Value = "*********";
                }        
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

    
