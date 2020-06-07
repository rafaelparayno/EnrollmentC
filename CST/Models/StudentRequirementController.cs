using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public void fillGridReq(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT student_req_id AS 'Pass_id' ,requirement_name,
                                        students_requirement.type_of_student,Concat(firstname,' ',lastname) AS 'Student name' 
                                        FROM students_requirement LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN  school_requirements ON school_requirements.req_id = students_requirement.req_id ");

            cs.FillDataGrid(sql, ref dg);
        }

        public void SearchGrid(ref DataGridView dg,string searchKey)
        {
          

            string sql = String.Format(@"SELECT student_req_id AS 'Pass_id' ,requirement_name,students_requirement.type_of_student,
                                        Concat(firstname,' ',lastname) AS 'Student name' FROM students_requirement 
                                        LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN  school_requirements ON school_requirements.req_id = students_requirement.req_id 
                                        WHERE students_requirement.student_no = '{0}'",
                    searchKey);

            cs.FillDataGrid(sql, ref dg);
            
        }

        public void searchName(ref DataGridView dg, string name)
        {
            string sql = String.Format(@"SELECT student_req_id AS 'Pass_id' ,requirement_name,students_requirement.type_of_student, 
                                        Concat(firstname,' ',lastname) AS 'Studentname' FROM students_requirement 
                                        LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN school_requirements ON school_requirements.req_id = students_requirement.req_id 
                                        WHERE Concat(firstname,' ',lastname) LIKE '%{0}%'", name);

            cs.FillDataGrid(sql, ref dg);
        }
        
        public bool findSame(string sno,int req)
        {
            string sql = String.Format(@"SELECT * FROM students_requirement WHERE student_no = '{0}' AND req_id ={1}", sno, req);

            MySqlDataReader reader = null;
            bool found = false;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                found = true;
            }

            cs.CloseConnection();

            return found;
        }

        public void removeReq(int id)
        {
            string sql = String.Format(@"DELETE FROM students_requirement WHERE `student_req_id` = {0}", id);
            cs.ExecuteQuery(sql);
        }

    }
}
