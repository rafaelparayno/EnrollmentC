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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox1.Text != "")
            {
                if (isEdited)
                {
                    subjectTypeController.updateSubjectType(textBox1.Text.Trim(), id);
                    
                }
                else
                {
                    subjectTypeController.addSubjectType(textBox1.Text.Trim());
                }
                this.Hide();
           
            }
        }
    }
}
