using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class RoomTypeController
    {
        crudFile cs = new crudFile();

        public void fillDataGridRoom(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT * FROM classroom_type");

            cs.FillDataGrid(sql, ref dg);
        }

        public void addRoomType(string name)
        {
            string sql = String.Format(@"INSERT INTO classroom_type (name) VALUES ('{0}') ", name);

            cs.ExecuteQuery(sql);
        }

        public string[] fillCombo(ref ComboBox cb)
        {
            MySqlDataReader reader = null;
            string id = "";
            string sql = String.Format("SELECT classroom_type_id,name FROM classroom_type");
            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                cb.Items.Add(reader["name"].ToString());
                id = id + " " + reader["classroom_type_id"].ToString();

            }
            id = id.Trim();
            string[] arr = id.Split(' ');
            return arr;
        }

        public void RemoveRoomType(int id)
        {
            string sql = String.Format(@"DELETE FROM classroom_type WHERE classroom_type_id = {0}", id);

            cs.ExecuteQuery(sql);
        }
    }
}
