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
            string sql = String.Format(@"SELECT * FROM `teacher_sched` WHERE ss_id in(SELECT ss_id FROM sched_section WHERE timestamp_id in(SELECT timestamp_id FROM timestamp WHERE start_time <= '{0}' AND end_time > '{1}')) AND teacher_ID = {2} AND SY_id = {3}"
                                        ,te,ts, teacher_id,yearSyid);
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
