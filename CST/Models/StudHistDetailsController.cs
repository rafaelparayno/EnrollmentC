using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class StudHistDetailsController
    {
        crudFile cs = new crudFile();
       public StudHistDetailsController()
        {

        }

        public void addHisDetails(string sno,string pastNameSchool,string pastAddSchool,string past_level,string year_attended,string isComplete,string vacine_details)
        {
            string sql = String.Format(@"INSERT INTO `stud_history_details`(`sno`, `nameschool`, `past_school_add`, `past_level`, `year_attended`, `isCompletedVacine`, `vacination_details`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                        sno, pastNameSchool, pastAddSchool, past_level, year_attended, isComplete, vacine_details);

            cs.ExecuteQuery(sql);

        }

        public void updateHisDetails(string sno, string pastNameSchool, string pastAddSchool, string past_level, string year_attended, string isComplete, string vacine_details)
        {
            string sql = String.Format(@"UPDATE `stud_history_details` SET `nameschool`='{0}' , `past_school_add`='{1}' , 
                                        `past_level`='{2}', `year_attended`='{3}',`isCompletedVacine`='{4}', 
                                         `vacination_details`='{5}' WHERE `sno`='{6}'",pastNameSchool,pastAddSchool,past_level,year_attended,
                                         isComplete,vacine_details,sno);

            cs.ExecuteQuery(sql);
        }

        public void fillDataHist(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT `stud_his_id`, `sno`, `nameschool`, `past_school_add`, `past_level`, `year_attended`, `isCompletedVacine`, `vacination_details` FROM `stud_history_details` WHERE sno in(SELECT sno FROM student_detail where isEnrolled = 'enrolled')");

            cs.FillDataGrid(sql, ref dg);
        }


        public string[] getHistStudent(string sno)
        {
            string[] studHist = new string[6];

            string sql = String.Format(@"SELECT * FROM `stud_history_details` WHERE sno = '{0}'", sno);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                studHist[0] = reader["nameschool"].ToString();
                studHist[1] = reader["past_school_add"].ToString();
                studHist[2] = reader["past_level"].ToString();
                studHist[3] = reader["year_attended"].ToString();
                studHist[4] = reader["isCompletedVacine"].ToString();
                studHist[5] = reader["vacination_details"].ToString();
              

            }

            cs.CloseConnection();
            return studHist;
        }

    }
}
