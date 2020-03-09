using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class TotalFeeController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        int syid = 0;
        public TotalFeeController()
        {
            syid = yearController.getSchoolYearId();
        }

        public void addTotalFee(double total,int tf_id)
        {
            if (!isTfFind(tf_id))
            {
                string sql = String.Format(@"INSERT INTO total_fee (total,tf_id) VALUES({0},{1})", total, tf_id);

                cs.ExecuteQuery(sql);
            }
            else
            {
                string sql = String.Format(@"UPDATE total_fee SET total = {0} WHERE tf_id = {1}", total, tf_id);
                cs.ExecuteQuery(sql);
            }
          
        }

        private bool isTfFind(int tf_id)
        {

            bool tfFind = false;
            string sql = String.Format(@"SELECT * FROM `total_fee` WHERE tf_id = '{0}'", tf_id);

            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                tfFind = true;
            }

            cs.CloseConnection();

            return tfFind;
        }

        public double getTotal(string mod,string grade)
        {
          
            string sql = String.Format(@"SELECT * from total_fee WHERE tf_id in(SELECT tf_id FROM tuition_fee WHERE mode_of_payment = '{0}' AND grade_level = '{1}' AND SY_ID = {2})",
                                        mod, grade, syid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            double total = 0;
          
            if (reader.Read())
            {
                total = double.Parse(reader["total"].ToString());
            }

            cs.CloseConnection();
            return total;
        }

    }
}
