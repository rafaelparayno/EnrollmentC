using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class SectionController
    {
        crudFile cs = new crudFile();
        
        YearController yearController = new YearController();
        private int yearID;
        public SectionController()
        {
            yearID = yearController.getSchoolYearId();
        }

        public void addSection(string grade_level,int teacher_id,string section_name)
        {
            int yearId = yearController.getSchoolYearId();
            string sql = String.Format("INSERT INTO sections (grade_level,teacher_ID,section_name,SY_ID) VALUES ('{0}',{1},'{2}',{3})", grade_level,
                                        teacher_id, section_name, yearID);

            cs.ExecuteQuery(sql);
        }

        public void updateSection(int sect_id,string grade_level, int teacher_id, string section_name,int yearId)
        {
            string sql = String.Format(@"UPDATE sections SET grade_level = '{0}',teacher_ID = {1},section_name = '{2}' WHERE SY_ID = {3} AND sect_id = {4}",
                                        grade_level, teacher_id, section_name, yearId, sect_id);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridSect(ref DataGridView dg)
        {
            string sql = String.Format("SELECT sect_id,sections.section_name, CONCAT(Firstname,' ',LastName) AS Adviser_Name,grade_level FROM `specialization` LEFT JOIN `useraccounts` ON specialization.acc_id = useraccounts.acc_id INNER JOIN `sections` ON sections.teacher_ID = specialization.teacher_ID WHERE sections.SY_ID = {0}", yearID);

            cs.FillDataGrid(sql, ref dg);
        } 

        public string[] fillComboSect(ref ComboBox cb)
        {
            MySqlDataReader reader = null;
            string sect_id = "";
            string sql = String.Format("SELECT sect_id,section_name FROM sections WHERE SY_ID = {0}", yearID);
            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                cb.Items.Add(reader["section_name"].ToString());
                sect_id = sect_id + " " + reader["sect_id"].ToString();
          
            }
            sect_id = sect_id.Trim();
            string[] arr = sect_id.Split(' ');
            return arr;
        }

        public string [] fillComboSect2(ref ComboBox cb)
        {
            MySqlDataReader reader = null;
            string sect_id = "";
            string sql = String.Format("SELECT sect_id,section_name FROM `sections` WHERE sect_id not in (SELECT sect_id From sched_section) AND SY_ID  = {0}", yearID);
            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                cb.Items.Add(reader["section_name"].ToString());
                sect_id = sect_id + " " + reader["sect_id"].ToString();

            }
            sect_id = sect_id.Trim();
            string[] arr = sect_id.Split(' ');
            return arr;
        }

        public int[] fillComboSect3(ref ComboBox cb, string grade)
        {
            int[] sectionIds = { };

            string sql = String.Format("SELECT sect_id,section_name FROM sections WHERE grade_level = '{0}' AND SY_ID ={1}",
                grade,yearID);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["section_name"].ToString());
                total++;
            }

            cs.CloseConnection();

            sectionIds = new int[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                sectionIds[i] = int.Parse(reader["sect_id"].ToString());
                i++;
            }
            cs.CloseConnection();
            return sectionIds;
        }


        public int[] fillComboSect4(ref ComboBox cb, int teacher_id)
        {
            int[] sectionIds = { };

            string sql = String.Format("SELECT sect_id,section_name FROM sections WHERE sect_id in (SELECT sect_id FROM sched_section WHERE sched_section.teacher_ID = {0}) AND SY_ID ={1}",
                teacher_id, yearID);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["section_name"].ToString());
                total++;
            }

            cs.CloseConnection();

            sectionIds = new int[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                sectionIds[i] = int.Parse(reader["sect_id"].ToString());
                i++;
            }
            cs.CloseConnection();
            return sectionIds;
        }


        public int[] fillComboSect5(ref ComboBox cb, int teacher_id)
        {
            int[] sectionIds = { };

            string sql = String.Format("SELECT sect_id,section_name FROM sections WHERE teacher_ID ={0} AND SY_ID ={1}",
                teacher_id, yearID);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["section_name"].ToString());
                total++;
            }

            cs.CloseConnection();

            sectionIds = new int[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                sectionIds[i] = int.Parse(reader["sect_id"].ToString());
                i++;
            }
            cs.CloseConnection();
            return sectionIds;
        }

        public void removeSection(int sect_id,int sy_id)
        {
            string sql = String.Format(@"DELETE FROM sections WHERE sect_id = {0} AND SY_ID = {1}", sect_id, sy_id);
          
            cs.ExecuteQuery(sql);
        }


        public string getSectionName(int sect_id)
        {
            string name = "";

            MySqlDataReader reader = null;
            string sql = String.Format(@"SELECT section_name FROM sections WHERE sect_id = {0}", sect_id);
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {
                name = reader["section_name"].ToString();
            }
            cs.CloseConnection();
            return name;
        }

        public string getGradeLevelinSections(int sect_id)
        {
            string grade_level = "";

            MySqlDataReader reader = null;
            string sql = String.Format(@"SELECT grade_level FROM sections WHERE sect_id = {0}", sect_id);
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {
                grade_level = reader["grade_level"].ToString();
            }
            cs.CloseConnection();
            return grade_level;
        }

    }
}
