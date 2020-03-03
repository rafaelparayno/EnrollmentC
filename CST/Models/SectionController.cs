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
            string sql = String.Format("INSERT INTO sections (grade_level,adviser,section_name,SY_ID) VALUES ('{0}',{1},'{2}',{3})", grade_level,
                                        teacher_id, section_name, yearID);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridSect(ref DataGridView dg)
        {
            string sql = String.Format("SELECT * FROM sections WHERE SY_ID = {0}", yearID);

            cs.FillDataGrid(sql, ref dg);
        } 


    }
}
