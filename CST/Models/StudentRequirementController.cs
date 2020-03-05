using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class StudentRequirementController
    {
        crudFile cs = new crudFile();
        public StudentRequirementController()
        {

        }

        public void addStudentReq(string sno,string type_of_student,int req_id)
        {
            string sql = String.Format(@"INSERT INTO `students_requirement`(`student_no`, `type_of_student`, `req_id`) VALUES ('{0}','{1}',{2})",
                                        sno, type_of_student, req_id);
            cs.ExecuteQuery(sql);
        }
    }
}
