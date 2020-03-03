using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CST.Models
{
    class YearController
    {
        crudFile cs = new crudFile();


        public string getSyActivated()
        {
            string sql = @String.Format("SELECT * FROM school_year WHERE sy_status = 'activate'");
            string sy = "";
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                sy = reader["school_year"].ToString();
            }
            cs.CloseConnection();
            return sy;
        }

        public int getSchoolYearId()
        {

            string sql = @String.Format("SELECT * FROM school_year WHERE sy_status = 'activate'");
            int id = 0;
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                id = int.Parse(reader["id"].ToString());
            }
            cs.CloseConnection();
            return id;
        }



        public void addNewSy(string from,string to)
        {
            string sql = String.Format(@"INSERT INTO school_year(school_year,sy_status) VALUES('{0}','{1}')", from + "-" + to, "deactivate");

            cs.ExecuteQuery(sql);
        }

        public void updateSY(int id)
        {
            string sql = String.Format(@"UPDATE school_year SET sy_status = '{0}'", "deactivate");

            cs.ExecuteQuery(sql);


            sql = String.Format(@"UPDATE school_year SET sy_status = '{0}' WHERE id = {1}", "activate", id);

            cs.ExecuteQuery(sql);
        }


        public void fillDataGridSY(ref DataGridView dg)
        {

            string sql = "SELECT * FROM school_year";

            cs.FillDataGrid(sql, ref dg);
        }

    }
}
