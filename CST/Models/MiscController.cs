using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class MiscController
    {
        crudFile cs = new crudFile();
        YearController yrcontroller = new YearController();
        int syid = 0;
        public MiscController()
        {
            syid = yrcontroller.getSchoolYearId();
        }

        public void addMisc(string details,double price,string grade)
        {
            string sql = String.Format(@"INSERT INTO misc_fee (details,price,grade_level,SY_ID) VALUES('{0}',{1},'{2}',{3})",
                                        details, price, grade, syid);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridMisc(ref DataGridView dg,string grade)
        {
            string sql = String.Format(@"SELECT miscfee_id,grade_level,details,price FROM misc_fee WHERE SY_ID = {0} AND grade_level = '{1}'", syid,grade);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridAllMisc(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT miscfee_id,grade_level,details,price FROM misc_fee WHERE SY_ID = {0} ", syid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void updateMisc(string details, double price, string grade,int id)
        {
            string sql = String.Format(@"UPDATE misc_fee SET details = '{0}', price = {1}, grade_level = '{2}' 
                                           WHERE miscfee_id = {3}", details, price, grade, id);

            cs.ExecuteQuery(sql);
        }


        public float getMiscFeeForGrade(string grade)
        {
            float fee = 0;

            string sql = String.Format(@"SELECT * FROM misc_fee WHERE grade_level = '{0}' AND SY_ID = {1}",
                                        grade, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                fee = fee + float.Parse(reader["price"].ToString());
            }
            cs.CloseConnection();

            return fee;
        }

        public string getInfoMiscForGrade(string grade)
        {
            string infos = "";
            string sql = String.Format(@"SELECT * FROM misc_fee WHERE grade_level = '{0}' AND SY_ID = {1}",
                                        grade, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                infos = infos + "Detail : " + reader["details"].ToString() + " - ₱ " + reader["price"].ToString() + "\n";
            }
            cs.CloseConnection();
            return infos;
        }

        public void RemoveMisc(int id)
        {
            string sql = String.Format(@"DELETE FROM misc_fee WHERE miscfee_id = {0}", id);

            cs.ExecuteQuery(sql);
        }
    }
}
