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

        public void addSpecialization(string user_id,string subject_name, string teaching_type,int subj_id)
        {
            string sql = String.Format(@"INSERT INTO specialization (acc_id,subject,subject_id,teaching_type,SY_ID) VALUES('{0}','{1}',{2},'{3}',{4})", user_id, subject_name,subj_id, teaching_type, syId);
           
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

        public void fillDataGridTeacher(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT teacher_ID,subject,CONCAT(Firstname,' ',LastName) as FullName,teaching_type FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE specialization.SY_ID = {0}", syId);

            cs.FillDataGrid(sql,ref dg);
        }

        public string[] fillDataTeacherSect(ref ComboBox cb,int syid)
        {
            string sql = String.Format(@"SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE specialization.SY_ID = {0}",syId);
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

        public string[] findTeacherWithAvailSub(ref ComboBox cb,int subjectid)
        {
            string sql = String.Format(@"SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE specialization.SY_ID = {0} AND specialization.subject_id = {1}",
                                    syId,subjectid);
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

        public string findTeacherName(string fn,string ln)
        {
            string sql = String.Format("SELECT teacher_ID,CONCAT(Firstname,' ',LastName) as FullName FROM `specialization` LEFT JOIN useraccounts ON specialization.acc_id = useraccounts.acc_id WHERE specialization.SY_ID = {0} AND useraccounts.Firstname = '{1}' AND useraccounts.Lastname ='{2}'", syId, fn,ln);
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
    }
}
