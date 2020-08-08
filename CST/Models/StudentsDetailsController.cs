using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class StudentsDetailsController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        private int syid = 0;
        public StudentsDetailsController()
        {
            syid = yearController.getSchoolYearId();
        }

        public void addStudDetails(string []arrDetails)
        {
            string sql = String.Format(@"INSERT INTO student_detail(`sno`,`firstname`,`lastname`,`middlename`,`gender`,`age`,
                                        `birthdate`,`pob`,`contact_no`,`nationality`,`religion`,`address`,`studentype`) 
                                        VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                                        arrDetails[0], arrDetails[1], arrDetails[2], arrDetails[3], arrDetails[4], arrDetails[5], arrDetails[6], arrDetails[7], arrDetails[8],
                                        arrDetails[9], arrDetails[10], arrDetails[11],arrDetails[12]);
      
            cs.ExecuteQuery(sql);
        }

        public int getRecentStudentId()
        {
            string sql = String.Format(@"SELECT AUTO_INCREMENT as Last_id FROM information_schema.TABLES WHERE TABLE_NAME = 'student_detail'");
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int last_id = 0;
            if (reader.Read())
            {
                last_id = int.Parse(reader["Last_id"].ToString());
            }
            cs.CloseConnection();
            return last_id;
        }

        public void updateStudDetails(string fn,string ln,string mn,string gen,int age,string bd,string pob, string cn,string nat,string rel,string add,string sno)
        {
            string sql = String.Format(@"UPDATE `student_detail` SET `firstname`='{0}',`lastname`='{1}',`middlename`='{2}',`gender`='{3}',`age`={4},`birthdate`='{5}',`pob`='{6}',`contact_no`='{7}',`nationality`='{8}',`religion`='{9}',`address`='{10}' WHERE sno = '{11}'",
                                        fn,ln,mn,gen,age,bd,pob,cn,nat,rel,add,sno);
            cs.ExecuteQuery(sql);
        }

        public void updateStudDetails2(string fn, string ln, string mn, string gen, int age, string bd, string pob, string cn, string nat, string rel, string add,string studtype ,string sno)
        {
            string sql = String.Format(@"UPDATE `student_detail` SET `firstname`='{0}',`lastname`='{1}',`middlename`='{2}',
                                        `gender`='{3}',`age`={4},`birthdate`='{5}',`pob`='{6}',`contact_no`='{7}',
                                        `nationality`='{8}',`religion`='{9}',`address`='{10}',
                                        `studentype` = '{11}' WHERE sno = '{12}'",
                                        fn, ln, mn, gen, age, bd, pob, cn, nat, rel, add, studtype, sno);
         
            cs.ExecuteQuery(sql);
        }

        public void fillDataGridDetails(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT  studentenrolledinfo.`sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, 
                                        `pob`, `contact_no`, `nationality`, `religion`, `address`,studentenrolledinfo.grade_level FROM student_detail 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sy_id = {0} AND studentenrolledinfo.is_Enrolled = 1", syid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridDetails(ref DataGridView dg,int yrid)
        {
            string sql = String.Format(@"SELECT  studentenrolledinfo.`sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, 
                                        `pob`, `contact_no`, `nationality`, `religion`, `address`,studentenrolledinfo.grade_level FROM student_detail 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sy_id = {0} AND studentenrolledinfo.is_Enrolled = 1", yrid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridDetails(ref DataGridView dg, int yrid,string grade)
        {
            string sql = String.Format(@"SELECT  studentenrolledinfo.`sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, 
                                        `pob`, `contact_no`, `nationality`, `religion`, `address`,studentenrolledinfo.grade_level FROM student_detail 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sy_id = {0} AND studentenrolledinfo.grade_level = '{1}' AND studentenrolledinfo.is_Enrolled = 1", yrid,grade);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridDetails(ref DataGridView dg, string sno)
        {
            string sql = String.Format(@"SELECT  studentenrolledinfo.`sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, 
                                        `pob`, `contact_no`, `nationality`, `religion`, `address` FROM student_detail 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sno = '{0}' AND studentenrolledinfo.is_Enrolled = 1 AND studentenrolledinfo.sy_id = {1}", sno,syid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridDetailsNotEnrolled(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT  studentenrolledinfo.`sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, 
                                        `pob`, `contact_no`, `nationality`, `religion`, `address` FROM student_detail 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sy_id = {0} AND studentenrolledinfo.is_Enrolled = 0", syid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridDetailsNotEnrolledWithSno(ref DataGridView dg,string sno)
        {
            string sql = String.Format(@"SELECT studentenrolledinfo.`sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, 
                                        `pob`, `contact_no`, `nationality`, `religion`, `address` FROM student_detail 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE  studentenrolledinfo.`sno` = '{0}' AND studentenrolledinfo.sy_id = {1} AND studentenrolledinfo.is_Enrolled = 0", sno ,syid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridDetailsInSection(ref DataGridView dg,int section_id)
        {
            string sql = String.Format(@"SELECT student_detail.sno,CONCAT(firstname,' ',lastname) AS 'Stutdent Name',studentenrolledinfo.grade_level FROM `studentenrolledinfo` 
                                        LEFT JOIN student_detail on studentenrolledinfo.sno = student_detail.sno 
                                        WHERE studentenrolledinfo.`sect_id`= {0} AND studentenrolledinfo.is_Enrolled = 1",
                                        section_id);

            cs.FillDataGrid(sql, ref dg);
        }

        public string searchName(string sno)
        {
            string name = "";
            string sql = String.Format(@"SELECT Concat(firstname, ' ', lastname ) as Fullname FROM student_detail WHERE sno = '{0}'", "STUD-" +sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                name = reader["Fullname"].ToString();
            }

            cs.CloseConnection();

            return name;
        }

        public string searchStudType(string sno)
        {
            string type = "";
            string sql = String.Format(@"SELECT studentype FROM student_detail WHERE sno = '{0}'", "STUD-" +sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                type = reader["studentype"].ToString();
            }

            cs.CloseConnection();

            return type;
        }

        public string searchStudInSection(string sno,int section_id)
        {
            string name = "";
            string sql = String.Format(@"SELECT Concat(firstname, ' ', lastname ) as Fullname FROM student_detail 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sect_id = {0} AND studentenrolledinfo.sno = '{1}' 
                                        AND studentenrolledinfo.sy_id = {2}", section_id,sno,syid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                name = reader["Fullname"].ToString();
            }

            cs.CloseConnection();

            return name;
        }

        public string[] searchAllDetails(string sno)
        {
            string[] details = new string[13];
            string sql = String.Format(@"SELECT * FROM student_detail WHERE sno = '{0}' ", sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {
                details[0] = reader["firstname"].ToString();
                details[1] = reader["lastname"].ToString();
                details[2] = reader["middlename"].ToString();
                details[3] = reader["gender"].ToString();
                details[4] = reader["age"].ToString();
                details[5] = reader["birthdate"].ToString();
                details[6] = reader["pob"].ToString();
                details[7] = reader["contact_no"].ToString();
                details[8] = reader["nationality"].ToString();
                details[9] = reader["lastname"].ToString();
                details[10] = reader["religion"].ToString();
                details[11] = reader["address"].ToString();
               // details[12] = reader["grade_level"].ToString();
           

            }

            cs.CloseConnection();
            return details;
        }

        public string [] searchEnrollment(string sno,int syid)
        {
            string[] details = new string[13];
            string sql = String.Format(@"SELECT student_detail.sno, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, `pob`, `contact_no`, 
                                        `nationality`, `religion`, `address`, studentenrolledinfo.`grade_level`, studentenrolledinfo.sect_id FROM `student_detail` 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sy_id = {0} AND studentenrolledinfo.sno = '{1}' AND studentenrolledinfo.is_Enrolled = 0",
                                        syid, sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {
                details[0] = reader["firstname"].ToString();
                details[1] = reader["lastname"].ToString();
                details[2] = reader["middlename"].ToString();
                details[3] = reader["gender"].ToString();
                details[4] = reader["age"].ToString();
                details[5] = reader["birthdate"].ToString();
                details[6] = reader["pob"].ToString();
                details[7] = reader["contact_no"].ToString();
                details[8] = reader["nationality"].ToString();
                details[9] = reader["lastname"].ToString();
                details[10] = reader["religion"].ToString();
                details[11] = reader["address"].ToString();
                details[12] = reader["grade_level"].ToString();


            }

            cs.CloseConnection();

            return details;
        }

        public string[] searchEnrollment(string sno)
        {
            string[] details = new string[13];
            string sql = String.Format(@"SELECT student_detail.`sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, `pob`, `contact_no`, `nationality`, 
                                        `religion`, `address`, studentenrolledinfo.`grade_level`, studentenrolledinfo.sect_id FROM `student_detail` 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno AND sy_id = {0} 
                                        WHERE student_detail.sno = '{1}'", syid, sno);
            MySqlDataReader reader = null;
      
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {

                details[0] = reader["sno"].ToString();
                details[1] = reader["firstname"].ToString();
                details[2] = reader["lastname"].ToString();
                details[3] = reader["middlename"].ToString();
                details[4] = reader["gender"].ToString();
                details[5] = reader["age"].ToString();
                details[6] = reader["birthdate"].ToString();
                details[7] = reader["pob"].ToString();
                details[8] = reader["contact_no"].ToString();
                details[9] = reader["nationality"].ToString();
                details[10] = reader["religion"].ToString();
                details[11] = reader["address"].ToString();
                details[12] = reader["grade_level"].ToString();
            }

            cs.CloseConnection();
          
            return details;
        }


        public string[] searchAllDetails2(string sno)
        {
            string[] details = new string[13];
            string sql = String.Format(@"SELECT student_detail.sno, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, `pob`, `contact_no`, 
                                        `nationality`, `religion`, `address`, studentenrolledinfo.`grade_level`, studentenrolledinfo.sect_id FROM `student_detail` 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sy_id = {0} AND studentenrolledinfo.sno = '{1}'", syid,sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {
           
                details[0] = reader["sno"].ToString();
                details[1] = reader["firstname"].ToString();
                details[2] = reader["lastname"].ToString();
                details[3] = reader["middlename"].ToString();
                details[4] = reader["gender"].ToString();
                details[5] = reader["age"].ToString();
                details[6] = reader["birthdate"].ToString();
                details[7] = reader["pob"].ToString();
                details[8] = reader["contact_no"].ToString();
                details[9] = reader["nationality"].ToString();
                details[10] = reader["religion"].ToString();
                details[11] = reader["address"].ToString();
                details[12] = reader["grade_level"].ToString();
            }

            cs.CloseConnection();
            return details;
        }


        public string[] searchAllDetails2(string sno,int yrid)
        {
            string[] details = new string[13];
            string sql = String.Format(@"SELECT student_detail.sno, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, `pob`, `contact_no`, 
                                        `nationality`, `religion`, `address`, studentenrolledinfo.`grade_level`, studentenrolledinfo.sect_id FROM `student_detail` 
                                        LEFT JOIN studentenrolledinfo ON student_detail.sno = studentenrolledinfo.sno
                                        WHERE studentenrolledinfo.sy_id = {0} AND studentenrolledinfo.sno = '{1}'", yrid, sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {

                details[0] = reader["sno"].ToString();
                details[1] = reader["firstname"].ToString();
                details[2] = reader["lastname"].ToString();
                details[3] = reader["middlename"].ToString();
                details[4] = reader["gender"].ToString();
                details[5] = reader["age"].ToString();
                details[6] = reader["birthdate"].ToString();
                details[7] = reader["pob"].ToString();
                details[8] = reader["contact_no"].ToString();
                details[9] = reader["nationality"].ToString();
                details[10] = reader["religion"].ToString();
                details[11] = reader["address"].ToString();
                details[12] = reader["grade_level"].ToString();
            }

            cs.CloseConnection();
            return details;
        }

    }
}
