using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySql.Data;

namespace LibraryApp.Classes
{
    public class User : Person
    {
        public int user_id;

        public User(DataSet dataSet) : base(dataSet)
        {
            this.user_id = (int) dataSet.Tables[0].Rows[0][0];
        }

        public static bool isUsernameExist(MyLibraryDb db, string username)
        {
            try
            {
                string sql = "SELECT username FROM user WHERE username = '" + username + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                DataSet tmpDs = new DataSet();
                da.Fill(tmpDs, "user");
                string tmp = tmpDs.Tables[0].Rows[0][0].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool isUserIdExist(MyLibraryDb db, int id)
        {
            try
            {
                string sql = "SELECT user_id FROM user WHERE user_id = " + id.ToString();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                DataSet tmpDs = new DataSet();
                da.Fill(tmpDs, "user");
                string tmp = tmpDs.Tables[0].Rows[0][0].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataSet getAccountData(MyLibraryDb db, string username)
        {
            string sql = "SELECT user_id, username, password, first_name, last_name" +
                " FROM user " +
                "WHERE username = '" + username + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

            DataSet tmpDs = new DataSet();
            da.Fill(tmpDs, "user");

            return tmpDs;
        }
    }
}
