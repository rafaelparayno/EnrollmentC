using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{

    class StudentGradesController
    {
        crudFile cs = new crudFile();
        YearController yr = new YearController();
        int syid = 0;
        public StudentGradesController()
        {
            syid = yr.getSchoolYearId();

        }

        public void fillDataGridGrades(ref DataGridView dg, int section_id, int sub_id, int teacher_id)
        {
            string sql = String.Format(@"SELECT student_grades.sno AS 'Student No', Concat(firstname,' ',middlename,' ', lastname) AS 'Student Name', 
                        student_grades.grade_first As '1st Grading',student_grades.grade_second As '2nd Grading',
                        student_grades.grade_third '3rd Grading',student_grades.grade_fourth AS '4th Grading', avg as 'Average' 
                        FROM `student_grades` LEFT JOIN student_detail ON student_grades.sno = student_detail.sno WHERE student_grades.sect_id = {0} 
                        AND subject_id = {1} AND teacher_ID = {2} AND student_grades.SY_ID = {3} ",section_id,sub_id,teacher_id,syid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillLisdViewTeacher(ref ListView lv, int section_id, int sub_id, int teacher_id)
        {
            string sql = String.Format(@"SELECT student_detail.sno AS 'StudentNo', Concat(firstname,' ',middlename,' ', lastname) AS 'StudentName', 
                        student_grades.grade_first,student_grades.grade_second,
                        student_grades.grade_third,student_grades.grade_fourth, avg
                        FROM student_detail 
                        LEFT JOIN student_grades on student_grades.sno  = student_detail.sno 
                        AND student_grades.subject_id = {0} AND student_grades.teacher_ID = {1}
                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno 
                        WHERE studentenrolledinfo.sect_id = {2} AND studentenrolledinfo.is_Enrolled = 1", sub_id, teacher_id, section_id);
            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                string gradefirst = reader["grade_first"].ToString() == "" ? "0" : reader["grade_first"].ToString();
                string gradesecond = reader["grade_second"].ToString() == "" ? "0" : reader["grade_second"].ToString();
                string gradethird = reader["grade_third"].ToString() == "" ? "0" : reader["grade_third"].ToString();
                string gradefourth = reader["grade_fourth"].ToString() == "" ? "0" : reader["grade_fourth"].ToString();
                string avg = reader["avg"].ToString() == "" ? "0" : reader["avg"].ToString();

                ListViewItem lvs = new ListViewItem();
                lvs.Text = reader["StudentNo"].ToString();
                lvs.SubItems.Add(reader["StudentName"].ToString());
                lvs.SubItems.Add(gradefirst);
                lvs.SubItems.Add(gradesecond);
                lvs.SubItems.Add(gradethird);
                lvs.SubItems.Add(gradefourth);
                lvs.SubItems.Add(avg);

                lv.Items.Add(lvs);
            }

            cs.CloseConnection();

        }


        public void fillLvGrades(ref ListView lv,int syid,string sno)
        {
            string sql = String.Format(@"SELECT student_detail.sno,CONCAT(student_detail.firstname,' ',student_detail.lastname) AS 'StudentName',
                                         CONCAT(useraccounts.Firstname,' ' ,useraccounts.Lastname) AS 'TeacherName',
                                         subject_name,avg,studentenrolledinfo.grade_level FROM student_grades
                                         LEFT JOIN student_detail on student_detail.sno  = '{1}'
                                         LEFT JOIN subjects ON student_grades.subject_id = subjects.subject_id
                                         LEFT JOIN specialization ON student_grades.teacher_ID = specialization.teacher_ID
                                         LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id
                                         LEFT JOIN studentenrolledinfo ON studentenrolledinfo.sno = '{1}'
                                         AND studentenrolledinfo.sy_id = {0}
                                         WHERE student_grades.sno = '{1}' AND student_grades.SY_ID = {0}", syid,sno);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                
                string avg = reader["avg"].ToString() == "" ? "0" : reader["avg"].ToString();

                ListViewItem lvs = new ListViewItem();
                lvs.Text = reader["sno"].ToString();
                lvs.SubItems.Add(reader["StudentName"].ToString());
                lvs.SubItems.Add(reader["TeacherName"].ToString());
                lvs.SubItems.Add(reader["subject_name"].ToString());
                lvs.SubItems.Add(avg);
                lvs.SubItems.Add(reader["grade_level"].ToString());

                lv.Items.Add(lvs);
            }

            cs.CloseConnection();
        }

        public void addStudentGrade(string sno,double g1,double g2,
                                    double g3,double g4,double avg,
                                    int subj,int section,int teacher_id)
        {

            if (Check(sno, subj, section, teacher_id))
            {
                string sql = String.Format(@"INSERT INTO `student_grades`(`sno`, `grade_first`, `grade_second`,
                                        `grade_third`, `grade_fourth`, `avg`, `subject_id`, `sect_id`, `teacher_ID`, `SY_ID`) 
                                        VALUES ('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9})",
                                 sno, g1, g2, g3, g4, avg, subj, section, teacher_id, syid);

                cs.ExecuteQuery(sql);
            }
            else
            {
                updateStudentGrade(sno, g1, g2, g3, g4, avg, subj, section, teacher_id);
             
            }
      
        
        }

        public void deleteGrade(string sno,int subj,int section,int teacher_id)
        {
            string sql = String.Format(@"DELETE FROM `student_grades` WHERE sno = '{0}' AND subject_id = {1} AND sect_id = {2} AND teacher_ID = {3} AND SY_ID = {4}"
                                        , sno, subj, section, teacher_id,syid);
         
            cs.ExecuteQuery(sql);
        }

        public void updateStudentGrade(string sno, double g1, double g2,
                                    double g3, double g4, double avg,
                                    int subj, int section, int teacher_id)
        {
            string sql = String.Format(@"UPDATE `student_grades` SET `grade_first`={0},`grade_second`={1},`grade_third`={2},`grade_fourth`={3},`avg`={4} 
                                        WHERE `subject_id`={5} AND`sect_id`={6} AND `teacher_ID`={7} AND  `SY_ID`={8} AND `sno`='{9}'",
                                        g1, g2, g3, g4, avg, subj, section, teacher_id, syid, sno);
        
            cs.ExecuteQuery(sql);
        }

        private bool Check(string sno,int sub,int sect,int teac)
        {
            bool isValid = true;

            string sql = String.Format(@"SELECT * FROM student_grades WHERE sno = '{0}' AND subject_id = {1} AND sect_id = {2} AND teacher_ID = {3} AND SY_ID = {4}",
                                          sno, sub, sect, teac, syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                isValid = false;
            }

            cs.CloseConnection();
            return isValid;
        }

        public int getTotalFailed(string sno,int syid)
        {
            int total = 0;

            string sql = String.Format(@"SELECT COUNT(studentgrade_id) AS 'failedcount' 
                                        FROM `student_grades` 
                                        WHERE avg <75 AND sno = '{0}' AND SY_ID = {1}", sno,syid);
            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                total = int.Parse(reader["failedcount"].ToString());
            }
            cs.CloseConnection();
            //
            return total;
        }
    }
}
