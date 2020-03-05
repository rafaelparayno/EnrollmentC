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
    }
}
