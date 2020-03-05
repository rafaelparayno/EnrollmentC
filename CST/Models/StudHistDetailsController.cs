using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public void fillDataHist(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT `stud_his_id`, `sno`, `nameschool`, `past_school_add`, `past_level`, `year_attended`, `isCompletedVacine`, `vacination_details` FROM `stud_history_details` WHERE sno in(SELECT sno FROM student_detail where isEnrolled = 'enrolled')");

            cs.FillDataGrid(sql, ref dg);
        }


    }
}
