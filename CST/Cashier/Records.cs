using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Cashier;
using CST.Models;
using CST.Reports;

namespace CST
{
    public partial class Records : Form
    {
        StudentBalance studentBalance = new StudentBalance();
        StudFamDetailsController studFamController = new StudFamDetailsController();
        TuitionFeeController tfController = new TuitionFeeController();
        MiscController mfController = new MiscController();
        StudentsDetailsController studentsDetailsController = new StudentsDetailsController();
        YearController yr = new YearController();
        OrController orController = new OrController();
        public Records()
        {
            InitializeComponent();
            studentBalance.fillDataGridTotal(ref dataGridView1);

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
                DataSet ds = new DataSet();
                string sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string bdate = studentsDetailsController.searchAllDetails2(sno)[6];
                string grade = studentsDetailsController.searchAllDetails2(sno)[12];
                DateTime bdateDateForm = DateTime.Parse(bdate);
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
        }
    }
}
