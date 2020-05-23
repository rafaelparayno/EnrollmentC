using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CST.Models;

namespace CST.Models
{
	
	class loginController
	{
		crudFile crud = new crudFile();
		
		string role = "";
		public loginController()
		{

		}
		public string login(string username, string pass)
		{
			if (username == "")
			{
				MessageBox.Show("Please enter username");
				return  "";
			}
			if (pass == "")
			{
				MessageBox.Show("Please enter password");
				return "";
			}

			string sql = String.Format(@"SELECT * FROM useraccounts  WHERE  Binary Username= '{0}' and Password = '{1}'", username, pass);
			//crud.ExecuteQuery(sql);
			MySqlDataReader reader = null;
			crud.RetrieveRecords(sql, ref reader);
			if (reader.Read())
			{
				MessageBox.Show("Login Success");
				role = reader.GetString(6);
				UserLog user = new UserLog(reader["Firstname"].ToString(), 
											reader["Lastname"].ToString(), 
											reader["MiddleName"].ToString(), 
											role,
											username,
											reader["acc_id"].ToString());
			}

			

			crud.CloseConnection();
			return role;
		}

		public void setOnline(string acc_id)
		{
			string sql = String.Format(@"UPDATE useraccounts SET Status = 'Online' WHERE acc_id = '{0}'",acc_id);
			crud.ExecuteQuery(sql);
		}

		public void setOffline(string acc_id)
		{
			string sql = String.Format(@"UPDATE useraccounts SET Status = 'Offline' WHERE acc_id = '{0}'", acc_id);
			crud.ExecuteQuery(sql);
		}

	}
}
