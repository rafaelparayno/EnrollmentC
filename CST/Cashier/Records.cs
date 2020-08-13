using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Cashier;
using CST.Models;
using CST.Reports;
using Microsoft.Vbe.Interop;

namespace CST
{
    public partial class Records : Form
    {

        int[] yrids = { };
        int selectedYrid = 0;
        StudentBalance studentBalance = new StudentBalance();
        StudFamDetailsController studFamController = new StudFamDetailsController();
        TuitionFeeController tfController = new TuitionFeeController();
        MiscController mfController = new MiscController();
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        EnrollScheduleController enrollSchedule = new EnrollScheduleController();
        OrController orCon = new OrController();
        YearController yr = new YearController();
        OrController orController = new OrController();
        StudentReserveController reserveController = new StudentReserveController();
        CultureInfo provider = CultureInfo.InvariantCulture;
        string idRightClick = "";
        string modRightClick = "";
        public Records()
        {
            InitializeComponent();
            studentBalance.fillDataGridTotal(ref dataGridView1);
            yrids = yr.fillComboSy(ref comboBox1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashierDashboard c = new CashierDashboard();
  
            c.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }

        private void Records_Load(object sender, EventArgs e)
        {

            label6.Text = yr.getSyActivated();

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataSet ds = new DataSet();

                DataTable dt = new DataTable();
                dt.Columns.Add("Student Number", typeof(string));
                dt.Columns.Add("Student Name", typeof(string));
                dt.Columns.Add("Total Payment", typeof(string));
                dt.Columns.Add("Remaining Balance", typeof(string));
                dt.Columns.Add("Mode of Payment", typeof(string));


                foreach (DataGridViewRow dgv in dataGridView1.Rows)
                {
                    dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);

                }


                ds.Tables.Add(dt);
             
                AccountRecordRep rep = new AccountRecordRep(ds);
                rep.ShowDialog();

              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                if (comboBox3.SelectedIndex == 1)
                {
                    if (comboBox1.SelectedIndex > -1)
                    {

                        showStudentAccountSearchYr();

                    }
                    else
                    {
                        MessageBox.Show("Please Select in the Combobox");
                    }
                }
                else
                {
                    showStudentAccountCurrentYear();
                }
            
            }
        }


        private void showStudentAccountCurrentYear()
        {
            DataSet ds = new DataSet();
                string sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string bdate = studentsDetailsController.searchAllDetails2(sno)[6];
                string grade = studentsDetailsController.searchAllDetails2(sno)[12];

                DateTime bdateDateForm = DateTime.ParseExact(bdate, "MM/dd/yyyy", provider);
                string add = studentsDetailsController.searchAllDetails2(sno)[11];
                string sex = studentsDetailsController.searchAllDetails2(sno)[4];
                string fname = studFamController.getAllFamDetails(sno)[0];
                string mname = studFamController.getAllFamDetails(sno)[6];
                string foccu = studFamController.getAllFamDetails(sno)[2];
                string moccu = studFamController.getAllFamDetails(sno)[8];
                string fcAdd = studFamController.getAllFamDetails(sno)[5];
                string mcAdd = studFamController.getAllFamDetails(sno)[11];
                string mod = studentBalance.getModOfPayment(sno);
                double balanceStud = studentBalance.getBalance(sno);
                double disc = studentBalance.getDisc(sno);
                double totalBal = (tfController.getTfPriceGrade(grade,mod) + mfController.getMiscFeeForGrade(grade)) - disc;

                orController.getOrStudDataSet(sno, totalBal, ref ds);


                //  ds.WriteXmlSchema("studentAccountsType.xml");
                string[] datas = new string[14];
                datas[0] = fullname;
                datas[1] = sno;
                datas[2] = bdateDateForm.ToString("MMMM dd, yyyy");

                datas[3] = add;
                datas[4] = sex; 
                datas[5] = fname;
                datas[6] = mname;
                datas[7] = foccu;
                datas[8] = moccu;
                datas[9] = fcAdd;
                datas[10] = mcAdd;
                datas[11] = mod;
                datas[12] = "₱ " + totalBal;
                datas[13] = "₱ " + balanceStud;

                StudentPaymentReps frm = new StudentPaymentReps(ds, datas);
                frm.ShowDialog();
        }

