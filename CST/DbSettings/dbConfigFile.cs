using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CST
{
	class dbConfigFile
	{
        public static string[] FetchDatabaseLocation()
        {
            string[] returnData = new string[4];

            try
            {
                StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + @"\databaseconfig.txt");

                returnData = file.ReadLine().Split('#');
                file.Close();
            }
            catch { }
            return returnData;
        }
    }
}
