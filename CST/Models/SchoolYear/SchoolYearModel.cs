using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models.SchoolYear
{
	class SchoolYearModel
	{
		private static string schoolYear;
		private static int schoolYearId;

		public SchoolYearModel(string sy)
		{
			schoolYear = sy;
		}


		public static string getSchoolYear()
		{
			return schoolYear;
		}

		public static int getSchoolYearId()
		{
			return schoolYearId;
		}

		public static void setSchoolYear(string sy)
		{
			schoolYear = sy;
		}

		public static void setSchoolYearId(int id)
		{
			schoolYearId = id;
		}


	}
}
