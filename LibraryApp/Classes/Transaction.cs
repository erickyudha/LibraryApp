using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace LibraryApp.Classes
{
    class Transaction
    {
        public int id;
        public int user_id;
        public string user_name;
        public string isbn;
        public string title;
        public DateTime borrowDate;
        public DateTime returnDate;
        public int lateBy;
        public bool isLate;
        public long penalty;
        public long penaltyPerDay = 2000;

        public Transaction(DataSet ds)
        {
            this.id = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.user_id = Int32.Parse(ds.Tables[0].Rows[0][1].ToString());
            this.user_name = ds.Tables[0].Rows[0][2].ToString();
            this.isbn = ds.Tables[0].Rows[0][3].ToString();
            this.title = ds.Tables[0].Rows[0][4].ToString();
            this.borrowDate = DateTime.Parse(ds.Tables[0].Rows[0][5].ToString());
            this.returnDate = DateTime.Parse(ds.Tables[0].Rows[0][6].ToString());
            DateTime now = DateTime.Now;
            this.isLate = returnDate < now;
            this.lateBy = (isLate) ? (int) (now - returnDate).TotalDays : 0;
            this.penalty = (isLate) ? lateBy * penaltyPerDay : 0;
        }

        public static bool isIdExist(MyLibraryDb db, int id)
        {
            try
            {
                string sql = "SELECT transaction_id FROM transaction WHERE transaction_id = " + id.ToString();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

                DataSet tmpDs = new DataSet();
                da.Fill(tmpDs, "transaction");
                string tmp = tmpDs.Tables[0].Rows[0][0].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataSet getTransactionData(MyLibraryDb db, int id)
        {
            string sql = "SELECT transaction.transaction_id, user.user_id, CONCAT(user.first_name, ' ', user.last_name) AS name, " +
                "books.isbn, books.title, transaction.borrow_date, transaction.return_date " +
                "FROM transaction " +
                "INNER JOIN books ON books.isbn = transaction.isbn " +
                "INNER JOIN user ON transaction.user_id = user.user_id " +
                "WHERE transaction.transaction_id = " + id.ToString() + ";";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, db.connection);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);

            DataSet tmpDs = new DataSet();
            da.Fill(tmpDs, "transaction");

            return tmpDs;
        }
    }
}
