using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class SectionController
    {
        crudFile cs = new crudFile();
        
        YearController yearController = new YearController();
        private int yearID;
        public SectionController()
        {
            yearID = yearController.getSchoolYearId();
        }

        public void addSection(string grade_level,int teacher_id,string section_name)
        {
            int yearId = yearController.getSchoolYearId();
            string sql = String.Format("INSERT INTO sections (grade_level,teacher_ID,section_name,SY_ID) VALUES ('{0}',{1},'{2}',{3})", grade_level,
                                        teacher_id, section_name, yearID);

            cs.ExecuteQuery(sql);
        }

        public void updateSection(int sect_id,string grade_level, int teacher_id, string section_name,int yearId)
        {
            string sql = String.Format(@"UPDATE sections SET grade_level = '{0}',teacher_ID = {1},section_name = '{2}' WHERE SY_ID = {3} AND sect_id = {4}",
                                        grade_level, teacher_id, section_name, yearId, sect_id);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridSect(ref DataGridView dg)
        {
            string sql = String.Format("SELECT sect_id,sections.section_name, CONCAT(Firstname,' ',LastName) AS Adviser_Name,grade_level FROM `specialization` LEFT JOIN `useraccounts` ON specialization.acc_id = useraccounts.acc_id INNER JOIN `sections` ON sections.teacher_ID = specialization.teacher_ID WHERE sections.SY_ID = {0}", yearID);

            cs.FillDataGrid(sql, ref dg);
        } 

        public void removeSection(int sect_id,int sy_id)
        {
            string sql = String.Format(@"DELETE FROM sections WHERE sect_id = {0} AND SY_ID = {1}", sect_id, sy_id);
          
            cs.ExecuteQuery(sql);
        }


    }
}
