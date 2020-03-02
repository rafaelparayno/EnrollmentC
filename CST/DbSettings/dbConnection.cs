using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CST.Models
{
	class dbConnection
	{
        public MySqlConnection connection = null;

        //Connecting and openning the database to the system.
        public dbConnection()
        {

        }
        public bool EstablishConnection()
        {

            try
            {
                string SERVER = dbConfigFile.FetchDatabaseLocation()[0];
                string USERNAME = dbConfigFile.FetchDatabaseLocation()[1];
                string PASSWORD = dbConfigFile.FetchDatabaseLocation()[2];
                string DATABASE = dbConfigFile.FetchDatabaseLocation()[3];

                /*Console.WriteLine(string.Format(@"Server={0};Port=3306;Database={1};Uid={2};Pwd={3};SslMode=none;",
                    SERVER, DATABASE, USERNAME, PASSWORD));

                connection = new MySqlConnection(string.Format(@"Server={0};Port=3306;Database={1};Uid={2};Pwd={3};SslMode=none;",
                    SERVER, DATABASE, USERNAME, PASSWORD));*/
                Console.WriteLine(string.Format("SERVER={0};  USERNAME={1}; PASSWORD={2}; DATABASE={3};",
                    SERVER, USERNAME, PASSWORD, DATABASE));

                connection = new MySqlConnection(string.Format("SERVER={0};  USERNAME={1}; PASSWORD={2}; DATABASE={3};",
                    SERVER, USERNAME, PASSWORD, DATABASE));

                connection.Open();
             
                //  FrmLogin.frmLogin.panel_Database.BackgroundImage = Properties.Resources.icon_database_connected;
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //FrmLogin.frmLogin.panel_Database.BackgroundImage = Properties.Resources.icon_database_disconnected;
                return false;
            }
        }
    }
}

