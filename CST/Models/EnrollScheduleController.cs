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
                string sql = String.Format(@"INSERT INTO `enrollment_schedule`(`start_date`, `end_date`, `SY_id`) VALUES('{0}','{1}',{2})", sd, ed, syid);

                cs.ExecuteQuery(sql);

            }
            else
            {
                MessageBox.Show("This School Year Has Already An Schedule", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
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


    }
}
