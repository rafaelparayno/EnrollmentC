using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class StudentEnrolledController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        int syid = 0;
        public StudentEnrolledController()
        {
            syid = yearController.getSchoolYearId();
        }

        public void addEnrolledStudents(string sno,string grade,int sectid)
        {
            string sql = String.Format(@"INSERT INTO `studentenrolledinfo`(`sno`, `grade_level`, `sect_id`, `is_Enrolled`, `sy_id`) VALUES ('{0}','{1}',{2},{3},{4})",
                                        sno, grade, sectid, 0, syid);

            cs.ExecuteQuery(sql);

        }

        public int getSchedId(string sno) 
        {
            int id = 0;
            string sql = String.Format(@"SELECT * FROM studentenrolledinfo WHERE sno = '{0}' AND sy_id = {1}", sno,syid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                id = int.Parse(reader["sect_id"].ToString());
            }
            cs.CloseConnection();

            return id;

        }


        public string [] getDataAll(string sno)
        {
            string[] datas = new string[4];

            string sql = String.Format(@"SELECT * FROM studentenrolledinfo WHERE sno = '{0}' AND sy_id = {1} ", sno,syid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                datas[0] = reader["grade_level"].ToString();
                datas[1] = reader["sect_id"].ToString();
                datas[2] = reader["is_Enrolled"].ToString();
                datas[3] = reader["sy_id"].ToString();
            }
            cs.CloseConnection();

            return datas;
        }

        public void updateSectionGrade(string sno,string grade,int sectid)
        {
            string sql = String.Format(@"UPDATE studentenrolledinfo SET sect_id = {0},grade_level ='{1}' WHERE sno = '{2}'", sectid,grade, sno);

            cs.ExecuteQuery(sql);
        }

        public void updateEnrolled(string sno)
        {
            string sql = String.Format(@"UPDATE studentenrolledinfo SET is_Enrolled = 1 WHERE sno = '{0}'", sno);

            cs.ExecuteQuery(sql);
        }

        public string getLastGraDe(string sno)
        {
            string grade = "";
            string sql = String.Format(@"SELECT * FROM `studentenrolledinfo` 
                                    WHERE sno  = '{0}'
                                    ORDER BY `studentenrolledinfo`.`sy_id` DESC",sno);
            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                grade = reader["grade_level"].ToString();
            }

            cs.CloseConnection();
            return grade;
        }
    }
}
