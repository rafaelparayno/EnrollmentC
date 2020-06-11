using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class EnrollScheduleController
    {
        crudFile cs = new crudFile();
        YearController yrController = new YearController();
        int syid = 0;
        public EnrollScheduleController()
        {
            syid = yrController.getSchoolYearId();
        }

        public void addEnrollmentSchedul(string sd,string ed)
        {
            if (isEnrollmentCurrentlyExists())
            {
                string sql = String.Format(@"INSERT INTO `enrollment_schedule`(`start_date`, `end_date`, is_open ,`SY_id`) VALUES('{0}','{1}',0,{2})", sd, ed, syid);

                cs.ExecuteQuery(sql);

            }
            else
            {
                updateEnrollmentSchedule(sd, ed);
              
            }
           
        }

        public int getStatusEnrollment()
        {
            int status = 0;
            string sql = String.Format(@"SELECT is_open FROM enrollment_schedule WHERE SY_id = {0}", syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                status = int.Parse(reader["is_open"].ToString());
            }
            cs.CloseConnection();

            return status;
        }


        private void updateEnrollmentSchedule(string sd,string ed)
        {
            string sql = String.Format(@"UPDATE enrollment_schedule SET start_date = '{0}', end_date = '{1}' WHERE SY_id = {2} ", sd, ed, syid);
            cs.ExecuteQuery(sql);
        }

        private bool isEnrollmentCurrentlyExists()
        {
            bool isValid = true;
            MySqlDataReader reader = null;
            string sql = String.Format(@"SELECT * FROM enrollment_schedule WHERE SY_id = {0}", syid);

            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                isValid = false;
            }
            cs.CloseConnection();
            return isValid;
        }

        public void fillDataEnrolSched(ref DataGridView dg)
        {
            string sql = "SELECT school_year,start_date,end_date FROM `enrollment_schedule` LEFT JOIN school_year ON enrollment_schedule.SY_id = school_year.id";

            cs.FillDataGrid(sql, ref dg);
        }

        public string [] getEnrollSched()
        {
            string[] data = new string[4];

            string sql = String.Format(@"SELECT  school_year,start_date,end_date,is_open FROM enrollment_schedule 
                                        LEFT JOIN school_year ON enrollment_schedule.SY_id = school_year.id 
                                        WHERE enrollment_schedule.SY_id = {0}",syid);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                data[0] = reader["school_year"].ToString();
                data[1] = reader["start_date"].ToString();
                data[2] = reader["end_date"].ToString();
                data[3] = reader["is_open"].ToString();
            }

            cs.CloseConnection();
            return data;
        }

        public void updateCloseEn()
        {
            string sql = String.Format(@"UPDATE enrollment_schedule SET is_open = 0 WHERE SY_id = {0} ",  syid);
            cs.ExecuteQuery(sql);
        }


        public void updateOpenEn()
        {
            string sql = String.Format(@"UPDATE enrollment_schedule SET is_open = 1 WHERE SY_id = {0} ", syid);
            cs.ExecuteQuery(sql);
        }


    }
}
