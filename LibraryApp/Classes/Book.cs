using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data.MySqlClient;

namespace LibraryApp.Classes
{
    class Book
    {
        public static bool isIsbnExist(MyLibraryDb db, string isbn)
        {
            try
            {
                string sql = "SELECT isbn FROM books WHERE isbn = " + isbn;
                MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                DataSet tmpDs = new DataSet();
                da.Fill(tmpDs, "books");
                string tmp = tmpDs.Tables[0].Rows[0][0].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
