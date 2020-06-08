using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class SpecializationController
    {
        crudFile cs = new crudFile();
        YearController yr = new YearController();
        UserController us = new UserController();
        private int syId = 0;
        public SpecializationController()
        {
            syId = yr.getSchoolYearId();
        }

        public void addSpecialization(string user_id, string subject_name, string teaching_type, int subj_id)
        {
            string sql = String.Format(@"INSERT INTO specialization (acc_id,subject,subject_id,teaching_type) VALUES('{0}','{1}',{2},'{3}')", user_id, subject_name, subj_id, teaching_type);

            cs.ExecuteQuery(sql);
        }

        public string[] fillDataTeacher(ref ComboBox cb)
        {
            string sql = String.Format(@"SELECT * FROM useraccounts WHERE acc_id NOT IN(SELECT acc_id FROM specialization) AND Role = 'Teacher'");

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int totalCount = 0;
            string idUser = "";


            while (reader.Read())
            {
                totalCount++;

                cb.Items.Add(reader["Firstname"].ToString() + " " + reader["Lastname"].ToString());
                idUser = idUser + " " + reader["acc_id"].ToString();

            }

            idUser = idUser.Trim();
            string[] idArgs = idUser.Split(' ');

            cs.CloseConnection();
            return idArgs;
        }

        public int[] fillDataTeacherCombo(ref ComboBox cb)
        {
            int[] teacher_ids = { };

            string sql = String.Format("SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id");

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["FullName"].ToString());
                total++;
            }

            cs.CloseConnection();

            teacher_ids = new int[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                teacher_ids[i] = int.Parse(reader["teacher_ID"].ToString());
                i++;
            }
            cs.CloseConnection();
            return teacher_ids;
        }

        public string[] fillComboSecondaryTeacher(ref ComboBox cb)
        {
            string[] teacher_ids = { };
            string sql = String.Format(@"SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE specialization.subject_id != 0 ");


            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["FullName"].ToString());
                total++;
            }

            cs.CloseConnection();

            teacher_ids = new string[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {
                teacher_ids[i] = reader["teacher_ID"].ToString();
                i++;
            }
            cs.CloseConnection();

            return teacher_ids;
        }

        public void fillDataGridTeacher(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT teacher_ID,subject,CONCAT(Firstname,' ',LastName) as FullName,teaching_type FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id ");

            cs.FillDataGrid(sql, ref dg);
        }

        public string[] fillDataTeacherSect(ref ComboBox cb)
        {
            string sql = String.Format(@"SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id");
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int totalCount = 0;
            string idUser = "";


            while (reader.Read())
            {
                totalCount++;

                cb.Items.Add(reader["FullName"].ToString());
                idUser = idUser + " " + reader["teacher_ID"].ToString();

            }

            idUser = idUser.Trim();
            string[] idArgs = idUser.Split(' ');

            cs.CloseConnection();
            return idArgs;
        }

        public string AdviserName(int teacher_id)
        {
            string name = "";

            MySqlDataReader reader = null;
            string sql = String.Format(@"SELECT Concat(Firstname,' ',Lastname) As 'FullName' FROM useraccounts WHERE acc_id = (SELECT acc_id FROM specialization WHERE teacher_ID = {0} )", teacher_id);
            cs.RetrieveRecords(sql, ref reader);
            if (reader.Read())
            {
                name = reader["FullName"].ToString();
            }
            cs.CloseConnection();
            return name;
        }
        public string[] findTeacherWithAvailSub(ref ComboBox cb, int subjectid)
        {
            string sql = String.Format(@"SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE specialization.subject_id = {0}",
                                    subjectid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            int totalCount = 0;
            string idUser = "";


            while (reader.Read())
            {
                totalCount++;

                cb.Items.Add(reader["FullName"].ToString());
                idUser = idUser + " " + reader["teacher_ID"].ToString();

            }

            idUser = idUser.Trim();
            string[] idArgs = idUser.Split(' ');

            cs.CloseConnection();
            return idArgs;
        }

        public string findTeacherName(string fn, string ln)
        {
            string sql = String.Format("SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE useraccounts.Firstname = '{0}' AND useraccounts.Lastname ='{1}'", fn, ln);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            string nameWithId = "";
            if (reader.Read())
            {
                nameWithId = reader["FullName"].ToString() + "-" + reader["teacher_ID"];
            }

            cs.CloseConnection();
            return nameWithId;
        }

        public int findTeacherId(string accid)
        {
            int teacher_id = 0;
            string sql = String.Format(@"SELECT teacher_id FROM specialization WHERE acc_id = '{0}'", accid);
            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            if (reader.Read())
            {
                teacher_id = int.Parse(reader["teacher_id"].ToString());
            }

            cs.CloseConnection();

            return teacher_id;
        }


        public int[] teacherAvailWithSubjsAndTime(string start, string end, string sub,ref ComboBox cb)
        {
            int[] ids;
            int count = 0;
            string sql = String.Format(@"SELECT teacher_ID,CONCAT(useraccounts.Firstname,' ',useraccounts.Lastname) AS 'FullName' 
                                        FROM `specialization` LEFT JOIN useraccounts on specialization.acc_id = useraccounts.acc_id 
                                        WHERE subject_id = {0} AND teacher_ID in(SELECT teacher_ID FROM sched_section WHERE timestamp_id in 
                                        (SELECT timestamp_id FROM timestamp WHERE start_time < '{1}' AND end_time > '{2}') AND SY_ID = {3})",
                                         sub,end,start,syId);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                cb.Items.Add(reader["FullName"].ToString());
                count++;
            }

            cs.CloseConnection();
            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            ids = new int[count];

            while (reader.Read())
            {
                ids[i] = int.Parse(reader["teacher_ID"].ToString());
                i++;
            }
            cs.CloseConnection();
       

            return ids;
        }

        public int[] teacherAvailWithTime(string start, string end, ref ComboBox cb)
        {
            int[] ids;
            int count = 0;
            string sql = String.Format(@"SELECT teacher_ID,CONCAT(useraccounts.Firstname,' ',useraccounts.Lastname) AS 'FullName' 
                                        FROM `specialization` LEFT JOIN useraccounts on specialization.acc_id = useraccounts.acc_id 
                                        WHERE teacher_ID NOT in(SELECT teacher_ID FROM sched_section WHERE timestamp_id in 
                                        (SELECT timestamp_id FROM timestamp WHERE start_time < '{0}' AND end_time > '{1}') AND SY_ID = {2})",
                                         end, start, syId);

            MySqlDataReader reader = null;

            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                cb.Items.Add(reader["FullName"].ToString());
                count++;
            }

            cs.CloseConnection();
            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            ids = new int[count];

            while (reader.Read())
            {
                ids[i] = int.Parse(reader["teacher_ID"].ToString());
                i++;
            }
            cs.CloseConnection();


            return ids;
        }

    }
}
