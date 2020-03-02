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

		public UserLog(string firstName,string lastname, string middlename, string role,string username)
		{
			FirstName = firstName;
			LastName = lastname;
			MiddleName = middlename;
			Role = role;
			UserName = username;
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


	}
}
