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
    public partial class ListRequirements : Form
    {

        StudentRequirementController studentRequirementController = new StudentRequirementController();
        
        public ListRequirements()
        {
            InitializeComponent();
        }

        private void ListRequirements_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addRequirements frm = new addRequirements();
            frm.ShowDialog();
            refreshGrid();
        }

        private void refreshGrid()
        {
            studentRequirementController.fillGridReq(ref dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                studentRequirementController.removeReq(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                refreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (txtUsername.Text.Trim() == "")
            {
                refreshGrid();
            }
            else
            {
                studentRequirementController.SearchGrid(ref dataGridView1, txtUsername.Text.Trim());
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
