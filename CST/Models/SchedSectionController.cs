using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class SchedSectionController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        int syid = 0;
        public SchedSectionController()
        {
            syid = yearController.getSchoolYearId();
        }


        public void saveSchedSection(int ts_id,int sub_id,int teacher_id,int room_id,int sect_id)
        {
            string sql = String.Format(@"INSERT INTO `sched_section`(`timestamp_id`, `subject_id`, `teacher_ID`, `classroom_id`, `sect_id`, `SY_id`) VALUES ({0},{1},{2},{3},{4},{5})",
                                        ts_id, sub_id, teacher_id, room_id, sect_id, syid);

            cs.ExecuteQuery(sql);
        }
    }
}
