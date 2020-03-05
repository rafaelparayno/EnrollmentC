using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
