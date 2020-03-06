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

        
            string sql = String.Format(@"INSERT timestamp (start_time,end_time,Sy_id) VALUES ('{0}','{1}',{2})", start, end, yearController.getSchoolYearId());

            cs.ExecuteQuery(sql);
        
        
        }

        public void fillDataTime(ref DataGridView dg, int yid)
        {
            string sql = String.Format(@"SELECT timestamp_id,start_time,end_time FROM timestamp WHERE Sy_id = {0} ORDER BY start_time ASC", yid);

            cs.FillDataGrid(sql, ref dg);
        }

       /* private bool checking(string end, string start)
        {

            bool conflict = false;
            string sql = String.Format(@"SELECT * FROM `timestamp` WHERE `start_time` < '{0}' AND `end_time` > '{1}'", end, start, yearController.getSchoolYearId());

            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                conflict = true;
            }

            cs.CloseConnection();

            return conflict;
        }*/

    }
}
