using CST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Enrollment_Admin.AddUpdateDiags
{
    public partial class AddUpdateSubjectType : Form
    {

        SubjectTypeController subjectTypeController = new SubjectTypeController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        bool isEdited = false;
        string name = "";
        int id = 0;

        public AddUpdateSubjectType()
        {
            InitializeComponent();
            
        }

        public AddUpdateSubjectType(int id ,string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            isEdited = true;
            textBox1.Text = name;
        }

        private void AddUpdateSubjectType_Load(object sender, EventArgs e)
        {
            label3.Hide();
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox1.Text != "")
            {
                if (isEdited)
                {
                    subjectTypeController.updateSubjectType(textBox1.Text.Trim(), id);
                    auditTrail.addAudit(label3.Text,"Update Subject Type");

                }
                else
                {
                    subjectTypeController.addSubjectType(textBox1.Text.Trim());
                    auditTrail.addAudit(label3.Text, "Add Subject Type " + textBox1.Text.Trim());
                }
                this.Hide();
           
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();
            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();
            label3.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
            timer1.Enabled = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
