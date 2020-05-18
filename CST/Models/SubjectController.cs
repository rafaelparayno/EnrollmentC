using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class SubjectController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        int syid = 0;
        public SubjectController()
        {
            syid = yearController.getSchoolYearId();
        }

        public void addSubject(string grade_level,string subject_name)
        {
            string sql = String.Format(@"INSERT INTO subjects(grade_level,subject_name) VALUES ('{0}','{1}')", grade_level, subject_name);

            cs.ExecuteQuery(sql);
        }


        public void fillDataGridSub(ref DataGridView dg)
        {

            string sql = String.Format(@"SELECT * FROM subjects");

            cs.FillDataGrid(sql,ref dg);
        }

        public void fillDataGridSubForGrade(ref ListBox lb,string grade,int[] subjIds)
        {

            if (subjIds == null)
            {
                string sql = String.Format(@"SELECT * FROM subjects WHERE grade_level = '{0}'", grade);
                // string[] subName = { };
                MySqlDataReader reader = null;
                reader = cs.RetrieveRecords(sql, ref reader);
                while (reader.Read())
                {

                    lb.Items.Add(reader["subject_name"].ToString());
                }
                cs.CloseConnection();
            }
            else
            {
                // string subjectsname = "";
                string[] subargs = { };
                int[] subids = { };
                //string s
                int count = 0;
                int count2 = 0;
                int[] subidsInList = { };
                string sql = String.Format(@"SELECT * FROM subjects WHERE grade_level = '{0}'", grade);
                MySqlDataReader reader = null;
                reader = cs.RetrieveRecords(sql, ref reader);
                while (reader.Read())
                {
                    //   subjectsname = reader["subject_name"].ToString() + "*" + subjectsname;
                    count++;
                }
                cs.CloseConnection();

                subargs = new string[count];
                subids = new int[count];
                reader = null;

                cs.RetrieveRecords(sql, ref reader);
                int i = 0;
                while (reader.Read())
                {
                    subargs[i] = reader["subject_name"].ToString();
                    subids[i] = int.Parse(reader["subject_id"].ToString());
                    i++;
                }
                cs.CloseConnection();


                for (int z = 0; z < subjIds.Length; z++)
                {
                    if (subjIds[z] != 0)
                    {
                        count2++;
                    }

                }
                subidsInList = new int[count2];
                int t = 0;
                for (int z = 0; z < subjIds.Length; z++)
                {
                    if (subjIds[z] != 0)
                    {
                        subidsInList[t] = subjIds[z];
                        t++;
                    
                    }

                }
                for (int j = 0; j < subids.Length; j++)
                {
                    if (!subidsInList.Contains(subids[j]))
                    {
                        lb.Items.Add(subargs[j]);
                    }


                }
            }
           

            //  cs.FillDataGrid(sql, ref dg);
        }

        public void updateSubjects(string grade_level,string subject_name,int id)
        {
            string sql = String.Format(@"UPDATE subjects SET grade_level = '{0}', subject_name = '{1}' WHERE subject_id = {2}", grade_level, subject_name, id);

            cs.ExecuteQuery(sql);
        }

        public void removeSubjects(int id)
        {
            string sql = String.Format(@"DELETE FROM subjects WHERE subject_id = {0}", id);

            cs.ExecuteQuery(sql);
        }

        public string[] getAllSubjectsForSecondary(ref ComboBox cb)
        {
            string sql = String.Format(@"SELECT subject_id,subject_name,grade_level FROM  subjects ");
            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            string subject_id = "";
            while (reader.Read())
            {
                if(reader["grade_level"].ToString().Contains("Grade"))
                {
                    string forGrade = reader["grade_level"].ToString().Split(' ')[1];
                    if (int.Parse(forGrade) > 6)
                    {
                        cb.Items.Add(reader["subject_name"].ToString());
                        subject_id = subject_id + " " + reader["subject_id"].ToString();
                    }
                   
                }
            }


            subject_id = subject_id.Trim();
            string[] args = subject_id.Split(' ');
            cs.CloseConnection();
            return args;
        }

        public string[] getSubjectAssignForGrade(string grade,ref ComboBox cb)
        {
            string sql = String.Format(@"SELECT subject_name,subject_id FROM  subjects  WHERE grade_level= '{0}'",grade);
            MySqlDataReader reader = null;
            reader = cs.RetrieveRecords(sql, ref reader);
            string subId = "";
            while (reader.Read())
            {
                subId = subId + " " + reader["subject_id"].ToString();
                cb.Items.Add(reader["subject_name"].ToString());

            }

            cs.CloseConnection();
            subId = subId.Trim();
            string[] arrs = subId.Split(' ');
            return arrs;
        
        }

        public int[] fillComboSubjectsAssignTeacher(ref ComboBox cb, int teacher_id,int sect_id)
        {
            int[] subject_ids = { };

            string sql = String.Format("SELECT * FROM `subjects` WHERE subject_id in(SELECT subject_id FROM sched_section WHERE teacher_Id = {0} AND sect_id = {1} AND Sy_id = {2})",
                teacher_id, sect_id,syid);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["subject_name"].ToString());
                total++;
            }

            cs.CloseConnection();

            subject_ids = new int[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                subject_ids[i] = int.Parse(reader["subject_id"].ToString());
                i++;
            }
            cs.CloseConnection();
            return subject_ids;
        }

        public bool isFound(int subid)
        {
            bool found = false;
            string sql = String.Format(@"SELECT * FROM subjects WHERE subject_id = {0}", subid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                found = true;
            }

            cs.CloseConnection();
            return found;
        }


    }
}