        private void showStudentAccountSearchYr()
        {
            DataSet ds = new DataSet();
            string sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string bdate = studentsDetailsController.searchAllDetails2(sno,selectedYrid)[6];
            string grade = studentsDetailsController.searchAllDetails2(sno,selectedYrid)[12];
            DateTime bdateDateForm = DateTime.ParseExact(bdate, "MM/dd/yyyy", provider);
            string add = studentsDetailsController.searchAllDetails2(sno,selectedYrid)[11];
            string sex = studentsDetailsController.searchAllDetails2(sno,selectedYrid)[4];
            string fname = studFamController.getAllFamDetails(sno)[0];
            string mname = studFamController.getAllFamDetails(sno)[6];
            string foccu = studFamController.getAllFamDetails(sno)[2];
            string moccu = studFamController.getAllFamDetails(sno)[8];
            string fcAdd = studFamController.getAllFamDetails(sno)[5];
            string mcAdd = studFamController.getAllFamDetails(sno)[11];
            string mod = studentBalance.getModOfPayment(sno,selectedYrid);
            double balanceStud = studentBalance.getBalance(sno,selectedYrid);
            double disc = studentBalance.getDisc(sno,selectedYrid);
            double totalBal = (tfController.getTfPriceGrade(grade, mod,selectedYrid) + mfController.getMiscFeeForGrade(grade,selectedYrid)) - disc;

            orController.getOrStudDataSet(sno, totalBal, ref ds,selectedYrid);


            //  ds.WriteXmlSchema("studentAccountsType.xml");
            string[] datas = new string[14];
            datas[0] = fullname;
            datas[1] = sno;
            datas[2] = bdateDateForm.ToString("MMMM dd, yyyy");
            datas[3] = add;
            datas[4] = sex;
            datas[5] = fname;
            datas[6] = mname;
            datas[7] = foccu;
            datas[8] = moccu;
            datas[9] = fcAdd;
            datas[10] = mcAdd;
            datas[11] = mod;
            datas[12] = "₱ " + totalBal;
            datas[13] = "₱ " + balanceStud;

            StudentPaymentReps frm = new StudentPaymentReps(ds, datas);
            frm.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 1)
            {
                comboBox1.Visible = true;
                txtUsername.Visible = false;
                button12.Visible = false;
                selectedYrid = 0;
            }
            else
            {
                comboBox1.Visible = false;
                txtUsername.Visible = true;
                button12.Visible = true;
                selectedYrid = yr.getSchoolYearId();
              
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > -1)
            {
                if (comboBox3.SelectedIndex == 0)
                {
                    //Sno
                    studentBalance.fillDataGridTotal(ref dataGridView1, "STUD-" + txtUsername.Text.Trim());


                }
                else
                {
                    //Year
                    if (comboBox1.SelectedIndex > -1)
                    {

                        studentBalance.fillDataGridTotal(ref dataGridView1, selectedYrid);

                    }
                    else
                    {
                        MessageBox.Show("Please Select in the Combobox");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Select in the Combobox");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            studentBalance.fillDataGridTotal(ref dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYrid = yrids[comboBox1.SelectedIndex];
         

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox3.SelectedIndex == 1)
            {
                return;
            }
                if (e.Button == MouseButtons.Right)
            {
                /*ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("View Due Date"))*/;

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;


                if (currentMouseOverRow >= 0)
                {
                    idRightClick = dataGridView1.Rows[currentMouseOverRow].Cells[0].Value.ToString();
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                    modRightClick = dataGridView1.Rows[currentMouseOverRow].Cells[4].Value.ToString();
                }
                         
            }

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void viewDueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string endDate = enrollSchedule.getEnrollSched()[2];

            string[] dues = setDueDates(endDate);
            int tot = orCon.totalPaid(idRightClick);
            tot = reserveController.checkReserve(idRightClick) ? tot -1 : tot;
             MessageBox.Show(getDueDates(dues, tot, modRightClick));
          
        }


        private string getDueDates(string[] dues,int tot,string mod)
        {
            string due = "";

            switch (mod)
            {
                case "Fullpayment":
                    due = "No Dues";
                    break;
                case "Semi-Annual":
                    if(tot == 1)
                    {
                        due = dues[4];
                    }
                    else
                    {
                        due = "No Dues";
                    }                   
                    break;
                case "Quarterly":
                    if(tot == 4)
                    {
                        due = "No Dues";
                    }
                    else
                    {
                      
                        due = dues[(tot * 3)-1];
                    }
                    break;
                case "Monthly":
                    if(tot == 10)
                    {
                        due = "No Dues";
                    }
                    else
                    {
                        due = dues[tot - 1];
                    }
                    break;
            }


            return due;
        }

        private string[] setDueDates( string dateEnd)
        {
            string[] duesDates = new string[9];
            string duess;
            DateTime date = DateTime.ParseExact(dateEnd, "dd/MM/yyyy", provider);
       
        

           
            for (int i = 0; i < 9; i++)
            {
                date = date.AddMonths(1);
                duess = date.ToString("MMMM") + ", 15 " + date.ToString("yyyy");
                duesDates[i] = duess;
            }

            return duesDates;
        }
    }
}
