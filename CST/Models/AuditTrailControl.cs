using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CST.Models;
using System.Windows.Forms;

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

		public void fillDataGridAudit(ref DataGridView dg)
		{
			string sql = "SELECT * FROM audit_trail ORDER BY audit_id DESC";

			cs.FillDataGrid(sql, ref dg);
		}

		public void searchGrid(string condition, string searchKeys, ref DataGridView dg)
		{


			string sql = String.Format(@"SELECT * FROM audit_trail WHERE {0} LIKE '%{1}%'", condition, searchKeys);

			cs.FillDataGrid(sql, ref dg);
		}


	}
}
