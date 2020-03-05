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
            string sql = String.Format(@"INSERT INTO student_detail(`sno`,`firstname`,`lastname`,`middlename`,`gender`,`age`,`birthdate`,`pob`,`contact_no`,`nationality`,`religion`,`address`,`isEnrolled`,`sy_id`) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','not yet',{12})",
                                        arrDetails[0], arrDetails[1], arrDetails[2], arrDetails[3], arrDetails[4], arrDetails[5], arrDetails[6], arrDetails[7], arrDetails[8],
                                        arrDetails[9], arrDetails[10], arrDetails[11], syid);
      
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

        public void fillDataGridDetails(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT  `sno`, `firstname`, `lastname`, `middlename`, `gender`, `age`, `birthdate`, `pob`, `contact_no`, `nationality`, `religion`, `address`, `grade_level` FROM student_detail WHERE isEnrolled = 'enrolled'");

            cs.FillDataGrid(sql, ref dg);
        }
    }
}
