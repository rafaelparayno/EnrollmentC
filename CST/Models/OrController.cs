using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class OrController
    {
        crudFile cs = new crudFile();
        YearController yr = new YearController();
        int syid = 0;

        public OrController()
        {
            syid = yr.getSchoolYearId();
        }

        public int getRecentOr()
        {
            string sql = String.Format(@"SELECT AUTO_INCREMENT as Last_id FROM information_schema.TABLES WHERE TABLE_NAME = 'orno'");
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int last_id = 0;
            if (reader.Read())
            {
                last_id = int.Parse(reader["Last_id"].ToString());
            }
            cs.CloseConnection();
            return last_id;
        }


        public void getOrStudDataSet(string sno,double balance ,ref DataSet dataSet)
        {
            string sql = String.Format(@"SELECT *  FROM orno WHERE sno = '{0}' AND syid = {1}", sno,syid);
            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            DataTable dt = new DataTable();
            dt.Columns.Add("Date Paid", typeof(string));
            dt.Columns.Add("O.R No.", typeof(string));
            dt.Columns.Add("Amount Paid", typeof(string));
            dt.Columns.Add("Balance", typeof(string));
         
            while (reader.Read())
            {
                double amt = double.Parse(reader["amount"].ToString());
                balance -= amt;
                dt.Rows.Add(reader["date_pay"].ToString(),
                  reader["oror"].ToString(),
                "₱ " + reader["amount"].ToString(),
                 "₱ " +  balance ) ;
            }
            dataSet.Tables.Add(dt);
            cs.CloseConnection();

        }

            public void addOr(string orno,string sno,double amt,string datePay)
        {
            string sql = String.Format(@"INSERT INTO orno (`oror`, `sno`, `amount`,`date_pay`,`syid`) VALUES ('{0}','{1}',{2},'{3}',{4})", orno,sno,amt, datePay, syid);

            cs.ExecuteQuery(sql);
        }
    }
}
