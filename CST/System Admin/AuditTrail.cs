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
using CST.Models;

namespace CST
{
    public partial class AuditTrail : Form
    {
        globalVariables gv = new globalVariables();
        AuditTrailControl auditTrailControl = new AuditTrailControl();
        public AuditTrail(string MyLabelText, string hi)                 
        {
          
            InitializeComponent();
            timer1.Start();
            comboBox1.SelectedIndex = 0;
            //txtUN.Text = MyLabelText;
            //txtUT.Text = hi;

            //globalVariables.myServer = globalVariables.IPv4_Address;
            //globalVariables.myDatabase = "final_enroll";
            //globalVariables.myUsername = "cst_db";
            //globalVariables.myPassword = "Sohhrs6d2F1PBOQR";

        }

        private void button2_Click(object sender, EventArgs e )
        { 

            this.Hide();
            Admin frm = new Admin();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         


        }

        private void AuditTrail_Load(object sender, EventArgs e)
        {


            auditTrailControl.fillDataGridAudit(ref dataGridView1);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





            //globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            //gv.cn = new MySqlConnection(globalVariables.myConnection);
            //gv.cn.Open();
            //string s = string.Format("SELECT * FROM `audit_trail` WHERE Username LIKE '%{0}%'", textBox1.Text); 

            // MySqlCommand cmd = new MySqlCommand(s,gv.cn);
            //cmd.Parameters.AddWithValue("@username", textBox1.Text);
            //     DataSet ds = new DataSet();
            //    DataTable dt = new DataTable();
            //    ds.Tables.Add(dt);
            //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt.DefaultView;
            //    gv.cn.Close();
            

            
         
        

            //gv.cn.Close();

            //
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                auditTrailControl.fillDataGridAudit(ref dataGridView1);
            }
            else
            {
                string condition = "";
                if (comboBox1.SelectedItem.ToString() == "Date")
                {
                    condition = "date_time";
                }
                else
                {
                    condition = comboBox1.SelectedItem.ToString();
                }
                auditTrailControl.searchGrid(condition, textBox1.Text.Trim(), ref dataGridView1);
            }
        }
    }
}
