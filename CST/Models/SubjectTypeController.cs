using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class SubjectTypeController
    {

        crudFile cs = new crudFile();

        public SubjectTypeController()
        {

        }



        public void addSubjectType(string name)
        {
            if (!findSameName(name))
            {
                string sql = String.Format(@"INSERT INTO subjectype(subject_type) 
                                        VALUES ('{0}')", name);

                cs.ExecuteQuery(sql);
                MessageBox.Show("Succesfully Added new Subject Type");
            }
            else
            {
                MessageBox.Show("Cannot Add With Same Name Type");
            }
        }

        public void fillDataGridSubType(ref DataGridView dg)
        {

            string sql = String.Format(@"SELECT * FROM subjectype");

            cs.FillDataGrid(sql, ref dg);
        }


        public void updateSubjectType(string subject_name, int id)
        {
            if (!isChanged(subject_name, id))
            {

                if (!findSameName(subject_name))
                {
                    string sql = String.Format(@"UPDATE subjectype SET subject_type = '{0}' WHERE sub_type_id = {1}", subject_name, id);

                    cs.ExecuteQuery(sql);
                    MessageBox.Show("Succesfully Update Subject");
                }
                else
                {
                    MessageBox.Show("Cannot Add With Same Name Type");
                }
            }
            else
            {
                string sql = String.Format(@"UPDATE subjectype SET subject_type = '{0}' WHERE sub_type_id = {1}", subject_name, id);

                cs.ExecuteQuery(sql);
                MessageBox.Show("Succesfully Update Subject");
            }
          
        }

        public void removeSubjectType(int id)
        {
            string sql = String.Format(@"DELETE FROM subjectype WHERE sub_type_id = {0}", id);

            cs.ExecuteQuery(sql);
        }



        private bool isChanged(string subjtype, int id)
        {
            bool isChange = false;

            string sql = String.Format(@"SELECT * FROM `subjectype` WHERE sub_type_id = {0} AND subject_type = '{1}' ", id, subjtype);

            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            if (reader.HasRows)
            {
                isChange = true;
            }

            cs.CloseConnection();

            return isChange;
        }

        private bool findSameName(string name)
        {
            bool found = false;
            string sql = String.Format(@"SELECT * FROM subjectype WHERE subject_type = '{0}'", name);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                found = true;
            }

            cs.CloseConnection();
            return found;
        }


        public int[] fillComboSubjectTypes(ref ComboBox cb)
        {
            int[] subject_types_ids = { };

            string sql = String.Format("SELECT * FROM `subjectype`");

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["subject_type"].ToString());
                total++;
            }

            cs.CloseConnection();

            subject_types_ids = new int[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                subject_types_ids[i] = int.Parse(reader["sub_type_id"].ToString());
                i++;
            }
            cs.CloseConnection();

            return subject_types_ids;
        }





    }
}
