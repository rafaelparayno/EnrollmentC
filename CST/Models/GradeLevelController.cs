using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class GradeLevelController
    {
        crudFile cs = new crudFile();
        YearController YearController = new YearController();
        public GradeLevelController()
        {

        }

        public void addGradeLevel(string gradeType,string gradeLvl)
        {
            string sql = "";
            bool check = checking(gradeLvl);
            

            if (!check)
            {
                sql = String.Format(@"INSERT INTO grade_level (grade_type,grade_level,SY_id) VALUES('{0}','{1}',{2})", gradeType, gradeLvl, YearController.getSchoolYearId());

                cs.ExecuteQuery(sql);
                MessageBox.Show("Succesfully Added a New Grade Level");
            }
            else
            {
                MessageBox.Show("Already Have the same grade level in this school year");
            }
        
        }

        public void removeGradeLevel(int id)
        {
            string sql = String.Format(@"DELETE from grade_level WHERE gradelvl_id = {0}", id);

            cs.ExecuteQuery(sql);
        }

      

        public void fillDataGridGrade(ref DataGridView dg,int sy_id)
        {

            string sql = String.Format("SELECT gradelvl_id,grade_type,grade_level FROM grade_level WHERE Sy_id = {0}",sy_id);
            cs.FillDataGrid(sql, ref dg);
        }

        private bool checking(string gradeLvl)
        {
            string sql = "";
            bool noSameGrade = false;
            sql = String.Format(@"SELECT * FROM `grade_level` WHERE grade_level = '{0}' AND SY_id = {1}", gradeLvl, YearController.getSchoolYearId());
            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                noSameGrade = true;
            }

            cs.CloseConnection();

            return noSameGrade;
        }


    }
}
