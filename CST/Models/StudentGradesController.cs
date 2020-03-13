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
                MessageBox.Show("Student have already Grade", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        
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
    }
}
