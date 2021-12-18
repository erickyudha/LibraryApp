using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace LibraryApp.Classes
{
    public class MyLibraryDb
    {
        private string server_name = Properties.Settings.Default.DbServerName;
        private string username = Properties.Settings.Default.DbUsername;
        private string db_name = Properties.Settings.Default.DbName;
        private string port = Properties.Settings.Default.DbPort;
        public MySqlConnection connection;

        public MyLibraryDb()
        {
            this.connection = new MySqlConnection(
                String.Format("server={0};user={1};database={2};port={3};",
                server_name, username, db_name, port
                )
            );
        }

        public static bool isValidSettings(string sv_name, string username, string db_name, string port)
        {
            try
            {
                MySqlConnection testConnection = new MySqlConnection(
                String.Format("server={0};user={1};database={2};port={3};",
                sv_name, username, db_name, port
                ));
                testConnection.Open();
                testConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
