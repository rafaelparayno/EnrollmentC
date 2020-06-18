using CST.Data;
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

namespace CST.Registrar
{
    public partial class editGradeAndSection : Form
    {

        StudentEnrolledController studentEnrolledController = new StudentEnrolledController();
        SectionController sectionController = new SectionController();
        int selectedSectIds = 0;
        int sectidInDb = 0;
        int[] sectionIds = { };
        int countTotalStuds = 0;
        int caps = 0;
        string sno = "";
        public editGradeAndSection(string sno,string name)
        {
            InitializeComponent();

            label5.Text = label5.Text + " \t" + name;
            label4.Text = label4.Text + " \t" + sno;
            this.sno = sno;
            foreach(string grade in DataClass.getAllGrade())
            {
                comboBox1.Items.Add(grade);
            }

            comboBox1.SelectedItem = studentEnrolledController.getDataAll(sno)[0];
            int sectid = int.Parse(studentEnrolledController.getDataAll(sno)[1]);

            sectidInDb = sectid;
            selectedSectIds = sectid;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
           
            sectionIds = sectionController.fillComboSect3(ref comboBox2, comboBox1.Text);
            comboBox2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                studentEnrolledController.updateSectionGrade(sno, comboBox1.SelectedItem.ToString(), selectedSectIds);

                MessageBox.Show("Succesfully Updated Grade and Section");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Complete Required Field","err",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool isValid()
        {
            bool isValid = true;

            isValid = (comboBox1.SelectedIndex > -1) && isValid;
            isValid = (comboBox2.SelectedIndex > -1) && isValid;
            return isValid;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSectIds = sectionIds[comboBox2.SelectedIndex];
         
          
            countTotalStuds = sectionController.totalStudentInSections(selectedSectIds);
            caps = sectionController.getCapacity(selectedSectIds);

            if (caps > countTotalStuds)
            {
               
                    button1.Enabled = true;
                    button5.Enabled = true;

                    label6.ForeColor = Color.ForestGreen;
                    label6.Text = "Selected Section Is Available";
                

            }
            else if (caps == countTotalStuds)
            {
                if (!isChanghed(sectidInDb, selectedSectIds))
                {
                    button1.Enabled = true;
                    button5.Enabled = true;

                    label6.ForeColor = Color.ForestGreen;
                    label6.Text = "Selected Section Is Available";
                }
                else
                {
                    button1.Enabled = false;
                    button5.Enabled = false;
                    label6.ForeColor = Color.IndianRed;
                    label6.Text = "Selected Section Is Currently full";

                }
               
            }
            label6.Visible = true;
        }

        private bool isChanghed(int sectidsInDb,int selectidInCb)
        {
            bool isChange = false;
            if(sectidsInDb != selectidInCb)
            {
                isChange = true;
            }

            return isChange;
        }
    }
}
