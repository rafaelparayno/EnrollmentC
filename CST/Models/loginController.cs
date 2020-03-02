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
											username);
			}

			

			crud.CloseConnection();
			return role;
		}

	}
}
