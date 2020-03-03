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
    }
}
