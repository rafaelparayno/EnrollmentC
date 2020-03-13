using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class StudentBalance
    {
        crudFile cs = new crudFile();
        YearController yr = new YearController();
        int syid = 0;
        public StudentBalance()
        {
            syid = yr.getSchoolYearId();

        }

        public void addBalance(string sno,double balance,string mod,double need)
        {
            string sql = String.Format(@"INSERT INTO `student_balance`(`sno`, `balance`, `modeofpayment`, `need_to_pay`, `SY_id`) VALUES ('{0}',{1},'{2}',{3},{4})",
                                        sno, balance, mod, need, syid);
            cs.ExecuteQuery(sql);
        }

        public void updateBalance(string sno)
        {
            string sql = String.Format(@"UPDATE `student_balance` SET `balance` = `balance` - `need_to_pay`,totalPayment = totalPayment + `need_to_pay` WHERE sno = '{0}' AND SY_id = {1}",
                                        sno, syid);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridBalance(ref DataGridView dg,string sno)
        {
            string sql = String.Format("SELECT balance AS 'Remaining Balance',modeofpayment FROM `student_balance` WHERE sno ='{0}'", sno);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridTotal(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT student_balance.sno, Concat(firstname,' ',middlename,' ',lastname) AS 'Student Name',totalPayment As 'Total Payment',
                                        balance AS 'Remaining Balance', modeofpayment AS 'Mode of Payment' 
                                        FROM `student_balance` LEFT JOIN student_detail ON student_balance.sno = student_detail.sno");


            cs.FillDataGrid(sql, ref dg);
        }

        public double getNeedToPay(string sno)
        {
            string sql = String.Format(@"SELECT need_to_pay FROM student_balance WHERE sno ='{0}' AND SY_id = {1} AND balance > 0", sno, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            double getNeedToPay = 0;
            if (reader.Read())
            {

                getNeedToPay = double.Parse(reader["need_to_pay"].ToString());
            }
            cs.CloseConnection();

            return getNeedToPay;
        }

        
    }
}
