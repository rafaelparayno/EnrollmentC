using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class SchedSectionController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        int syid = 0;
        public SchedSectionController()
        {
            syid = yearController.getSchoolYearId();
        }


        public void saveSchedSection(int ts_id,int sub_id,int teacher_id,int room_id,int sect_id)
        {
            string sql = String.Format(@"INSERT INTO `sched_section`(`timestamp_id`, `subject_id`, `teacher_ID`, `classroom_id`, `sect_id`, `SY_id`) VALUES ({0},{1},{2},{3},{4},{5})",
                                        ts_id, sub_id, teacher_id, room_id, sect_id, syid);

            cs.ExecuteQuery(sql);
        }

        public void fillListSched(ref ListView lv,int sect_id)
        {
            string sql = String.Format(@"SELECT timestamp.start_time,timestamp.end_time,subjects.subject_name,CONCAT(useraccounts.Firstname,' ',useraccounts.Lastname) AS 'Teachers Name' FROM `sched_section` LEFT JOIN timestamp ON sched_section.timestamp_id = timestamp.timestamp_id LEFT JOIN subjects ON sched_section.subject_id = subjects.subject_id LEFT JOIN specialization ON sched_section.teacher_ID = specialization.teacher_ID LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE sched_section.sect_id = {0}",
                                        sect_id);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                ListViewItem lvs = new ListViewItem();
                lvs.Text = reader["start_time"].ToString();
                lvs.SubItems.Add(reader["end_time"].ToString());
                lvs.SubItems.Add(reader["subject_name"].ToString());
                lvs.SubItems.Add(reader["Teachers Name"].ToString());

                lv.Items.Add(lvs);
            }

            cs.CloseConnection();
        }
    }
}
