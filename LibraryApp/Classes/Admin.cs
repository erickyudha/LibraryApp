using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using MySql.Data;

namespace LibraryApp.Classes
{
    public class Admin : Person
    {
        private int admin_id;

        public Admin(DataSet dataSet) : base(dataSet)
        {
            this.admin_id = (int)dataSet.Tables[0].Rows[0][0];
        }

        public static bool isUsernameExist(MyLibraryDb db, string username)
        {
            try
            {
                string sql = "SELECT username FROM admin WHERE username = '" + username + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                DataSet tmpDs = new DataSet();
                da.Fill(tmpDs, "admin");
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
            string sql = "SELECT admin_id, username, password, first_name, last_name" +
                " FROM admin " +
                "WHERE username = '" + username + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

            DataSet tmpDs = new DataSet();
            da.Fill(tmpDs, "admin");

            return tmpDs;
        }
    }


}
