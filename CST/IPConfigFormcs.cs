using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST
{
    public partial class IPConfigFormcs : Form
    {
        public IPConfigFormcs()
        {
            InitializeComponent();
        }

        private void IPConfigFormcs_Load(object sender, EventArgs e)
        {
            txtServername.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtServername.Text == "" || txtDatabase.Text.Trim() == "")
            {
                ep1.SetError(txtServername, "Enter Server! or database name");
                txtServername.Focus();
                return;
            }
            else
            {
                globalVariables.IPv4_Address = txtServername.Text;
                MessageBox.Show("IP Address has been obtained successfully", "IP Address: " + txtServername.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //globalVariables.myServer = txtServername.Text.Trim();
                //globalVariables.myDatabase = txtDatabase.Text.Trim();
                //globalVariables.myUsername = txtUsername.Text.Trim();
                //globalVariables.myPassword = txtPassword.Text.Trim();
                string lines = string.Format("{0}#{1}#{2}#{3}", txtServername.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim(), txtDatabase.Text.Trim());
                System.IO.StreamWriter file = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + @"\databaseconfig.txt");
                file.WriteLine(lines);
                file.Close();
                this.Close();
                Login l = new Login();
                l.Show();
               
            }

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void label1_Click(object sender, EventArgs e)
        {
        

        }

        private void IPConfigFormcs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //txtIPAddress.Text = "192.168.254.152";
                txtServername.Text = "192.168.1.83";
            }
        }

        private void textBox1_(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
    }
}
