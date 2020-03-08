using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class RoomController
    {
        crudFile cs = new crudFile();
        YearController yr = new YearController();
        private int sy = 0;
        public RoomController()
        {
            sy = yr.getSchoolYearId();
        }

        public void addRoom(string type, int roomno) 
        {

            bool check = checking(roomno,type);


            if (!check)
            {
                string sql = String.Format(@"INSERT INTO classroom (classroom_type,classroom_no,SY_ID) VALUES ('{0}','{1}',{2})", type, roomno, sy);

                cs.ExecuteQuery(sql);
                MessageBox.Show("Succesfully Added a New Room");
            }
            else
            {
                MessageBox.Show("Already Have the same room and type in this school year");
            }
        }

        public void removeRoom(int id)
        {
            string sql = String.Format(@"DELETE FROM classroom WHERE classroom_id = {0}", id);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridRoom(ref DataGridView dg, int syid)
        {
            string sql = String.Format(@"SELECT classroom_id,classroom_type,classroom_no FROM classroom WHERE SY_ID = {0}", syid);

            cs.FillDataGrid(sql, ref dg);
        }

        private bool checking(int roomno,string type)
        {
         
            bool noSameRoom = false;
            string sql = String.Format(@"SELECT * FROM `classroom` WHERE classroom_type = '{0}' AND classroom_no = {1} AND SY_ID = {2}", type, roomno, yr.getSchoolYearId());
          
            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                noSameRoom = true;
            }

            cs.CloseConnection();

            return noSameRoom;
        }

        public string [] fillClassRoomAvail(ref ComboBox cb,string te,string ts)
        {

            string sql = String.Format(@"SELECT CONCAT(classroom_type,' ',classroom_no) As RoomName,classroom_id FROM classroom WHERE classroom_id not in(SELECT classroom_id FROM sched_section WHERE timestamp_id in(SELECT timestamp_id FROM timestamp WHERE start_time <= '{0}' AND end_time > '{1}'))",
                                    te, ts);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            string ids = "";
            while (reader.Read())
            {
                ids = ids + " " + reader["classroom_id"].ToString();
                cb.Items.Add(reader["RoomName"].ToString());
            }


            string[] arr = ids.Split(' ');
            cs.CloseConnection();
            return arr;
        }
    }
}
