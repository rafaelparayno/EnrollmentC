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

        public void updateSection(string sno,string sectid)
        {
            string sql = String.Format(@"UPDATE studentenrolledinfo SET sect_id = {0} WHERE sno = '{1}'", sectid, sno);

            cs.ExecuteQuery(sql);
        }

        public void updateEnrolled(string sno)
        {
            string sql = String.Format(@"UPDATE studentenrolledinfo SET is_Enrolled = 1 WHERE sno = '{0}'", sno);

            cs.ExecuteQuery(sql);
        }
    }
}
