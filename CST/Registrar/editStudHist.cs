using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;

namespace CST.Registrar
{
    public partial class editStudHist : Form
    {
        string isVacine = "";
        string sno = "";
        StudHistDetailsController studHist = new StudHistDetailsController();
        public editStudHist(string pschool,string padd,string plvl,string pdate,string isVacine,string vdetails,string sno)
        {
            InitializeComponent();
            txtPastSchool.Text = pschool;
            txtPastAdd.Text = padd;
            txtPastLevel.Text = plvl;
            dateTimePicker2.Value = DateTime.Parse(pdate);

            if (isVacine == "Yes")
            {
                radioButton7.Checked = true;
                isVacine = "Yes";
            }
            else
            {
                radioButton6.Checked = true;
                isVacine = "No";
            }
            txtVaccination.Text = vdetails;

            this.sno = sno;



        }

        private bool validationTab3()
        {
            bool isValid = true;

            isValid = !(txtPastSchool.Text.Trim() == "") && isValid;

            isValid = !(txtPastAdd.Text.Trim() == "") && isValid;

            isValid = !(txtPastLevel.Text.Trim() == "") && isValid;


            return isValid;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validationTab3())
            {
                studHist.updateHisDetails(sno, txtPastSchool.Text.Trim(), txtPastAdd.Text.Trim(), txtPastLevel.Text.Trim(), dateTimePicker2.Value.ToShortDateString(),
                                        isVacine, txtVaccination.Text.Trim());
                MessageBox.Show("Succesfully Updated");
                this.Hide();
            }
        }
    }
}
