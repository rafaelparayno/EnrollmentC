using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Data;
using CST.Models;

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class diagMisc : Form
    {
        MiscController misc = new MiscController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        bool isEdited = false;
   
        int id;

        public diagMisc()
        {
            InitializeComponent();
            loadGradeData();
        }


        public diagMisc(string grade,string details,string fee,int id)
        {
            InitializeComponent();
            loadGradeData();


            comboBox2.SelectedItem = grade;
            textBox1.Text = details;
            textBox2.Text = fee;
            this.id = id;
            isEdited = true;
        }

        private void diagMisc_Load(object sender, EventArgs e)
        {

            label5.Hide();
            timer1.Start();

        }

        private void button6_Click(object sender, EventArgs e)
        {
          

            if(validation())
            {
                if (isEdited)
                {
                    misc.updateMisc(textBox1.Text.Trim(), double.Parse(textBox2.Text.ToString()), comboBox2.SelectedItem.ToString(), id);
                    auditTrail.addAudit(label5.Text, "Updated " + comboBox2.SelectedItem.ToString() + " Miscellaneous Fee");
                    MessageBox.Show("Succesfully Update Misc");
                }
                else
                {
                    misc.addMisc(textBox1.Text.Trim(), double.Parse(textBox2.Text.ToString()), comboBox2.SelectedItem.ToString());
                    auditTrail.addAudit(label5.Text, "Added " + comboBox2.SelectedItem.ToString() + " Miscellaneous Fee");
                    MessageBox.Show("Succesfully Added A new Misc");
                }

              
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error!! please fill data or the Misc fee is not a number","error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool validation()
        {
            bool isValid = true;
            double _;
            isValid = comboBox2.SelectedIndex > -1 && isValid;

            isValid = !(textBox1.Text.Trim() == "") && isValid;

            isValid = double.TryParse(textBox2.Text, out _) && isValid;

            return isValid;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789.";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loadGradeData()
        {
            foreach (string items in DataClass.getAllGrade())
            {
                comboBox2.Items.Add(items);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label5.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
