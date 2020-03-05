using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class TotalFeeController
    {
        crudFile cs = new crudFile();

        public TotalFeeController()
        {

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

    }
}
