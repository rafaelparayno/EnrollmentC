using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
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
            string sql = String.Format(@"SELECT timestamp.start_time,timestamp.end_time,subjects.subject_name,CONCAT(useraccounts.Firstname,' ',useraccounts.Lastname) AS 'Teachers Name' 
                                        FROM `sched_section` LEFT JOIN timestamp ON sched_section.timestamp_id = timestamp.timestamp_id 
                                        LEFT JOIN subjects ON sched_section.subject_id = subjects.subject_id 
                                        LEFT JOIN specialization ON sched_section.teacher_ID = specialization.teacher_ID 
                                        LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id 
                                        WHERE sched_section.sect_id = {0} AND sched_section.SY_id = {1}",
                                        sect_id,syid);

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

        public int[] fillListSched2(ref ListView lv, int sect_id)
        {

            int[] ids;
            int count = 0;
            string sql = String.Format(@"SELECT ss_id,timestamp.start_time,timestamp.end_time,subjects.subject_name,
                                        CONCAT(useraccounts.Firstname,' ',useraccounts.Lastname) AS 'Teachers Name' FROM `sched_section` 
                                        LEFT JOIN timestamp ON sched_section.timestamp_id = timestamp.timestamp_id 
                                        LEFT JOIN subjects ON sched_section.subject_id = subjects.subject_id 
                                        LEFT JOIN specialization ON sched_section.teacher_ID = specialization.teacher_ID 
                                        LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id 
                                        WHERE sched_section.sect_id = {0} AND sched_section.SY_id = {1}",
                                        sect_id, syid);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                ListViewItem lvs = new ListViewItem();
                lvs.Text = reader["start_time"].ToString();
                lvs.SubItems.Add(reader["end_time"].ToString());
                lvs.SubItems.Add(reader["subject_name"].ToString());
                lvs.SubItems.Add(reader["Teachers Name"].ToString());
                //lvs.SubItems.Add(reader["Class Room"].ToString());
                lv.Items.Add(lvs);
                count++;
            }
           
            cs.CloseConnection();
            ids = new int[count];
            reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                ids[i] = int.Parse(reader["ss_id"].ToString());
                i++;
            }
            cs.CloseConnection();
            return ids;
        }

        public void fillListTeachSched(ref ListView lv, int teacher_id)
        {
            string sql = String.Format(@"SELECT timestamp.start_time,timestamp.end_time,subjects.subject_name,Concat(classroom_type.name,' ',classroom.classroom_no) AS 'Class Room',
                                        sections.section_name,sections.grade_level FROM `sched_section` 
                                        LEFT JOIN timestamp ON sched_section.timestamp_id = timestamp.timestamp_id 
                                        LEFT JOIN subjects ON sched_section.subject_id = subjects.subject_id 
                                        LEFT JOIN classroom ON sched_section.classroom_id = classroom.classroom_id 
                                        LEFT JOIN classroom_type ON classroom.classroom_type = classroom_type.classroom_type_id
                                        LEFT JOIN sections ON sched_section.sect_id = sections.sect_id 
                                        WHERE sched_section.teacher_ID = {0} AND sched_section.SY_id = {1} ORDER BY timestamp.start_time",
                                        teacher_id,syid);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                ListViewItem lvs = new ListViewItem();
                lvs.Text = reader["start_time"].ToString();
                lvs.SubItems.Add(reader["end_time"].ToString());
                lvs.SubItems.Add(reader["subject_name"].ToString());
                lvs.SubItems.Add(reader["Class Room"].ToString());
                lvs.SubItems.Add(reader["section_name"].ToString());
                lvs.SubItems.Add(reader["grade_level"].ToString());
                lv.Items.Add(lvs);
            
            }
        
            cs.CloseConnection();


        }

        public void fillListTeachSched2(ref ListView lv, int teacher_id,string grade_level)
        {
           
            string sql = String.Format(@"SELECT ss_id,timestamp.start_time,timestamp.end_time,subjects.subject_name,Concat(classroom_type.name,' ',classroom.classroom_no) AS 'Class Room',
                                        sections.section_name,sections.grade_level FROM `sched_section` 
                                        LEFT JOIN timestamp ON sched_section.timestamp_id = timestamp.timestamp_id 
                                        LEFT JOIN subjects ON sched_section.subject_id = subjects.subject_id 
                                        LEFT JOIN classroom ON sched_section.classroom_id = classroom.classroom_id 
                                        LEFT JOIN classroom_type ON classroom.classroom_type = classroom_type.classroom_type_id
                                        LEFT JOIN sections ON sched_section.sect_id = sections.sect_id 
                                        WHERE sched_section.teacher_ID = {0} AND sched_section.SY_id = {1} AND sections.grade_level = '{2}'",
                                        teacher_id, syid,grade_level);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                ListViewItem lvs = new ListViewItem();
                lvs.Text = reader["start_time"].ToString();
                lvs.SubItems.Add(reader["end_time"].ToString());
                lvs.SubItems.Add(reader["subject_name"].ToString());
                lvs.SubItems.Add(reader["Class Room"].ToString());
                lvs.SubItems.Add(reader["section_name"].ToString());
                lvs.SubItems.Add(reader["grade_level"].ToString());
                lv.Items.Add(lvs);
              
            }
           
            cs.CloseConnection();


        }

        public string roomname(int sect_ids)
        {
            string name = "";
            string sql = String.Format(@"SELECT Concat(classroom_type.name,' ',classroom.classroom_no) AS 'ClassRoom' FROM sched_section 
                                        LEFT JOIN classroom ON sched_section.classroom_id = classroom.classroom_id 
                                        LEFT JOIN classroom_type ON classroom.classroom_type = classroom_type.classroom_type_id 
                                        WHERE sched_section.sect_id = {0}", sect_ids);
            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                name = reader["ClassRoom"].ToString();
            }


            cs.CloseConnection();
            return name;
        }

        public void deleteSchedSection(int sect_ids)
        {
            string sql = String.Format(@"DELETE FROM sched_section WHERE sect_id = {0} AND SY_id = {1}", sect_ids, syid);

            cs.ExecuteQuery(sql);

        }
    }
}
