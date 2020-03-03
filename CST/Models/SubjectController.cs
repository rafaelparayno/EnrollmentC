using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class SubjectController
    {
        crudFile cs = new crudFile();
        public SubjectController()
        {

        }

        public void addSubject(string grade_level,string subject_name)
        {
            string sql = String.Format(@"INSERT INTO subjects(grade_level,subject_name) VALUES ('{0}','{1}')", grade_level, subject_name);

            cs.ExecuteQuery(sql);
        }


        public void fillDataGridSub(ref DataGridView dg)
        {

            string sql = String.Format(@"SELECT * FROM subjects");

            cs.FillDataGrid(sql,ref dg);
        }

        public void updateSubjects(string grade_level,string subject_name,int id)
        {
            string sql = String.Format(@"UPDATE subjects SET grade_level = '{0}', subject_name = '{1}' WHERE subject_id = {2}", grade_level, subject_name, id);

            cs.ExecuteQuery(sql);
        }

        public void removeSubjects(int id)
        {
            string sql = String.Format(@"DELETE FROM subjects WHERE subject_id = {0}", id);

            cs.ExecuteQuery(sql);
        }


    }
}
