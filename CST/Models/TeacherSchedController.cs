using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class TeacherSchedController
    {
        crudFile cs = new crudFile();
        YearController yr = new YearController();
        int yearSyid = 0;

        public TeacherSchedController()
        {
            yearSyid = yr.getSchoolYearId();
        }

        public bool isConflictWithTheTime(string te,string ts, int teacher_id)
        {
            bool isConflict = false;
            string sql = String.Format(@"SELECT * FROM `sched_section` WHERE teacher_ID = {0} AND SY_id = {1} 
                                        AND timestamp_id in 
                                        (SELECT timestamp_id  FROM timestamp WHERE start_time < '{2}' AND end_time > '{3}')"
                                        , teacher_id,yearSyid, te,ts);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                isConflict = true;
            }

            cs.CloseConnection();

            return isConflict;
        }
    }
}
