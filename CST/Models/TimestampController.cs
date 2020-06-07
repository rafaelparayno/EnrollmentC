using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class TimestampController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();

        public TimestampController()
        {

        }


        public void addTime(string end,string start)
        {

        
            string sql = String.Format(@"INSERT timestamp (start_time,end_time) VALUES ('{0}','{1}')", start, end);

            cs.ExecuteQuery(sql);
        
        
        }

        public void fillDataTime(ref DataGridView dg, int yid)
        {
            string sql = String.Format(@"SELECT timestamp_id,start_time,end_time FROM timestamp ORDER BY start_time ASC");

            cs.FillDataGrid(sql, ref dg);
        }

        public bool checking(string end, string start)
        {
            //for rangess
            bool conflict = false;
            string sql = String.Format(@"SELECT * FROM `timestamp` WHERE `start_time` < '{0}' AND `end_time` > '{1}'", end, start);

            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                conflict = true;
            }

            cs.CloseConnection();

            return conflict;
        }

        public bool checking2(string end, string start, string end2, string start2)
        {
            //for exact
            bool conflict = false;
            string sql = String.Format(@"SELECT * FROM `timestamp` WHERE '{0}' < '{1}' AND '{2}' > '{3}'", start, end2, end, start2);

            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                conflict = true;
            }

            cs.CloseConnection();
            return conflict;
        }

    }
}
