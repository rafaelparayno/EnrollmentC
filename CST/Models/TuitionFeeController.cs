using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class TuitionFeeController
    {
        YearController yearcontroler = new YearController();
        crudFile cs = new crudFile();
        int yid = 0;
        public TuitionFeeController()
        {
            yid = yearcontroler.getSchoolYearId();
        }

        public void addTuition(string grade_level,double fee,string mod)
        {
            bool isCheck = checking(grade_level, mod);

            if (!isCheck)
            {
                string sql = String.Format(@"INSERT INTO `tuition_fee`(`grade_level`, `tuition_fee`, `mode_of_payment`, `SY_ID`) VALUES ('{0}',{1},'{2}',{3})",
                                       grade_level, fee, mod, yid);

                cs.ExecuteQuery(sql);
                MessageBox.Show("Succesfully Added Tuition");
            }
            else
            {
                MessageBox.Show("Has already an type mode of payment in that grade level");
            }

           
        }

        private bool checking(string grade_level, string mod)
        {

            bool noSameRoom = false;
            string sql = String.Format(@"SELECT * FROM `tuition_fee` WHERE grade_level = '{0}' AND mode_of_payment = '{1}' AND SY_ID = {2}", grade_level, mod, yearcontroler.getSchoolYearId());

            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                noSameRoom = true;
            }

            cs.CloseConnection();

            return noSameRoom;
        }

        public void fillDataTuion2(ref DataGridView dg,string grade)
        {
            string sql = String.Format(@"SELECT grade_level,tuition_fee,mode_of_payment FROM `tuition_fee` WHERE grade_level = '{0}' AND SY_ID = {1}",
                                        grade, yid);

            cs.FillDataGrid(sql,ref dg);
        }

        public void fillAllTuition(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT grade_level,tuition_fee,mode_of_payment FROM `tuition_fee` WHERE  SY_ID = {0}",
                                         yid);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataTuition(ref DataGridView dg,string mod,string grade)
        {
            string sql = String.Format(@"SELECT `tf_id`,`tuition_fee`,grade_level,mode_of_payment FROM tuition_fee WHERE grade_level = '{0}' AND mode_of_payment = '{1}' AND SY_ID = {2}",
                                        grade, mod, yid);

            cs.FillDataGrid(sql, ref dg);
        }
    }
}
