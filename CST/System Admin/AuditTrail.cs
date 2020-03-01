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
    public partial class AuditTrail : Form
    {
        globalVariables gv = new globalVariables();
        public AuditTrail(string MyLabelText, string hi)
            
           
        {
          

            InitializeComponent();
            txtUN.Text = MyLabelText;
            txtUT.Text = hi;
           
            globalVariables.myServer = globalVariables.IPv4_Address;
            globalVariables.myDatabase = "final_enroll";
            globalVariables.myUsername = "cst_db";
            globalVariables.myPassword = "Sohhrs6d2F1PBOQR";
 
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            this.Hide();
            Admin frm = new Admin(txtUN.Text, txtUT.Text);
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
        }

        private void AuditTrail_Load(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand();
            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);
             gv.cn.Open();
            MySqlDataAdapter sqldae = new MySqlDataAdapter("SELECT * FROM `audit_trail` ORDER BY `audit_trail`.`audit_id` DESC", gv.cn);
            DataTable dtble = new DataTable();
            sqldae.Fill(dtble);

            dataGridView1.DataSource = dtble;
            dataGridView1.DisplayedRowCount(true);


            


            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





            globalVariables.myConnection = "SERVER =" + globalVariables.myServer + ";" + "DATABASE =" + globalVariables.myDatabase + ";" + "UID =" + globalVariables.myUsername + ";" + "PASSWORD =" + globalVariables.myPassword + ";";
            gv.cn = new MySqlConnection(globalVariables.myConnection);
            gv.cn.Open();
            string s = string.Format("SELECT * FROM `audit_trail` WHERE Username LIKE '%{0}%'", textBox1.Text); 

             MySqlCommand cmd = new MySqlCommand(s,gv.cn);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
                 DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                gv.cn.Close();
            

            
         
        

            gv.cn.Close();

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

       
    }
}
