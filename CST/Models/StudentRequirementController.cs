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

        public void addStudentReq(string sno,int req_id)
        {
            string sql = String.Format(@"INSERT INTO `students_requirement`(`student_no`, `req_id`) VALUES ('{0}',{1})",
                                        sno, req_id);
            cs.ExecuteQuery(sql);
        }

        public void fillGridReq(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT student_req_id AS 'Requirement ID' ,requirement_name  As 'Requirements', student_detail.sno,Concat(firstname,' ',lastname) AS 'Student name' 
                                        FROM students_requirement LEFT JOIN student_detail ON students_requirement.student_no = student_detail.sno 
                                        LEFT JOIN  school_requirements ON school_requirements.req_id = students_requirement.req_id ");

            cs.FillDataGrid(sql, ref dg);
        }


        public void RawQuery(ref DataGridView dg, string sql)
        {
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
