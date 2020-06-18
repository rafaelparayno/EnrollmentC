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

        public void addBalance(string sno,double balance,
                            string mod,double need,
                            double totalPayment,double disc,double uponPay)
        {
            string sql = String.Format(@"INSERT INTO `student_balance`(`sno`, `balance`, `modeofpayment`, `need_to_pay`,`totalPayment`, `disc`,`upon_pay`,`SY_id`) 
                                                VALUES ('{0}',{1},'{2}',{3},{4},{5},{6},{7})",
                                        sno, balance, mod, need, totalPayment,disc, uponPay, syid);
            cs.ExecuteQuery(sql);
        }

        public void updateBalance(string sno,int yrid)
        {
            string sql = String.Format(@"UPDATE `student_balance` SET `balance` = `balance` - `need_to_pay`,totalPayment = totalPayment + `need_to_pay` WHERE sno = '{0}' AND SY_id = {1}",
                                        sno, yrid);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridBalance(ref DataGridView dg,string sno,int yrid)
        {
            string sql = String.Format("SELECT balance AS 'Remaining Balance',modeofpayment FROM `student_balance` WHERE sno ='{0}' AND SY_id = {1}", sno,yrid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridTotal(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT student_balance.sno, Concat(firstname,' ',middlename,' ',lastname) AS 'Student Name',totalPayment As 'Total Payment',
                                        balance AS 'Remaining Balance', modeofpayment AS 'Mode of Payment' 
                                        FROM `student_balance` LEFT JOIN student_detail ON student_balance.sno = student_detail.sno
                                        WHERE SY_id = {0} ",syid);


            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridTotal(ref DataGridView dg,int yrid)
        {
            string sql = String.Format(@"SELECT student_balance.sno, Concat(firstname,' ',middlename,' ',lastname) AS 'Student Name',totalPayment As 'Total Payment',
                                        balance AS 'Remaining Balance', modeofpayment AS 'Mode of Payment' 
                                        FROM `student_balance` LEFT JOIN student_detail ON student_balance.sno = student_detail.sno
                                        WHERE SY_id = {0} ", yrid);


            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridTotal(ref DataGridView dg, string sno)
        {
            string sql = String.Format(@"SELECT student_balance.sno, Concat(firstname,' ',middlename,' ',lastname) AS 'Student Name',totalPayment As 'Total Payment',
                                        balance AS 'Remaining Balance', modeofpayment AS 'Mode of Payment' 
                                        FROM `student_balance` LEFT JOIN student_detail ON student_balance.sno = student_detail.sno
                                        WHERE SY_id = {0} AND student_balance.sno = '{1}' ", syid,sno);


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

        public double getNeedToPay(string sno,int yrid)
        {
            string sql = String.Format(@"SELECT need_to_pay FROM student_balance WHERE sno ='{0}' AND SY_id = {1} AND balance > 0", sno, yrid);

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



        public double getDisc(string sno)
        {

            string sql = String.Format(@"SELECT disc FROM student_balance WHERE sno ='{0}' AND SY_id = {1} ", sno, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            double getdisc = 0;
            if (reader.Read())
            {

                getdisc = double.Parse(reader["disc"].ToString());
            }
            cs.CloseConnection();

            return getdisc;
        }

        public double getDisc(string sno,int yrid)
        {

            string sql = String.Format(@"SELECT disc FROM student_balance WHERE sno ='{0}' AND SY_id = {1} ", sno, yrid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            double getdisc = 0;
            if (reader.Read())
            {

                getdisc = double.Parse(reader["disc"].ToString());
            }
            cs.CloseConnection();

            return getdisc;
        }


        public double getUponPay(string sno)
        {

            string sql = String.Format(@"SELECT upon_pay FROM student_balance WHERE sno ='{0}' AND SY_id = {1} ", sno, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            double upon = 0;
            if (reader.Read())
            {

                upon = double.Parse(reader["upon_pay"].ToString());
            }
            cs.CloseConnection();

            return upon;
        }


        public double getUponPay(string sno,int yrid)
        {

            string sql = String.Format(@"SELECT upon_pay FROM student_balance WHERE sno ='{0}' AND SY_id = {1} ", sno, yrid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            double upon = 0;
            if (reader.Read())
            {

                upon = double.Parse(reader["upon_pay"].ToString());
            }
            cs.CloseConnection();

            return upon;
        }

        public string getModOfPayment(string sno)
        {
            string mod = "";
            string sql = String.Format(@"SELECT modeofpayment FROM student_balance WHERE sno ='{0}' AND SY_id = {1}", sno, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
          
            if (reader.Read())
            {

                mod = reader["modeofpayment"].ToString();
            }
            cs.CloseConnection();

          

            return mod;
        }


        public string getModOfPayment(string sno,int yrid)
        {
            string mod = "";
            string sql = String.Format(@"SELECT modeofpayment FROM student_balance WHERE sno ='{0}' AND SY_id = {1}", sno, yrid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {

                mod = reader["modeofpayment"].ToString();
            }
            cs.CloseConnection();



            return mod;
        }

        public double getBalance(string sno)
        {
            double bal = 0;
            string sql = String.Format(@"SELECT balance FROM student_balance WHERE sno ='{0}' AND SY_id = {1}", sno, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {

                bal = double.Parse(reader["balance"].ToString());
            }
            cs.CloseConnection();



            return bal;
        }

        public double getBalance(string sno,int yrid)
        {
            double bal = 0;
            string sql = String.Format(@"SELECT balance FROM student_balance WHERE sno ='{0}' AND SY_id = {1}", sno, yrid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {

                bal = double.Parse(reader["balance"].ToString());
            }
            cs.CloseConnection();



            return bal;
        }


    }
}
