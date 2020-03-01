using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CST.DbSettings.UserLog;

namespace CST.Models
{
	class AuditTrailControl
	{
		crudFile cs = new crudFile();
		public AuditTrailControl()
		{

		}
		public void addAudit(string dateTime,string action)
		{

			string sql = String.Format(@"INSERT INTO audit_trail( Username, Date_Time, Action, User_type,User) VALUES ('{0}','{1}','{2}','{3}','{4}')",
										UserLog.getUserName(), dateTime, action, UserLog.getRole(), UserLog.getFullName());

			cs.ExecuteQuery(sql);

		}

	 
	}
}
