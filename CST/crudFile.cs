using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace CST
{
	class crudFile
	{
		string cnString = "";
		MySqlConnection cn;
		MySqlCommand cmd = new MySqlCommand();
		MySqlDataAdapter adptr = new MySqlDataAdapter();
		DataSet ds = new DataSet();
        string SERVER = dbConfigFile.FetchDatabaseLocation()[0];
        string USERNAME = dbConfigFile.FetchDatabaseLocation()[1];
        string PASSWORD = dbConfigFile.FetchDatabaseLocation()[2];
        string DATABASE = dbConfigFile.FetchDatabaseLocation()[3];
		//globalVariables global = new globalVariables();
		public crudFile()
		{
			cnString = String.Format("SERVER={0};PORT=3306;Database={1};Uid={2};Pwd={3};Ssl Mode=none", SERVER, DATABASE, USERNAME, PASSWORD);
			cn = new MySqlConnection(cnString);
          

        }

        public Task<DataSet> GetDataSetAsync(string sSQL, List<MySqlParameter> parameters)
        {
            return Task.Run(() =>
            {
                try
                {
                    cn.Open();

                    cmd = new MySqlCommand(sSQL, cn);
                    if (parameters != null) cmd.Parameters.AddRange(parameters.ToArray<MySqlParameter>());
                    adptr = new MySqlDataAdapter(cmd);
                    ds = new DataSet();
                    adptr.FillAsync(ds);
                    cn.Close();
                    return ds;
                }
                catch (Exception e)
                {
                    cn.Close();
                    MessageBox.Show("" + e.Message);
                    return null;
                }

            });
        }


        public async Task<int> ExecuteAsync(string sql, List<MySqlParameter> parameters)
        {
            try
            {
                await cn.OpenAsync().ConfigureAwait(false);

                cmd = new MySqlCommand(sql, cn);
                if (parameters != null) cmd.Parameters.AddRange(parameters.ToArray<MySqlParameter>());

                return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);

            }
            catch (Exception e)
            {

                MessageBox.Show("" + e.Message);
                return 0;

            }
            finally
            {
                cn.Close();
            }
        }

        public  void FillDataGrid(string sql, ref DataGridView dg)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                adptr = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                adptr.Fill(ds);
                dg.DataSource = "";
                dg.DataSource =  ds.Tables[0];
                dg.AutoResizeColumns();
                cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            cn.Close();
        }
        public void ExecuteQuery(string sql)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            cn.Close();
        }
     

        public MySqlDataReader RetrieveRecords(string sql, ref MySqlDataReader reader)
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand(sql, cn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
                return null;
            }
        }

        

    

        public void CloseConnection()
        {
            cn.Close();
        }

    }
}
