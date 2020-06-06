using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models.SchoolRequirementsMod;
using MySql.Data.MySqlClient;

namespace CST.Models
{
    class SchoolRequirementsController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        private int schoolYearId = 0;
        public SchoolRequirementsController()
        {
            schoolYearId = yearController.getSchoolYearId();
        }


        public void addSchoolRequirements(string typeStud,string name)
        {
            string sql = String.Format(@"INSERT INTO school_requirements (type_of_student,requirement_name) VALUES ('{0}','{1}')",
                                       typeStud, name);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridSchoolReq(ref DataGridView dg,int schoolId)
        {
            string sql = String.Format(@"SELECT req_id,type_of_student,requirement_name FROM school_requirements");

            cs.FillDataGrid(sql,ref dg);
        }

        public void fillDataGridForTypeStud(ref DataGridView dg,string stud_type)
        {
              string sql = String.Format(@"SELECT * FROM school_requirements WHERE type_of_student = '{0}'", stud_type);
           
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);
            List<SchoolRequireModel> requireModels = new List<SchoolRequireModel>();
            

            while (reader.Read())
            {
                SchoolRequireModel req = new SchoolRequireModel();
                req.requirement_name = reader["requirement_name"].ToString();
                req.req_id = int.Parse(reader["req_id"].ToString());
            
                requireModels.Add(req);
            }

            dg.DataSource = requireModels;
            cs.CloseConnection();
           
        }

        public int[] fillComboReq(string type,ref ComboBox cb)
        {
            int[] req_ids = { };

            string sql = String.Format("SELECT req_id,requirement_name FROM school_requirements WHERE type_of_student = '{0}'",
                type);

            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            int total = 0;
            while (reader.Read())
            {
                cb.Items.Add(reader["requirement_name"].ToString());
                total++;
            }

            cs.CloseConnection();

            req_ids = new int[total];

            reader = null;

            cs.RetrieveRecords(sql, ref reader);
            int i = 0;
            while (reader.Read())
            {  
             req_ids[i] = int.Parse(reader["req_id"].ToString());
                  i++;
            }
            cs.CloseConnection();
            return req_ids;
        }

        public void updateSchoolRequirements(string typeStud,string name , int idReq)
        {
            string sql = String.Format(@"UPDATE school_requirements SET type_of_student = '{0}', requirement_name ='{1}' WHERE req_id = {2}",
                                        typeStud, name, idReq);

            cs.ExecuteQuery(sql);
        }

        public void removeSchoolReq(int idReq)
        {
            string sql = String.Format(@"DELETE FROM school_requirements WHERE req_id = {0}", idReq);

            cs.ExecuteQuery(sql);
        }

        public void searchGrid(string condition, string searchKeys, ref DataGridView dg,int schoolId)
        {
            string sql = String.Format(@"SELECT req_id,type_of_student,requirement_name FROM school_requirements WHERE SY_ID = {0} AND type_of_student = '{1}' AND requirement_name LIKE '%{2}%'", 
                                            schoolId,
                                            condition,
                                             searchKeys);

            cs.FillDataGrid(sql, ref dg);
        }
    }
}
