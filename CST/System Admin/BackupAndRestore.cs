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
    public partial class BackupAndRestore : Form
    {
        globalVariables gv = new globalVariables();
     
        private string dateClicked = string.Empty;
        private string timeClicked = string.Empty;
        public BackupAndRestore()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to back up data?",
                  "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
                
            {
                csBackupAndRestore.DoBackup();
                MessageBox.Show("Back Up Data Success");
                reloadBackup();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            csBackupAndRestore.DoRestore(dateClicked, timeClicked);
            MessageBox.Show("Recover Data Success");
            reloadBackup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin frm = new Admin();
            frm.Show();
        }

        private void BackupAndRestore_Load(object sender, EventArgs e)
        {
           
        }

        private void txtUT_Click(object sender, EventArgs e)
        {

        }

        private void txtUN_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void datePick_Logs_ValueChanged(object sender, EventArgs e)
        {
            reloadBackup();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            datePick_Logs.Value = DateTime.Now;
        }

        private void reloadBackup()
        {
            csBackupAndRestore.CreateDirectory();
            DirectoryInfo d = new DirectoryInfo(@"C:\CST-backup\");
            FileInfo[] Files = d.GetFiles("*.sql");
            Array.Sort(Files, (f1, f2) => f1.Name.CompareTo(f2.Name));

            int backupIndex = 1;

            lv_Backup.Items.Clear();

            for (int i = Files.Length - 1; i >= 0; i--)
            {

                string[] dateTime = Files[i].Name.Split(new[] { "--" }, StringSplitOptions.None);
                string dateParse = dateTime[1] + "-" + dateTime[2] + "-" + dateTime[3];
                string timeParse = dateTime[4] + ":" + dateTime[5] + ":" + dateTime[6] + " " + dateTime[7].Replace(".sql", "");


                if (dateParse != datePick_Logs.Value.ToString("yyyy-MM-dd"))
                {
                    continue;
                }


                ListViewItem lv = new ListViewItem();
                lv.Text = dateParse;
                lv.SubItems.Add(timeParse);

                lv_Backup.Items.Add(lv);
                backupIndex++;
            }

           
        }

        private void lv_Backup_Click(object sender, EventArgs e)
        {
            if (lv_Backup.SelectedItems.Count == 1)
            {
                dateClicked = lv_Backup.SelectedItems[0].SubItems[0].Text;
                timeClicked = lv_Backup.SelectedItems[0].SubItems[1].Text;

                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }
    }
}
