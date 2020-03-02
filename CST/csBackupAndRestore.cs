using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using CST.Models;

namespace CST
{
    class csBackupAndRestore
    {
        dbConnection dbConnection = new dbConnection();
        public static void CreateDirectory()
        {
            string backupDirectory = @"C:\CST-backup\";
            bool exists = File.Exists(backupDirectory);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(backupDirectory);
            }
        }

        public static void DoBackup()
        {
            CreateDirectory();

            string filePath = @"C:\CST-backup\BACKUP--" + DateTime.Now.ToString("yyyy--MM--dd--HH--mm--ss--tt") + ".sql";

            dbConnection.EstablishConnection2();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup md = new MySqlBackup(cmd))
                {
                    cmd.Connection = dbConnection.connection;
                    md.ExportToFile(filePath);
                    dbConnection.connection.Close();
                }
            }
        }

        public static void DoRestore(string date, string time)
        {
            DoBackup();
            string dateParse = DateTime.Parse(date).ToString("yyyy--MM--dd");
            string timeParse = DateTime.Parse(time).ToString("HH--mm--ss--tt");
            string combine = dateParse + "--" + timeParse;

            string filePath = @"C:\CST-backup\BACKUP--" + combine + ".sql";

            Console.WriteLine(filePath);
            dbConnection.EstablishConnection2();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup md = new MySqlBackup(cmd))
                {
                    cmd.Connection = dbConnection.connection;
                    md.ImportFromFile(filePath);
                    dbConnection.connection.Close();
                }
            }


        }


    }
}
