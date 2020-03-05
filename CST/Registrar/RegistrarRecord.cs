using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Registrar;
using CST.Models;

namespace CST
{
    public partial class RegistrarRecord : Form
    {

        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        StudFamDetailsController studFamDetailsController = new StudFamDetailsController();
        StudHistDetailsController StudHistDetailsController = new StudHistDetailsController();
        string clickedBut = "";
        public RegistrarRecord()
        {
            InitializeComponent();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsDetailsController.fillDataGridDetails(ref dataGridView1);
            clickedBut = "Personal";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm reg = new RegistrarForm();
            reg.Show();
            this.Hide();
        }

        private void RegistrarRecord_Load(object sender, EventArgs e)
        {
            studentsDetailsController.fillDataGridDetails(ref dataGridView1);
            clickedBut = "Personal";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(clickedBut == "Personal")
            {
                editStudentForm frm = new editStudentForm(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                          int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                                                          dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                          );
                //string fn,string ln,string mn,string gen,int age,string bd,string pob, string cn,string nat,string rel,string add,string sno
                frm.ShowDialog();

            }
            else if(clickedBut == "Family")
            {
                MessageBox.Show("family");
            }else if( clickedBut == "History")
            {
                MessageBox.Show("history");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            studFamDetailsController.filldataGridFam(ref dataGridView1);
            clickedBut = "Family";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudHistDetailsController.fillDataHist(ref dataGridView1);
            clickedBut = "History";
        }
    }
}
