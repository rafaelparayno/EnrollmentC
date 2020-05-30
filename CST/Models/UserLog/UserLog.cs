using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
	class UserLog
	{

		private static string FirstName;
		private static string LastName;
		private static string MiddleName;
		private static string UserName;
		private static string Role;
		private static string userid;
		private static int isPasswordChanged;

		public UserLog(string firstName,string lastname, string middlename, string role,string username,string userids,int isPasword)
		{
			FirstName = firstName;
			LastName = lastname;
			MiddleName = middlename;
			Role = role;
			UserName = username;
			userid = userids;
			isPasswordChanged = isPasword;
		}

		public static string getFirstName()
		{
			return FirstName;
		}

		public static string getLastName()
		{
			return LastName;
		}
		public static string getMiddleName()
		{
			return MiddleName;
		}
		public static string getUserName()
		{
			return UserName;
		}
		public static string getRole()
		{
			return Role;
		}

		public static string getFullName()
		{
			return FirstName + " " + MiddleName + " " + LastName; 
		}

		public static string getUserId()
		{
			return userid;
		}

		public static int getIsPasswordChanged()
		{
			return isPasswordChanged;
		}


	}
}
