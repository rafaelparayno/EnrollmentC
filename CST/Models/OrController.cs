using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class OrController
    {
        crudFile cs = new crudFile();

        public int getRecentOr()
        {
            string sql = String.Format(@"SELECT AUTO_INCREMENT as Last_id FROM information_schema.TABLES WHERE TABLE_NAME = 'orno'");
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int last_id = 0;
            if (reader.Read())
            {
                last_id = int.Parse(reader["Last_id"].ToString());
            }
            cs.CloseConnection();
            return last_id;
        }

        public void addOr(int orno)
        {
            string sql = String.Format(@"INSERT INTO orno (oror) VALUES ({0})", orno);

            cs.ExecuteQuery(sql);
        }
    }
}
