using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Docs;
using CST.Models;
using MySql.Data.MySqlClient;

namespace CST.Registrar
{
    public partial class addRequirements : Form
    {
        SchoolRequirementsController schoolRequirements = new SchoolRequirementsController();
        StudentsDetailsController studentsDetails = new StudentsDetailsController();
        StudentRequirementController studentRequirementController = new StudentRequirementController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        crudFile cs = new crudFile();
        string sno = "";
        string name = "";
        string studType = "";
        int[] req_ids;
        int selectedReqId = 0;
        public addRequirements()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //comboBox2.Items.Clear();
         //   req_ids = schoolRequirements.fillComboReq(comboBox1.SelectedItem.ToString(), ref comboBox2);
         //   comboBox2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name = studentsDetails.searchName(textBox1.Text.Trim());
            studType = studentsDetails.searchStudType(textBox1.Text.Trim());

            label3.Text = "Name :" + name;
            label2.Text = "Type of Student : " + studType;
            comboBox2.Items.Clear();
            if (name == "")
            {
                MessageBox.Show("No Student Number Found");
                comboBox2.Enabled = false;
            }
            else
            {
                sno =  "STUD-"+textBox1.Text.Trim();
                req_ids = schoolRequirements.fillComboReq(studType, ref comboBox2);
                comboBox2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReqId = req_ids[comboBox2.SelectedIndex];
        }

        private bool Validation()
        {
            bool isValid = true;

            isValid = !(sno == "") && isValid;

            isValid = comboBox2.SelectedIndex > -1 && isValid;

            return isValid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                if (!studentRequirementController.findSame(sno, selectedReqId))
                {

                    string path = CreateDirectory.CreateDir(sno + "-" +name.Split(',')[0] );
                    studentRequirementController.addStudentReq(sno,  selectedReqId);
                    auditTrail.addAudit(label7.Text, name + "Submit " +comboBox2.SelectedItem.ToString());

                    string datenow = DateTime.Now.ToString("yyyy--MM--dd");
                    string timenow = DateTime.Now.ToString("HH--mm--ss--tt");
                    string combine = datenow + "--" + timenow;
                    string filename = combine + "--" + selectedReqId + ".jpg";
                    pbAutomated.Image.Save(path + filename);

                    await saveDb(selectedReqId, filename, path);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Already has the requirement", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            else
            {
                MessageBox.Show("Complete Required Field", "validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRequirements_Load(object sender, EventArgs e)
        {
            label7.Hide();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }


        private async Task saveDb(int reqid, string filename, string path)
        {
            string sql = String.Format(@"INSERT INTO attach_requirements (student_no,req_id,filename,path) 
                                        VALUES (@sno,@reqid,@filename,@path)");

            List<MySqlParameter> listparams = new List<MySqlParameter>();

            listparams.Add(new MySqlParameter("@sno", sno));

            listparams.Add(new MySqlParameter("@reqid", reqid));

            listparams.Add(new MySqlParameter("@filename", filename));

            listparams.Add(new MySqlParameter("@path", path));

            await cs.ExecuteAsync(sql, listparams);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png;";
            string filePath = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                filePath = openFileDialog.FileName;
                pbAutomated.SizeMode = PictureBoxSizeMode.AutoSize;
                pbAutomated.Image = Image.FromFile(filePath);
             /*   pbAutomated.Image = Image.FromFile(filePath);*/

            }
        }
    }
}
